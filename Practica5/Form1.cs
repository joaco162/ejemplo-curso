using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5
{
    public partial class forDatosPersonales : Form
    {
        public forDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool bApellido = false, bNombre = false, bEdad = false, bDireccion = false;

            if (txtApellido.Text != "")
            {
                string apellido = txtApellido.Text;
                bApellido = true;
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
            }
            else
                txtApellido.BackColor = Color.Red;

            if (txtNombre.Text != "")
            {
                string nombre = txtNombre.Text;
                bNombre = true;
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
            }
            else
                txtNombre.BackColor = Color.Red;

            if (txtEdad.Text != "")
            {
                string edad = txtEdad.Text;
                bEdad = true;
                txtEdad.BackColor = System.Drawing.SystemColors.Control;
            }
            else
                txtEdad.BackColor = Color.Red;

            if (txtDireccion.Text != "")
            {
                string direccion = txtDireccion.Text;
                bDireccion = true;
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;
            }
            else
                txtDireccion.BackColor = Color.Red;
           
            if(bApellido && bNombre && bEdad && bDireccion )
            {
                txtbResultado.Text = "Apellido y Nombre: " + txtApellido.Text + " " + txtNombre.Text + "            " +
                    " Edad: " + txtEdad.Text + "                                          " +
                    " Direccion: " + txtDireccion.Text;
              
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
