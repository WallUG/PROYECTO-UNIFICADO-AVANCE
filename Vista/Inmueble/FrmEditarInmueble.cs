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
    public partial class FrmEditarInmueble : Form
    {

        AdmInmueble admInmueble = new AdmInmueble();
        public FrmEditarInmueble()
        {
            InitializeComponent();
            admInmueble.LlenarTabla(dgvInmueble);

        }

        private void btnEditarInmueble_Click(object sender, EventArgs e)
        {
            int indice = 0;
            if (dgvInmueble.SelectedRows.Count == 1)
            {
                indice = dgvInmueble.CurrentRow.Index;
                    admInmueble.guardarNumeroEditarInmueble(indice, dgvInmueble);
                    FrmEditarDetallesInmueble editarDetallesInmueble = new FrmEditarDetallesInmueble();
                    editarDetallesInmueble.ShowDialog();

                    admInmueble.LlenarTabla(dgvInmueble);
            }
            else
            {
                MessageBox.Show("Seleccione para editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Boolean resul = admInmueble.EsFiltroVacio(txtNumeroInmueble.Text, txtTipoInmueble.Text);
            if (resul)
            {
                MessageBox.Show("No ha ingresado ningun filtro", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                admInmueble.LlenarTabla(dgvInmueble);
            }
            else
            {
                admInmueble.verificarFiltros(txtNumeroInmueble.Text, txtTipoInmueble.Text, dgvInmueble);
            }

            MessageBox.Show("Lista actualizada correctamente.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void selectradionButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNumeroInmueble.Checked)
            {
                txtNumeroInmueble.Enabled = true;
                txtNumeroInmueble.Clear(); // Limpia el campo al habilitar
                txtTipoInmueble.Enabled = false;
                txtTipoInmueble.Clear(); // Limpia el campo al deshabilitar
            }
            else if (rbTipoInmueble.Checked)
            {
                txtTipoInmueble.Enabled = true;
                txtTipoInmueble.Clear(); // Limpia el campo al habilitar
                txtNumeroInmueble.Enabled = false;
                txtNumeroInmueble.Clear(); // Limpia el campo al deshabilitar
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
