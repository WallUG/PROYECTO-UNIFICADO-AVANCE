using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista;

namespace Visual
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void mniRegistrarFactura_Click(object sender, EventArgs e)
        {
            FrmFacturaRegistrar registrar = new FrmFacturaRegistrar();
            registrar.ShowDialog();
        }

        private void mniInmueble_Click(object sender, EventArgs e)
        {
            //Inmueble
            FrmRegistroInmueble registroInmueble = new FrmRegistroInmueble();
            registroInmueble.ShowDialog();
        }

        private void mniListarInmueble_Click(object sender, EventArgs e)
        {
            FrmListarInmueble frmLisInmueble = new FrmListarInmueble();
            frmLisInmueble.ShowDialog();
        }

        private void mniListarFactura_Click(object sender, EventArgs e)
        {
            FrmListarFactura frmLisFactura = new FrmListarFactura();
            frmLisFactura.ShowDialog();
        }

        private void mniAutor_Click(object sender, EventArgs e)
        {

        }

        private void mniSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
