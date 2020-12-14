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
    public partial class Form04ModificarSalas : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form04ModificarSalas()
        {
            InitializeComponent();
            //String cadena = "Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2020"; //cadena tajamar
            String cadena =@"Data Source=LAPTOP-KR2NL673\SQLAURORAMASTER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2020";//cadena casa
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.CargarSalas();
        }

        private void CargarSalas()
        {
            this.lstSalas.Items.Clear();
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "select distinct nombre from sala";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                String nombre = this.reader["NOMBRE"].ToString();
                //String sala_cod = this.reader["SALA_COD"].ToString();
                this.lstSalas.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String consulta = "update sala set nombre=@newname where nombre=@oldname";
            String newname = this.txtNombre.Text;
            String oldname = this.lstSalas.SelectedItem.ToString();
            this.com.Parameters.AddWithValue("@newname", newname);
            this.com.Parameters.AddWithValue("@oldname", oldname);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = consulta;
            this.cn.Open();
            int update = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.CargarSalas();
        }
    }
}
