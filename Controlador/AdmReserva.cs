//NICK ADRIAN ZAMBRANO ARTEAGA
using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    //CLASE QUE ADMINISTRARA LOS DATOS DE RESERVA
    public class AdmReserva
    {
       
        static List<Reserva> listaReservas = new List<Reserva>();
        List<Evento> listaEvento = AdmEvento.ObtenerTodosLosEventos();
        Evento even = null;
        //Inicializa la lista de reservas vacia
        public AdmReserva()
        {
            
        }

        public static Reserva ObtenerReservaPorId(int id)
        {
            return listaReservas.Find(v => v.IdReserva == id);
        }

        // Método para obtener todos
        public static List<Reserva> ObtenerTodosLasReservas()
        {
            return listaReservas;
        }
       
        // Metodo para mostrar todas las reservas
        public string MostrarTodasReservas()
        {
            if (listaReservas.Count == 0)
            {
                return "No hay reservas registradas.";
            }

            string mensaje = "\n===== LISTA DE RESERVAS =====\n";
            for (int i = 0; i < listaReservas.Count; i++)
            {
                // Usar el método mostrarReserva del diagrama
                mensaje = mensaje + listaReservas[i].MostrarReserva() + "\n";
            }
            return mensaje;
        }

        //Lista para agarrar la info del boton guaradar
        static List<Reserva> lista = new List<Reserva>();
        Reserva reserva = null;
        string[] tiposSolicitud = { "Reservada", "No reservada" };

        public void LlenarComboTipoEvento(ComboBox cmbTipoEventos, Evento evem)
        {
            cmbTipoEventos.Items.Add(evem.TipoEvento);
            int index = 0;
            cmbTipoEventos.SelectedIndex = index;
        }

        public void LlenarComboClientes(ComboBox cmbClientes, Evento evem)
        {
            cmbClientes.Items.Add(evem.Cliente.Nombre);
            int index = 0;
            cmbClientes.SelectedIndex = index;
        }

        public void LlenarComboNombEvento(ComboBox cmbNombEvento, ComboBox cmbIdEvento)
        {
            if (listaEvento.Count == 0)
            {
                MessageBox.Show("La lista de eventos está vacía.");
                return;
            }

            foreach (Evento nomEven in listaEvento)
            {
                cmbNombEvento.Items.Add(nomEven.NombreEvento);
                cmbIdEvento.Items.Add(nomEven.NumEventos);
            }
        }
        public bool EsVacio(string cliente, string nombEvent, string tipEvents,
                          int cantPersonass, DateTime fecha, DateTime horaIni,
                          DateTime horaFinsh, string tipSolicitudd)
        {
            if (string.IsNullOrEmpty(cliente) ||string.IsNullOrEmpty(nombEvent) || string.IsNullOrEmpty(tipEvents) ||string.IsNullOrEmpty(tipSolicitudd))
            {
                MessageBox.Show("Error: Se necesita todos los campos llenos");
                return true;  // TRUE significa que Si hay campos vacíos
            }

            return false;  // FALSE significa que No hay campos vacíos (todo está lleno)
        }
        // Método para verificar si ya existe una reserva en una fecha específica
        public bool ExisteReservaEnFecha(DateTime fecha)
        {
            foreach (Reserva reserva in listaReservas)
            {
                // Comparar solo la fecha, sin la hora
                if (reserva.FechaReserva.Date == fecha.Date)
                {
                    return true; // Ya existe una reserva en esa fecha
                }
            }
            return false; // No existe reserva en esa fecha
        }


        public string Registrar(string cliente, string nombEvent, string tipEvents,
                               int cantPersonas, DateTime fecha, DateTime horaIni,
                               DateTime horaFin, string tipSolicitud)
        {
            //Validar que la hora de inicio sea antes que la hora de fin
            if (horaIni.TimeOfDay >= horaFin.TimeOfDay)
            {
                return "Error...La hora de inicio debe ser antes de la hora de fin";
            }
            
            Reserva nuevaReserva = new Reserva();

            nuevaReserva.evento = even;
            nuevaReserva.FechaReserva = fecha;
            
            
            nuevaReserva.HoraInicio = horaIni.TimeOfDay;
            nuevaReserva.HoraFin = horaFin.TimeOfDay;
            nuevaReserva.TipoSolicitud = tipSolicitud;
            listaReservas.Add(nuevaReserva);
            return nuevaReserva.MostrarReserva();
        }


        public void LlenarTabla(DataGridView dgvReservas)
        {
            dgvReservas.Rows.Clear();
            if (listaReservas.Count > 0)
            {
                int indice = 0;

                
                foreach (Reserva r in listaReservas)
                {
                    
                    indice = dgvReservas.Rows.Add();

                    
                    dgvReservas.Rows[indice].Cells["colNro"].Value = indice + 1;
                    dgvReservas.Rows[indice].Cells["colCliente"].Value = r.evento.Cliente.Nombre;
                    dgvReservas.Rows[indice].Cells["colNombreEvento"].Value = r.evento.NombreEvento;
                    dgvReservas.Rows[indice].Cells["colTipoEvento"].Value = r.evento.TipoEvento;
                    dgvReservas.Rows[indice].Cells["colCantPersonas"].Value = r.evento.NumPersonasEvento;

                    // Formatear la fecha para que se vea bonita (dd/MM/yyyy)
                    dgvReservas.Rows[indice].Cells["colFechaReserva"].Value = r.FechaReserva.ToString("dd/MM/yyyy");

                    // Formatear las horas para que se vean como HH:mm (ejemplo: 14:30)
                    dgvReservas.Rows[indice].Cells["colHoraInicio"].Value = r.HoraInicio.ToString(@"hh\:mm");
                    dgvReservas.Rows[indice].Cells["colHoraFin"].Value = r.HoraFin.ToString(@"hh\:mm");
                }
            }
        }

        public void MostrarDatosEventoPorNombre(int indexEvento, ComboBox cmbTipoEvento, ComboBox cmbTipoSolicitud, ComboBox cmbClientes, TextBox txtDescripcionEvento, NumericUpDown nudCantPersonas)
        {
            even = AdmEvento.ObtenerEventoPorNumEventos(indexEvento);
            if(even != null) {
                LlenarComboTipoEvento(cmbTipoEvento, even);
                LlenarComboTipoSolicitud(cmbTipoSolicitud);
                LlenarDescripcionEvento(txtDescripcionEvento, even);
                LlenarComboClientes(cmbClientes, even);
                LlenarNumeroPersonas(nudCantPersonas, even);
            }

        }

        private void LlenarComboTipoSolicitud(ComboBox cmbTipoSolicitud)
        {
            foreach (string tipSoli in tiposSolicitud)
            {
                cmbTipoSolicitud.Items.Add(tipSoli);
            }
        }

        private void LlenarDescripcionEvento(TextBox txtDescripcionEvento, Evento even)
        {
            txtDescripcionEvento.Text = even.DescripcionEvento;
        }

        private void LlenarNumeroPersonas(NumericUpDown nudCantPersonas, Evento even)
        {
            nudCantPersonas.Value = even.NumPersonasEvento;
        }

        public void selecionarIdEvento(int selectedIndex, ComboBox cmbIdEvento, ComboBox cmbTipoEvento, ComboBox cmbClientes, TextBox txtDescripcionEvento, NumericUpDown nudCantPersonas)
        {
            cmbIdEvento.SelectedIndex = selectedIndex;
        }

        public int GetCantidadLista()
        {
            return listaReservas.Count;
        }
    }
}