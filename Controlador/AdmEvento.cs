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

        /* Cliente seleccionado actualmente*/
        private Cliente cliente = null;

        string[] tipoIn = { "Locales", "Accesorios", "Servicios" };

        List<Inmueble> listaInmuebles = AdmInmueble.ObtenerTodosLosInmuebles();
        List<EventoInmueble> listaEventoInmueble = new List<EventoInmueble>();

        // Método para obtener un Eventos
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

        // Método para obtener todos
        public static List<Evento> ObtenerTodosLosEventos()
        {
            return eventos;
        }

        public void LlenarComboTipo(ComboBox cmbTipoInmueble)
        {
            foreach (string tipo in tipoIn)
            {
                cmbTipoInmueble.Items.Add(tipo);
            }
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
        
        /*Tipos de inmueble disponibles
        private string[] tiposInmueble = { 
            "Salón de Eventos", 
            "Jardín", 
            "Terraza", 
            "Auditorio", 
            "Sala de Reuniones" 
        };
        */
        /// Verifica si existen clientes registrados en el sistema.
        /// true si hay al menos un cliente, False si no hay
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

            Cliente clientebusqueda = AdmCliente.ObtenerClientePorId(ciORuc);

            if (clientebusqueda != null)
            {
                // Verificar si coincide con la cédula (y no es N/A)
                bool coincideCedula = (clientebusqueda.CedulaORuc == ciORuc) && (clientebusqueda.CedulaORuc != "N/A");

                if (coincideCedula)
                {
                    nombre = clientebusqueda.Nombre;
                    apellido = clientebusqueda.Apellido;
                    cliente = clientebusqueda;
                    return true;
                }

                // Verificar si coincide con el RUC (y no es N/A)
                bool coincideRuc = (clientebusqueda.CedulaORuc == ciORuc) && (clientebusqueda.CedulaORuc != "N/A");

                if (coincideRuc)
                {
                    nombre = clientebusqueda.Nombre;
                    apellido = clientebusqueda.Apellido;
                    cliente = clientebusqueda;
                    return true;
                }
            }
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
        
        /// Verifica si hay inmuebles seleccionados con cantidad mayor a 0
        public bool HayInmueblesSeleccionados()
        {
            if (listaEventoInmueble == null || listaEventoInmueble.Count == 0)
            {
                return false;
            }

            // Verificar que al menos uno tenga cantidad mayor a 0
            for (int i = 0; i < listaEventoInmueble.Count; i++)
            {
                if (listaEventoInmueble[i].cantidadInmueble > 0)
                {
                    return true;
                }
            }

            return false;
        }

        /// Limpia la lista de inmuebles seleccionados
        public void LimpiarInmueblesSeleccionados()
        {
            listaEventoInmueble.Clear();
        }

        /// Elimina un inmueble de la lista de seleccionados por su ID
        public void EliminarInmuebleSeleccionado(int idInmueble)
        {
            for (int i = listaEventoInmueble.Count - 1; i >= 0; i--)
            {
                if (listaEventoInmueble[i].inmueble != null && 
                    listaEventoInmueble[i].inmueble.idInmueble == idInmueble)
                {
                    listaEventoInmueble.RemoveAt(i);
                    break;
                }
            }
        }

        /// Actualiza o agrega un inmueble seleccionado con la cantidad especificada
        public void ActualizarInmuebleSeleccionado(int idInmueble, int cantidadAsignada, DateTime fechaAsignacion)
        {
            // Buscar si ya existe el inmueble en la lista
            bool encontrado = false;
            for (int i = 0; i < listaEventoInmueble.Count; i++)
            {
                if (listaEventoInmueble[i].inmueble != null && 
                    listaEventoInmueble[i].inmueble.idInmueble == idInmueble)
                {
                    // Actualizar la cantidad y fecha
                    listaEventoInmueble[i].cantidadInmueble = cantidadAsignada;
                    listaEventoInmueble[i].fechaAsignacionInmueble = fechaAsignacion;
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
                    EventoInmueble eventoInmueble = new EventoInmueble();
                    eventoInmueble.inmueble = inmueble;
                    eventoInmueble.cantidadInmueble = cantidadAsignada;
                    eventoInmueble.fechaAsignacionInmueble = fechaAsignacion;
                    listaEventoInmueble.Add(eventoInmueble);
                }
            }
        }
        
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
                descEvento,  // descripción del evento (estaba pasando direccionEvento dos veces)
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

        public void LlenarTabla(DataGridView dgvEvento)
        {
            // Limpiar filas existentes
            dgvEvento.Rows.Clear();

            // Verificar si hay eventos para mostrar
            if (eventos.Count > 0)
            {
                // Recorrer cada evento y agregarlo al DataGridView
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

        public void LlenarDescripcionInmuebleLocales(DataGridView dgvInmuebles, string filtro)
        {
            // Limpiar filas existentes
            dgvInmuebles.Rows.Clear();

            // Obtener la lista actualizada de inmuebles
            List<Inmueble> listaActual = AdmInmueble.ObtenerTodosLosInmuebles();

            if(listaActual.Count == 0)
            {
                MessageBox.Show("No hay inmuebles registrados en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Recorrer cada inmueble y agregarlo al DataGridView
            for (int i = 0; i < listaActual.Count; i++)
            {
                Inmueble inm = listaActual[i];
                if(inm.tipoInmueble == filtro)
                {
                    int indice = dgvInmuebles.Rows.Add();
                    dgvInmuebles.Rows[indice].Cells["IdInmueble"].Value = inm.idInmueble;
                    dgvInmuebles.Rows[indice].Cells["NombreInmueble"].Value = inm.nombreInmueble;
                    dgvInmuebles.Rows[indice].Cells["Disponible"].Value = inm.inmuebleDisponible;
                    dgvInmuebles.Rows[indice].Cells["CantidadDisp"].Value = inm.cantidadInmuebleDisponible;
                }
            }
        }
        
        public void AgregarInmuebleSeleccionado(int v, int cantidadAsignada, DateTime fechaAsignacion)
        {
            Inmueble inmueble = AdmInmueble.ObtenerInmueblePorId(v);
            if (inmueble != null)
            {
                EventoInmueble eventoInmueble = new EventoInmueble();
                eventoInmueble.inmueble = inmueble;
                eventoInmueble.cantidadInmueble = cantidadAsignada;
                eventoInmueble.fechaAsignacionInmueble = fechaAsignacion;
                MessageBox.Show("Inmueble agregado: " + inmueble.nombreInmueble, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listaEventoInmueble.Add(eventoInmueble);
            }
            else
            {
                MessageBox.Show("Inmueble no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}