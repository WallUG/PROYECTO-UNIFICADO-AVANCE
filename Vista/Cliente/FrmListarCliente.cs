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
    public partial class FrmListarCliente : Form
    {
        AdmCliente AdmCliente = new AdmCliente();
        AdmPDF admPdf = new AdmPDF();
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

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            string rutaPdf = "Cliente_" + ".pdf";
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

                admPdf.GenerarPDFClientes(rutaPdf);
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
