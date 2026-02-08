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
    public partial class FrmEditarDetallesFactura : Form
    {
        private AdmFactura admFactura = new AdmFactura();
        private AdmPDF admPdf = new AdmPDF();

        public FrmEditarDetallesFactura()
        {
            InitializeComponent();
        }

        private void FrmEditarDetallesFactura_Load(object sender, EventArgs e)
        {
            CargarDatosFactura();
            ConfigurarEstadoBotones();
        }

        private void CargarDatosFactura()
        {
            string numeroFactura = admFactura.ObtenerNumeroFacturaEditar();
            
            if (string.IsNullOrEmpty(numeroFactura))
            {
                MessageBox.Show("No se ha seleccionado ninguna factura para editar.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            admFactura.CargarFacturaParaEditar(groupBoxCliente, groupBoxEvento, 
                groupBoxFactura, dgvDetallesFactura);
        }

        private void ConfigurarEstadoBotones()
        {
            string estado = txtEstadoFactura.Text;

            if (estado == "Emitida" || estado == "Anulada")
            {
                // Deshabilitar edición si la factura ya fue emitida o anulada
                txtDescuento.ReadOnly = true;
                txtDescuento.BackColor = SystemColors.Control;
                btnRecalcular.Enabled = false;
                btnGuardar.Enabled = false;
                btnEmitirFactura.Enabled = false;
                btnAnular.Enabled = (estado == "Emitida"); // Solo permitir anular si está emitida

                lblInfoEdicion.Text = estado == "Emitida" 
                    ? "Esta factura ya fue emitida y no puede ser modificada" 
                    : "Esta factura está anulada y no puede ser modificada";
                lblInfoEdicion.ForeColor = Color.Red;
            }
            else
            {
                // Factura pendiente - permitir edición
                txtDescuento.ReadOnly = false;
                txtDescuento.BackColor = Color.LightYellow;
                btnRecalcular.Enabled = true;
                btnGuardar.Enabled = true;
                btnEmitirFactura.Enabled = true;
                btnAnular.Enabled = true;

                lblInfoEdicion.Text = "Puede modificar el descuento y recalcular los totales";
                lblInfoEdicion.ForeColor = Color.Green;
            }
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control (backspace, etc.)
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            // Permitir solo dígitos y punto decimal
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            // Solo permitir un punto decimal
            if (e.KeyChar == '.' && txtDescuento.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                txtDescuento.Text = "0";
            }

            // Validar que el descuento sea un número válido
            if (!double.TryParse(txtDescuento.Text, out double descuento))
            {
                MessageBox.Show("Por favor ingrese un valor numérico válido para el descuento.", 
                    "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescuento.Focus();
                return;
            }

            // Validar rango del descuento (0-100%)
            if (descuento < 0 || descuento > 100)
            {
                MessageBox.Show("El descuento debe estar entre 0 y 100%.", 
                    "Valor fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescuento.Focus();
                return;
            }

            // Actualizar la factura con el nuevo descuento
            bool resultado = admFactura.ActualizarDescuentoFactura(txtDescuento.Text, groupBoxFactura);
            
            if (resultado)
            {
                MessageBox.Show("Totales recalculados correctamente.", 
                    "Recálculo exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtEstadoFactura.Text != "Pendiente")
            {
                MessageBox.Show("Solo se pueden guardar cambios en facturas con estado Pendiente.", 
                    "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Primero recalcular con el descuento actual
            if (!double.TryParse(txtDescuento.Text, out double descuento))
            {
                txtDescuento.Text = "0";
            }

            admFactura.ActualizarDescuentoFactura(txtDescuento.Text, groupBoxFactura);
            
            bool resultado = admFactura.GuardarCambiosFactura(txtDescuento.Text);
            
            if (resultado)
            {
                // Recargar datos después de guardar
                CargarDatosFactura();
            }
        }
        private void btnEmitirFactura_Click(object sender, EventArgs e)
        {
            if (txtEstadoFactura.Text != "Pendiente")
            {
                MessageBox.Show("Solo se pueden emitir facturas con estado Pendiente.", 
                    "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea emitir esta factura?\n\n" +
                "Una vez emitida, no podrá ser modificada.",
                "Confirmar emisión", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                bool resultado = admFactura.EmitirFacturaEdicion(groupBoxFactura);
                
                if (resultado)
                {
                    ConfigurarEstadoBotones();
                }
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (txtEstadoFactura.Text == "Anulada")
            {
                MessageBox.Show("Esta factura ya está anulada.", 
                    "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool resultado = admFactura.AnularFacturaEdicion(groupBoxFactura);
            
            if (resultado)
            {
                ConfigurarEstadoBotones();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            string rutaPdf = "Factura_" + txtNumeroFactura.Text + ".pdf";
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

                admPdf.GenerarPDFRegistro(rutaPdf, txtNumeroFactura.Text);
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
