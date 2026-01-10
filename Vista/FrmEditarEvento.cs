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
    public partial class FrmEditarEvento : Form
    {
        AdmEvento admEvento = new AdmEvento();
        public FrmEditarEvento()
        {
            InitializeComponent();
        }

        private void selectradionButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNumEventos.Checked)
            {
                lblNumEventos.Enabled = true;
                txtNumEventos.Enabled = true;
                lblCedulaORuc.Enabled = false;
                txtCiRucCliente.Enabled = false;
            }
            else if (rdbCedulaORuc.Checked)
            {
                lblCedulaORuc.Enabled = true;
                txtCiRucCliente.Enabled = true;
                lblNumEventos.Enabled = false;
                txtNumEventos.Enabled = false;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
        Boolean resul = admEvento.EsVacio(txtCiRucCliente.Text, txtNumEventos.Text);
        if (resul)
        {
            MessageBox.Show("No ha ingresado ningún filtro, se mostrarán todos los eventos.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            admEvento.CargarTablaEventos(dgvEventos);
        }
        else
        {
            admEvento.VerificarFiltros(txtCiRucCliente.Text, txtNumEventos.Text, dgvEventos);
        }

        MessageBox.Show("Lista de eventos actualizada correctamente.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnActualizarListaEvento_Click(object sender, EventArgs e)
        {
            Boolean resul = admEvento.EsVacio(txtCiRucCliente.Text, txtNumEventos.Text);
            if (resul)
            {
                MessageBox.Show("No ha ingresado ningún filtro, se mostrarán todos los eventos.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                admEvento.CargarTablaEventos(dgvEventos);
            }
            else
            {
                admEvento.VerificarFiltros(txtCiRucCliente.Text, txtNumEventos.Text, dgvEventos);
            }

            MessageBox.Show("Lista de eventos actualizada correctamente.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}