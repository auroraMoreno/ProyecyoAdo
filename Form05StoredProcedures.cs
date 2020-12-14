using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region PROCEDIMIENTOS ALMACENADOS
//CREATE PROCEDURE TODOSEMPLEADOS
//AS

//    SELECT* FROM EMP
//GO

//CREATE PROCEDURE BUSCAREMPLEADO
//(@APELLIDO NVARCHAR(30))
//AS

//    SELECT* FROM EMP
//   WHERE APELLIDO LIKE @APELLIDO + '%'
//GO
#endregion

namespace ProyecyoAdo
{
    public partial class Form05StoredProcedures : Form
    {

        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form05StoredProcedures()
        {
            InitializeComponent();
            String cadena = @"Data Source=LAPTOP-KR2NL673\SQLAURORAMASTER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2020";
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "TODOSEMPLEADOS";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.lstEmpleados.Items.Add(this.reader["APELLIDO"].ToString());
            }
            this.reader.Close();
            this.cn.Close();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String apellido = this.txtApellido.Text;
            this.com.Parameters.AddWithValue("@APELLIDO", apellido);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "BUSCAREMPLEADO";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                this.lstEmpleados.Items.Add(this.reader["APELLIDO"].ToString());
            }
            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();
        }
    }
}
