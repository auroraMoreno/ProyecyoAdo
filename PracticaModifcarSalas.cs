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
    public partial class PracticaModifcarSalas : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader; 
        public PracticaModifcarSalas()
        {
            InitializeComponent();
            String cadena = @"Data Source=LAPTOP-KR2NL673\SQLAURORAMASTER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2020";
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
                this.lstSalas.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.com.Parameters.AddWithValue("@NOMBRE", this.txtNombre.Text);
            this.com.Parameters.AddWithValue("@NOMBREANTIGUO", this.lstSalas.SelectedItem.ToString());
            //this.com.Parameters.AddWithValue("@NUM", this.lstSalas.SelectedItem);
            String query = "UPDATE SALA SET NOMBRE=@NOMBRE WHERE NOMBRE=@NOMBREANTIGUO";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = query;
            this.cn.Open();
            int afectados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.CargarSalas();
        }
    }
}
