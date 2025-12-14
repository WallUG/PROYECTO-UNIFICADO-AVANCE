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
        AdmCliente admCliente = new AdmCliente();

        public FrmBienvenida(string nombre)
        {
            InitializeComponent();
            this.nombre = nombre;

            // Actualizar el título de la ventana
            this.Text = "Bienvenido - " + nombre;

            // Actualizar los labels con el nuevo diseño
            lblSaludo.Text = "¡Hola, " + nombre + "!";
            lblSistema.Text = "Bienvenido(a) a nuestro Sistema de\nGestión de Eventos Sociales";
            lblGrupo.Text = "Grupo #4";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Visible = false;
            frmMenu.ShowDialog();
        }

        private void FrmBienvenida_Load(object sender, EventArgs e)
        {
            //Adicional
        }

        private void FrmBienvenida_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
