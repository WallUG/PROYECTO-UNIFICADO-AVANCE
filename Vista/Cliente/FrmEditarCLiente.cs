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

namespace Vista
{
    public partial class FrmEditarCLiente : Form
    {
        AdmCliente admCliente = new AdmCliente();

        public FrmEditarCLiente()
        {
            InitializeComponent();
            //admCliente.MostrarClientes(dgvClientes);
            CargarCLientes();
        }
        private void CargarCLientes()
        {
            admCliente.MostrarClientes(dgvCliente);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void tnFiltrar_Click(object sender, EventArgs e)
        {
            string cedulaoruc = txtBuscarxcedula.Text;
            admCliente.FiltrarCliente(cedulaoruc, dgvCliente);

        }
    }
}
