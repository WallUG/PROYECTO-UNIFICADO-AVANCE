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
    public partial class FrmRegistroReserva : Form
    {
        AdmReserva admReser = new AdmReserva();
        public FrmRegistroReserva()
        {
            InitializeComponent();
            admReser.LlenarComboNombEvento(cmbNombEvento, cmbIdEvento);
        }
        //private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    char c = e.KeyChar;
        //    if (!Char.IsLetter(c) && c != ' ')
        //    {
        //        e.Handled = true;
        //        return;
        //    }
        //}
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cliente = (string)cmbClientes.SelectedItem, nombEvent = (string)cmbNombEvento.SelectedItem, tipEvents = (string)cmbTipoEvento.SelectedItem, tipSolicitudd =(string)cmbTipoSolicitud.SelectedItem;
            int cantPersonass = (int)nudCantPersonas.Value;
            DateTime fecha = dtpFechRerserva.Value;
            DateTime horaIni = dtpHoraInicio.Value;
            DateTime horaFinsh = dtpHoraFin.Value;
            string contenido= "";

            if (!admReser.EsVacio(cliente, nombEvent, tipEvents, cantPersonass, fecha, horaIni, horaFinsh,tipSolicitudd))
            {
                contenido = admReser.Registrar(cliente, nombEvent, tipEvents, cantPersonass, fecha, horaIni, horaFinsh, tipSolicitudd);
                txtcontenido.Text = contenido;
                MessageBox.Show("Reserva registrada con exito :D");
            }
            else
            {
                MessageBox.Show("ERROR...DEBE LLENAR TODOS LOS CAMPOS");
            }
        }

        public void cmbNombreEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            admReser.selecionarIdEvento(cmbNombEvento.SelectedIndex, cmbIdEvento, cmbClientes, cmbTipoEvento, txtDescripcionEvento, nudCantPersonas);
        }

        public void btnSeleccionar_click(object sender, EventArgs e)
        {
            admReser.MostrarDatosEventoPorNombre(Convert.ToInt16(cmbIdEvento.SelectedItem), cmbTipoEvento, cmbTipoSolicitud, cmbClientes, txtDescripcionEvento, nudCantPersonas);
            
        }

    }
}
