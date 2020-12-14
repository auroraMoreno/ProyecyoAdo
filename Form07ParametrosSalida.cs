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
    #region PROCEDIMIENTOS ALMACENADOS
    //    CREATE PROCEDURE EMPLEADOSDEPTOUT
    //    (@NOMBRE NVARCHAR(30), @SUMA INT OUT)
    //AS
    //    DECLARE @DEPTNO INT

    //    SELECT @DEPTNO = DEPT_NO FROM DEPT WHERE DNOMBRE = @NOMBRE

    //    SELECT* FROM EMP
    //   WHERE DEPT_NO=@DEPTNO
    //   SELECT @SUMA=SUM(SALARIO) FROM EMP WHERE DEPT_NO = @DEPTNO
    //GO
    //    #endregion
    #endregion

    public partial class Form07ParametrosSalida : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader; 
        public Form07ParametrosSalida()
        {
            InitializeComponent();
            String cadena = ConfigurationManager
                .ConnectionStrings["conexionhospital"]
                .ConnectionString;
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "CARGARDEPARTAMENTOS";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.cmbdepartamentos.Items.Add(this.reader["DNOMBRE"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
        
        }

        private void cmbdepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            String nombre = this.cmbdepartamentos.SelectedItem.ToString();
            this.com.Parameters.AddWithValue("@NOMBRE", nombre);
            SqlParameter pamsuma = new SqlParameter();
            pamsuma.ParameterName = "@SUMA";
            pamsuma.Direction = ParameterDirection.Output;
            pamsuma.Value = 0;
            this.com.Parameters.Add(pamsuma);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "EMPLEADOSDEPTOUT";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.lstEmpleados.Items.Add(this.reader["APELLIDO"]);
            }
            this.reader.Close();
            this.txtSumSalarial.Text = pamsuma.Value.ToString();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
