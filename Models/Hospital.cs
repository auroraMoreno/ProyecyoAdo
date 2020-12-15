using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecyoAdo.Models
{
    public class Hospital
    {
        public String HospitalCod { get; set; }
        public String NombreHospital { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public int NumCamas { get; set; }
    }
}
