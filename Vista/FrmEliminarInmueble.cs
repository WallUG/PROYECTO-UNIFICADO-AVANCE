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
    public partial class FrmEliminarInmueble : Form
    {
        AdmInmueble admInmueble = new AdmInmueble();//creamos una instancia
        public FrmEliminarInmueble()
        {
            InitializeComponent();//iniciamos los controladores
            admInmueble.LlenarTabla(dgvInmueble);//llamamos al metodo llenar tabla
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = 0;
            if (dgvInmueble.SelectedRows.Count == 1)
            {
                indice = dgvInmueble.CurrentRow.Index;
                admInmueble.EliminarInmueble(indice, dgvInmueble);
                admInmueble.LlenarTabla(dgvInmueble);
                MessageBox.Show("Inmueble eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione un inmueble para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                txtTipoInmueble.Enabled = false;
            }
            else if (rbTipoInmueble.Checked)
            {
                txtTipoInmueble.Enabled = true;
                txtNumeroInmueble.Enabled = false;
            }
        }

    }
}
