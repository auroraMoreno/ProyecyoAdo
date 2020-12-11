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
    public partial class Form02BuscadorEmpleados : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form02BuscadorEmpleados()
        {
            InitializeComponent();
            String cadena="Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2020";
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //String deptno = this.txtDato.Text;
            String dato = this.txtDato.Text;
            //String query =
            //"select apellido, oficio from emp where dept_no=" + dato;
            String query =
             "select apellido, oficio from emp where oficio='" + dato + "'"; //si no se ponen las comillas simples da error
            this.lstEmpleados.Items.Clear();
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = query;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                //String apellido = this.reader.GetString(0);//no se hace asi, mejor poner nombre de campo
                String apellido = this.reader["APELLIDO"].ToString();
                String oficio = this.reader["oficio"].ToString();
                this.lstEmpleados.Items.Add(apellido + " " + oficio);
            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}
