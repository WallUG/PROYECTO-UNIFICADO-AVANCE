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

namespace Visual
{
    public partial class FrmListarFactura : Form
    {
        private AdmFactura adm = new AdmFactura();
        private AdmPDF ctrlPdf = new AdmPDF();
        // Usar ruta absoluta en la carpeta Documentos del usuario
        private string rutaPdf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Facturas.pdf");

        public FrmListarFactura()
        {
            InitializeComponent();
        }

        private void FormListarFactura_Load(object sender, EventArgs e)
        {
            adm.CargarTablaFacturas(dgvFacturas);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Boolean resul = adm.EsVacio(txtNumCedula.Text, txtNumFactura.Text);
            if (resul)
            {
                MessageBox.Show("No ha ingresado ningun filtro, se mostraran todas las facturas.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                adm.CargarTablaFacturas(dgvFacturas);
            }
            else
            {
                adm.verificarFiltros(txtNumCedula.Text, txtNumFactura.Text, dgvFacturas);
            }

            MessageBox.Show("Lista de facturas actualizada correctamente.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectradionButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNumCedula.Checked)
            {
                txtNumCedula.Enabled = true;
                txtNumFactura.Enabled = false;
                txtFiltroAplicado.Clear();
                txtFiltroAplicado.Text = "1"; // Indica que se aplicará el filtro por número de cédula
                txtNumFactura.Clear();
            }
            else if (rbNumFactura.Checked)
            {
                txtNumFactura.Enabled = true;
                txtNumCedula.Enabled = false;
                txtFiltroAplicado.Clear();
                txtFiltroAplicado.Text = "2" ; // Indica que se aplicará el filtro por número de factura
                txtNumCedula.Clear();
            }
        }

        private void BtnGenerarPdf_Click(object sender, EventArgs e)
        {
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

                ctrlPdf.GenerarPDF(rutaPdf, ObtenerFiltro());
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


        public string ObtenerFiltro()
        {
            if(txtNumCedula.Enabled && string.IsNullOrEmpty(txtNumCedula.Text))
            {
                return "1" + txtNumCedula.Text;
            }
            else if(txtNumFactura.Enabled && string.IsNullOrEmpty(txtNumFactura.Text))
            {
                return "2" + txtNumFactura.Text;
            }
            return "0"; // Indica que no se aplicará ningún filtro
        }
    }
}
