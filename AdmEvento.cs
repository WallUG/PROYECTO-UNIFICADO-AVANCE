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
    /// <summary>
    /// Administra la lógica de negocio para el módulo de Evento.
    /// Gestiona la creación, búsqueda y registro de eventos.
    /// También maneja los datos quemados de clientes e inmuebles.
    /// </summary>
    public class AdmEvento
    {
        #region Campos y Variables
        
        // Lista estática para mantener los eventos entre instancias
        private static List<Evento> eventos = new List<Evento>();
        
        // Evento actual en proceso
        private Evento evento = null;
        
        // Cliente seleccionado actualmente
        private Cliente clienteActual = null;
        
        // Lista estática de clientes (simula módulo cliente)
        private static List<Cliente> clientes = new List<Cliente>();
        
        // Lista estática de inmuebles (simula módulo inmueble)
        private static List<Inmueble> inmuebles = new List<Inmueble>();
        
        #endregion

        #region Datos para ComboBox
        
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
        
        // Estados de reserva disponibles
        private string[] estadosReserva = { 
            "Pendiente", 
            "Confirmada", 
            "Cancelada" 
        };
        
        // Tipos de inmueble disponibles
        private string[] tiposInmueble = { 
            "Salón de Eventos", 
            "Jardín", 
            "Terraza", 
            "Auditorio", 
            "Sala de Reuniones" 
        };
        
        #endregion

        #region Constructor
        
        /// <summary>
        /// Constructor que inicializa los datos quemados de clientes e inmuebles.
        /// Los datos se crean solo una vez (lista estática).
        /// </summary>
        public AdmEvento()
        {
            // Crear datos de clientes solo si la lista está vacía
            if (clientes.Count == 0)
            {
                CrearClientes();
            }
            
            // Crear datos de inmuebles solo si la lista está vacía
            if (inmuebles.Count == 0)
            {
                CrearInmuebles();
            }
        }
        
        #endregion

        #region Métodos de Inicialización de Datos
        
        /// <summary>
        /// Crea los clientes de prueba (datos quemados).
        /// Simula el módulo de cliente para el registro de eventos.
        /// </summary>
        private void CrearClientes()
        {
            // Primer cliente - Persona natural con cédula
            Cliente cliente1 = new Cliente();
            cliente1.IdCliente = 1;
            cliente1.CedulaCliente = "0931661482";
            cliente1.RucCliente = "N/A";
            cliente1.NombresCliente = "Daniel Fernando";
            cliente1.ApellidosCliente = "Castillo Mera";
            cliente1.NumCelularCliente = "0912345678";
            cliente1.TelefonoFijoCliente = "042124784";
            cliente1.CorreoElectronicoCliente = "daniel@gmail.com";
            cliente1.DireccionCliente = "Av. 9 de Octubre";
            clientes.Add(cliente1);

            // Segundo cliente - Persona natural con cédula
            Cliente cliente2 = new Cliente();
            cliente2.IdCliente = 2;
            cliente2.CedulaCliente = "0912345678";
            cliente2.RucCliente = "N/A";
            cliente2.NombresCliente = "María José";
            cliente2.ApellidosCliente = "López García";
            cliente2.NumCelularCliente = "0987654321";
            cliente2.TelefonoFijoCliente = "042567890";
            cliente2.CorreoElectronicoCliente = "maria@gmail.com";
            cliente2.DireccionCliente = "Av. Las Américas";
            clientes.Add(cliente2);

            // Tercer cliente - Empresa con RUC
            Cliente cliente3 = new Cliente();
            cliente3.IdCliente = 3;
            cliente3.CedulaCliente = "N/A";
            cliente3.RucCliente = "0931661482001";
            cliente3.NombresCliente = "Empresa ABC";
            cliente3.ApellidosCliente = "S.A.";
            cliente3.NumCelularCliente = "0999888777";
            cliente3.TelefonoFijoCliente = "042111222";
            cliente3.CorreoElectronicoCliente = "empresa@abc.com";
            cliente3.DireccionCliente = "Centro Empresarial";
            clientes.Add(cliente3);
        }

        /// <summary>
        /// Crea los inmuebles de prueba (datos quemados).
        /// Simula el módulo de inmueble para asignar a eventos.
        /// </summary>
        private void CrearInmuebles()
        {
            // Primer inmueble - Salón de Eventos
            Inmueble inmueble1 = new Inmueble();
            inmueble1.IdInmueble = 1;
            inmueble1.NombreInmueble = "Salón Principal";
            inmueble1.TipoInmueble = "Salón de Eventos";
            inmueble1.CantidadInmueblesDisponible = 100;
            inmueble1.PrecioUnitario = 50.00;
            inmueble1.PrecioTotal = 5000.00;
            inmueble1.InmuebleDisponible = true;
            inmuebles.Add(inmueble1);

            // Segundo inmueble - Jardín
            Inmueble inmueble2 = new Inmueble();
            inmueble2.IdInmueble = 2;
            inmueble2.NombreInmueble = "Jardín Tropical";
            inmueble2.TipoInmueble = "Jardín";
            inmueble2.CantidadInmueblesDisponible = 200;
            inmueble2.PrecioUnitario = 30.00;
            inmueble2.PrecioTotal = 6000.00;
            inmueble2.InmuebleDisponible = true;
            inmuebles.Add(inmueble2);

            // Tercer inmueble - Terraza
            Inmueble inmueble3 = new Inmueble();
            inmueble3.IdInmueble = 3;
            inmueble3.NombreInmueble = "Terraza Vista Mar";
            inmueble3.TipoInmueble = "Terraza";
            inmueble3.CantidadInmueblesDisponible = 80;
            inmueble3.PrecioUnitario = 75.00;
            inmueble3.PrecioTotal = 6000.00;
            inmueble3.InmuebleDisponible = true;
            inmuebles.Add(inmueble3);
        }
        
        #endregion

        #region Métodos de Búsqueda de Cliente
        
        /// <summary>
        /// Verifica si existen clientes registrados en el sistema.
        /// </summary>
        /// <returns>True si hay al menos un cliente, False si no hay ninguno</returns>
        public bool ExistenClientes()
        {
            return clientes.Count > 0;
        }

        /// <summary>
        /// Busca un cliente por su número de cédula o RUC.
        /// Recorre la lista de clientes usando foreach para encontrar coincidencias.
        /// </summary>
        /// <param name="ciRuc">Cédula o RUC a buscar</param>
        /// <param name="nombres">Parámetro de salida con los nombres del cliente</param>
        /// <param name="apellidos">Parámetro de salida con los apellidos del cliente</param>
        /// <returns>True si encuentra el cliente, False si no lo encuentra</returns>
        public bool BuscarClientePorCedulaORuc(string ciRuc, out string nombres, out string apellidos)
        {
            // Inicializar parámetros de salida
            nombres = "";
            apellidos = "";

            // Validar que el parámetro no esté vacío
            if (string.IsNullOrEmpty(ciRuc))
            {
                return false;
            }

            // Recorrer la lista de clientes buscando coincidencias
            foreach (Cliente c in clientes)
            {
                // Verificar si coincide con la cédula (y no es N/A)
                bool coincideCedula = (c.CedulaCliente == ciRuc) && (c.CedulaCliente != "N/A");
                
                if (coincideCedula)
                {
                    nombres = c.NombresCliente;
                    apellidos = c.ApellidosCliente;
                    clienteActual = c;
                    return true;
                }
                
                // Verificar si coincide con el RUC (y no es N/A)
                bool coincideRuc = (c.RucCliente == ciRuc) && (c.RucCliente != "N/A");
                
                if (coincideRuc)
                {
                    nombres = c.NombresCliente;
                    apellidos = c.ApellidosCliente;
                    clienteActual = c;
                    return true;
                }
            }
            
            return false;
        }

        /// <summary>
        /// Verifica si hay un cliente seleccionado actualmente.
        /// </summary>
        /// <returns>True si hay cliente seleccionado, False si no hay</returns>
        public bool HayClienteSeleccionado()
        {
            return clienteActual != null;
        }

        /// <summary>
        /// Limpia el cliente seleccionado actualmente.
        /// Se usa al limpiar el formulario para un nuevo registro.
        /// </summary>
        public void LimpiarClienteSeleccionado()
        {
            clienteActual = null;
        }
        
        #endregion

        #region Métodos para Llenar ComboBox
        
        /// <summary>
        /// Llena un ComboBox con los tipos de evento disponibles.
        /// </summary>
        /// <param name="cmb">ComboBox a llenar</param>
        public void LlenarTiposEvento(ComboBox cmb)
        {
            cmb.Items.Clear();
            foreach (string tipo in tiposEvento)
            {
                cmb.Items.Add(tipo);
            }
        }

        /// <summary>
        /// Llena un ComboBox con los estados de evento disponibles.
        /// </summary>
        /// <param name="cmb">ComboBox a llenar</param>
        public void LlenarEstadosEvento(ComboBox cmb)
        {
            cmb.Items.Clear();
            foreach (string estado in estadosEvento)
            {
                cmb.Items.Add(estado);
            }
        }

        /// <summary>
        /// Llena un ComboBox con los estados de reserva disponibles.
        /// </summary>
        /// <param name="cmb">ComboBox a llenar</param>
        public void LlenarEstadosReserva(ComboBox cmb)
        {
            cmb.Items.Clear();
            foreach (string estado in estadosReserva)
            {
                cmb.Items.Add(estado);
            }
        }

        /// <summary>
        /// Llena un ComboBox con los tipos de inmueble disponibles.
        /// </summary>
        /// <param name="cmb">ComboBox a llenar</param>
        public void LlenarTiposInmueble(ComboBox cmb)
        {
            cmb.Items.Clear();
            foreach (string tipo in tiposInmueble)
            {
                cmb.Items.Add(tipo);
            }
        }
        
        #endregion

        #region Métodos de Generación de ID
        
        /// <summary>
        /// Genera un nuevo ID para un evento.
        /// El ID es secuencial basado en la cantidad de eventos existentes.
        /// </summary>
        /// <returns>Siguiente ID disponible</returns>
        public int GenerarNuevoId()
        {
            return eventos.Count + 1;
        }
        
        #endregion

        #region Métodos de Datos Predeterminados
        
        /// <summary>
        /// Obtiene datos predeterminados según el tipo de evento seleccionado.
        /// Usa switch-case para determinar los valores según el tipo.
        /// </summary>
        /// <param name="tipoEvento">Tipo de evento seleccionado</param>
        /// <returns>Tupla con nombre, descripción, número de personas, dirección y estado</returns>
        public (string nombreEvento, string descripcionEvento, int numeroPersonas, string direccionEvento, string estadoEvento) ObtenerDatosPredeterminados(string tipoEvento)
        {
            // Usar switch para determinar datos según el tipo de evento
            switch (tipoEvento)
            {
                case "Cumpleaños":
                    return (
                        "Fiesta de cumpleaños", 
                        "Celebración de cumpleaños con pastel y sorpresas", 
                        50, 
                        "Dirección de la fiesta", 
                        "Planificado"
                    );
                    
                case "Boda":
                    return (
                        "Mi Boda soñada", 
                        "Celebración de matrimonio con recepción", 
                        150, 
                        "Dirección de la boda", 
                        "Confirmado"
                    );
                    
                case "Graduación":
                    return (
                        "Ceremonia de graduación", 
                        "Evento para celebrar la graduación académica", 
                        100, 
                        "Dirección de la graduación", 
                        "Planificado"
                    );
                    
                case "Corporativo":
                    return (
                        "Evento corporativo", 
                        "Reunión de negocios y networking", 
                        100, 
                        "Dirección del evento corporativo", 
                        "Planificado"
                    );
                    
                case "Conferencia":
                    return (
                        "Conferencia de tecnología", 
                        "Evento para discutir las últimas tendencias", 
                        200, 
                        "Dirección de la conferencia", 
                        "Planificado"
                    );
                    
                case "Otro":
                    return (
                        "Evento especial", 
                        "Descripción del evento", 
                        50, 
                        "Dirección del evento especial", 
                        "Planificado"
                    );
                    
                default:
                    return (
                        "Evento genérico", 
                        "Descripción del evento genérico", 
                        20, 
                        "Dirección del evento genérico", 
                        "Planificado"
                    );
            }
        }
        
        #endregion

        #region Métodos de Obtención de Datos
        
        /// <summary>
        /// Obtiene la lista completa de eventos registrados.
        /// </summary>
        /// <returns>Lista de eventos</returns>
        public List<Evento> ObtenerEventos()
        {
            return eventos;
        }
        
        #endregion

        #region Métodos de Validación
        
        /// <summary>
        /// Valida que los campos obligatorios del evento no estén vacíos.
        /// </summary>
        /// <param name="tipoEvento">Tipo de evento</param>
        /// <param name="nombreEvento">Nombre del evento</param>
        /// <param name="descEvento">Descripción del evento</param>
        /// <param name="numPersonas">Número de personas</param>
        /// <param name="direccionEvento">Dirección del evento</param>
        /// <param name="estadoEvento">Estado del evento</param>
        /// <returns>True si algún campo está vacío, False si todos tienen valor</returns>
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
        
        #endregion

        #region Métodos de Registro
        
        /// <summary>
        /// Registra un evento completo con toda su información.
        /// Crea internamente los objetos Reserva y EventoInmueble.
        /// </summary>
        /// <returns>Cadena con la información del evento registrado</returns>
        public string RegistrarEventoCompleto(
            int idEvento, 
            string tipoEvento, 
            string nombreEvento, 
            string descEvento, 
            int numPersonas, 
            string direccionEvento, 
            string estadoEvento, 
            DateTime fechaReserva, 
            DateTime horaInicio,
            DateTime horaFin, 
            string estadoReserva, 
            string tipoInmueble, 
            int cantidadInmueble, 
            DateTime fechaAsignacion)
        {
            // Paso 1: Crear objeto Reserva
            Reserva reserva = new Reserva();
            reserva.IdReserva = idEvento;
            reserva.FechaReserva = fechaReserva;
            reserva.HoraInicioReserva = horaInicio;
            reserva.HoraFinReserva = horaFin;
            reserva.EstadoReserva = estadoReserva;

            // Paso 2: Buscar inmueble por tipo
            Inmueble inmuebleSeleccionado = null;
            foreach (Inmueble inm in inmuebles)
            {
                if (inm.TipoInmueble == tipoInmueble)
                {
                    inmuebleSeleccionado = inm;
                    break;
                }
            }
            
            // Si no encuentra, usar el primero disponible
            if (inmuebleSeleccionado == null && inmuebles.Count > 0)
            {
                inmuebleSeleccionado = inmuebles[0];
            }

            // Paso 3: Crear EventoInmueble
            EventoInmueble eventoInmueble = new EventoInmueble();
            eventoInmueble.Inmueble = inmuebleSeleccionado;
            eventoInmueble.cantidadAsignada = cantidadInmueble;
            eventoInmueble.FechaAsignacion = fechaAsignacion;

            // Paso 4: Crear lista de EventoInmueble
            List<EventoInmueble> listaEventoInmueble = new List<EventoInmueble>();
            listaEventoInmueble.Add(eventoInmueble);

            // Paso 5: Crear el evento con toda la información
            evento = new Evento();
            evento.IdEvento = idEvento;
            evento.TipoEvento = tipoEvento;
            evento.NombreEvento = nombreEvento;
            evento.DescripcionEvento = descEvento;
            evento.NumPersonasEvento = numPersonas;
            evento.DireccionEvento = direccionEvento;
            evento.EstadoEvento = estadoEvento;
            evento.Cliente = clienteActual;
            evento.Reserva = reserva;
            evento.EventoInmueble = listaEventoInmueble;

            // Paso 6: Agregar evento a la lista
            eventos.Add(evento);
            
            return evento.mostrarEvento();
        }
        
        #endregion

        #region Métodos para DataGridView
        
        /// <summary>
        /// Llena un DataGridView con la lista de eventos registrados.
        /// </summary>
        /// <param name="dgvEvento">DataGridView a llenar</param>
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
        
        #endregion
    }
}