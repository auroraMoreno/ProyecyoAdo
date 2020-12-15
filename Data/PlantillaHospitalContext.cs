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
    public class PlantillaHospitalContext
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public PlantillaHospitalContext()
        {
            String cadena = ConfigurationManager.ConnectionStrings["conexionhospital"].ConnectionString;
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<Hospital> GetHospitales()
        {
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = "select * from hospital";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<Hospital> hospitales = new List<Hospital>();
            while (this.reader.Read())
            {
                Hospital hospital = new Hospital();
                hospital.HospitalCod = this.reader["HOSPITAL_COD"].ToString();
                hospital.NombreHospital = this.reader["NOMBRE"].ToString();
                hospital.Direccion = this.reader["DIRECCION"].ToString();
                hospital.Telefono = this.reader["TELEFONO"].ToString();
                hospital.NumCamas = Convert.ToInt32(this.reader["NUM_CAMA"]);
                hospitales.Add(hospital);
            }
            this.reader.Close();
            this.cn.Close();
            return hospitales;

        }
    }
}
