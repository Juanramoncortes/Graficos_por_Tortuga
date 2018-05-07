using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficos_de_Tortuga
{
    public partial class Form1 : Form
    {
        Tortuga Tortuga = new Tortuga();
        int _posicion;
        public Form1()
        {
            InitializeComponent();
            lblPosicion.Text = "[0,0]";
            _posicion = 1;
        }
        private bool Pluma()
        {
            
            if (radioButtonAbajo.Checked)
            {
                return true;
            }
            if (radioButtonArriba.Checked)
            {
                return false;
            }
            return false;
        }
        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            bool pluma = Pluma();
            int cantidad = 0;
            cantidad = Convert.ToInt32(txtPasos.Text);
            Tortuga.avanzar(_posicion, cantidad, pluma);
            textBox1.Text = Tortuga.Graficos.ToString();
            lblPosicion.Text="["+Tortuga.localizacion[0]+","+Tortuga.localizacion[1]+"]";
        }

        private void Girar_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
           
            _posicion = Convert.ToInt32(button.Text);
            switch (_posicion)
            {
                case 0:
                    lblDireccion.Text = "Arriba";
                    break;
                case 1:
                    lblDireccion.Text = "Derecha";
                    break;
                case 2:
                    lblDireccion.Text = "Abajo";
                    break;
                case 3:
                    lblDireccion.Text = "Izquierda";
                    break;
            }
        }

        private void btnAvanzarDatos_Click(object sender, EventArgs e)
        {
            string[] Datos = txtDatos.Text.Split(',');
            int a=  Tortuga.Datos(Datos);
            if (a == 1)
            {
                textBox1.Text=Tortuga.Graficos.ToString();
            }
            lblPosicion.Text = "[" + Tortuga.localizacion[0] + "," + Tortuga.localizacion[1] + "]";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            textBox1.Text=Tortuga.Graficos.ToString();
        }
    }
}
