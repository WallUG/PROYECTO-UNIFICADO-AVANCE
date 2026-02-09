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
    public partial class FrmEditarReserva : Form
    {
        AdmReserva admReser = new AdmReserva();
        AdmPDF admPDF = new AdmPDF();

        public FrmEditarReserva()
        {
            InitializeComponent();
            admReser.LlenarTabla(dgvReservas);
            admReser.LlenarComboTipoSolicitud(cmbTipoSolicitudEdicion);

            ConfigurarFiltros(false);
        }

        private void ConfigurarFiltros(bool estado)
        {
            cmbDesde.Enabled = estado;
            cmbHasta.Enabled = estado;
            btnAplicarFiltro.Enabled = estado;

            if (!estado)
            {
                cmbDesde.Items.Clear();
                cmbHasta.Items.Clear();
            }
        }
        private void rdbFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTodos.Checked)
            {
                ConfigurarFiltros(false);
                admReser.LlenarTabla(dgvReservas);
            }
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFiltrar.Checked)
            {
                ConfigurarFiltros(true);
                admReser.LlenarComboCodigos(cmbDesde);
                admReser.LlenarComboCodigos(cmbHasta);
                dgvReservas.Rows.Clear();
            }
        }
        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            if (rdbFiltrar.Checked)
            {
                string codigoD = cmbDesde.Text;
                string codigoH = cmbHasta.Text;

                if (string.IsNullOrEmpty(codigoD) || string.IsNullOrEmpty(codigoH))
                {
                    MessageBox.Show("Seleccione el rango Desde y Hasta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                admReser.FiltrarXCodigo(codigoD, codigoH, dgvReservas);
                return;
            }

            if (rdbFiltrarFecha.Checked)
            {
                DateTime desde = dtpDesdeFiltroEdit.Value.Date;
                DateTime hasta = dtpHastaFiltroEdit.Value.Date;

                if (desde > hasta)
                {
                    MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                string nombreArchivo = $"Reporte_Reservas_Edit_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                string rutaPdf = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    nombreArchivo
                );

                admPDF.GenerarPDFReservas(rutaPdf);

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

        private void rdbFiltrarFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFiltrarFecha.Checked)
            {
                ConfigurarFiltros(true);

                // Deshabilitar combos de código cuando filtramos por fecha
                cmbDesde.Enabled = false;
                cmbHasta.Enabled = false;
                cmbDesde.Items.Clear();
                cmbHasta.Items.Clear();

                // Habilitar fechas
                dtpDesdeFiltroEdit.Enabled = true;
                dtpHastaFiltroEdit.Enabled = true;

                dgvReservas.Rows.Clear();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 1)
            {
                int indice = dgvReservas.CurrentRow.Index;

                
                //admReser.EditarReserva(indice, dgvReservas);

    
                if (rdbFiltrar.Checked)
                {
                   
                    admReser.LlenarComboCodigos(cmbDesde);
                    admReser.LlenarComboCodigos(cmbHasta);

                    //btnBuscar_Click(sender, e);
                }
                else
                {
                
                    admReser.LlenarTabla(dgvReservas);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una reserva para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                // Obtenemos la fila seleccionada
                DataGridViewRow fila = dgvReservas.Rows[e.RowIndex];

                txtCodigoEdicion.Text = fila.Cells["colCodigo"].Value.ToString();
                dtpFechRerservaEdicion.Value = DateTime.Parse(fila.Cells["colFechaReserva"].Value.ToString());
                dtpHoraInicioEdicion.Value = DateTime.Parse(fila.Cells["colHoraInicio"].Value.ToString());
                dtpHoraFinEdicion.Value = DateTime.Parse(fila.Cells["colHoraFin"].Value.ToString());

                string tipSolicitud = admReser.ObtenerTipoSolicitud(txtCodigoEdicion.Text);

                cmbTipoSolicitudEdicion.Text = tipSolicitud;

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // 1. Validar que tengamos una reserva cargada
            if (string.IsNullOrEmpty(txtCodigoEdicion.Text))
            {
                MessageBox.Show("Por favor, seleccione una reserva de la tabla primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar campos obligatorios
            if (admReser.EsVacio( dtpFechRerservaEdicion.Value, dtpHoraInicioEdicion.Value,
                dtpHoraFinEdicion.Value, cmbTipoSolicitudEdicion.Text))
            {
                return;
            }

            // 3. Recolectar datos nuevos
            string codigo = txtCodigoEdicion.Text;
            //string cliente = cmbClientesEdicion.Text;
            //string nombreEvento = cmbNombEventoEdicion.Text;
            //string tipoEvento = cmbTipoEventoEdicion.Text;
            string tipoSolicitud = cmbTipoSolicitudEdicion.Text;
            int cantidadPersonas = (int)nudCantPersonasEdicion.Value;
            DateTime fecha = dtpFechRerservaEdicion.Value;
            DateTime horaInicio = dtpHoraInicioEdicion.Value;
            DateTime horaFin = dtpHoraFinEdicion.Value;

            // 4. Llamar al método ActualizarReserva
            string resultado = admReser.ActualizarReserva(codigo, fecha, horaInicio, horaFin, tipoSolicitud);

            // 5. Mostrar resultado
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 6. Refrescar tabla
            if (rdbFiltrar.Checked || rdbFiltrarFecha.Checked)
            {
                btnAplicarFiltro_Click(sender, e); // Re-aplicar filtro
            }
            else
            {
                admReser.LlenarTabla(dgvReservas);
            }

            // 7. Limpiar campos
            LimpiarCampos();
        }
        public void LimpiarCampos()
        {

            txtCodigoEdicion.Text = "";
            cmbTipoSolicitudEdicion.SelectedIndex = -1;
            dtpFechRerservaEdicion.Value = DateTime.Now;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}

