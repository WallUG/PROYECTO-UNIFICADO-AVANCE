//NICK ADRIAN ZAMBRANO ARTEAGA
using Datos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Controlador
{
    //CLASE QUE ADMINISTRARA LOS DATOS DE RESERVA
    public class AdmReserva
    {

        static List<Reserva> listaReservas = new List<Reserva>();
        List<Evento> listaEvento = AdmEvento.ObtenerTodosLosEventos();
        Evento even = null;
        Conexion Cn = null;
        DatosReserva datosReser = null;
        //Inicializa la lista de reservas vacia
        public AdmReserva()
        {
            ConsultarReservaBDD();
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

        public  List<Reserva> ObtenerListaReservas()
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
        //Reserva reserva = null;
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
        public bool EsVacio( DateTime fecha, DateTime horaIni,
                            DateTime horaFinsh, string tipSolicitudd)
        {
            if ( string.IsNullOrEmpty(tipSolicitudd))
            {
                MessageBox.Show("Error: Se necesita todos los campos llenos");
                return true;
            }
            return false;
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
            RegistrarReservaBBD(nuevaReserva);
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
                    dgvReservas.Rows[indice].Cells["colCodigo"].Value = r.CodigoReserva;
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
            if (even != null)
            {
                LlenarComboTipoEvento(cmbTipoEvento, even);
                LlenarComboTipoSolicitud(cmbTipoSolicitud);
                LlenarDescripcionEvento(txtDescripcionEvento, even);
                LlenarComboClientes(cmbClientes, even);
                LlenarNumeroPersonas(nudCantPersonas, even);
            }

        }

        public void LlenarComboTipoSolicitud(ComboBox cmbTipoSolicitud)
        {
            cmbTipoSolicitud.Items.Clear();
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
        public void EliminarReserva(int indice, DataGridView dgvReservas)
        {
            string codigoReservaB = dgvReservas.Rows[indice].Cells["colCodigo"].Value.ToString();
            DialogResult result = MessageBox.Show("¿Desea Eliminar la Reserva " + codigoReservaB + "?",
                "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dgvReservas.Rows.RemoveAt(indice);

                EliminarReservaBDD(codigoReservaB);
                listaReservas.RemoveAll(r => r.CodigoReserva == codigoReservaB);

                MessageBox.Show("Registro de Reserva " + codigoReservaB + " se eliminó correctamente!");
            }
        }
        public void FiltrarXCodigo(string codigoD, string codigoH, DataGridView dgvReservas)
        {
            int indice = 0;
            dgvReservas.Rows.Clear();

            // Extraer numeros de los códigos
            int numDesde = ExtraerNumero(codigoD);
            int numHasta = ExtraerNumero(codigoH);

            if (listaReservas.Count > 0)
            {
                foreach (Reserva r in listaReservas)
                {
                    int numReserva = ExtraerNumero(r.CodigoReserva);

                    if (numReserva >= numDesde && numReserva <= numHasta)
                    {
                        indice = dgvReservas.Rows.Add();
                        dgvReservas.Rows[indice].Cells["colNro"].Value = indice + 1;
                        dgvReservas.Rows[indice].Cells["colCodigo"].Value = r.CodigoReserva;
                        dgvReservas.Rows[indice].Cells["colCliente"].Value = r.evento.Cliente.Nombre;
                        dgvReservas.Rows[indice].Cells["colNombreEvento"].Value = r.evento.NombreEvento;
                        dgvReservas.Rows[indice].Cells["colTipoEvento"].Value = r.evento.TipoEvento;
                        dgvReservas.Rows[indice].Cells["colCantPersonas"].Value = r.evento.NumPersonasEvento;
                        dgvReservas.Rows[indice].Cells["colFechaReserva"].Value = r.FechaReserva.ToString("dd/MM/yyyy");
                        dgvReservas.Rows[indice].Cells["colHoraInicio"].Value = r.HoraInicio.ToString(@"hh\:mm");
                        dgvReservas.Rows[indice].Cells["colHoraFin"].Value = r.HoraFin.ToString(@"hh\:mm");
                    }
                }
            }
        }
        // Metodo auxiliar para extraer el numero del codigo (RES-001 -> 1)
        public int ExtraerNumero(string codigo)
        {
            int posGuion = codigo.IndexOf('-');
            if (posGuion >= 0 && posGuion < codigo.Length - 1)
            {
                string parteNumerica = codigo.Substring(posGuion + 1);
                int numero;
                if (int.TryParse(parteNumerica, out numero))
                {
                    return numero;
                }
            }
            return 0;
        }
        public void LlenarComboCodigos(ComboBox combo)
        {
            combo.Items.Clear();
            foreach (Reserva r in listaReservas)
            {
                combo.Items.Add(r.CodigoReserva);
            }
        }

        public void EditarReserva(int indice, DataGridView dgvReservas)
        {

        }

        public string ObtenerTipoSolicitud(string CodigoReserva)
        {
            Reserva r = BuscarReservaPorNumero(CodigoReserva);

            if (r != null)
            {
                return r.TipoSolicitud;
            }
            return "";
        }

        private Reserva BuscarReservaPorNumero(object CodigoReserva)
        {
            foreach (Reserva r in listaReservas)
            {
                if (r.CodigoReserva == CodigoReserva.ToString())
                {
                    return r;
                }
            }
            return null;
        }

        public string ActualizarReserva(string CodigoReserva, DateTime fecha,
                                        DateTime horaIni, DateTime horaFin, string tipSolicitud)
        {
            // Buscar la reserva que queremos modificar
            Reserva reservaExistente = BuscarReservaPorNumero(CodigoReserva);

            if (reservaExistente == null)
            {
                return "Error: No se encontró la reserva con el codigo " + CodigoReserva;
            }

            if (horaIni.TimeOfDay >= horaFin.TimeOfDay)
            {
                return "Error...La hora de inicio debe ser antes de la hora de fin";
            }

            //reservaExistente.evento.Cliente.Nombre = cliente;
            //reservaExistente.evento.NombreEvento = nombEvent;
            //reservaExistente.evento.TipoEvento = tipEvents;
            //reservaExistente.evento.NumEventos = cantPersonas;
            reservaExistente.FechaReserva = fecha;
            reservaExistente.HoraInicio = horaIni.TimeOfDay;
            reservaExistente.HoraFin = horaFin.TimeOfDay;
            reservaExistente.TipoSolicitud = tipSolicitud;

            // Actualizar en la base de datos
            string respuestaBDD = EditarReservaBDD(reservaExistente);

            if (respuestaBDD[0] == '1')
            {
                return "Reserva " + CodigoReserva + " actualizada exitosamente\n" + reservaExistente.MostrarReserva();
            }
            else
            {
                return "Error al actualizar en la base de datos: " + respuestaBDD;
            }
        }

        public void Conectar()
            {
                Cn = new Conexion();
                string msj = Cn.Conectar();
                if (msj[0] == '1')
                {
                    MessageBox.Show("Conexión a la Base de Datos Exitosa");
                    Cn.Desconectar();

                }
                else if (msj[0] == '0')
                {
                    MessageBox.Show(msj);
                }
            }

        //Método para registrar una reserva en la base de datos
        private void RegistrarReservaBBD(Reserva nuevaReserva)
        {
            Cn = new Conexion();
            datosReser = new DatosReserva();
            string msj = Cn.Conectar();
            string resp = "";
            if (msj[0] == '1')
            {
                resp = datosReser.RegistrarReserva(nuevaReserva, Cn.sql);
                if (resp[0] == '1')
                {
                    MessageBox.Show("Reserva registrada en la BDD");
                }
                else
                {
                    MessageBox.Show(resp);
                }
                Cn.Desconectar();

            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj);
            }
        }

        //Método para eliminar una reserva en la base de datos
        private void EliminarReservaBDD(string CodigoReserva)
        {
            Cn = new Conexion();
            datosReser = new DatosReserva();
            string msj = Cn.Conectar();
            string resp = "";

            if (msj[0] == '1')
            {
                resp = datosReser.EliminarReservaBBD(CodigoReserva, Cn.sql);

                if (resp[0] == '1')
                {
                    MessageBox.Show("Reserva con código " + CodigoReserva + " eliminada en BDD");
                }
                else if (resp[0] == '0')
                {
                    MessageBox.Show(resp);
                }
                Cn.Desconectar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj);
            }
        }

        // Método para editar una reserva en la base de datos
        private string EditarReservaBDD(Reserva reservaActualizada)
        {
            Cn = new Conexion();
            datosReser = new DatosReserva();
            string msj = Cn.Conectar();
            string resp = "";
            if (msj[0] == '1')
            {
                resp = datosReser.EditarReservaBBD(reservaActualizada, Cn.sql);
                if (resp[0] == '1')
                {
                    MessageBox.Show("Datos de la Reserva " + reservaActualizada.CodigoReserva + " editados con exito en BDD");
                }
                else if (resp[0] == '0')
                {
                    MessageBox.Show(resp);
                }
                Cn.Desconectar();
                return resp;
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj);
                return msj;
            }
            return "Error desconocido al editar la reserva en BDD";
        }

        private void ConsultarReservaBDD()
        {
            Cn = new Conexion();
            datosReser = new DatosReserva();
            string msj = Cn.Conectar();
            if (msj[0] == '1')
            {
                listaReservas = datosReser.ConsultarReservas(Cn.sql);
                if (listaReservas.Count == 0)
                {
                    MessageBox.Show("No existen registros de reservas en la BDD");
                }
                Cn.Desconectar();

            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj);
            }
        }

        // Método para filtrar reservas por rango de fechas
        public void FiltrarXFecha(DateTime fechaDesde, DateTime fechaHasta, DataGridView dgvReservas)
        {
            // Normalizar rangos (incluir todo el día 'hasta')
            DateTime desde = fechaDesde.Date;
            DateTime hasta = fechaHasta.Date;

            dgvReservas.Rows.Clear();

            int nro = 1;
            foreach (Reserva r in listaReservas)
            {
                DateTime fecha = r.FechaReserva.Date;
                if (fecha >= desde && fecha <= hasta)
                {

                    dgvReservas.Rows.Add(
                        nro++,
                        r.CodigoReserva ?? "",
                        r.evento.Cliente.Nombre ?? "",
                        r.evento.NombreEvento ?? "",
                        r.evento.TipoEvento ?? "",
                        r.evento.NumPersonasEvento,
                        r.FechaReserva != DateTime.MinValue ? r.FechaReserva.ToString("dd/MM/yyyy") : "",
                        r.HoraInicio.ToString(@"hh\:mm"),
                        r.HoraFin.ToString(@"hh\:mm")
                    );
                }
            }
        }
    }
}