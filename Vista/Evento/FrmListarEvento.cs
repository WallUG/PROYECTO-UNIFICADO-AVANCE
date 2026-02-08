//CASTILLO MERA DANIEL FERNANDO
using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmListarEvento : Form
    {
        private AdmEvento admEvento = new AdmEvento();
        AdmPDF admPdf = new AdmPDF();

        public FrmListarEvento()
        {
            InitializeComponent();
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
                MessageBox.Show("No ha ingresado ningún filtro, se mostrarán todos los eventos.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if(rdbNumEventos.Checked)
            {
                lblNumEventos.Enabled = true;
                txtNumEventos.Enabled = true;
                lblCedulaORuc.Enabled = false;
                txtCiRucCliente.Enabled = false;
            }
            else if(rdbCedulaORuc.Checked)
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

        private void txtCiRucCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            bool esDigito = Char.IsDigit(caracter);
            bool esBackspace = (caracter == (char)Keys.Back);

            if (!esDigito && !esBackspace)
            {
                e.Handled = true;
            }
        }

        private void txtNumEventos_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            bool esDigito = Char.IsDigit(caracter);
            bool esBackspace = (caracter == (char)Keys.Back);

            if (!esDigito && !esBackspace)
            {
                e.Handled = true;
            }
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            string rutaPdf = "Evento_" + ".pdf";
            try
            {
                // Verificar si el archivo existe y está en uso
                if (File.Exists(rutaPdf))
                {
                    try
                    {
                        // Intentar eliminar para verificar si está bloqueado
                        File.Delete(rutaPdf);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("El archivo PDF está abierto por otra aplicación. Por favor, ciérrelo e intente nuevamente.",
                                        "Archivo en uso",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;
                    }
                }

                admPdf.GenerarPDFEvento(rutaPdf);
                //Codigo para abrir PDF
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = rutaPdf;
                psi.UseShellExecute = true;
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}