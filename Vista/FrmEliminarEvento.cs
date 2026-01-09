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
    public partial class FrmEliminarEvento : Form
    {
        AdmEvento admEvento = new AdmEvento();
        public FrmEliminarEvento()
        {
            InitializeComponent();
            admEvento.LlenarTabla(dgvEvento);
        }

        private void btnEliminarEvento_Click(object sender, EventArgs e)
        {
            int indice = 0;
            if (dgvEvento.SelectedRows.Count == 1)
            {
                indice = dgvEvento.CurrentRow.Index;
                admEvento.EliminarEvento(indice, dgvEvento);
                admEvento.LlenarTabla(dgvEvento);
                MessageBox.Show("Evento eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione un evento para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
