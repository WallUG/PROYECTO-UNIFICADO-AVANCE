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
    public partial class FrmListarReserva : Form
    {
        AdmReserva admReser = new AdmReserva();
        AdmPDF controlPdf = new AdmPDF();

        public FrmListarReserva()
        {
            InitializeComponent();
            admReser.LlenarTabla(dgvReservas);
            ConfigurarControles(false);
            rdbTodos.Checked = true;
        }

        private void ConfigurarControles(bool estado)
        {
            cmbDesde.Enabled = estado;
            cmbHasta.Enabled = estado;
            btnAplicarFiltro.Enabled = estado;
            dtpDesdeFiltro.Enabled = estado;
            dtpHastaFiltro.Enabled = estado;

            if (!estado)
            {
                cmbDesde.Items.Clear();
                cmbHasta.Items.Clear();
                dtpDesdeFiltro.Value = DateTime.Today;
                dtpHastaFiltro.Value = DateTime.Today;
            }
        }

        private void rdbFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFiltrar.Checked)
            {
                ConfigurarControles(true);
                dtpDesdeFiltro.Enabled = false;
                dtpHastaFiltro.Enabled = false;
                cmbDesde.Enabled = true;
                cmbHasta.Enabled = true;
                admReser.LlenarComboCodigos(cmbDesde);
                admReser.LlenarComboCodigos(cmbHasta);
                dgvReservas.Rows.Clear();
            }
        }

        private void rdbFiltrarFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFiltrarFecha.Checked)
            {
                ConfigurarControles(true);
                dtpDesdeFiltro.Enabled = true;
                dtpHastaFiltro.Enabled = true;
                cmbDesde.Enabled = false;
                cmbHasta.Enabled = false;
                cmbDesde.Items.Clear();
                cmbHasta.Items.Clear();
                dgvReservas.Rows.Clear();
            }
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTodos.Checked)
            {
                ConfigurarControles(false);
                admReser.LlenarTabla(dgvReservas);
            }
        }

        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            if (rdbFiltrar.Checked)
            {
                string codigoD = cmbDesde.Text.Trim();
                string codigoH = cmbHasta.Text.Trim();

                if (string.IsNullOrEmpty(codigoD) || string.IsNullOrEmpty(codigoH))
                {
                    MessageBox.Show("Por favor seleccione ambos códigos (Desde y Hasta).",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                admReser.FiltrarXCodigo(codigoD, codigoH, dgvReservas);
                return;
            }

            if (rdbFiltrarFecha.Checked)
            {
                DateTime desde = dtpDesdeFiltro.Value.Date;
                DateTime hasta = dtpHastaFiltro.Value.Date;

                if (desde > hasta)
                {
                    MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                admReser.FiltrarXFecha(desde, hasta, dgvReservas);
                return;
            }

            if (rdbTodos.Checked)
            {
                admReser.LlenarTabla(dgvReservas);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReservas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para generar el reporte.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string nombreArchivo = $"Reporte_Reservas_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                string rutaPdf = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    nombreArchivo
                );

                controlPdf.GenerarPDFReservas(rutaPdf);

                if (File.Exists(rutaPdf))
                {
                    MessageBox.Show($"Reporte generado con éxito:\n{rutaPdf}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = rutaPdf,
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageBox.Show("El archivo PDF no se pudo crear.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
