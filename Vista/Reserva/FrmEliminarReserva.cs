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
    public partial class FrmEliminarReserva : Form
    {
        AdmReserva admReser = new AdmReserva();
        public FrmEliminarReserva()
        {
            InitializeComponent();
            admReser.LlenarTabla(dgvReservas);

            
            ConfigurarControles(false);
        }
        // Metodo auxiliar para activar/desactivar y limpiar
        private void ConfigurarControles(bool estado)
        {
            cmbDesde.Enabled = estado;
            cmbHasta.Enabled = estado;
            btnAplicarFiltro.Enabled = estado; // Usamos el nombre del botón que vi en tu designer

            // controles de fecha del filtro
            dtpDesdeFiltro.Enabled = estado;
            dtpHastaFiltro.Enabled = estado;

            if (!estado)
            {
                // Si desactivamos, limpiamos las listas para que no quede basura visual
                cmbDesde.Items.Clear();
                cmbHasta.Items.Clear();

                // reset fechas al día actual
                dtpDesdeFiltro.Value = DateTime.Today;
                dtpHastaFiltro.Value = DateTime.Today;
            }
        }

        // EVENTO: Cuando marcas "Filtrar por Código"
        private void rdbFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFiltrar.Checked)
            {
                ConfigurarControles(true);

                dtpDesdeFiltro.Enabled = false;
                dtpHastaFiltro.Enabled = false;

                // --- CLAVE DEL ÉXITO ---
                // Aquí llenamos los ComboBox para que no estén vacíos
                admReser.LlenarComboCodigos(cmbDesde);
                admReser.LlenarComboCodigos(cmbHasta);

                // Limpiamos la tabla para obligar al usuario a filtrar
                dgvReservas.Rows.Clear();
            }
        }

        // EVENTO: Cuando marcas "Filtrar por Fecha"
        private void rdbFiltrarFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFiltrarFecha.Checked)
            {
                ConfigurarControles(true);

                // Deshabilitar combos cuando se filtra por fecha
                cmbDesde.Enabled = false;
                cmbHasta.Enabled = false;
                cmbDesde.Items.Clear();
                cmbHasta.Items.Clear();

                dgvReservas.Rows.Clear();
            }
        }

        // EVENTO: Cuando marcas "Ver todo"
        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTodos.Checked)
            {
                ConfigurarControles(false);
                admReser.LlenarTabla(dgvReservas);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rdbFiltrar.Checked)
            {
                // IMPORTANTE: Usamos .Text para obtener lo que se ve en el combo
                string codigoD = cmbDesde.Text;
                string codigoH = cmbHasta.Text;

                // Verificamos que haya seleccionado algo
                if (string.IsNullOrEmpty(codigoD) || string.IsNullOrEmpty(codigoH))
                {
                    MessageBox.Show("Por favor seleccione ambos códigos (Desde y Hasta).");
                    return;
                }

                // Llamamos al controlador
                admReser.FiltrarXCodigo(codigoD, codigoH, dgvReservas);
                return;
            }

            if (rdbFiltrarFecha.Checked)
            {
                DateTime desde = dtpDesdeFiltro.Value.Date;
                DateTime hasta = dtpHastaFiltro.Value.Date;

                if (desde > hasta)
                {
                    MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.");
                    return;
                }

                admReser.FiltrarXFecha(desde, hasta, dgvReservas);
                return;
            }

            // Si está seleccionado Ver todo:
            if (rdbTodos.Checked)
            {
                admReser.LlenarTabla(dgvReservas);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 1)
            {
                int indice = dgvReservas.CurrentRow.Index;
                admReser.EliminarReserva(indice, dgvReservas);

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
                MessageBox.Show("Seleccione una reserva para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
