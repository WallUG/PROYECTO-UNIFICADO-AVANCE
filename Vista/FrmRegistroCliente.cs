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
    public partial class FrmRegistroCliente : Form
    {
        AdmCliente admCliente= new AdmCliente();
        public FrmRegistroCliente()
        {
            InitializeComponent();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            bool esLetra = Char.IsLetter(caracter);
            bool esEspacio = (caracter == ' ');
            bool esBackspace = (caracter == (char)Keys.Back);

            if (!esLetra && !esEspacio && !esBackspace)
            {
                e.Handled = true;
            }


        }

        private void TxtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            bool esLetra = Char.IsLetter(caracter);
            bool esEspacio = (caracter == ' ');
            bool esBackspace = (caracter == (char)Keys.Back);

            if (!esLetra && !esEspacio && !esBackspace)
            {
                e.Handled = true;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            bool esDigito = Char.IsDigit(caracter);
            bool esBackspace = (caracter == (char)Keys.Back);

            if (!esDigito && !esBackspace)
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            bool esDigito = Char.IsDigit(caracter);
            bool esBackspace = (caracter == (char)Keys.Back);

            if (!esDigito && !esBackspace)
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String Nombre = txtNombre.Text.Trim(), Apellido = TxtApellidos.Text.Trim(), cedula = txtCedula.Text, Telefono = txtTelefono.Text,
                Correo = txtCorreoElectronico.Text.Trim(), Direccion = txtDireccion.Text.Trim();
            if (!admCliente.Esvacio(Nombre, Apellido, cedula, Telefono, Correo, Direccion))
            {

                admCliente.Registrar(Nombre, Apellido, cedula, Telefono, Correo, Direccion);

            }
            else
            {
                MessageBox.Show("Debe completar todos los campos ");

            }
        }
    }
}
