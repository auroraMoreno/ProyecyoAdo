using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //hacer using 

namespace ProyecyoAdo
{
    public partial class Form01PrimerADO : Form
    {
        //cadena de conexión:
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form01PrimerADO()
        {
            InitializeComponent();
            //instanciamso los obj: 
            this.cadenaconexion =
                "Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2020";
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            //si declaramos la opcion de ctor public y lo ponemos prvado no podemos hacer new 
            //eventos de la conexion:
            this.cn.StateChange += Cn_StateChange;

        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblestado.Text = 
                "Connection pasando de " + e.OriginalState + " a " + e.CurrentState;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //indicamos cual base de datos va a eligir y que lo abra
            //this.cn.ConnectionString = this.cadenaconexion;
            if(this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
                this.lblestado.BackColor = Color.LightGreen;
            }
          
            
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblestado.BackColor = Color.LightCoral;
        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            //indicar al comando la conexión:
            this.com.Connection = this.cn; //la conexion que va utilizar
            //tipo de consulta a realizar con commandType: 
            this.com.CommandType = CommandType.Text;
            //la consulta a bbdd
            this.com.CommandText = "select * from emp";
            //ejecutar el comando con la conexion abierta (en este caso usamos el metod)
            this.reader = this.com.ExecuteReader();

            for (int i=0; i<this.reader.FieldCount;i++)
            {
                String columna = this.reader.GetName(i);
                String tipo = this.reader.GetDataTypeName(i);
                this.lstcolumnas.Items.Add(columna);
                this.lsttipos.Items.Add(tipo);
            }

            //String columna = this.reader.GetName(0);
            //String tipo = this.reader.GetDataTypeName(0);


            while (this.reader.Read())
            {
                String apellido = this.reader.GetString(1);
                this.lstApellidos.Items.Add(apellido);

            }//devuelve un boolean
            this.reader.Close();
        }
    }
}
