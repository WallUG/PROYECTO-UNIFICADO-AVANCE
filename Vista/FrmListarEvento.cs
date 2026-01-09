//CASTILLO MERA DANIEL FERNANDO
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
    public partial class FrmListarEvento : Form
    {        
        // Controlador para la lógica de negocio de eventos
        private AdmEvento admEvento = new AdmEvento();
        
        public FrmListarEvento()
        {
            InitializeComponent();

            // Cargar los eventos en el DataGridView
            CargarEventos();
        }
        
        private void CargarEventos()
        {
            admEvento.CargarTablaEventos(dgvEventos);
        }

        private void btnActualizarListaEvento_Click(object sender, EventArgs e)
        {
            Boolean resul = admEvento.EsVacio(txtCiRucCliente.Text, txtNumEventos.Text);
            if (resul)
            {
                MessageBox.Show("No ha ingresado ningun filtro, se mostraran todos los eventos.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                admEvento.CargarTablaEventos(dgvEventos);
            }
            else
            {
                admEvento.VerificarFiltros(txtCiRucCliente.Text, txtNumEventos.Text, dgvEventos);
            }

            MessageBox.Show("Lista de eventos actualizada correctamente.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void selectradionButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCedulaORuc.Checked)
            {
                txtCiRucCliente.Enabled = true;
                txtNumEventos.Enabled = false;
                lblNumEventos.Enabled = false;
            }
            else if (rdbNumEventos.Checked)
            {
                txtNumEventos.Enabled = true;
                txtCiRucCliente.Enabled = false;
                lblCedulaORuc.Enabled= false;
            }
        }
    }
}