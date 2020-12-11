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
            String cadena = "Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2020";
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.CargarSalas();
        }

        private void CargarSalas()
        {
            this.lstSalas.Items.Clear();
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "select * from sala";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                String nombre = this.reader["NOMBRE"].ToString();
                String sala_cod = this.reader["SALA_COD"].ToString();
                this.lstSalas.Items.Add(nombre + " " + sala_cod);
            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}
