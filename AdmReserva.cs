using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    //CLASE QUE ADMINISTRARA LOS DATOS DE RESERVA
    public class AdmReserva
    {
       
        static List<Reserva> listaReservas = new List<Reserva>();
        //Inicializa la lista de reservas vacia
        public AdmReserva()
        {
            
        }

        // Metodo para agregar una nueva reserva
        public string AgregarReserva(DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin, string tipoSolicitud)
        {
            {
                // Validar horarios
                if (horaInicio >= horaFin)
                {
                    return "Error...La hora de inicio debe ser antes de la hora de fin";
                }

                // Crear la reserva 
                Reserva nuevaReserva = new Reserva();

                //Se crea el metodo de CrearReserva
                nuevaReserva.CrearReserva(fecha, horaInicio, horaFin, tipoSolicitud);

                // Agregar a la lista
                listaReservas.Add(nuevaReserva);

                return "\nReserva creada exitosamente:\n" + nuevaReserva.MostrarReserva();
            }
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


        string[] tipsEventos = { "Fiesta", "Reunión Empresarial", "Boda", "Graduación", "Conferencia", "Cumpleaños" };
        string[] tiposSolicitud = { "Salón Principal", "Salón VIP", "Auditorio", "Espacio para eventos y servicio de alimentos" };
        string[] nombreClientes = { "Leonardo Pluas", "Josue Chichanda", "Gustavo Garcia", "Daniel Castillo" };
        string[] nombreEventos = { "Cena Anual de Empresa TechSolutions", "Graduación Promoción 2025", "Fiesta de Fin de Año - Banco Guayaquil", "Despedida de Soltera de Ana" };


        public void LlenarComboTipoEvento(ComboBox cmbTipoEventos)
        {
            foreach (string tipEvent in tipsEventos)
            {
                cmbTipoEventos.Items.Add(tipEvent);
            }
        }
        public void LlenarComboTipoSolicitud(ComboBox cmbTipoSolicitud)
        {
            foreach (string tipSoli in tiposSolicitud)
            {
                cmbTipoSolicitud.Items.Add(tipSoli);
            }
        }
        public void LlenarComboClientes(ComboBox cmbClientes)
        {
            foreach (string nomClientes in nombreClientes)
            {
                cmbClientes.Items.Add(nomClientes);
            }
        }

        public void LlenarComboNombEvento(ComboBox cmbNombEvento)
        {
            foreach (string nomEven in nombreEventos)
            {
                cmbNombEvento.Items.Add(nomEven);
            }
        }
        public bool EsVacio(string cliente, string nombEvent, string tipEvents,
                          int cantPersonass, DateTime fecha, DateTime horaIni,
                          DateTime horaFinsh, string tipSolicitudd)
        {
            if (string.IsNullOrEmpty(cliente) ||string.IsNullOrEmpty(nombEvent) || string.IsNullOrEmpty(tipEvents) ||string.IsNullOrEmpty(tipSolicitudd))
            {
                MessageBox.Show("Error: Se necesita todos los campos llenos");
                return true;  // TRUE significa que SÍ hay campos vacíos
            }

            return false;  // FALSE significa que NO hay campos vacíos (todo está lleno)
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
            // PASO 2: Crear un nuevo objeto Reserva vacío
            Reserva nuevaReserva = new Reserva();

            nuevaReserva.Cliente = cliente;
            nuevaReserva.NombreEvento = nombEvent;
            nuevaReserva.TipoEvento = tipEvents;
            nuevaReserva.CantPersonas = cantPersonas;
            nuevaReserva.FechaReserva = fecha;
            // IMPORTANTE: horaIni y horaFin son DateTime, pero necesitamos TimeSpan
            // .TimeOfDay convierte DateTime a TimeSpan (solo la hora, sin la fecha)
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

                // PASO 3: Recorrer cada reserva de la lista
                foreach (Reserva r in listaReservas)
                {
                    // Agregar una nueva fila vacía y obtener su índice
                    indice = dgvReservas.Rows.Add();

                    // IMPORTANTE: Los nombres de las columnas deben coincidir EXACTAMENTE
                    // con los nombres que están en el Designer (colNro, colCliente, etc.)
                    dgvReservas.Rows[indice].Cells["colNro"].Value = indice + 1;
                    dgvReservas.Rows[indice].Cells["colCliente"].Value = r.Cliente;
                    dgvReservas.Rows[indice].Cells["colNombreEvento"].Value = r.NombreEvento;
                    dgvReservas.Rows[indice].Cells["colTipoEvento"].Value = r.TipoEvento;
                    dgvReservas.Rows[indice].Cells["colCantPersonas"].Value = r.CantPersonas;

                    // Formatear la fecha para que se vea bonita (dd/MM/yyyy)
                    dgvReservas.Rows[indice].Cells["colFechaReserva"].Value = r.FechaReserva.ToString("dd/MM/yyyy");

                    // Formatear las horas para que se vean como HH:mm (ejemplo: 14:30)
                    dgvReservas.Rows[indice].Cells["colHoraInicio"].Value = r.HoraInicio.ToString(@"hh\:mm");
                    dgvReservas.Rows[indice].Cells["colHoraFin"].Value = r.HoraFin.ToString(@"hh\:mm");
                }
            }
        }
    }
}



