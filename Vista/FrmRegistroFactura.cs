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
    public partial class FrmRegistroFactura : Form
    {
        AdmFactura adm = new AdmFactura();
        public FrmRegistroFactura()
        {
            InitializeComponent();

        }

        private void FrmFacturaRegistro_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            adm.BuscarCliente(cmbIdEvento, groupBoxCliente, txtCedula.Text);
            adm.limpiarDatos(groupBoxEvento, groupBoxFactura, groupBoxDetalles);
            btnGuardar.Enabled = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarEvento_Click(object sender, EventArgs e)
        {
            if (cmbIdEvento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un evento");
                return;
            }
            else
            {
                adm.cargarEventoPorId(groupBoxEvento, dgvDetallesFactura, Convert.ToInt16(cmbIdEvento.SelectedItem));
                adm.limpiarDatos(groupBoxFactura);
                //btnGuardar.Enabled = true;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bug resuelto: permite usar teclas de control como backspace
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            //solo permite ingresar numeros
            char c = e.KeyChar;
            if (!Char.IsDigit(c))
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbIdEvento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un evento");
                return;
            }
            else
            {
                adm.generarFactura(groupBoxFactura, Convert.ToInt16(cmbIdEvento.SelectedItem), txtDescuento.Text.Trim());
                btnGuardar.Enabled = false;
            }
        }

        private void btnEmitirFactura_Click(object sender, EventArgs e)
        {
            if (txtIdFactura.Text == "")
            {
                MessageBox.Show("Debe seleccionar un evento y generar una factura");
                return;
            }
            else
            {
                adm.EmitirFactura(groupBoxFactura, Convert.ToInt16(txtIdFactura.Text));
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (txtIdFactura.Text == "")
            {
                MessageBox.Show("Debe seleccionar un evento y generar una factura");
                return;
            }
            else
            {
                adm.AnularFactura(groupBoxFactura, Convert.ToInt16(txtIdFactura.Text));
            }
        }
    }
}
