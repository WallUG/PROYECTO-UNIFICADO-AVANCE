using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class FrmEliminarFactura : Form
    {
        AdmFactura admFactura = new AdmFactura();
        public FrmEliminarFactura()
        {
            InitializeComponent();
            admFactura.CargarTablaFacturas(dgvFacturas);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = 0;
            if(dgvFacturas.SelectedRows.Count == 1)
            {
                indice = dgvFacturas.CurrentRow.Index;
                admFactura.EliminarFactura(indice, dgvFacturas);
                admFactura.CargarTablaFacturas(dgvFacturas);
                MessageBox.Show("Factura eliminada correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione una factura para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
