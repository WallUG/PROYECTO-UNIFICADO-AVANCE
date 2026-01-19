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
        AdmEvento admEvento = new AdmEvento();
        AdmFactura admFactura = new AdmFactura();
        AdmInmueble admInmueble = new AdmInmueble();
        AdmReserva admReserva = new AdmReserva();
        AdmCliente admCliente = new AdmCliente();

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
            if (admCliente.GetCantidadLista() > 0)
            {
                FrmListarCliente FrmLisCliente = new FrmListarCliente();
                FrmLisCliente.ShowDialog();
            }
            else {
                MessageBox.Show("No hay clientes registradas para listar.", "Advertencia");

            }
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
            if (admFactura.GetCantidadLista() > 0)
            {
                FrmListarFactura frmLisFactura = new FrmListarFactura();
                frmLisFactura.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay facturas registradas para listar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            if (admReserva.GetCantidadLista() > 0)
            {
                FrmListarReserva frmLisReserva = new FrmListarReserva();
                frmLisReserva.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay reservas registradas para listar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mniRegistrarEvento_Click(object sender, EventArgs e)
        {
            FrmRegistrarEvento frmRegistrarEvento = new FrmRegistrarEvento();
            frmRegistrarEvento.ShowDialog();
        }

        private void mniListarEvento_Click(object sender, EventArgs e)
        {
            if (admEvento.GetCantidadLista() > 0)
            {
                FrmListarEvento frmListarEvento = new FrmListarEvento();
                frmListarEvento.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay eventos registrados para listar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mniEliminarFactura_Click(object sender, EventArgs e)
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

        private void mniEliminarEvento_Click(object sender, EventArgs e)
        {
            if (admEvento.GetCantidadLista() > 0)
            {
                FrmEliminarEvento frmEliminarEvento = new FrmEliminarEvento();
                frmEliminarEvento.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay eventos registrados para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mniEditarEvento_Click(object sender, EventArgs e)
        {
            if (admEvento.GetCantidadLista() > 0)
            {
                FrmEditarEvento frmEditarEvento = new FrmEditarEvento();
                frmEditarEvento.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay eventos registrados para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripSeparator7_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (admReserva.GetCantidadLista() > 0)
            {
                FrmEliminarReserva frmEliminarReserva = new FrmEliminarReserva();
                frmEliminarReserva.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay reservas registradas para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarReserva frmEditarReserva = new FrmEditarReserva();
            frmEditarReserva.ShowDialog();
        }

        private void mniEditar_Click(object sender, EventArgs e)
        {
            FrmEditarFactura frmEditarFactura = new FrmEditarFactura();
            frmEditarFactura.ShowDialog();
        }

        private void mniEliminarCliente_Click(object sender, EventArgs e)
        {
            if (admCliente.GetCantidadLista() > 0)
            {
                FrmEliminarCliente frmEliminarCliente = new FrmEliminarCliente();
                frmEliminarCliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay clientes registradas para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
