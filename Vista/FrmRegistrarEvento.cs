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

        // Indica el índice de la fila seleccionada actualmente en el DataGridView
        private int filaSeleccionadaActual = -1;
         
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
            
            // Configurar nudCantidadInmueble para que solo se pueda cambiar con los botones
            nudCantidadInmueble.ReadOnly = true;
            
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
            nudCantidadInmueble.Minimum = 0;
            nudCantidadInmueble.Value = 0;
            nudCantidadInmueble.Maximum = 0;

            // Paso 6: Reiniciar fila seleccionada
            filaSeleccionadaActual = -1;
            
            // Paso 7: Deshabilitar botón guardar
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
            string nombres;
            string apellidos;
            bool encontrado = admEve.BuscarClientePorCedulaORuc(ciRuc, out nombres, out apellidos);
            
            if (encontrado)
            {
                // Marcar que se encontró cliente
                clienteEncontrado = true;
                
                // Mostrar mensaje de éxito
                MessageBox.Show("Cliente encontrado: " + nombres + " " + apellidos, 
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
                
                // Obtener datos predeterminados del controlador
                (string nombreEvento, string descripcionEvento, int numeroPersonas, 
                    string direccionEvento, string estadoEvento) datos = 
                    admEve.ObtenerDatosPredeterminados(tipoSeleccionado);
                
                // Llenar los campos con la información predeterminada
                txtNombreEvento.Text = datos.nombreEvento;
                txtDescripcionEvento.Text = datos.descripcionEvento;
                txtNumPersonasEvento.Text = datos.numeroPersonas.ToString();
                txtbDireccionUbicacion.Text = datos.direccionEvento;

                // Buscar y seleccionar el estado en el ComboBox
                for (int i = 0; i < cmbEstadoEvento.Items.Count; i++)
                {
                    if (cmbEstadoEvento.Items[i].ToString() == datos.estadoEvento)
                    {
                        cmbEstadoEvento.SelectedIndex = i;
                        break;
                    }
                }
            }
        }
        /*
            Evento cuando se selecciona un estado del evento.
            Habilita los GroupBox de inmuebles, reserva y el botón guardar.
        */
        private void cmbEstadoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstadoEvento.SelectedItem != null)
            {
                // Habilitar asignación de inmuebles
                gbAsignarInmuebles.Enabled = true;

                // Mantener nudCantidadInmueble deshabilitado hasta que se seleccione un inmueble
                nudCantidadInmueble.Enabled = false;
                nudCantidadInmueble.Minimum = 0;
                nudCantidadInmueble.Value = 0;
                nudCantidadInmueble.Maximum = 0;
                
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
                int.TryParse(txtNumPersonasEvento.Text, out numPersonas);
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

            // Paso 4: Validar que se haya seleccionado al menos un inmueble con cantidad
            if (!admEve.HayInmueblesSeleccionados())
            {
                MessageBox.Show("Debe seleccionar al menos un inmueble y asignar una cantidad mayor a 0.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Paso 5: Obtener datos del Inmueble
            string tipoInmueble = "Salón de Eventos";
            if (cmbTipoInmueble.SelectedItem != null)
            {
                tipoInmueble = cmbTipoInmueble.SelectedItem.ToString();
            }
            
            int cantidadInmueble = (int)nudCantidadInmueble.Value;
            DateTime fechaAsignacion = dtpFechaAsignacionInmueble.Value;

            // Paso 6: Generar ID y registrar evento
            int idEvento = admEve.GenerarNuevoId();

            admEve.RegistrarEventoCompleto(
                idEvento, 
                tipoEvento, 
                nombreEvento, 
                descripcionEvento, 
                numPersonas, 
                direccionEvento,
                estadoEvento,
                tipoInmueble, 
                cantidadInmueble, 
                fechaAsignacion
            );
            
            // Paso 7: Mostrar mensaje de éxito
            MessageBox.Show("Evento registrado exitosamente con ID: " + idEvento.ToString(), 
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Paso 8: Limpiar formulario para nuevo registro
            LimpiarFormulario();
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
            nudCantidadInmueble.Minimum = 0;
            nudCantidadInmueble.Value = 0;
            nudCantidadInmueble.Maximum = 0;
            nudCantidadInmueble.Enabled = false;
            dtpFechaAsignacionInmueble.Value = DateTime.Now;
            dgvInmuebles.Rows.Clear();

            // Reiniciar fila seleccionada
            filaSeleccionadaActual = -1;
            
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


        private void selectTipoInmueble(object sender, EventArgs e)
        {
            // Limpiar selección anterior y deshabilitar nudCantidadInmueble
            filaSeleccionadaActual = -1;
            nudCantidadInmueble.Enabled = false;
            nudCantidadInmueble.Minimum = 0;
            nudCantidadInmueble.Value = 0;
            nudCantidadInmueble.Maximum = 0;

            admEve.LlenarDescripcionInmuebleLocales(dgvInmuebles, Convert.ToString(cmbTipoInmueble.SelectedItem));
        }

        private void dvgInmuebles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                dgvInmuebles.Columns[e.ColumnIndex].Name == "Seleccionar")
            {
                bool marcado = Convert.ToBoolean(
                    dgvInmuebles.Rows[e.RowIndex].Cells["Seleccionar"].Value
                );

                if (marcado)
                {
                    // Desmarcar la fila anterior si había una seleccionada
                    if (filaSeleccionadaActual >= 0 && filaSeleccionadaActual != e.RowIndex)
                    {
                        dgvInmuebles.Rows[filaSeleccionadaActual].Cells["Seleccionar"].Value = false;
                        // Eliminar el inmueble anterior de la lista
                        int idInmuebleAnterior = Convert.ToInt32(dgvInmuebles.Rows[filaSeleccionadaActual].Cells["IdInmueble"].Value);
                        admEve.EliminarInmuebleSeleccionado(idInmuebleAnterior);
                    }

                    // Guardar la fila actual como seleccionada
                    filaSeleccionadaActual = e.RowIndex;

                    // Obtener la cantidad disponible del inmueble seleccionado
                    int cantidadDisponible = Convert.ToInt32(dgvInmuebles.Rows[e.RowIndex].Cells["CantidadDisp"].Value);

                    // Habilitar y configurar el nudCantidadInmueble
                    nudCantidadInmueble.Enabled = true;
                    nudCantidadInmueble.Minimum = 0;
                    nudCantidadInmueble.Maximum = cantidadDisponible;
                    nudCantidadInmueble.Value = 0;

                    MessageBox.Show("Inmueble seleccionado. Cantidad máxima disponible: " + cantidadDisponible.ToString(), 
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Si se desmarca el inmueble seleccionado actualmente
                    if (filaSeleccionadaActual == e.RowIndex)
                    {
                        // Eliminar el inmueble de la lista de seleccionados
                        int idInmueble = Convert.ToInt32(dgvInmuebles.Rows[e.RowIndex].Cells["IdInmueble"].Value);
                        admEve.EliminarInmuebleSeleccionado(idInmueble);

                        // Deshabilitar nudCantidadInmueble
                        nudCantidadInmueble.Enabled = false;
                        nudCantidadInmueble.Minimum = 0;
                        nudCantidadInmueble.Value = 0;
                        nudCantidadInmueble.Maximum = 0;

                        // Reiniciar la fila seleccionada
                        filaSeleccionadaActual = -1;

                        MessageBox.Show("Inmueble desmarcado", 
                            "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void dvgInmuebles_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvInmuebles.IsCurrentCellDirty)
            {
                dgvInmuebles.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        /*
        Evento cuando cambia el valor de nudCantidadInmueble.
        Actualiza la cantidad asignada al inmueble seleccionado.
        */
        private void nudCantidadInmueble_ValueChanged(object sender, EventArgs e)
        {
            if (filaSeleccionadaActual >= 0 && nudCantidadInmueble.Enabled)
            {
                int idInmueble = Convert.ToInt32(dgvInmuebles.Rows[filaSeleccionadaActual].Cells["IdInmueble"].Value);
                int cantidadAsignada = (int)nudCantidadInmueble.Value;
                DateTime fechaAsignacion = dtpFechaAsignacionInmueble.Value;

                if (cantidadAsignada > 0)
                {
                    // Actualizar o agregar el inmueble seleccionado
                    admEve.ActualizarInmuebleSeleccionado(idInmueble, cantidadAsignada, fechaAsignacion);
                }
                else
                {
                    // Si la cantidad es 0, eliminar de la lista
                    admEve.EliminarInmuebleSeleccionado(idInmueble);
                }
            }
        }
    }
}