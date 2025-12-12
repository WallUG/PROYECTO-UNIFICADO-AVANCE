//CASTILLO MERA DANIEL FERNANDO
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    /*
    Administra la lógica de negocio para el módulo de Evento.
    /// Gestiona la creación, búsqueda y registro de eventos.
    También maneja los datos quemados de clientes e inmuebles.
    */
    public class AdmEvento
    {
        // Lista estática para mantener los eventos entre instancias
        private static List<Evento> eventos = new List<Evento>();
        
        // Evento actual en proceso
        private Evento evento = null;

        /* Cliente seleccionado actualmente
        private Cliente clienteActual = null;*/
        private Cliente cliente = null;

        // Método para obtener un Eventos
        public static Evento ObtenerEventoPorId(int id)
        {
            return eventos.Find(v => v.IdEvento == id);
        }

        // Método para obtener todos
        public static List<Evento> ObtenerTodosLosEventos()
        {
            return eventos;
        }

        // Tipos de evento disponibles
        private string[] tiposEvento = { 
            "Cumpleaños", 
            "Boda", 
            "Graduación", 
            "Corporativo", 
            "Conferencia", 
            "Otro" 
        };
        
        // Estados de evento disponibles
        private string[] estadosEvento = { 
            "Planificado", 
            "Confirmado", 
            "Realizado", 
            "Cancelado" 
        };
        
        /* Estados de reserva disponibles
        private string[] estadosReserva = { 
            "Pendiente", 
            "Confirmada", 
            "Cancelada" 
        };*/
        
        // Tipos de inmueble disponibles
        private string[] tiposInmueble = { 
            "Salón de Eventos", 
            "Jardín", 
            "Terraza", 
            "Auditorio", 
            "Sala de Reuniones" 
        };
        
        /// Verifica si existen clientes registrados en el sistema.
        /// true si hay al menos un cliente, False si no hay ninguno</returns>
        public bool ExistenClientes()
        {
            List<Cliente> clientes = AdmCliente.ObtenerTodosLosClientes();
            return clientes.Count > 0;
        }
        
        public bool BuscarClientePorCedulaORuc(string ciORuc, out string nombre, out string apellido)
        {
            // Inicializar parámetros de salida
            nombre = "";
            apellido = "";

            // Validar que el parámetro no esté vacío
            if (string.IsNullOrEmpty(ciORuc))
            {
                return false;
            }

            // Recorrer la lista de clientes buscando coincidencias
            //foreach (Cliente c in clientes)
            //{

            Cliente cliente = AdmCliente.ObtenerClientePorId(ciORuc);

            if (cliente != null)
            {
                // Verificar si coincide con la cédula (y no es N/A)
                bool coincideCedula = (cliente.CedulaORuc == ciORuc) && (cliente.CedulaORuc != "N/A");

                if (coincideCedula)
                {
                    nombre = cliente.Nombre;
                    apellido = cliente.Apellido;
                    //clientes = c;
                    return true;
                }

                // Verificar si coincide con el RUC (y no es N/A)
                bool coincideRuc = (cliente.CedulaORuc == ciORuc) && (cliente.CedulaORuc != "N/A");

                if (coincideRuc)
                {
                    nombre = cliente.Nombre;
                    apellido = cliente.Apellido;
                    //clientes = c;
                    return true;
                }
            }
            //}
            
            return false;
        }
        
        public bool HayClienteSeleccionado()
        {
            return cliente != null;
        }
        
        public void LimpiarClienteSeleccionado()
        {
            cliente = null;
        }
        
        public void LlenarTiposEvento(ComboBox cmb)
        {
            cmb.Items.Clear();
            foreach (string tipo in tiposEvento)
            {
                cmb.Items.Add(tipo);
            }
        }
        
        public void LlenarEstadosEvento(ComboBox cmb)
        {
            cmb.Items.Clear();
            foreach (string estado in estadosEvento)
            {
                cmb.Items.Add(estado);
            }
        }
        
        public int GenerarNuevoId()
        {
            return eventos.Count + 1;
        }
        
        public (string nombreEvento, string descripcionEvento, int numeroPersonas, string direccionEvento, string estadoEvento) ObtenerDatosPredeterminados(string tipoEvento)
        {
            switch (tipoEvento)
            {
                case "Cumpleaños":
                    return ("Fiesta de cumpleaños", "Celebración de cumpleaños con pastel y sorpresas", 50, "Dirección de la fiesta", "Planificado");
                    
                case "Boda":
                    return ("Mi Boda soñada", "Celebración de matrimonio con recepción", 150, "Dirección de la boda", "Confirmado");
                    
                case "Graduación":
                    return ("Ceremonia de graduación", "Evento para celebrar la graduación académica", 100, "Dirección de la graduación", "Planificado");
                    
                case "Corporativo":
                    return ("Evento corporativo", "Reunión de negocios y networking", 100, "Dirección del evento corporativo", "Planificado");
                    
                case "Conferencia":
                    return ("Conferencia de tecnología", "Evento para discutir las últimas tendencias", 200, "Dirección de la conferencia", "Planificado");
                    
                case "Otro":
                    return ("Evento especial", "Descripción del evento", 50, "Dirección del evento especial", "Planificado");
                    
                default:
                    return ("Evento genérico", "Descripción del evento genérico", 20, "Dirección del evento genérico", "Planificado");
            }
        }
        
        /// Obtiene la lista completa de eventos registrados.
        
        public List<Evento> ObtenerEventos()
        {
            return eventos;
        }
        
        public bool EsVacio(string tipoEvento, string nombreEvento, string descEvento, 
            int numPersonas, string direccionEvento, string estadoEvento)
        {
            // Verificar cada campo obligatorio
            bool tipoVacio = string.IsNullOrEmpty(tipoEvento);
            bool nombreVacio = string.IsNullOrEmpty(nombreEvento);
            bool descVacio = string.IsNullOrEmpty(descEvento);
            bool personasVacio = (numPersonas == 0);
            bool direccionVacio = string.IsNullOrEmpty(direccionEvento);
            bool estadoVacio = string.IsNullOrEmpty(estadoEvento);
            
            // Retornar true si alguno está vacío
            if (tipoVacio || nombreVacio || descVacio || personasVacio || direccionVacio || estadoVacio)
            {
                return true;
            }
            
            return false;
        }
        
        public string RegistrarEventoCompleto(int idEvento, string tipoEvento, string nombreEvento, string descEvento, int numPersonas, string direccionEvento, 
            string estadoEvento, 
            string tipoInmueble, 
            int cantidadInmueble, 
            DateTime fechaAsignacion)
        {
            // Paso 2: rellenar tabla con inmuebles por tipo
            Inmueble inmuebleSeleccionado = null;
            List<Inmueble> listaInmueble = AdmInmueble.ObtenerTodosLosInmuebles();
            foreach (Inmueble inm in listaInmueble)
            {
                if (inm.tipoInmueble == tipoInmueble)
                {
                    inmuebleSeleccionado = inm;
                    break;
                }
            }
            

            // Si no encuentra, usar el primero disponible
            //if (inmuebleSeleccionado == null && inmuebles.Count > 0)
            //{
            //    inmuebleSeleccionado = inmuebles[0];
            //}
            
            // Paso 3: Crear EventoInmueble
            EventoInmueble eventoInmueble = new EventoInmueble();
            eventoInmueble.inmueble = inmuebleSeleccionado;
            eventoInmueble.cantidadInmueble = cantidadInmueble;
            eventoInmueble.fechaAsignacionInmueble = fechaAsignacion;

            // Paso 4: Crear lista de EventoInmueble
            List<EventoInmueble> listaEventoInmueble = new List<EventoInmueble>();
            listaEventoInmueble.Add(eventoInmueble);
            // Usar el primer cliente registrado

            // Paso 5: Crear el evento con toda la información
            evento.IdEvento = idEvento;
            evento.Cliente = cliente;
            evento.TipoEvento = tipoEvento;
            evento.NombreEvento = nombreEvento;
            evento.DescripcionEvento = descEvento;
            evento.NumPersonasEvento = numPersonas;
            evento.DireccionEvento = direccionEvento;
            evento.EstadoEvento = estadoEvento;
            evento.EventoInmueble = listaEventoInmueble;

            evento = new Evento(idEvento, cliente, tipoEvento, nombreEvento, direccionEvento, numPersonas, direccionEvento, estadoEvento, listaEventoInmueble);

            // Paso 6: Agregar evento a la lista
            eventos.Add(evento);
            
            return evento.mostrarEvento();
        }

        public void LlenarTabla(DataGridView dgvEvento)
        {
            // Limpiar filas existentes
            dgvEvento.Rows.Clear();

            // Verificar si hay eventos para mostrar
            if (eventos.Count > 0)
            {
                // Recorrer cada evento y agregarlo al DataGridView
                foreach (Evento e in eventos)
                {
                    int indice = dgvEvento.Rows.Add();
                    dgvEvento.Rows[indice].Cells["colId"].Value = e.IdEvento;
                    dgvEvento.Rows[indice].Cells["colTipoEvento"].Value = e.TipoEvento;
                    dgvEvento.Rows[indice].Cells["colNombreEvento"].Value = e.NombreEvento;
                    dgvEvento.Rows[indice].Cells["colDescripcionEvento"].Value = e.DescripcionEvento;
                    dgvEvento.Rows[indice].Cells["colNumPersona"].Value = e.NumPersonasEvento;
                    dgvEvento.Rows[indice].Cells["colDireccionEvento"].Value = e.DireccionEvento;
                    dgvEvento.Rows[indice].Cells["colEstadoEvento"].Value = e.EstadoEvento;
                }
            }
        }
    }
}