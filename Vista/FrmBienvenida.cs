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
    public partial class FrmBienvenida : Form
    {
        string nombre = "";
        AdmFactura admFactura = new AdmFactura();
        public FrmBienvenida(string nombre)
        {
            InitializeComponent();
            admFactura.AdmFacturaEstatico();
            this.Text += "" + nombre;
            lblIngreso.Text = "Hola " + nombre;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Visible = false;
            frmMenu.ShowDialog();
        }

        private void FrmBienvenida_Load(object sender, EventArgs e)
        {

        }

        private void FrmBienvenida_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
