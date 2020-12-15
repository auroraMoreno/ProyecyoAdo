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
    public partial class Form09ClasesEnfermo : Form
    {
        EnfermoContext context;
        public Form09ClasesEnfermo()
        {
            InitializeComponent();
            this.context = new EnfermoContext();
            this.CargarEnfermos();
        }

        private void CargarEnfermos()
        {
            List<Enfermo> enfermos = this.context.GetEnfermos();
            this.lsvenfermos.Items.Clear();
            foreach(Enfermo enf in enfermos)
            {
                ListViewItem it = new ListViewItem();
                it.Text = enf.Inscripcion.ToString();
                it.SubItems.Add(enf.Apellido);
                it.SubItems.Add(enf.Direccion);
                it.SubItems.Add(enf.FechaNacimiento.ToShortDateString());
                this.lsvenfermos.Items.Add(it);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //recuperando el elemento seleccionado
            ListViewItem it = this.lsvenfermos.SelectedItems[0];
            int inscripcion = int.Parse(it.Text);
            this.context.EliminarEnfermo(inscripcion);
            this.CargarEnfermos();

        }

        private void lsvenfermos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lsvenfermos.SelectedItems.Count != 0)
            {
                ListViewItem it = this.lsvenfermos.SelectedItems[0];
                this.btnEliminar.Text = it.Text; 
            }
           
        }
    }
}
