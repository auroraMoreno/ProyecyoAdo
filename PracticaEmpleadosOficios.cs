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
    public partial class PracticaEmpleadosOficios : Form
    {
        EmpleadosContext context;
        public PracticaEmpleadosOficios()
        {
            InitializeComponent();
            this.context = new EmpleadosContext();
            this.CargarOficios();

        }
        private void CargarOficios()
        {
            List<Empleado> empleados = this.context.GetOficios();
            foreach(Empleado emp in empleados)
            {
                this.cmbOficios.Items.Add(emp.Oficio);
            }
        }

        private void cmbOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Empleado> empleados = this.context.GetEmpleados(this.cmbOficios.SelectedItem.ToString());
            this.listView1.Items.Clear();
            foreach(Empleado emp in empleados)
            {
                ListViewItem it = new ListViewItem();
                it.Text = emp.IdEmpleado.ToString();
                it.SubItems.Add(emp.Apellido);
                it.SubItems.Add(emp.Oficio);
                it.SubItems.Add(emp.Salario.ToString());
                this.listView1.Items.Add(it);
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            String oficio = this.cmbOficios.SelectedIndex.ToString();
            int salario = Convert.ToInt32(this.txtIncremento.Text);
            this.context.UpdateSalario(salario, oficio);
            //List<Empleado> empleados = this.context.GetEmpleados(oficio);
            //this.listView1.Items.Clear();
            //foreach (Empleado emp in empleados)
            //{
            //    ListViewItem it = new ListViewItem();
            //    it.Text = emp.IdEmpleado.ToString();
            //    it.SubItems.Add(emp.Apellido);
            //    it.SubItems.Add(emp.Oficio);
            //    it.SubItems.Add(emp.Salario.ToString());
            //    this.listView1.Items.Add(it);
            //}
        }
    }
}
