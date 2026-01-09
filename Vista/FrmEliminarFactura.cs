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
            if (dgvFacturas.SelectedRows.Count == 1)
            {
                indice = dgvFacturas.CurrentRow.Index;
                admFactura.EliminarFactura(indice, dgvFacturas);
                admFactura.CargarTablaFacturas(dgvFacturas);
            }
            else
            {
                MessageBox.Show("Seleccione una factura para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void selectradionButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNumCedula.Checked)
            {
                txtNumCedula.Enabled = true;
                txtNumFactura.Enabled = false;
            }
            else if (rbNumFactura.Checked)
            {
                txtNumFactura.Enabled = true;
                txtNumCedula.Enabled = false;
            }
        }

        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            Boolean resul = admFactura.EsVacio(txtNumCedula.Text, txtNumFactura.Text);
            if (resul)
            {
                MessageBox.Show("No ha ingresado ningun filtro, se mostraran todas las facturas.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                admFactura.CargarTablaFacturas(dgvFacturas);
            }
            else
            {
                admFactura.verificarFiltros(txtNumCedula.Text, txtNumFactura.Text, dgvFacturas);
            }

            MessageBox.Show("Lista de facturas actualizada correctamente.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
