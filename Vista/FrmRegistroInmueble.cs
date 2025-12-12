using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    public partial class FrmRegistroInmueble : Form
    {
        AdmInmueble admInmueble = new AdmInmueble();
        public FrmRegistroInmueble()
        {
            InitializeComponent();
            admInmueble.LlenarCombo(cmbTipo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text.Trim());

            string nombre = txtNombre.Text.Trim();
            string tipo = (string)cmbTipo.SelectedItem;
            int cantidad = (int)nudCantidad.Value;
            double precio = (double)nudPrecio.Value;
            bool disponible = chkDisponibilidad.Checked;

            string contenido = "";

            if (!admInmueble.EsVacio(id, nombre, tipo, cantidad, precio))
            {
                contenido = admInmueble.Registrar(id, nombre, tipo, cantidad, precio, disponible);
                txtContenido.Text = contenido;
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsLetter(c) && c != ' ')
            {
                e.Handled = true;
                return;
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números y teclas de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

    }
}
