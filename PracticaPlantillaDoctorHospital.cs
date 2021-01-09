using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ProyecyoAdo
{
    public partial class PracticaPlantillaDoctorHospital : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public PracticaPlantillaDoctorHospital()
        {
            InitializeComponent();
            String cadena = ConfigurationManager
                .ConnectionStrings["conexionhospital"].ConnectionString;
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "CARGARHOSPITALES";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.cmbHospitales.Items.Add(this.reader["NOMBRE"]);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            String nombreHospital = this.cmbHospitales.SelectedItem.ToString();
            this.com.Parameters.AddWithValue("@NOMBREHOSP", nombreHospital);
            SqlParameter pamsuma = new SqlParameter();
            pamsuma.ParameterName = "@SUMA";
            pamsuma.Direction = ParameterDirection.Output;
            pamsuma.Value = 0;
            this.com.Parameters.Add(pamsuma);
            SqlParameter pammedia = new SqlParameter();
            pammedia.ParameterName = "@MEDIA";
            pammedia.Direction = ParameterDirection.Output;
            pammedia.Value = 0;
            this.com.Parameters.Add(pammedia);
            SqlParameter pampersonas = new SqlParameter();
            pampersonas.ParameterName = "@PERSONAS";
            pampersonas.Direction = ParameterDirection.Output;
            pampersonas.Value = 0;
            this.com.Parameters.Add(pampersonas);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "EMPLEADOSHOSPITALESOUTPUT";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                this.lstEmpleados.Items.Add(this.reader["APELLIDO"]);
            }
            this.reader.Close();
            this.txtSumaSalarial.Text = pamsuma.Value.ToString();
            this.txtMediaSalarial.Text = pammedia.Value.ToString();
            this.txtPersonas.Text = pampersonas.Value.ToString();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
