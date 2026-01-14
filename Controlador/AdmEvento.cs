//CASTILLO MERA DANIEL FERNANDO
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
        private static List<Evento> listaEventos = new List<Evento>();
        private Evento evento = null;
        private Cliente cliente = null;
        List<EventoInmueble> listaEventoInmueble = new List<EventoInmueble>();
        string[] tipoInmuebles = { "Locales", "Accesorios", "Servicios" };

        private string clienteNombresEncontrado = "";
        private string clienteApellidosEncontrado = "";
        private bool clienteFueEncontrado = false;

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
            for (int i = 0; i < tipoInmuebles.Length; i++)
            {
                cmbTipoInmueble.Items.Add(tipoInmuebles[i]);
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
        
        public int GenerarNuevoNumEventos()
        {
            return listaEventos.Count + 1;
        }
        
        public void CargarDatosPredeterminados(string tipoEvento)
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
            bool encontrado = false;
            for (int i = 0; i < listaEventoInmueble.Count; i++)
            {
                if (listaEventoInmueble[i].inmueble != null && 
                    listaEventoInmueble[i].ObtenerNumInmuebles() == numeroInmueble)
                {
                    listaEventoInmueble[i].ActualizarCantidadAsignada(cantidadAsignada);
                    listaEventoInmueble[i].ActualizarFechaAsignacion(fechaAsignacion);
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Inmueble inmueble = AdmInmueble.ObtenerInmueblePorNumInmuebles(numeroInmueble);
                if (inmueble != null)
                {
                    EventoInmueble eventoInmueble = new EventoInmueble(inmueble, cantidadAsignada, fechaAsignacion);
                    listaEventoInmueble.Add(eventoInmueble);
                }
            }
        }
        
        public void RegistrarEventoCompleto(int numEventos, string tipoEvento, string nombreEvento, string descripcionEvento, int numPersonas, string direccionEvento, 
            string estadoEvento, 
            string tipoInmueble, 
            int cantidadInmueble, 
            DateTime fechaAsignacion)
        {
            List<EventoInmueble> listaInmueblesEvento = new List<EventoInmueble>();
            for (int i = 0; i < listaEventoInmueble.Count; i++)
            {
                EventoInmueble copia = new EventoInmueble();
                copia.inmueble = listaEventoInmueble[i].inmueble;
                copia.cantidadInmueble = listaEventoInmueble[i].cantidadInmueble;
                copia.fechaAsignacionInmueble = listaEventoInmueble[i].fechaAsignacionInmueble;
                listaInmueblesEvento.Add(copia);
            }
            
            // Usar el constructor correcto que incluye IdEvento Y NumEventos
            evento = new Evento(
                numEventos,
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
            
            listaEventoInmueble.Clear();
        }
        
        public void CargarTablaEventos(DataGridView dgvEventos)
        {
            dgvEventos.Rows.Clear();
            int indice=0;

            foreach (Evento evento in listaEventos)
            {
                dgvEventos.Rows.Add();
                dgvEventos.Rows[indice].Cells["colNro"].Value = indice + 1;
                dgvEventos.Rows[indice].Cells["colNumEventos"].Value = evento.NumEventos;
                dgvEventos.Rows[indice].Cells["colTipoEvento"].Value = evento.TipoEvento;
                dgvEventos.Rows[indice].Cells["colNombreEvento"].Value = evento.NombreEvento;
                dgvEventos.Rows[indice].Cells["colDescripcionEvento"].Value = evento.DescripcionEvento;
                dgvEventos.Rows[indice].Cells["colNumPersonas"].Value = evento.NumPersonasEvento;
                dgvEventos.Rows[indice].Cells["colDireccionEvento"].Value = evento.DireccionEvento;
                dgvEventos.Rows[indice].Cells["colEstadoEvento"].Value = evento.EstadoEvento;
                indice ++;
            }
        }
        
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

        public int GetCantidadLista()
        {
            return listaEventos.Count;
        }

        public void EliminarEvento(int indice, DataGridView dgvEvento)
        {
            string numEventos = dgvEvento.Rows[indice].Cells["colNumEventos"].Value.ToString();
            DialogResult result = MessageBox.Show("Desea eliminar el Evento " + numEventos + "?",
                "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dgvEvento.Rows.RemoveAt(indice);

                for (int i = 0; i < listaEventos.Count; i++)
                {
                    if (listaEventos[i].NumEventos.ToString() == numEventos)
                    {
                        listaEventos.RemoveAt(i);
                        break;
                    }
                }
                MessageBox.Show("Registro Evento " + numEventos + " se eliminó correctamente!");
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
            dgvEventos.Rows.Clear();
            int indice = 0;

            string filtro = "";
            if (!string.IsNullOrWhiteSpace(txtCiRucCliente))
            {
                filtro = "Cédula o RUC";
            }
            else if (!string.IsNullOrWhiteSpace(txtNumEventos))
            {
                filtro = "Número de Eventos";
            }

            foreach (Evento evento in listaEventos)
            {
                if (filtro == "Cédula o RUC")
                {
                    if (evento.Cliente.CedulaORuc == txtCiRucCliente)
                    {
                        dgvEventos.Rows.Add();
                        dgvEventos.Rows[indice].Cells["colNro"].Value = indice + 1;
                        dgvEventos.Rows[indice].Cells["colNumEventos"].Value = evento.NumEventos;
                        dgvEventos.Rows[indice].Cells["colTipoEvento"].Value = evento.TipoEvento;
                        dgvEventos.Rows[indice].Cells["colNombreEvento"].Value = evento.NombreEvento;
                        dgvEventos.Rows[indice].Cells["colDescripcionEvento"].Value = evento.DescripcionEvento;
                        dgvEventos.Rows[indice].Cells["colNumPersonas"].Value = evento.NumPersonasEvento;
                        dgvEventos.Rows[indice].Cells["colDireccionEvento"].Value = evento.DireccionEvento;
                        dgvEventos.Rows[indice].Cells["colEstadoEvento"].Value = evento.EstadoEvento;
                        indice++;
                    }
                }
                else if (filtro == "Número de Eventos")
                {
                    if (evento.NumEventos.ToString() == txtNumEventos)
                    {
                        dgvEventos.Rows.Add();
                        dgvEventos.Rows[indice].Cells["colNro"].Value = indice + 1;
                        dgvEventos.Rows[indice].Cells["colNumEventos"].Value = evento.NumEventos;
                        dgvEventos.Rows[indice].Cells["colTipoEvento"].Value = evento.TipoEvento;
                        dgvEventos.Rows[indice].Cells["colNombreEvento"].Value = evento.NombreEvento;
                        dgvEventos.Rows[indice].Cells["colDescripcionEvento"].Value = evento.DescripcionEvento;
                        dgvEventos.Rows[indice].Cells["colNumPersonas"].Value = evento.NumPersonasEvento;
                        dgvEventos.Rows[indice].Cells["colDireccionEvento"].Value = evento.DireccionEvento;
                        dgvEventos.Rows[indice].Cells["colEstadoEvento"].Value = evento.EstadoEvento;
                        indice++;
                    }
                }
            }
        }
    }
}