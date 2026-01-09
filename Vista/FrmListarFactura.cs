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
    public partial class FrmListarFactura : Form
    {
        private AdmFactura adm = new AdmFactura();

        public FrmListarFactura()
        {
            InitializeComponent();
        }

        private void FormListarFactura_Load(object sender, EventArgs e)
        {
            adm.CargarTablaFacturas(dgvFacturas);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Boolean resul = adm.EsVacio(txtNumCedula.Text, txtNumFactura.Text);
            if (resul)
            {
                MessageBox.Show("No ha ingresado ningun filtro, se mostraran todas las facturas.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                adm.CargarTablaFacturas(dgvFacturas);
            }
            else
            {
                adm.verificarFiltros(txtNumCedula.Text, txtNumFactura.Text, dgvFacturas);
            }

            MessageBox.Show("Lista de facturas actualizada correctamente.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectradionButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNumCedula.Checked)
            {
                txtNumCedula.Enabled = true;
            }
            else if (rbNumFactura.Checked)
            {
                txtNumFactura.Enabled = true;
            }
        }
    }
}
