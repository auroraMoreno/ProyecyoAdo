using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyecyoAdo
{
    public partial class Form03EliminarEnfermo : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        // SqlParameter pam;

        public Form03EliminarEnfermo()
        {
            InitializeComponent();
            String cadena = "Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2020";
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            //this.pam = new SqlParameter();
            //this.pam.ParameterName = "@INSCRIPCION";
            //this.pam.DbType = DbType.String; //si yo no pongo esto no pasa nada
            //this.pam.Value = "";
            //this.com.Parameters.Add(pam);
            this.CargarEnfermos();
        }

        private void CargarEnfermos()
        {
            this.lstEnfermos.Items.Clear();
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "select * from enfermo";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                String ape = this.reader["APELLIDO"].ToString();
                String inscripcion = this.reader["INSCRIPCION"].ToString();
                this.lstEnfermos.Items.Add(ape + " " + inscripcion);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlParameter pam;
            pam = new SqlParameter();
            pam.ParameterName = "@INSCRIPCION";
            pam.DbType = DbType.String; //si yo no pongo esto no pasa nada
            pam.Value = "";
            this.com.Parameters.Add(pam);
            pam.Value = this.txtInscripcion.Text;
            String query = 
                "delete from enfermo where inscripcion=@INSCRIPCION";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = query;
            this.cn.Open();
            int afectados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear(); //limpiar los param bc si no da fallo
            this.CargarEnfermos();
        }
    }
}
