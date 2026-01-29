using Datos;
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
    public class AdmEvento
    {
        public static List<Evento> listaEventos = new List<Evento>();
        public static int numeroEditarEvento = 0;
        public static int IdEventoDB = 0;
        public Evento evento = null;
        public Cliente cliente = null;
        public List<EventoInmueble> listaEventoInmueble = new List<EventoInmueble>();
        ConexionBDD cnBDD = null;
        DatosEvento datosEvento = null;
        DatosEventoInmueble datosEventoInmueble = null;
        EventoInmueble copia = null;

        private string clienteNombresEncontrado = "";
        private string clienteApellidosEncontrado = "";
        private bool clienteFueEncontrado = false;
        private string clienteCedulaEncontrado = "";

        private string datoNombreEvento = "";
        private string datoDescripcionEvento = "";
        private int datoNumeroPersonas = 0;
        private string datoDireccionEvento = "";
        private string datoEstadoEvento = "";

        private string[] tiposEvento = {
            "Cumpleaños",
            "Boda",
            "Graduación",
            "Corporativo",
            "Conferencia",
            "Otro"
        };

        private string[] estadosEvento = {
            "Planificado",
            "Confirmado",
            "Realizado",
            "Cancelado"
        };

        private string[] estadosEventoEditables = {
            "Planificado",
            "Confirmado"
        };

        public AdmEvento() {
            ConsultarEventosBDD();
        }
        private void EliminarEventosBDD(Evento evento)
        {
            cnBDD = new ConexionBDD();
            DatosEvento datosEvento = new DatosEvento();
            string msj = cnBDD.Conectar();
            if (msj[0] == '1')
            {
                datosEvento.EliminarEventos(evento, cnBDD.sql);
                cnBDD.Desconectar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj);
            }
        }

        private string MostrarDatosListaEventos()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Evento evento in listaEventos)
            {
                foreach(EventoInmueble inmueble in evento.EventoInmueble)
                {
                    foreach(Inmueble inm in inmueble.listaInmuebles)
                    {
                        sb.AppendLine("Número de Evento: " + evento.NumEventos);
                        sb.AppendLine("Cliente: " + evento.ObtenerNombreCliente());
                        sb.AppendLine("Tipo de Evento: " + evento.TipoEvento);
                        sb.AppendLine("Nombre del Evento: " + evento.NombreEvento);
                        sb.AppendLine("Descripción del Evento: " + evento.DescripcionEvento);
                        sb.AppendLine("Número de Personas: " + evento.NumPersonasEvento);
                        sb.AppendLine("Dirección del Evento: " + evento.DireccionEvento);
                        sb.AppendLine("Estado del Evento: " + evento.EstadoEvento);
                        sb.AppendLine("Casto: " + inm.precioInmueble);
                        sb.AppendLine("Inmueble Asignado: " + inm.nombreInmueble);
                        sb.AppendLine("Cantidad Asignada: " + inmueble.cantidadInmueble);
                        sb.AppendLine("Fecha de Asignación: " + inmueble.fechaAsignacionInmueble.ToShortDateString());
                        sb.AppendLine("----------------------------------------");
                    }
                }

            }
            return sb.ToString();
        }

        private void ConsultarEventosBDD()
        {
            cnBDD = new ConexionBDD();
            datosEvento = new DatosEvento();
            string msj = cnBDD.Conectar();

            if (msj[0] == '1')
            {
                listaEventos = datosEvento.ConsultarEventos(cnBDD.sql);
                if (listaEventos.Count==0)
                {
                    MessageBox.Show("No existen registros de Eventos en la Base de Datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //MessageBox.Show("Eventos cargados desde la Base de Datos:\n" + MostrarDatosListaEventos(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cnBDD.Desconectar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj, "Error de conexión a la Base de Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static Evento ObtenerEventoPorNumEventos(int numEventos)
        {
            for (int i = 0; i < listaEventos.Count; i++)
            {
                if (listaEventos[i].NumEventos == numEventos)
                {
                    return listaEventos[i];
                }
            }
            return null;
        }

        public static List<Evento> ObtenerTodosLosEventos()
        {
            return listaEventos;
        }

        public void LlenarComboTipo(ComboBox cmbTipoInmueble)
        {
            string[] tiposInmueble = AdmEventoInmueble.ObtenerTiposInmueble();
            for (int i = 0; i < tiposInmueble.Length; i++)
            {
                cmbTipoInmueble.Items.Add(tiposInmueble[i]);
            }
        }

        public bool ExistenClientes()
        {
            List<Cliente> clientes = AdmCliente.ObtenerTodosLosClientes();
            return clientes.Count > 0;
        }

        public bool BuscarClientePorCedulaORuc(string ciORuc)
        {
            clienteFueEncontrado = false;
            clienteNombresEncontrado = "";
            clienteApellidosEncontrado = "";
            clienteCedulaEncontrado = "";

            if (string.IsNullOrEmpty(ciORuc))
            {
                return false;
            }

            Cliente clientebusqueda = AdmCliente.ObtenerClientePorIdentificacion(ciORuc);

            if (clientebusqueda != null)
            {
                bool coincide = (clientebusqueda.CedulaORuc == ciORuc) && (clientebusqueda.CedulaORuc != "N/A");

                if (coincide)
                {
                    clienteFueEncontrado = true;
                    clienteNombresEncontrado = clientebusqueda.Nombre;
                    clienteApellidosEncontrado = clientebusqueda.Apellido;
                    clienteCedulaEncontrado = clientebusqueda.CedulaORuc;
                    cliente = clientebusqueda;
                    return true;
                }
            }
            return false;
        }

        public string ObtenerNombresClienteEncontrado()
        {
            return clienteNombresEncontrado;
        }

        public string ObtenerApellidosClienteEncontrado()
        {
            return clienteApellidosEncontrado;
        }

        public string ObtenerNombreCompletoClienteEncontrado()
        {
            return clienteNombresEncontrado + " " + clienteApellidosEncontrado;
        }

        public string ObtenerCedulaClienteEncuentrado()
        {
            return clienteCedulaEncontrado;
        }

        public bool ClienteFueEncontrado()
        {
            return clienteFueEncontrado;
        }

        public bool HayClienteSeleccionado()
        {
            return cliente != null;
        }

        public void LimpiarClienteSeleccionado()
        {
            cliente = null;
            clienteFueEncontrado = false;
            clienteNombresEncontrado = "";
            clienteApellidosEncontrado = "";
            clienteCedulaEncontrado = "";
        }

        public void LlenarTiposEvento(ComboBox cmb)
        {
            cmb.Items.Clear();
            for (int i = 0; i < tiposEvento.Length; i++)
            {
                cmb.Items.Add(tiposEvento[i]);
            }
        }

        public void LlenarEstadosEvento(ComboBox cmb)
        {
            cmb.Items.Clear();
            for (int i = 0; i < estadosEvento.Length; i++)
            {
                cmb.Items.Add(estadosEvento[i]);
            }
        }

        public void LlenarEstadosEventoEditables(ComboBox cmb)
        {
            cmb.Items.Clear();
            for (int i = 0; i < estadosEventoEditables.Length; i++)
            {
                cmb.Items.Add(estadosEventoEditables[i]);
            }
        }

        public int GenerarNuevoNumEventos()
        {
            return listaEventos.Count + 1;
        }

        public void CargarDatosPredeterminadosEvento(string tipoEvento)
        {
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
                datoNumeroPersonas = 150;
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

        public string ObtenerNombreEventoPredeterminado()
        {
            return datoNombreEvento;
        }

        public string ObtenerDescripcionEventoPredeterminado()
        {
            return datoDescripcionEvento;
        }

        public int ObtenerNumeroPersonasPredeterminado()
        {
            return datoNumeroPersonas;
        }

        public string ObtenerDireccionEventoPredeterminado()
        {
            return datoDireccionEvento;
        }

        public string ObtenerEstadoEventoPredeterminado()
        {
            return datoEstadoEvento;
        }

        public List<Evento> ObtenerEventos()
        {
            return listaEventos;
        }

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

        public void LimpiarInmueblesSeleccionados()
        {
            listaEventoInmueble.Clear();
        }

        public void EliminarInmuebleSeleccionado(string numeroInmueble)
        {
            for (int i = listaEventoInmueble.Count - 1; i >= 0; i--)
            {
                if (listaEventoInmueble[i].inmueble != null &&
                    listaEventoInmueble[i].ObtenerNumInmuebles() == numeroInmueble)
                {
                    listaEventoInmueble.RemoveAt(i);
                    break;
                }
            }
        }

        public int ObtenerCantidadDisponibleInmueble(string numeroInmueble)
        {
            Inmueble inmueble = AdmInmueble.ObtenerInmueblePorNumInmuebles(numeroInmueble);

            if (inmueble != null)
            {
                EventoInmueble eventoInmuebleTemporal = new EventoInmueble();
                eventoInmuebleTemporal.inmueble = inmueble;
                return eventoInmuebleTemporal.ObtenerCantidadDisponibleInmueble();
            }

            return 0;
        }

        public bool EsCantidadValidaParaInmueble(string numeroInmueble, int cantidadSolicitada)
        {
            Inmueble inmueble = AdmInmueble.ObtenerInmueblePorNumInmuebles(numeroInmueble);

            if (inmueble != null)
            {
                EventoInmueble eventoInmuebleTemporal = new EventoInmueble();
                eventoInmuebleTemporal.inmueble = inmueble;
                return eventoInmuebleTemporal.EsCantidadValida(cantidadSolicitada);
            }

            return false;
        }

        public void ActualizarInmuebleSeleccionado(string numeroInmueble, int cantidadAsignada, DateTime fechaAsignacion)
        {
            bool enviado = false;
            for (int i = 0; i < listaEventoInmueble.Count; i++)
            {
                if (listaEventoInmueble[i].inmueble != null &&
                    listaEventoInmueble[i].ObtenerNumInmuebles() == numeroInmueble)
                {
                    listaEventoInmueble[i].ActualizarCantidadAsignada(cantidadAsignada);
                    listaEventoInmueble[i].ActualizarFechaAsignacion(fechaAsignacion);
                    enviado = true;
                    break;
                }
            }

            if (!enviado)
            {
                Inmueble inmueble = AdmInmueble.ObtenerInmueblePorNumInmuebles(numeroInmueble);
                if (inmueble != null)
                {
                    EventoInmueble eventoInmueble = new EventoInmueble(inmueble, cantidadAsignada, fechaAsignacion);
                    listaEventoInmueble.Add(eventoInmueble);
                }
            }
        }

        public void RegistrarEventoCompleto(int numEventos, string tipoEvento, string nombreEvento, string descripcionEvento,
            int numPersonas, string direccionEvento, string estadoEvento, string tipoInmueble, int cantidadInmueble,
            DateTime fechaAsignacion)
        {
            List<EventoInmueble> listaInmueblesEvento = new List<EventoInmueble>();
            for (int i = 0; i < listaEventoInmueble.Count; i++)
            {
                copia = new EventoInmueble();
                copia.inmueble = listaEventoInmueble[i].inmueble;
                copia.cantidadInmueble = listaEventoInmueble[i].cantidadAsignada;
                copia.fechaAsignacionInmueble = listaEventoInmueble[i].fechaAsignacion;
                listaInmueblesEvento.Add(copia);
            }

            evento = new Evento(
                numEventos,
                cliente,
                tipoEvento,
                nombreEvento,
                descripcionEvento,
                numPersonas,
                direccionEvento,
                estadoEvento,
                listaInmueblesEvento
            );

            listaEventos.Add(evento);
            RegistrarEventoBDD(evento);
            RegistrarEventoInmuebleBDD(IdEventoDB, copia);

            listaEventoInmueble.Clear();
        }
        
        public void CargarTablaEventos(DataGridView dgvEventos)
        {
            Cliente cliente = new Cliente();
            dgvEventos.Rows.Clear();
            int indice = 0;

            foreach (Evento evento in listaEventos)
            {
                dgvEventos.Rows.Add();
                dgvEventos.Rows[indice].Cells["colNro"].Value = indice + 1;
                dgvEventos.Rows[indice].Cells["colCedulaORuc"].Value = evento.Cliente.CedulaORuc;
                dgvEventos.Rows[indice].Cells["colNumEventos"].Value = evento.NumEventos;
                dgvEventos.Rows[indice].Cells["colTipoEvento"].Value = evento.TipoEvento;
                dgvEventos.Rows[indice].Cells["colNombreEvento"].Value = evento.NombreEvento;
                dgvEventos.Rows[indice].Cells["colDescripcionEvento"].Value = evento.DescripcionEvento;
                dgvEventos.Rows[indice].Cells["colNumPersonas"].Value = evento.NumPersonasEvento;
                dgvEventos.Rows[indice].Cells["colDireccionEvento"].Value = evento.DireccionEvento;
                dgvEventos.Rows[indice].Cells["colEstadoEvento"].Value = evento.EstadoEvento;
                dgvEventos.Rows[indice].Cells["colNumModificacionesEvento"].Value = evento.NumModificacionesEvento;
                indice++;
            }
        }

        public void LlenarDescripcionInmuebleLocales(DataGridView dgvInmuebles, string filtro)
        {
            dgvInmuebles.Rows.Clear();

            List<Inmueble> listaActual = AdmInmueble.ObtenerTodosLosInmuebles();

            if (listaActual.Count == 0)
            {
                MessageBox.Show("No hay inmuebles registrados en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = 0; i < listaActual.Count; i++)
            {
                Inmueble inm = listaActual[i];
                if (inm.tipoInmueble == filtro)
                {
                    EventoInmueble eventoInmuebleTemporal = new EventoInmueble();
                    eventoInmuebleTemporal.inmueble = inm;

                    int indice = dgvInmuebles.Rows.Add();
                    dgvInmuebles.Rows[indice].Cells["colNumInmuebles"].Value = eventoInmuebleTemporal.ObtenerNumInmuebles();
                    dgvInmuebles.Rows[indice].Cells["colNombreInmueble"].Value = eventoInmuebleTemporal.ObtenerNombreInmueble();
                    dgvInmuebles.Rows[indice].Cells["colDisponible"].Value = eventoInmuebleTemporal.EstaDisponible();
                    dgvInmuebles.Rows[indice].Cells["colCantidadDisp"].Value = eventoInmuebleTemporal.ObtenerCantidadDisponibleInmueble();
                }
            }
        }

        public void AgregarInmuebleSeleccionado(string numeroInmueble, int cantidadAsignada, DateTime fechaAsignacion)
        {
            Inmueble inmueble = AdmInmueble.ObtenerInmueblePorNumInmuebles(numeroInmueble);
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

        public List<EventoInmueble> ObtenerInmueblesSeleccionadosActuales()
        {
            return listaEventoInmueble;
        }

        public int ObtenerCantidadInmueblesSeleccionados()
        {
            return listaEventoInmueble.Count;
        }

        public EventoInmueble ObtenerInmuebleSeleccionadoPorNumero(string numeroInmueble)
        {
            for (int i = 0; i < listaEventoInmueble.Count; i++)
            {
                if (listaEventoInmueble[i].inmueble != null &&
                    listaEventoInmueble[i].ObtenerNumInmuebles() == numeroInmueble)
                {
                    return listaEventoInmueble[i];
                }
            }
            return null;
        }

        public void SincronizarInmuebleTemp(string numeroInmueble, int cantidadAsignada, DateTime fechaAsignacion)
        {
            Inmueble inmuebleActual = AdmInmueble.ObtenerInmueblePorNumInmuebles(numeroInmueble);

            if (inmuebleActual != null)
            {
                EventoInmueble eventoInmueble = new EventoInmueble(inmuebleActual, cantidadAsignada, fechaAsignacion);
                AdmEventoInmueble.AgregarInmuebleTemp(eventoInmueble);
            }
        }

        public void EliminarInmuebleTemp(string numeroInmueble)
        {
            AdmEventoInmueble.EliminarInmuebleTemp(numeroInmueble);
        }

        public void LimpiarInmueblesTemp()
        {
            AdmEventoInmueble.LimpiarInmueblesTemp();
        }

        public int ObtenerCantidadRealDisponible(string numeroInmueble)
        {
            Inmueble inmueble = AdmInmueble.ObtenerInmueblePorNumInmuebles(numeroInmueble);

            if (inmueble != null)
            {
                EventoInmueble eventoInmTemp = new EventoInmueble();
                eventoInmTemp.inmueble = inmueble;
                return eventoInmTemp.ObtenerCantidadDisponibleInmueble();
            }

            return 0;
        }

        public string ObtenerNombreInmueble(string numeroInmueble)
        {
            Inmueble inmueble = AdmInmueble.ObtenerInmueblePorNumInmuebles(numeroInmueble);

            if (inmueble != null)
            {
                EventoInmueble eventoInmTemp = new EventoInmueble();
                eventoInmTemp.inmueble = inmueble;
                return eventoInmTemp.ObtenerNombreInmueble();
            }

            return "";
        }

        public bool ObtenerDisponibilidadInmueble(string numeroInmueble)
        {
            Inmueble inmueble = AdmInmueble.ObtenerInmueblePorNumInmuebles(numeroInmueble);

            if (inmueble != null)
            {
                EventoInmueble eventoInmTemp = new EventoInmueble();
                eventoInmTemp.inmueble = inmueble;
                return eventoInmTemp.EstaDisponible();
            }

            return false;
        }

        public int GetCantidadLista()
        {
            return listaEventos.Count;
        }

        public void EliminarEvento(int indice, DataGridView dgvEventos)
        {
            string numEventos = dgvEventos.Rows[indice].Cells["colNumEventos"].Value.ToString();
            DialogResult resultado = MessageBox.Show("Desea eliminar el Evento " + numEventos + "?",
                "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                for (int i = 0; i < listaEventos.Count; i++)
                {
                    if (listaEventos[i].NumEventos.ToString() == numEventos)
                    {
                        EliminarEventosBDD(listaEventos[i]);
                        listaEventos.RemoveAt(i);
                        MessageBox.Show("Evento eliminado correctamente!", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("La operación se canceló", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public bool EsVacio(string txtNumCedula, string txtNumEventos)
        {
            if (string.IsNullOrWhiteSpace(txtNumCedula) && string.IsNullOrWhiteSpace(txtNumEventos))
            {
                return true;
            }
            return false;
        }

        public void VerificarFiltros(string txtCiRucCliente, string txtNumEventos, DataGridView dgvEventos)
        {
            Cliente cliente = new Cliente();
            dgvEventos.Rows.Clear();
            int indice = 0;

            string filtro = "";
            if (!string.IsNullOrWhiteSpace(txtCiRucCliente))
            {
                filtro = "Cedula";
            }
            else if (!string.IsNullOrWhiteSpace(txtNumEventos))
            {
                filtro = "NumEventos";
            }

            for (int i = 0; i < listaEventos.Count; i++)
            {
                Evento eventoActual = listaEventos[i];
                bool agregar = false;

                if (filtro == "Cedula")
                {
                    if (eventoActual.Cliente != null && eventoActual.Cliente.CedulaORuc == txtCiRucCliente)
                    {
                        agregar = true;
                    }
                }
                else if (filtro == "NumEventos")
                {
                    if (eventoActual.NumEventos.ToString() == txtNumEventos)
                    {
                        agregar = true;
                    }
                }

                if (agregar)
                {
                    dgvEventos.Rows.Add();
                    dgvEventos.Rows[indice].Cells["colNro"].Value = indice + 1;
                    dgvEventos.Rows[indice].Cells["colCedulaORuc"].Value = eventoActual.Cliente.CedulaORuc;
                    dgvEventos.Rows[indice].Cells["colNumEventos"].Value = eventoActual.NumEventos;
                    dgvEventos.Rows[indice].Cells["colTipoEvento"].Value = eventoActual.TipoEvento;
                    dgvEventos.Rows[indice].Cells["colNombreEvento"].Value = eventoActual.NombreEvento;
                    dgvEventos.Rows[indice].Cells["colDescripcionEvento"].Value = eventoActual.DescripcionEvento;
                    dgvEventos.Rows[indice].Cells["colNumPersonas"].Value = eventoActual.NumPersonasEvento;
                    dgvEventos.Rows[indice].Cells["colDireccionEvento"].Value = eventoActual.DireccionEvento;
                    dgvEventos.Rows[indice].Cells["colEstadoEvento"].Value = eventoActual.EstadoEvento;
                    dgvEventos.Rows[indice].Cells["colNumModificacionesEvento"].Value = eventoActual.NumModificacionesEvento;
                    indice++;
                }
            }
        }

        public bool EventoEsEditable(int indice, DataGridView dgvEventos)
        {
            object valorCelda = dgvEventos.Rows[indice].Cells["colNumEventos"].Value;
            if (valorCelda == null)
            {
                return false;
            }

            int numerosEvento = Convert.ToInt32(valorCelda);

            for (int i = 0; i < listaEventos.Count; i++)
            {
                if (listaEventos[i].NumEventos == numerosEvento)
                {
                    if (listaEventos[i].EstadoEvento == "Realizado")
                    {
                        MessageBox.Show("El evento ya ha sido realizado y no puede ser editado.", "Editar Evento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else if (listaEventos[i].EstadoEvento == "Cancelado")
                    {
                        MessageBox.Show("El evento está cancelado y no puede ser editado.", "Editar Evento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void GuardarNumeroEditarEvento(int indice, DataGridView dgvEventos)
        {
            object valorCelda = dgvEventos.Rows[indice].Cells["colNumEventos"].Value;
            if (valorCelda != null)
            {
                numeroEditarEvento = Convert.ToInt32(valorCelda);
            }
        }

        public int ObtenerNumeroEventoEditar()
        {
            return numeroEditarEvento;
        }

        public Evento ObtenerEventoPorNumero(int numEvento)
        {
            for (int i = 0; i < listaEventos.Count; i++)
            {
                if (listaEventos[i].NumEventos == numEvento)
                {
                    return listaEventos[i];
                }
            }
            return null;
        }

        public bool ExisteEventoParaEditar(int numEvento)
        {
            for (int i = 0; i < listaEventos.Count; i++)
            {
                if (listaEventos[i].NumEventos == numEvento)
                {
                    return true;
                }
            }
            return false;
        }

        public void PrepararEdicionEvento(int numEvento)
        {
            Evento eventoEditar = ObtenerEventoPorNumero(numEvento);
            if (eventoEditar != null && eventoEditar.Cliente != null)
            {
                cliente = eventoEditar.Cliente;
                clienteFueEncontrado = true;
                clienteNombresEncontrado = eventoEditar.Cliente.Nombre;
                clienteApellidosEncontrado = eventoEditar.Cliente.Apellido;
                clienteCedulaEncontrado = eventoEditar.Cliente.CedulaORuc;
            }

            listaEventoInmueble.Clear();
            if (eventoEditar != null && eventoEditar.EventoInmueble != null)
            {
                for (int i = 0; i < eventoEditar.EventoInmueble.Count; i++)
                {
                    EventoInmueble original = eventoEditar.EventoInmueble[i];
                    EventoInmueble copia = new EventoInmueble();
                    copia.inmueble = original.inmueble;
                    copia.cantidadInmueble = original.cantidadInmueble;
                    copia.fechaAsignacionInmueble = original.fechaAsignacionInmueble;
                    listaEventoInmueble.Add(copia);
                }
            }
        }

        public string ObtenerCedulaClienteEvento(int numEvento)
        {
            Evento eventoEditar = ObtenerEventoPorNumero(numEvento);
            if (eventoEditar != null && eventoEditar.Cliente != null)
            {
                return eventoEditar.Cliente.CedulaORuc;
            }
            return "";
        }

        public string ObtenerNombresClienteEvento(int numEvento)
        {
            Evento eventoEditar = ObtenerEventoPorNumero(numEvento);
            if (eventoEditar != null && eventoEditar.Cliente != null)
            {
                return eventoEditar.Cliente.Nombre;
            }
            return "";
        }

        public string ObtenerApellidosClienteEvento(int numEvento)
        {
            Evento eventoEditar = ObtenerEventoPorNumero(numEvento);
            if (eventoEditar != null && eventoEditar.Cliente != null)
            {
                return eventoEditar.Cliente.Apellido;
            }
            return "";
        }

        public string ObtenerTipoEventoPorNumero(int numEvento)
        {
            Evento eventoEditar = ObtenerEventoPorNumero(numEvento);
            if (eventoEditar != null)
            {
                return eventoEditar.TipoEvento;
            }
            return "";
        }

        public string ObtenerNombreEventoPorNumero(int numEvento)
        {
            Evento eventoEditar = ObtenerEventoPorNumero(numEvento);
            if (eventoEditar != null)
            {
                return eventoEditar.NombreEvento;
            }
            return "";
        }

        public string ObtenerDescripcionEventoPorNumero(int numEvento)
        {
            Evento eventoEditar = ObtenerEventoPorNumero(numEvento);
            if (eventoEditar != null)
            {
                return eventoEditar.DescripcionEvento;
            }
            return "";
        }

        public int ObtenerNumPersonasEventoPorNumero(int numEvento)
        {
            Evento eventoEditar = ObtenerEventoPorNumero(numEvento);
            if (eventoEditar != null)
            {
                return eventoEditar.NumPersonasEvento;
            }
            return 0;
        }

        public string ObtenerDireccionEventoPorNumero(int numEvento)
        {
            Evento eventoEditar = ObtenerEventoPorNumero(numEvento);
            if (eventoEditar != null)
            {
                return eventoEditar.DireccionEvento;
            }
            return "";
        }

        public string ObtenerEstadoEventoPorNumero(int numEvento)
        {
            Evento eventoEditar = ObtenerEventoPorNumero(numEvento);
            if (eventoEditar != null)
            {
                return eventoEditar.EstadoEvento;
            }
            return "";
        }

        public List<string> ObtenerNumerosInmueblesEvento(int numEvento)
        {
            List<string> numeros = new List<string>();
            Evento eventoEditar = ObtenerEventoPorNumero(numEvento);

            if (eventoEditar != null && eventoEditar.EventoInmueble != null)
            {
                for (int i = 0; i < eventoEditar.EventoInmueble.Count; i++)
                {
                    if (eventoEditar.EventoInmueble[i].inmueble != null)
                    {
                        numeros.Add(eventoEditar.EventoInmueble[i].ObtenerNumInmuebles());
                    }
                }
            }

            return numeros;
        }

        public List<int> ObtenerCantidadesInmueblesEvento(int numEvento)
        {
            List<int> cantidades = new List<int>();
            Evento eventoEditar = ObtenerEventoPorNumero(numEvento);

            if (eventoEditar != null && eventoEditar.EventoInmueble != null)
            {
                for (int i = 0; i < eventoEditar.EventoInmueble.Count; i++)
                {
                    cantidades.Add(eventoEditar.EventoInmueble[i].cantidadInmueble);
                }
            }

            return cantidades;
        }

        public DateTime ObtenerFechaAsignacionInmueblesEvento(int numEvento)
        {
            Evento eventoEditar = ObtenerEventoPorNumero(numEvento);

            if (eventoEditar != null && eventoEditar.EventoInmueble != null && eventoEditar.EventoInmueble.Count > 0)
            {
                return eventoEditar.EventoInmueble[0].fechaAsignacionInmueble;
            }

            return DateTime.MinValue;
        }

        public int ObtenerIndiceTipoEvento(string tipoEvento)
        {
            for (int i = 0; i < tiposEvento.Length; i++)
            {
                if (tiposEvento[i] == tipoEvento)
                {
                    return i;
                }
            }
            return -1;
        }

        public int ObtenerIndiceEstadoEventoEditable(string estadoEvento)
        {
            for (int i = 0; i < estadosEventoEditables.Length; i++)
            {
                if (estadosEventoEditables[i] == estadoEvento)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool ActualizarEventoExistente(int numEventos, string tipoEvento, string nombreEvento,
            string descripcionEvento, int numPersonas, string direccionEvento, string estadoEvento)
        {
            for (int i = 0; i < listaEventos.Count; i++)
            {
                if (listaEventos[i].NumEventos == numEventos)
                {
                    listaEventos[i].TipoEvento = tipoEvento;
                    listaEventos[i].NombreEvento = nombreEvento;
                    listaEventos[i].DescripcionEvento = descripcionEvento;
                    listaEventos[i].NumPersonasEvento = numPersonas;
                    listaEventos[i].DireccionEvento = direccionEvento;
                    listaEventos[i].EstadoEvento = estadoEvento;
                    listaEventos[i].NumModificacionesEvento = listaEventos[i].NumModificacionesEvento + 1;

                    List<EventoInmueble> listaInmueblesActualizada = new List<EventoInmueble>();
                    for (int j = 0; j < listaEventoInmueble.Count; j++)
                    {
                        EventoInmueble copia = new EventoInmueble();
                        copia.inmueble = listaEventoInmueble[j].inmueble;
                        copia.cantidadInmueble = listaEventoInmueble[j].cantidadInmueble;
                        copia.fechaAsignacionInmueble = listaEventoInmueble[j].fechaAsignacionInmueble;
                        listaInmueblesActualizada.Add(copia);
                    }

                    listaEventos[i].EventoInmueble = listaInmueblesActualizada;

                    listaEventoInmueble.Clear();

                    return true;
                }
            }
            return false;
        }

        public void CargarEventoParaEditar(GroupBox gbInformacionCliente, GroupBox gbCreacionEvento, GroupBox gbAsignarInmuebles, GroupBox gbListaInmueblesSele)
        {
            Evento eventoEditar = ObtenerEventoPorNumero(numeroEditarEvento);

            if (eventoEditar == null)
            {
                MessageBox.Show("No se encontró el evento a editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void Conectar()
        {
            cnBDD = new ConexionBDD();
            string msj = cnBDD.Conectar();

            if (msj[0] == '1')
            {
                MessageBox.Show("Conexión a la Base de Datos exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnBDD.Desconectar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj, "Error de conexión a la Base de Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int ObtenerIdEventoDB()
        {
            int id = 0;
            id = IdEventoDB;
            return id;
        }

        private void RegistrarEventoBDD(Evento evento)
        {
            cnBDD = new ConexionBDD();
            datosEvento = new DatosEvento();
            string msj = cnBDD.Conectar();
            string resp = "";

            if (msj[0] == '1')
            {
                IdEventoDB = datosEvento.RegistrarEvento(evento, cnBDD.sql);
                //if(resp[0] == '1')
                //{
                //    MessageBox.Show("Los datos del Evento se registraron en la Base de Datos exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if(resp[0] == '0')
                //{
                //    MessageBox.Show(resp, "Error al guardar los datos del Evento en la Base de Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

                cnBDD.Desconectar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj, "Error de conexión a la Base de Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrarEventoInmuebleBDD(int idEvento, EventoInmueble eventoInmueble)
        {
            cnBDD = new ConexionBDD();
            datosEventoInmueble = new DatosEventoInmueble();
            string msj = cnBDD.Conectar();
            string resp = "";

            if (msj[0] == '1')
            {
                resp = datosEventoInmueble.RegistrarEventoInmueble(idEvento, eventoInmueble, cnBDD.sql);
                if (resp[0] == '1')
                {
                    MessageBox.Show("Los datos del Evento se registraron en la Base de Datos exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resp[0] == '0')
                {
                    MessageBox.Show(resp, "Error al guardar los datos del Evento en la Base de Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cnBDD.Desconectar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj, "Error de conexión a la Base de Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarTablaInmueblesActual(DataGridView dgvInmueblesActual)
        {
            dgvInmueblesActual.Rows.Clear();


            foreach (Evento evento in listaEventos)
            {
                foreach (EventoInmueble inmueble in evento.EventoInmueble)
                {
                    foreach (Inmueble inm in inmueble.listaInmuebles)
                    {


                        int indice = dgvInmueblesActual.Rows.Add();
                        dgvInmueblesActual.Rows[indice].Cells["colNumInmueblesAct"].Value = inm.numeroInmueble;
                        dgvInmueblesActual.Rows[indice].Cells["colNombreAct"].Value = inm.nombreInmueble;
                        dgvInmueblesActual.Rows[indice].Cells["colDisponibleAct"].Value = inm.inmuebleDisponible;
                        dgvInmueblesActual.Rows[indice].Cells["colCantDispAct"].Value = inmueble.cantidadInmueble;
                        dgvInmueblesActual.Rows[indice].Cells["colFechaAsignacionAct"].Value = inmueble.fechaAsignacionInmueble.ToShortDateString();
                    }
                }
            }
        }
    }
}