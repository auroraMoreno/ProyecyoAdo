﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using ProyecyoAdo.Models;

namespace ProyecyoAdo.Data
{
    public class EmpleadosContext
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;
        public EmpleadosContext()
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
            List<Empleado> empleados = new List<Empleado>();
            while (this.reader.Read())
            {
                Empleado emp = new Empleado();
                //emp.IdEmpleado = Convert.ToInt32(this.reader["EMP_NO"]);
                //emp.Apellido = this.reader["APELLIDO"].ToString();
                emp.Oficio = this.reader["OFICIO"].ToString();
                //emp.Salario = Convert.ToInt32(this.reader["SALARIO"]);
                empleados.Add(emp);
            }
            this.reader.Close();
            this.cn.Close();
            return empleados;
        }

        public List<Empleado> GetEmpleados(String oficio)
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
                emp.Oficio = this.reader["OFICIO"].ToString();
                emp.Salario = Convert.ToInt32(this.reader["SALARIO"]);
                empleados.Add(emp);
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return empleados;
        }

        public int UpdateSalario(int salario, String oficio)
        {
            this.com.Parameters.AddWithValue("@NUMERO", salario);
            this.com.Parameters.AddWithValue("@OFICIO", oficio);
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "INCREMENTARSALARIOEMP ";
            this.cn.Open();
            int afectados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return afectados;
        }
    }
}
