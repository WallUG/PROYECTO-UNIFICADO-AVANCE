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
using Vista;

namespace Visual
{
    public partial class FrmMenu : Form
    {
        AdmFactura admFactura = new AdmFactura();
        AdmInmueble admInmueble = new AdmInmueble();

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void mniRegistrarFactura_Click(object sender, EventArgs e)
        {
            FrmRegistroFactura registrar = new FrmRegistroFactura();
            registrar.ShowDialog();
        }

        private void mniRegistrarCliente_Click(object sender, EventArgs e)
        {
            //Cliente
            FrmRegistroCliente registroCliente = new FrmRegistroCliente();
            registroCliente.ShowDialog();
        }
        private void mniListarCliente_Click(object sender, EventArgs e)
        {
            //Cliente
            FrmListarCliente frmLisCliente = new FrmListarCliente();
            frmLisCliente.ShowDialog();
        }



        //INMUEBLE REGISTRAR
        private void mniRegistrarInmueble_Click(object sender, EventArgs e)
        {
      
            FrmRegistroInmueble registroInmueble = new FrmRegistroInmueble();
            registroInmueble.ShowDialog();
        }

        //INMUEBLE LISTAR
        private void mniListarInmueble_Click(object sender, EventArgs e)
        {

            if (admInmueble.GetCantidadLista() < 0)
            {
                MessageBox.Show("No hay inmuebles registradas para listar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmListarInmueble frmLisInmueble = new FrmListarInmueble();
            frmLisInmueble.ShowDialog();

        }

        //ELIMINAR INMUEBLE
        private void mniEliminarInmueble_Click(object sender, EventArgs e)
        {
            if (admInmueble.GetCantidadLista() > 0)
            {
                FrmEliminarInmueble frmEliminarInmueble = new FrmEliminarInmueble();
                frmEliminarInmueble.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay inmuebles registradas para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void mniListarFactura_Click(object sender, EventArgs e)
        {

            FrmListarFactura frmLisFactura = new FrmListarFactura();
            frmLisFactura.ShowDialog();
        }

        private void mniAutor_Click(object sender, EventArgs e)
        {
            FrmAutores frmAutores = new FrmAutores();
            frmAutores.ShowDialog();
        }

        private void mniSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();//Cerrar toda la aplicacion
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //RESERVA
        private void mniRegistrarReserva_Click(object sender, EventArgs e)
        {
            FrmRegistroReserva frmRegistroReserva = new FrmRegistroReserva();
            frmRegistroReserva.ShowDialog();
        }

        private void mnisalir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnilistarReserva_Click(object sender, EventArgs e)
        {
            FrmListarReserva frmListarReserva = new FrmListarReserva();
            frmListarReserva.ShowDialog();
        }

        private void mniRegistrarEvento_Click(object sender, EventArgs e)
        {
            FrmRegistrarEvento frmRegistrarEvento = new FrmRegistrarEvento();
            frmRegistrarEvento.ShowDialog();
        }

        private void mniListarEvento_Click(object sender, EventArgs e)
        {
            FrmListarEvento frmListarEvento = new FrmListarEvento();
            frmListarEvento.ShowDialog();
        }

        private void mniEliminar_Click(object sender, EventArgs e)
        {
            if(admFactura.GetCantidadLista() > 0) {
                FrmEliminarFactura frmEliminarFactura = new FrmEliminarFactura();
                frmEliminarFactura.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay facturas registradas para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
