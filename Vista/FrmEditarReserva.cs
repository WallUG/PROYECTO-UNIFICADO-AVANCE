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

namespace Visual
{
    public partial class FrmEditarReserva : Form
    {
        AdmReserva admReser = new AdmReserva();
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
            string codigoD = cmbDesde.Text;
            string codigoH = cmbHasta.Text;

            if (string.IsNullOrEmpty(codigoD) || string.IsNullOrEmpty(codigoH))
            {
                MessageBox.Show("Seleccione el rango Desde y Hasta.");
                return;
            }
            admReser.FiltrarXCodigo(codigoD, codigoH, dgvReservas);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 1)
            {
                int indice = dgvReservas.CurrentRow.Index;

                
                admReser.EditarReserva(indice, dgvReservas);

    
                if (rdbFiltrar.Checked)
                {
                   
                    admReser.LlenarComboCodigos(cmbDesde);
                    admReser.LlenarComboCodigos(cmbHasta);

                    btnBuscar_Click(sender, e);
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
                if (string.IsNullOrEmpty(txtCodigoEdicion.Text))
                {
                    MessageBox.Show("Por favor, seleccione una reserva de la tabla primero.");
                    return;
                }

                string CodigoReserva = txtCodigoEdicion.Text;
                DateTime fecha = dtpFechRerservaEdicion.Value;
                DateTime horaIni = dtpHoraInicioEdicion.Value;
                DateTime horaFin = dtpHoraFinEdicion.Value;
                string tipSolicitud = cmbTipoSolicitudEdicion.Text;

               string resultado = admReser.ActualizarReserva(CodigoReserva, fecha, horaIni, horaFin, tipSolicitud);
                MessageBox.Show(resultado);

                if (rdbFiltrar.Checked)
                {
                    btnBuscar_Click(sender, e);
                }
                else
                {
                    admReser.LlenarTabla(dgvReservas);
                }
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

