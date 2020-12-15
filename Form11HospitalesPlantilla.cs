using ProyecyoAdo.Data;
using ProyecyoAdo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecyoAdo
{
    public partial class Form11HospitalesPlantilla : Form
    {
        PlantillaHospitalContext context;
        public Form11HospitalesPlantilla()
        {
            InitializeComponent();
            this.context = new PlantillaHospitalContext();
            this.CargarHospitales();
        }

        private void CargarHospitales()
        {
            List<Hospital> hospitales = this.context.GetHospitales();
            foreach (Hospital h in hospitales)
            {
                CheckBox check = new CheckBox();
                //check = new CheckBox();
                check.Text = h.NombreHospital;
                check.AutoSize = true;
                int y = 10;
                int x = 10;
                check.Location = new Point(x, y);
                x += 10;
                y += 10;
            }

        }
    }
}
