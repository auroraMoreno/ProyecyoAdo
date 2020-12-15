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
    public partial class Form10ClasesEmpleados : Form
    {
        EmpleadoContext context;
        public Form10ClasesEmpleados()
        {
            InitializeComponent();
            this.context = new EmpleadoContext();
            this.CargarOficios();
        }

        private void CargarOficios()
        {
            List<Empleado> oficios = this.context.GetOficios();
            foreach(Empleado emp in oficios)
            {
                String oficio = emp.Oficio;
                this.cmboficios.Items.Add(oficio);
            }
        }

        private void cmboficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            String oficio = this.cmboficios.SelectedItem.ToString();
            List<Empleado> empleados = this.context.GetEmpleadosOficio(oficio);
            foreach(Empleado emp in empleados)
            {
                ListViewItem it = new ListViewItem();
                it.Text = emp.IdEmpleado.ToString();
                it.SubItems.Add(emp.Apellido);
                it.SubItems.Add(emp.Oficio);
                it.SubItems.Add(emp.Salario.ToString());
                this.lsvEmpleados.Items.Add(it);
            }
        }
    }
}
