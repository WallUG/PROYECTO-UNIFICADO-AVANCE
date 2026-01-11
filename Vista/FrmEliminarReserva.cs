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
            btnAplicarFiltro.Enabled = estado; 

            if (!estado)
            {  
                cmbDesde.Items.Clear();
                cmbHasta.Items.Clear();
            }
        }

        private void rdbFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFiltrar.Checked)
            {
                ConfigurarControles(true);

                admReser.LlenarComboCodigos(cmbDesde);
                admReser.LlenarComboCodigos(cmbHasta);

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigoD = cmbDesde.Text;
            string codigoH = cmbHasta.Text;


            if (string.IsNullOrEmpty(codigoD) || string.IsNullOrEmpty(codigoH))
            {
                MessageBox.Show("Por favor seleccione ambos códigos (Desde y Hasta).");
                return;
            }

            admReser.FiltrarXCodigo(codigoD, codigoH, dgvReservas);
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
