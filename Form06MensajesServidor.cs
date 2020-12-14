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
    #region PROCEDIMIENTOS ALMACENADOS
//    CREATE PROCEDURE CARGARDEPARTAMENTOS
//AS

//    SELECT* FROM DEPT
//GO

//CREATE PROCEDURE INSERTARDEPARTAMENTOS
//(@NUMERO INT, @NOMBRE NVARCHAR(30), @LOCALIDAD NVARCHAR(30))
//AS
//    INSERT INTO DEPT VALUES(@NUMERO, @NOMBRE, @LOCALIDAD)
//GO

    #endregion
    public partial class Form06MensajesServidor : Form
    {

        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form06MensajesServidor()
        {
            InitializeComponent();
            String cadena = @"Data Source=LAPTOP-KR2NL673\SQLAURORAMASTER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2020";
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.cn.InfoMessage += Cn_InfoMessage;
            this.CargarDepartamentos();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblmensajes.Text = e.Message;
        }

        private void CargarDepartamentos()
        {
            this.lstDepartamentos.Items.Clear();
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "CARGARDEPARTAMENTOS";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read()) {
                String num = this.reader["DEPT_NO"].ToString();
                String nom = this.reader["DNOMBRE"].ToString();
                String loc = this.reader["LOC"].ToString();
                this.lstDepartamentos.Items.Add(num + " " + nom + " " + loc);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.lblmensajes.Text = "";
            String num = this.txtNumero.Text;
            String nom = this.txtNombre.Text;
            String loc = this.txtLocalidad.Text;

            this.com.Parameters.AddWithValue("@NUMERO", num);
            this.com.Parameters.AddWithValue("@NOMBRE", nom);
            this.com.Parameters.AddWithValue("@LOCALIDAD", loc);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "INSERTARDEPARTAMENTOS";
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.CargarDepartamentos();
        }
    }
}
