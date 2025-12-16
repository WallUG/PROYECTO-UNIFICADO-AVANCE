//CASTILLO MERA DANIEL FERNANDO
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    /*
        Formulario para registrar nuevos eventos en el sistema.
        Permite buscar cliente, crear evento, asignar inmuebles y reserva.
    */
    public partial class FrmRegistrarEvento : Form
    {   
        // Controlador para la lógica de negocio de eventos
        private AdmEvento admEve = new AdmEvento();
        
        // Indica si se encontró un cliente válido
        private bool clienteEncontrado = false;

        // Estructura para almacenar temporalmente las selecciones de inmuebles (sin crear objetos)
        // Clave: idInmueble, Valor: cantidadAsignada
        private Dictionary<int, int> seleccionesTemporales = new Dictionary<int, int>();

        // Fila actualmente activa para editar cantidad (puede ser cualquier fila seleccionada)
        private int filaActivaParaCantidad = -1;

        // Cantidad máxima disponible del inmueble activo
        private int cantidadMaximaDisponible = 0;

        // Bandera para evitar eventos recursivos durante la actualización del DataGridView
        private bool actualizandoSeleccion = false;
         
        /*
            Constructor del formulario de registro de eventos.
            Inicializa los ComboBox y configura el estado inicial.
        */
        public FrmRegistrarEvento()
        {
            InitializeComponent();

            // Llenar los ComboBox con datos del controlador
            admEve.LlenarTiposEvento(cmbTipoEvento);
            admEve.LlenarEstadosEvento(cmbEstadoEvento);
            admEve.LlenarComboTipo(cmbTipoInmueble);

            // Configurar estado inicial del formulario
            ConfigurarEstadoInicial();

            // Suscribir evento KeyPress para nudCantidadInmueble
            nudCantidadInmueble.KeyPress += nudCantidadInmueble_KeyPress;
            
            // Suscribir eventos de los ComboBox
            cmbTipoEvento.SelectedIndexChanged += cmbTipoEvento_SelectedIndexChanged;
            cmbEstadoEvento.SelectedIndexChanged += cmbEstadoEvento_SelectedIndexChanged;
        }

        /*
            Configura el estado inicial del formulario.
            Deshabilita todos los GroupBox excepto el de búsqueda de cliente.
        */
        private void ConfigurarEstadoInicial()
        {
            // Paso 1: Habilitar solo la búsqueda de cliente
            gbBuscarCliente.Enabled = true;
            
            // Paso 2: Deshabilitar información del cliente
            gbInformacionCliente.Enabled = false;
            txtNombresCliente.ReadOnly = true;
            txtApellidosCliente.ReadOnly = true;
            txtNombresCliente.Text = "";
            txtApellidosCliente.Text = "";
            
            // Paso 3: Deshabilitar creación del evento
            gbCreacionEvento.Enabled = false;
            
            // Paso 4: Deshabilitar asignación de inmuebles
            gbAsignarInmuebles.Enabled = false;

            // Paso 5: Deshabilitar nudCantidadInmueble al inicio
            nudCantidadInmueble.Enabled = false;
            /*
            nudCantidadInmueble.Minimum = 1;
            nudCantidadInmueble.Maximum = 10000;
            cantidadMaximaDisponible = 0;
            */

            // Paso 6: Reiniciar selecciones temporales
            seleccionesTemporales.Clear();
            filaActivaParaCantidad = -1;

            // Paso 7: Reiniciar bandera de actualización
            actualizandoSeleccion = false;
            
            // Paso 8: Deshabilitar botón guardar
            btnGuardarEvento.Enabled = false;
        }

        /*
            Busca un cliente por su cédula o RUC.
            Habilita los demás campos si encuentra el cliente.
        */
        private void BuscarCliente()
        {
            // Obtener el valor de búsqueda
            string ciRuc = txtCiRucCliente.Text.Trim();
            
            // Validar que no esté vacío
            if (string.IsNullOrEmpty(ciRuc))
            {
                MessageBox.Show("Debe ingresar una cédula o RUC para buscar.", 
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que existan clientes en el sistema
            if (!admEve.ExistenClientes())
            {
                MessageBox.Show("No existen clientes registrados en el sistema.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar el cliente usando el controlador
            bool encontrado = admEve.BuscarClientePorCedulaORuc(ciRuc);
            
            if (encontrado)
            {
                // Marcar que se encontró cliente
                clienteEncontrado = true;
                
                // Obtener datos del cliente encontrado desde el controlador
                string nombreCompleto = admEve.ObtenerNombreCompletoClienteEncontrado();
                string nombres = admEve.ObtenerNombresClienteEncontrado();
                string apellidos = admEve.ObtenerApellidosClienteEncontrado();
                
                // Mostrar mensaje de éxito
                MessageBox.Show("Cliente encontrado: " + nombreCompleto, 
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Deshabilitar el botón de búsqueda para evitar cambios
                btnBuscarCliente.Enabled = false;
                txtCiRucCliente.ReadOnly = true;
                
                // Mostrar información del cliente
                gbInformacionCliente.Enabled = true;
                txtNombresCliente.Text = nombres;
                txtApellidosCliente.Text = apellidos;
                
                // Habilitar la creación del evento
                gbCreacionEvento.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontró ningún cliente con la cédula o RUC ingresado.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
            Evento cuando se selecciona un tipo de evento.
            Carga los datos predeterminados según el tipo seleccionado.
        */
        private void cmbTipoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoEvento.SelectedItem != null)
            {
                // Obtener el tipo seleccionado
                string tipoSeleccionado = cmbTipoEvento.SelectedItem.ToString();
                
                // Cargar datos predeterminados en el controlador
                admEve.CargarDatosPredeterminados(tipoSeleccionado);
                
                // Obtener los datos predeterminados desde el controlador
                string nombreEvento = admEve.ObtenerNombreEventoPredeterminado();
                string descripcionEvento = admEve.ObtenerDescripcionEventoPredeterminado();
                int numeroPersonas = admEve.ObtenerNumeroPersonasPredeterminado();
                string direccionEvento = admEve.ObtenerDireccionEventoPredeterminado();
                string estadoEvento = admEve.ObtenerEstadoEventoPredeterminado();
                
                // Llenar los campos con la información predeterminada
                txtNombreEvento.Text = nombreEvento;
                txtDescripcionEvento.Text = descripcionEvento;
                txtNumPersonasEvento.Text = numeroPersonas.ToString();
                txtbDireccionUbicacion.Text = direccionEvento;

                // Buscar y seleccionar el estado en el ComboBox
                for (int i = 0; i < cmbEstadoEvento.Items.Count; i++)
                {
                    if (cmbEstadoEvento.Items[i].ToString() == estadoEvento)
                    {
                        cmbEstadoEvento.SelectedIndex = i;
                        break;
                    }
                }

                // Habilitar asignación y cantidad de inmuebles después de seleccionar tipo de evento
                gbAsignarInmuebles.Enabled = true;
                nudCantidadInmueble.Enabled = true;

                // Habilitar botón guardar
                btnGuardarEvento.Enabled = true;
            }
        }

        /*
            Evento cuando se selecciona un estado del evento.
            Mantiene los GroupBox habilitados.
        */
        private void cmbEstadoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstadoEvento.SelectedItem != null)
            {
                // Mantener asignación y cantidad de inmuebles habilitado
                gbAsignarInmuebles.Enabled = true;
                nudCantidadInmueble.Enabled = true;

                // Habilitar botón guardar
                btnGuardarEvento.Enabled = true;
            }
        }        

        /*
        Evento click del botón Buscar Cliente.
        Inicia la búsqueda del cliente.
        */
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        /*
        Evento click del botón Guardar Evento.
        Valida y registra el evento completo.
        */
        private void btnGuardarEvento_Click(object sender, EventArgs e)
        {
            // Paso 1: Validar que se haya seleccionado un cliente
            if (!clienteEncontrado || !admEve.HayClienteSeleccionado())
            {
                MessageBox.Show("Debe buscar y seleccionar un cliente primero.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Paso 2: Obtener datos del evento
            string tipoEvento = "";
            if (cmbTipoEvento.SelectedItem != null)
            {
                tipoEvento = cmbTipoEvento.SelectedItem.ToString();
            }
            
            string nombreEvento = txtNombreEvento.Text.Trim();
            string descripcionEvento = txtDescripcionEvento.Text.Trim();
            string direccionEvento = txtbDireccionUbicacion.Text.Trim();
            
            int numPersonas = 0;
            if (!string.IsNullOrEmpty(txtNumPersonasEvento.Text))
            {
                numPersonas = ConvertirAEntero(txtNumPersonasEvento.Text);
            }
            
            string estadoEvento = "";
            if (cmbEstadoEvento.SelectedItem != null)
            {
                estadoEvento = cmbEstadoEvento.SelectedItem.ToString();
            }

            // Paso 3: Validar campos obligatorios
            if (admEve.EsVacio(tipoEvento, nombreEvento, descripcionEvento, 
                numPersonas, direccionEvento, estadoEvento))
            {
                MessageBox.Show("No deben quedar campos vacíos en la información del evento.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Paso 4: Validar que se haya seleccionado al menos un inmueble
            if (seleccionesTemporales.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un inmueble.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Paso 5: Validar cantidades de cada inmueble seleccionado
            foreach (KeyValuePair<int, int> seleccion in seleccionesTemporales)
            {
                int idInmueble = seleccion.Key;
                int cantidadAsignada = seleccion.Value;
                
                if (cantidadAsignada <= 0)
                {
                    MessageBox.Show("Todos los inmuebles seleccionados deben tener una cantidad mayor a 0.", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!admEve.EsCantidadValidaParaInmueble(idInmueble, cantidadAsignada))
                {
                    MessageBox.Show("La cantidad asignada para uno de los inmuebles excede la cantidad disponible.", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Paso 6: Obtener datos del Inmueble
            string tipoInmueble = "Salón de Eventos";
            if (cmbTipoInmueble.SelectedItem != null)
            {
                tipoInmueble = cmbTipoInmueble.SelectedItem.ToString();
            }
            
            DateTime fechaAsignacion = dtpFechaAsignacionInmueble.Value;

            // Paso 7: Limpiar la lista de inmuebles del controlador antes de agregar los nuevos
            admEve.LimpiarInmueblesSeleccionados();

            // Paso 8: Agregar los inmuebles seleccionados al controlador (AQUI se crean los objetos EventoInmueble)
            foreach (KeyValuePair<int, int> seleccion in seleccionesTemporales)
            {
                int idInmueble = seleccion.Key;
                int cantidadAsignada = seleccion.Value;
                admEve.ActualizarInmuebleSeleccionado(idInmueble, cantidadAsignada, fechaAsignacion);
            }

            // Paso 9: Generar ID y registrar evento
            int idEvento = admEve.GenerarNuevoId();

            // Obtener la cantidad total de inmuebles para pasar al método
            int cantidadTotalInmuebles = 0;
            foreach (KeyValuePair<int, int> seleccion in seleccionesTemporales)
            {
                cantidadTotalInmuebles = cantidadTotalInmuebles + seleccion.Value;
            }

            admEve.RegistrarEventoCompleto(
                idEvento, 
                tipoEvento, 
                nombreEvento, 
                descripcionEvento, 
                numPersonas, 
                direccionEvento,
                estadoEvento,
                tipoInmueble, 
                cantidadTotalInmuebles, 
                fechaAsignacion
            );
            
            // Paso 10: Mostrar mensaje de éxito
            MessageBox.Show("Evento registrado exitosamente con ID: " + idEvento.ToString(), 
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Paso 11: Limpiar formulario para nuevo registro
            LimpiarFormulario();
        }

        /*
        Convierte una cadena de texto a entero de forma manual sin usar TryParse.
        Retorna 0 si la cadena está vacía o no es válida.
        */
        private int ConvertirAEntero(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return 0;
            }

            int resultado = 0;
            bool esValido = true;

            for (int i = 0; i < texto.Length; i++)
            {
                char c = texto[i];
                if (Char.IsDigit(c))
                {
                    resultado = resultado * 10 + (c - '0');
                }
                else
                {
                    esValido = false;
                    break;
                }
            }

            if (esValido)
            {
                return resultado;
            }
            return 0;
        }

        /*
        Limpia todos los campos del formulario y lo devuelve al estado inicial.
        Se ejecuta después de guardar un evento exitosamente.
        */
        private void LimpiarFormulario()
        {
            // Limpiar sección de búsqueda
            txtCiRucCliente.Text = "";
            txtCiRucCliente.ReadOnly = false;
            txtCiRucCliente.Enabled = true;
            btnBuscarCliente.Enabled = true;
            clienteEncontrado = false;
            admEve.LimpiarClienteSeleccionado();
            admEve.LimpiarInmueblesSeleccionados();
            
            // Limpiar información del cliente
            txtNombresCliente.Text = "";
            txtApellidosCliente.Text = "";
            
            // Limpiar datos del evento
            cmbTipoEvento.SelectedIndex = -1;
            txtNombreEvento.Text = "";
            txtDescripcionEvento.Text = "";
            txtNumPersonasEvento.Text = "";
            txtbDireccionUbicacion.Text = "";
            cmbEstadoEvento.SelectedIndex = -1;
            
            // Limpiar datos de inmuebles
            cmbTipoInmueble.SelectedIndex = -1;
            /*
            nudCantidadInmueble.Minimum = 1;
            nudCantidadInmueble.Maximum = 10000;
            nudCantidadInmueble.Enabled = false;
            cantidadMaximaDisponible = 0;
            */
            dtpFechaAsignacionInmueble.Value = DateTime.Now;
            dgvInmuebles.Rows.Clear();

            // Limpiar selecciones temporales
            seleccionesTemporales.Clear();
            filaActivaParaCantidad = -1;

            // Reiniciar bandera de actualización
            actualizandoSeleccion = false;
            
            // Volver al estado inicial
            ConfigurarEstadoInicial();
        }

        /*
        Permite solo letras, espacios y tecla Backspace en el nombre del evento.
        */
        private void txtNombreEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            bool esLetra = Char.IsLetter(caracter);
            bool esEspacio = (caracter == ' ');
            bool esBackspace = (caracter == (char)Keys.Back);
            
            if (!esLetra && !esEspacio && !esBackspace)
            {
                e.Handled = true;
            }
        }

        /*
        Permite solo números y tecla Backspace en el campo de búsqueda de cliente.
        */
        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            bool esDigito = Char.IsDigit(caracter);
            bool esBackspace = (caracter == (char)Keys.Back);
            
            if (!esDigito && !esBackspace)
            {
                e.Handled = true;
            }
        }

        /*
        Permite solo números y tecla Backspace en el campo de número de personas.
        */
        private void txtNumPersonasEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            bool esDigito = Char.IsDigit(caracter);
            bool esBackspace = (caracter == (char)Keys.Back);
            
            if (!esDigito && !esBackspace)
            {
                e.Handled = true;
            }
        }

        /*
        Bloquea la edición en el campo de nombres del cliente (solo lectura).
        */
        private void txtNombresCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /*
        Permite solo números positivos y tecla Delete/Backspace en nudCantidadInmueble.
        */
        private void nudCantidadInmueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            bool esDigito = Char.IsDigit(caracter);
            bool esBackspace = (caracter == (char)Keys.Back);
            bool esDelete = (caracter == (char)Keys.Delete);
            
            // Solo permitir números positivos y teclas de borrado
            if (!esDigito && !esBackspace && !esDelete)
            {
                e.Handled = true;
                return;
            }

            // Validar que el valor ingresado no exceda el máximo disponible
            if (esDigito && cantidadMaximaDisponible > 0)
            {
                string textoActual = nudCantidadInmueble.Text;
                string nuevoTexto = textoActual + caracter.ToString();
                int valorNuevo = ConvertirAEntero(nuevoTexto);
                if (valorNuevo > cantidadMaximaDisponible)
                {
                    e.Handled = true;
                    MessageBox.Show("La cantidad no puede ser mayor a " + cantidadMaximaDisponible.ToString() + " (cantidad disponible).", 
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void selectTipoInmueble(object sender, EventArgs e)
        {
            // Limpiar selección de fila activa
            filaActivaParaCantidad = -1;
            cantidadMaximaDisponible = 0;
            
            // habilitar nudCantidadInmueble hasta que se seleccione una fila
            nudCantidadInmueble.Enabled = true;
            
            // Limpiar selecciones temporales al cambiar de tipo
            seleccionesTemporales.Clear();

            admEve.LlenarDescripcionInmuebleLocales(dgvInmuebles, Convert.ToString(cmbTipoInmueble.SelectedItem));
        }

        private void dvgInmuebles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar procesamiento durante actualización programática o índices inválidos
            if (actualizandoSeleccion || e.RowIndex < 0)
            {
                return;
            }

            // Verificar que la columna sea la de selección
            if (dgvInmuebles.Columns[e.ColumnIndex].Name != "Seleccionar")
            {
                return;
            }

            // Obtener el valor de la celda de selección
            object valorCelda = dgvInmuebles.Rows[e.RowIndex].Cells["Seleccionar"].Value;
            bool marcado = false;
            if (valorCelda != null)
            {
                marcado = Convert.ToBoolean(valorCelda);
            }

            // Obtener el ID del inmueble de esta fila
            object idInmuebleObj = dgvInmuebles.Rows[e.RowIndex].Cells["IdInmueble"].Value;
            if (idInmuebleObj == null)
            {
                return;
            }
            int idInmueble = Convert.ToInt32(idInmuebleObj);

            // Obtener la cantidad disponible de esta fila
            object cantidadDispObj = dgvInmuebles.Rows[e.RowIndex].Cells["CantidadDisp"].Value;
            int cantidadDisponible = 0;
            if (cantidadDispObj != null)
            {
                cantidadDisponible = Convert.ToInt32(cantidadDispObj);
            }

            if (marcado)
            {
                // Agregar a selecciones temporales con la cantidad disponible por defecto
                if (!seleccionesTemporales.ContainsKey(idInmueble))
                {
                    seleccionesTemporales.Add(idInmueble, cantidadDisponible);
                }

                // Establecer esta fila como activa para editar cantidad
                filaActivaParaCantidad = e.RowIndex;
                cantidadMaximaDisponible = cantidadDisponible;

                // Habilitar y configurar el NumericUpDown
                nudCantidadInmueble.Enabled = true;
                
                if (cantidadDisponible > 0)
                {
                    nudCantidadInmueble.Maximum = cantidadDisponible;
                    nudCantidadInmueble.Value = cantidadDisponible;
                }
            }
            else
            {
                // Remover de selecciones temporales
                if (seleccionesTemporales.ContainsKey(idInmueble))
                {
                    seleccionesTemporales.Remove(idInmueble);
                }

                // Si era la fila activa, buscar otra fila seleccionada o deshabilitar
                if (filaActivaParaCantidad == e.RowIndex)
                {
                    filaActivaParaCantidad = -1;
                    cantidadMaximaDisponible = 0;

                    // Buscar otra fila seleccionada para activar
                    bool encontroOtra = false;
                    for (int i = 0; i < dgvInmuebles.Rows.Count; i++)
                    {
                        object valor = dgvInmuebles.Rows[i].Cells["Seleccionar"].Value;
                        if (valor != null && Convert.ToBoolean(valor) == true)
                        {
                            // Activar esta fila
                            filaActivaParaCantidad = i;
                            object cantDispObj = dgvInmuebles.Rows[i].Cells["CantidadDisp"].Value;
                            if (cantDispObj != null)
                            {
                                cantidadMaximaDisponible = Convert.ToInt32(cantDispObj);
                            }
                            
                            object idObj = dgvInmuebles.Rows[i].Cells["IdInmueble"].Value;
                            int idActivo = 0;
                            if (idObj != null)
                            {
                                idActivo = Convert.ToInt32(idObj);
                            }
                            
                            // Obtener la cantidad guardada para este inmueble
                            int cantidadGuardada = cantidadMaximaDisponible;
                            if (seleccionesTemporales.ContainsKey(idActivo))
                            {
                                cantidadGuardada = seleccionesTemporales[idActivo];
                            }

                            nudCantidadInmueble.Maximum = cantidadMaximaDisponible;
                            nudCantidadInmueble.Value = cantidadGuardada;
                            encontroOtra = true;
                            break;
                        }
                    }
                }
            }

            // Desactivar bandera
            actualizandoSeleccion = false;
        }

        private void dvgInmuebles_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvInmuebles.IsCurrentCellDirty)
            {
                dgvInmuebles.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        /*
        Evento cuando se hace clic en una celda del DataGridView.
        Permite cambiar la fila activa para editar cantidad.
        */
        private void dgvInmuebles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            // Verificar si la fila está seleccionada (marcada)
            object valorCelda = dgvInmuebles.Rows[e.RowIndex].Cells["Seleccionar"].Value;
            bool estaMarcada = false;
            if (valorCelda != null)
            {
                estaMarcada = Convert.ToBoolean(valorCelda);
            }

            if (estaMarcada)
            {
                // Cambiar la fila activa para editar cantidad
                filaActivaParaCantidad = e.RowIndex;

                // Obtener datos de esta fila
                object idInmuebleObj = dgvInmuebles.Rows[e.RowIndex].Cells["IdInmueble"].Value;
                object cantidadDispObj = dgvInmuebles.Rows[e.RowIndex].Cells["CantidadDisp"].Value;

                if (idInmuebleObj != null && cantidadDispObj != null)
                {
                    int idInmueble = Convert.ToInt32(idInmuebleObj);
                    int cantidadDisponible = Convert.ToInt32(cantidadDispObj);
                    cantidadMaximaDisponible = cantidadDisponible;

                    // Obtener la cantidad guardada para este inmueble
                    int cantidadGuardada = cantidadDisponible;
                    if (seleccionesTemporales.ContainsKey(idInmueble))
                    {
                        cantidadGuardada = seleccionesTemporales[idInmueble];
                    }

                    // Configurar el NumericUpDown
                    nudCantidadInmueble.Enabled = true;
                    nudCantidadInmueble.Maximum = cantidadDisponible;
                    nudCantidadInmueble.Value = cantidadGuardada;
                }
            }
        }

        /*
        Evento cuando cambia el valor de nudCantidadInmueble.
        Actualiza la cantidad en las selecciones temporales (NO crea objetos).
        */
        private void nudCantidadInmueble_ValueChanged(object sender, EventArgs e)
        {
            // Verificar que hay una fila activa y el control está habilitado
            if (filaActivaParaCantidad < 0 || !nudCantidadInmueble.Enabled)
            {
                return;
            }

            // Verificar que la fila activa existe en el DataGridView
            if (filaActivaParaCantidad >= dgvInmuebles.Rows.Count)
            {
                return;
            }

            // Obtener el ID del inmueble de la fila activa
            object idInmuebleObj = dgvInmuebles.Rows[filaActivaParaCantidad].Cells["IdInmueble"].Value;
            if (idInmuebleObj == null)
            {
                return;
            }

            int idInmueble = Convert.ToInt32(idInmuebleObj);
            int cantidadAsignada = Convert.ToInt32(nudCantidadInmueble.Value);

            // Validar que la cantidad no sea mayor a la disponible
            if (cantidadAsignada > cantidadMaximaDisponible && cantidadMaximaDisponible > 0)
            {
                nudCantidadInmueble.Value = cantidadMaximaDisponible;
                cantidadAsignada = cantidadMaximaDisponible;
            }

            // Actualizar en las selecciones temporales (solo datos, no objetos)
            if (seleccionesTemporales.ContainsKey(idInmueble))
            {
                seleccionesTemporales[idInmueble] = cantidadAsignada;
            }
        }
    }
}