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
    public partial class FrmListarInmueble : Form
    {
        AdmInmueble admInmueble = new AdmInmueble();//creamos una instancia
        public FrmListarInmueble()
        {
            InitializeComponent();//iniciamos los controladores
            admInmueble.LlenarTabla(dgvInmueble);//llamamos al metodo llenar tabla
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


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectradionButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTipoInmueble.Checked)
            {
                txtNumeroInmueble.Enabled = true;
                txtTipoInmueble.Enabled = false;
            }
            else if (rbNumeroInmueble.Checked)
            {
                txtTipoInmueble.Enabled = true;
                txtNumeroInmueble.Enabled = false;
            }
        }

    }
}
