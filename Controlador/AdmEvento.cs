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
    public class AdmEvento
    {
        // Lista estática para mantener los eventos entre instancias
        private static List<Evento> eventos = new List<Evento>();
        
        // Evento actual en proceso
        private Evento evento = null;

        // Cliente seleccionado actualmente
        private Cliente cliente = null;

        // Tipos de inmueble disponibles
        string[] tipoIn = { "Locales", "Accesorios", "Servicios" };

        // Lista de inmuebles seleccionados para el evento actual
        List<EventoInmueble> listaEventoInmueble = new List<EventoInmueble>();

        // Variables para almacenar los datos del cliente encontrado
        private string clienteNombresEncontrado = "";
        private string clienteApellidosEncontrado = "";
        private bool clienteFueEncontrado = false;

        // Variables para almacenar los datos predeterminados del evento
        private string datoNombreEvento = "";
        private string datoDescripcionEvento = "";
        private int datoNumeroPersonas = 0;
        private string datoDireccionEvento = "";
        private string datoEstadoEvento = "";

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

        // Método para obtener un Evento por ID
        public static Evento ObtenerEventoPorId(int id)
        {
            for (int i = 0; i < eventos.Count; i++)
            {
                if (eventos[i].IdEvento == id)
                {
                    return eventos[i];
                }
            }
            return null;
        }

        // Método para obtener todos los eventos
        public static List<Evento> ObtenerTodosLosEventos()
        {
            return eventos;
        }

        // Método para llenar ComboBox de tipos de inmueble
        public void LlenarComboTipo(ComboBox cmbTipoInmueble)
        {
            for (int i = 0; i < tipoIn.Length; i++)
            {
                cmbTipoInmueble.Items.Add(tipoIn[i]);
            }
        }

        // Verifica si existen clientes registrados en el sistema
        public bool ExistenClientes()
        {
            List<Cliente> clientes = AdmCliente.ObtenerTodosLosClientes();
            return clientes.Count > 0;
        }
        
        // Busca un cliente por cédula o RUC y almacena el resultado
        public bool BuscarClientePorCedulaORuc(string ciORuc)
        {
            // Reiniciar valores
            clienteFueEncontrado = false;
            clienteNombresEncontrado = "";
            clienteApellidosEncontrado = "";

            // Validar que el parámetro no esté vacío
            if (string.IsNullOrEmpty(ciORuc))
            {
                return false;
            }

            Cliente clientebusqueda = AdmCliente.ObtenerClientePorId(ciORuc);

            if (clientebusqueda != null)
            {
                // Verificar si coincide con la cédula o RUC (y no es N/A)
                bool coincide = (clientebusqueda.CedulaORuc == ciORuc) && (clientebusqueda.CedulaORuc != "N/A");

                if (coincide)
                {
                    clienteFueEncontrado = true;
                    clienteNombresEncontrado = clientebusqueda.Nombre;
                    clienteApellidosEncontrado = clientebusqueda.Apellido;
                    cliente = clientebusqueda;
                    return true;
                }
            }
            return false;
        }

        // Obtiene los nombres del cliente encontrado
        public string ObtenerNombresClienteEncontrado()
        {
            return clienteNombresEncontrado;
        }

        // Obtiene los apellidos del cliente encontrado
        public string ObtenerApellidosClienteEncontrado()
        {
            return clienteApellidosEncontrado;
        }

        // Obtiene el nombre completo del cliente encontrado
        public string ObtenerNombreCompletoClienteEncontrado()
        {
            return clienteNombresEncontrado + " " + clienteApellidosEncontrado;
        }

        // Verifica si se encontró un cliente en la última búsqueda
        public bool ClienteFueEncontrado()
        {
            return clienteFueEncontrado;
        }
        
        // Verifica si hay un cliente seleccionado
        public bool HayClienteSeleccionado()
        {
            return cliente != null;
        }
        
        // Limpia el cliente seleccionado
        public void LimpiarClienteSeleccionado()
        {
            cliente = null;
            clienteFueEncontrado = false;
            clienteNombresEncontrado = "";
            clienteApellidosEncontrado = "";
        }
        
        // Llena el ComboBox con los tipos de evento
        public void LlenarTiposEvento(ComboBox cmb)
        {
            cmb.Items.Clear();
            for (int i = 0; i < tiposEvento.Length; i++)
            {
                cmb.Items.Add(tiposEvento[i]);
            }
        }
        
        // Llena el ComboBox con los estados de evento
        public void LlenarEstadosEvento(ComboBox cmb)
        {
            cmb.Items.Clear();
            for (int i = 0; i < estadosEvento.Length; i++)
            {
                cmb.Items.Add(estadosEvento[i]);
            }
        }
        
        // Genera un nuevo ID para el evento
        public int GenerarNuevoId()
        {
            return eventos.Count + 1;
        }
        
        // Carga los datos predeterminados según el tipo de evento
        public void CargarDatosPredeterminados(string tipoEvento)
        {
            // Reiniciar valores por defecto
            datoNombreEvento = "Evento genérico";
            datoDescripcionEvento = "Descripción del evento genérico";
            datoNumeroPersonas = 20;
            datoDireccionEvento = "Dirección del evento genérico";
            datoEstadoEvento = "Planificado";

            if (tipoEvento == "Cumpleaños")
            {
                datoNombreEvento = "Fiesta de cumpleaños";
                datoDescripcionEvento = "Celebración de cumpleaños con pastel y sorpresas";
                datoNumeroPersonas = 50;
                datoDireccionEvento = "Dirección de la fiesta";
                datoEstadoEvento = "Planificado";
            }
            else if (tipoEvento == "Boda")
            {
                datoNombreEvento = "Mi Boda soñada";
                datoDescripcionEvento = "Celebración de matrimonio con recepción";
                datoNumeroPersonas = 150;
                datoDireccionEvento = "Dirección de la boda";
                datoEstadoEvento = "Confirmado";
            }
            else if (tipoEvento == "Graduación")
            {
                datoNombreEvento = "Ceremonia de graduación";
                datoDescripcionEvento = "Evento para celebrar la graduación académica";
                datoNumeroPersonas = 100;
                datoDireccionEvento = "Dirección de la graduación";
                datoEstadoEvento = "Planificado";
            }
            else if (tipoEvento == "Corporativo")
            {
                datoNombreEvento = "Evento corporativo";
                datoDescripcionEvento = "Reunión de negocios y networking";
                datoNumeroPersonas = 100;
                datoDireccionEvento = "Dirección del evento corporativo";
                datoEstadoEvento = "Planificado";
            }
            else if (tipoEvento == "Conferencia")
            {
                datoNombreEvento = "Conferencia de tecnología";
                datoDescripcionEvento = "Evento para discutir las últimas tendencias";
                datoNumeroPersonas = 200;
                datoDireccionEvento = "Dirección de la conferencia";
                datoEstadoEvento = "Planificado";
            }
            else if (tipoEvento == "Otro")
            {
                datoNombreEvento = "Evento especial";
                datoDescripcionEvento = "Descripción del evento";
                datoNumeroPersonas = 50;
                datoDireccionEvento = "Dirección del evento especial";
                datoEstadoEvento = "Planificado";
            }
        }

        // Obtiene el nombre del evento predeterminado cargado
        public string ObtenerNombreEventoPredeterminado()
        {
            return datoNombreEvento;
        }

        // Obtiene la descripción del evento predeterminado cargado
        public string ObtenerDescripcionEventoPredeterminado()
        {
            return datoDescripcionEvento;
        }

        // Obtiene el número de personas del evento predeterminado cargado
        public int ObtenerNumeroPersonasPredeterminado()
        {
            return datoNumeroPersonas;
        }

        // Obtiene la dirección del evento predeterminado cargado
        public string ObtenerDireccionEventoPredeterminado()
        {
            return datoDireccionEvento;
        }

        // Obtiene el estado del evento predeterminado cargado
        public string ObtenerEstadoEventoPredeterminado()
        {
            return datoEstadoEvento;
        }
        
        // Obtiene la lista completa de eventos registrados
        public List<Evento> ObtenerEventos()
        {
            return eventos;
        }
        
        // Verifica si los campos del evento están vacíos
        public bool EsVacio(string tipoEvento, string nombreEvento, string descEvento, 
            int numPersonas, string direccionEvento, string estadoEvento)
        {
            bool tipoVacio = string.IsNullOrEmpty(tipoEvento);
            bool nombreVacio = string.IsNullOrEmpty(nombreEvento);
            bool descVacio = string.IsNullOrEmpty(descEvento);
            bool personasVacio = (numPersonas == 0);
            bool direccionVacio = string.IsNullOrEmpty(direccionEvento);
            bool estadoVacio = string.IsNullOrEmpty(estadoEvento);
            
            if (tipoVacio || nombreVacio || descVacio || personasVacio || direccionVacio || estadoVacio)
            {
                return true;
            }
            
            return false;
        }
        
        // Verifica si hay inmuebles seleccionados con cantidad mayor a 0
        public bool HayInmueblesSeleccionados()
        {
            if (listaEventoInmueble == null || listaEventoInmueble.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < listaEventoInmueble.Count; i++)
            {
                if (listaEventoInmueble[i].cantidadInmueble > 0)
                {
                    return true;
                }
            }

            return false;
        }

        // Limpia la lista de inmuebles seleccionados
        public void LimpiarInmueblesSeleccionados()
        {
            listaEventoInmueble.Clear();
        }

        // Elimina un inmueble de la lista de seleccionados por su ID
        public void EliminarInmuebleSeleccionado(int idInmueble)
        {
            for (int i = listaEventoInmueble.Count - 1; i >= 0; i--)
            {
                if (listaEventoInmueble[i].inmueble != null && 
                    listaEventoInmueble[i].ObtenerIdInmueble() == idInmueble)
                {
                    listaEventoInmueble.RemoveAt(i);
                    break;
                }
            }
        }

        // Obtiene la cantidad disponible de un inmueble por su ID usando EventoInmueble
        public int ObtenerCantidadDisponibleInmueble(int idInmueble)
        {
            // Obtener el inmueble desde AdmInmueble
            Inmueble inmueble = AdmInmueble.ObtenerInmueblePorId(idInmueble);
            
            if (inmueble != null)
            {
                // Crear un EventoInmueble temporal para obtener la cantidad disponible
                EventoInmueble eventoInmuebleTemporal = new EventoInmueble();
                eventoInmuebleTemporal.inmueble = inmueble;
                return eventoInmuebleTemporal.ObtenerCantidadDisponibleInmueble();
            }
            
            return 0;
        }

        // Verifica si la cantidad solicitada es válida para un inmueble
        public bool EsCantidadValidaParaInmueble(int idInmueble, int cantidadSolicitada)
        {
            Inmueble inmueble = AdmInmueble.ObtenerInmueblePorId(idInmueble);
            
            if (inmueble != null)
            {
                EventoInmueble eventoInmuebleTemporal = new EventoInmueble();
                eventoInmuebleTemporal.inmueble = inmueble;
                return eventoInmuebleTemporal.EsCantidadValida(cantidadSolicitada);
            }
            
            return false;
        }

        // Actualiza o agrega un inmueble seleccionado con la cantidad especificada
        public void ActualizarInmuebleSeleccionado(int idInmueble, int cantidadAsignada, DateTime fechaAsignacion)
        {
            // Buscar si ya existe el inmueble en la lista
            bool encontrado = false;
            for (int i = 0; i < listaEventoInmueble.Count; i++)
            {
                if (listaEventoInmueble[i].inmueble != null && 
                    listaEventoInmueble[i].ObtenerIdInmueble() == idInmueble)
                {
                    // Actualizar la cantidad y fecha usando los métodos de EventoInmueble
                    listaEventoInmueble[i].ActualizarCantidadAsignada(cantidadAsignada);
                    listaEventoInmueble[i].ActualizarFechaAsignacion(fechaAsignacion);
                    encontrado = true;
                    break;
                }
            }

            // Si no existe, agregarlo
            if (!encontrado)
            {
                Inmueble inmueble = AdmInmueble.ObtenerInmueblePorId(idInmueble);
                if (inmueble != null)
                {
                    EventoInmueble eventoInmueble = new EventoInmueble(inmueble, cantidadAsignada, fechaAsignacion);
                    listaEventoInmueble.Add(eventoInmueble);
                }
            }
        }
        
        // Registra el evento completo con todos sus datos
        public string RegistrarEventoCompleto(int idEvento, string tipoEvento, string nombreEvento, string descEvento, int numPersonas, string direccionEvento, 
            string estadoEvento, 
            string tipoInmueble, 
            int cantidadInmueble, 
            DateTime fechaAsignacion)
        {
            // Crear una copia de la lista de inmuebles seleccionados para el evento
            List<EventoInmueble> listaInmueblesEvento = new List<EventoInmueble>();
            for (int i = 0; i < listaEventoInmueble.Count; i++)
            {
                EventoInmueble copia = new EventoInmueble();
                copia.inmueble = listaEventoInmueble[i].inmueble;
                copia.cantidadInmueble = listaEventoInmueble[i].cantidadInmueble;
                copia.fechaAsignacionInmueble = listaEventoInmueble[i].fechaAsignacionInmueble;
                listaInmueblesEvento.Add(copia);
            }

            // Crear el evento con todos los parámetros correctos
            evento = new Evento(
                idEvento, 
                cliente, 
                tipoEvento, 
                nombreEvento, 
                descEvento,
                numPersonas, 
                direccionEvento, 
                estadoEvento, 
                listaInmueblesEvento
            );

            // Agregar evento a la lista estática
            eventos.Add(evento);

            // Limpiar la lista de inmuebles seleccionados para el próximo evento
            listaEventoInmueble.Clear();
            
            return evento.mostrarEvento();
        }

        // Llena el DataGridView con los eventos registrados
        public void LlenarTabla(DataGridView dgvEvento)
        {
            dgvEvento.Rows.Clear();

            if (eventos.Count > 0)
            {
                for (int i = 0; i < eventos.Count; i++)
                {
                    Evento e = eventos[i];
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

        // Llena el DataGridView de inmuebles filtrado por tipo
        public void LlenarDescripcionInmuebleLocales(DataGridView dgvInmuebles, string filtro)
        {
            dgvInmuebles.Rows.Clear();

            List<Inmueble> listaActual = AdmInmueble.ObtenerTodosLosInmuebles();

            if(listaActual.Count == 0)
            {
                MessageBox.Show("No hay inmuebles registrados en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = 0; i < listaActual.Count; i++)
            {
                Inmueble inm = listaActual[i];
                if(inm.tipoInmueble == filtro)
                {
                    // Crear un EventoInmueble temporal para obtener los datos
                    EventoInmueble eventoInmuebleTemporal = new EventoInmueble();
                    eventoInmuebleTemporal.inmueble = inm;

                    int indice = dgvInmuebles.Rows.Add();
                    dgvInmuebles.Rows[indice].Cells["IdInmueble"].Value = eventoInmuebleTemporal.ObtenerIdInmueble();
                    dgvInmuebles.Rows[indice].Cells["NombreInmueble"].Value = eventoInmuebleTemporal.ObtenerNombreInmueble();
                    dgvInmuebles.Rows[indice].Cells["Disponible"].Value = eventoInmuebleTemporal.EstaDisponible();
                    dgvInmuebles.Rows[indice].Cells["CantidadDisp"].Value = eventoInmuebleTemporal.ObtenerCantidadDisponibleInmueble();
                }
            }
        }
        
        // Agrega un inmueble a la lista de seleccionados
        public void AgregarInmuebleSeleccionado(int idInmueble, int cantidadAsignada, DateTime fechaAsignacion)
        {
            Inmueble inmueble = AdmInmueble.ObtenerInmueblePorId(idInmueble);
            if (inmueble != null)
            {
                EventoInmueble eventoInmueble = new EventoInmueble(inmueble, cantidadAsignada, fechaAsignacion);
                MessageBox.Show("Inmueble agregado: " + eventoInmueble.ObtenerNombreInmueble(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listaEventoInmueble.Add(eventoInmueble);
            }
            else
            {
                MessageBox.Show("Inmueble no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}