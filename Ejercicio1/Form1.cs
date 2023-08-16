using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class MiPrimeraAplicacion : Form
    {
        public MiPrimeraAplicacion()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");

        }

        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau..");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Click ", " Atencion");
            //this.BackColor = Color.Blue;
            if (txbNombre.Text == "")
                txbNombre.BackColor = Color.Red;
            else
                txbNombre.BackColor = System.Drawing.SystemColors.Control;
        }

        private void Formulario_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el boton Izquierdo", "Atencion");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el boton Derecho", "Atencion");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el boton del Medio", "Atencion");

        }

        private void lblNombre_MouseMove(object sender, MouseEventArgs e)
        {
            lblNombre.BackColor = Color.Cyan;
            lblNombre.Cursor = Cursors.Hand;
        }

        private void lblNombre_MouseLeave(object sender, EventArgs e)
        {
            lblNombre.BackColor = System.Drawing.SystemColors.Control;
            lblNombre.Cursor = Cursors.Arrow;
        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txbApellido_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txbApellido.Text.Length + " Caracteres");
        }
    }
}
