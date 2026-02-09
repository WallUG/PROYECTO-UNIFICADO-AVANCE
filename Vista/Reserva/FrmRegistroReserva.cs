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
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cliente = (string)cmbClientes.SelectedItem, nombEvent = (string)cmbNombEvento.SelectedItem, tipEvents = (string)cmbTipoEvento.SelectedItem, tipSolicitudd =(string)cmbTipoSolicitud.SelectedItem;
            int cantPersonass = (int)nudCantPersonas.Value;
            DateTime fecha = dtpFechRerserva.Value;
            DateTime horaIni = dtpHoraInicio.Value;
            DateTime horaFinsh = dtpHoraFin.Value;
            string contenido= "";

            if (!admReser.EsVacio(fecha, horaIni, horaFinsh,tipSolicitudd))
            {

                // Verificar que la hora de inicio sea menor que la hora de fin
                if (horaIni.TimeOfDay >= horaFinsh.TimeOfDay)
                {
                    MessageBox.Show("ERROR...La hora de inicio debe ser menor que la hora de fin");
                    return;
                }
                // Verificar si ya existe una reserva en esa fecha
                if (admReser.ExisteReservaEnFecha(fecha))
                {
                    MessageBox.Show("ERROR: Ya existe una reserva para esta fecha. Por favor seleccione otra fecha.");
                    return;
                }
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
