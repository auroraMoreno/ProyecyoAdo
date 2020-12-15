using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using ProyecyoAdo.Models;

namespace ProyecyoAdo.Data
{
    public class EmpleadoContext
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public EmpleadoContext()
        {
            String cadena = ConfigurationManager.ConnectionStrings["conexionhospital"].ConnectionString;
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<Empleado> GetOficios()
        {
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = "select distinct oficio from emp";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<Empleado> lista = new List<Empleado>();
            while (this.reader.Read())
            {
                Empleado emp = new Empleado();
                //emp.IdEmpleado = Convert.ToInt32(this.reader["EMP_NO"]);
                //emp.Apellido = this.reader["APELLIDO"].ToString();
                //emp.Salario = Convert.ToInt32(this.reader["SALARIO"]);
                emp.Oficio = this.reader["OFICIO"].ToString();
                lista.Add(emp);
            }
            this.reader.Close();
            this.cn.Close();
            return lista;
        }

        public List<Empleado> GetEmpleadosOficio(string oficio)
        {
            this.com.Parameters.AddWithValue("@OFICIO", oficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = "select * from emp where oficio=@OFICIO";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<Empleado> empleados = new List<Empleado>();
            while (this.reader.Read())
            {
                Empleado emp = new Empleado();
                emp.IdEmpleado = Convert.ToInt32(this.reader["EMP_NO"]);
                emp.Apellido = this.reader["APELLIDO"].ToString();
                emp.Salario = Convert.ToInt32(this.reader["SALARIO"]);
                emp.Oficio = this.reader["OFICIO"].ToString();
                empleados.Add(emp);
            }
            this.reader.Close();
            this.cn.Close();
            return empleados;
        }
       
    }
}
