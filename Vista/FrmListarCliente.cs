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
    public partial class FrmListarCliente : Form
    {
        AdmCliente AdmCliente = new AdmCliente();
        public FrmListarCliente()
        {
            InitializeComponent();
            //AdmCliente.MostrarClientes(dgvListaCliente);
            CargarCLientes();
        }

        private void CargarCLientes()
        {
            AdmCliente.MostrarClientes(dgvCliente);
        }

        private void tnFiltrar_Click(object sender, EventArgs e)
        {
            string cedulaoruc = txtBuscarxcedula.Text;
            AdmCliente.FiltrarCliente(cedulaoruc, dgvCliente);
        }

       
    }
}
