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
    public partial class FrmRegistrarEvento : Form
    {   
        private AdmEvento admEvento = new AdmEvento();
        private bool clienteEncontrado = false;
        
        // Reemplazo de Dictionary por listas paralelas
        private List<string> seleccionesNumerosInmuebles = new List<string>();
        private List<int> seleccionesCantidades = new List<int>();
        
        private int filaActivaParaCantidad = -1;
        private int cantidadMaximaDisponible = 0;
        private bool actualizandoSeleccion = false;
         
        public FrmRegistrarEvento()
        {
            InitializeComponent();

            admEvento.LlenarTiposEvento(cmbTipoEvento);
            admEvento.LlenarEstadosEvento(cmbEstadoEvento);
            admEvento.LlenarComboTipo(cmbTipoInmueble);

            ConfigurarEstadoInicial();

            nudCantidadInmueble.KeyPress += nudCantidadInmueble_KeyPress;
            
            cmbTipoEvento.SelectedIndexChanged += cmbTipoEvento_SelectedIndexChanged;
            cmbEstadoEvento.SelectedIndexChanged += cmbEstadoEvento_SelectedIndexChanged;
        }

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
            
            // Paso 6: Reiniciar selecciones temporales
            seleccionesNumerosInmuebles.Clear();
            seleccionesCantidades.Clear();
            filaActivaParaCantidad = -1;

            // Paso 7: Reiniciar bandera de actualización
            actualizandoSeleccion = false;
            
            // Paso 8: Deshabilitar botón guardar
            btnGuardarEvento.Enabled = false;
        }

        private void BuscarCliente()
        {
            string ciRuc = txtCiRucCliente.Text.Trim();
            
            if (string.IsNullOrEmpty(ciRuc))
            {
                MessageBox.Show("Debe ingresar una cédula o RUC para buscar.", 
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!admEvento.ExistenClientes())
            {
                MessageBox.Show("No existen clientes registrados en el sistema.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool encontrado = admEvento.BuscarClientePorCedulaORuc(ciRuc);
            
            if (encontrado)
            {
                clienteEncontrado = true;
                
                string nombreCompleto = admEvento.ObtenerNombreCompletoClienteEncontrado();
                string nombres = admEvento.ObtenerNombresClienteEncontrado();
                string apellidos = admEvento.ObtenerApellidosClienteEncontrado();

                MessageBox.Show("Cliente encontrado: " + nombreCompleto, 
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                btnBuscarCliente.Enabled = false;
                txtCiRucCliente.ReadOnly = true;
                
                gbInformacionCliente.Enabled = true;
                txtNombresCliente.Text = nombres;
                txtApellidosCliente.Text = apellidos;
                
                gbCreacionEvento.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontró ningún cliente con la cédula o RUC ingresado.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTipoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoEvento.SelectedItem != null)
            {
                string tipoSeleccionado = cmbTipoEvento.SelectedItem.ToString();
                
                admEvento.CargarDatosPredeterminados(tipoSeleccionado);
                
                string nombreEvento = admEvento.ObtenerNombreEventoPredeterminado();
                string descripcionEvento = admEvento.ObtenerDescripcionEventoPredeterminado();
                int numeroPersonas = admEvento.ObtenerNumeroPersonasPredeterminado();
                string direccionEvento = admEvento.ObtenerDireccionEventoPredeterminado();
                string estadoEvento = admEvento.ObtenerEstadoEventoPredeterminado();
                
                txtNombreEvento.Text = nombreEvento;
                txtDescripcionEvento.Text = descripcionEvento;
                txtNumPersonasEvento.Text = numeroPersonas.ToString();
                txtbDireccionUbicacion.Text = direccionEvento;

                for (int i = 0; i < cmbEstadoEvento.Items.Count; i++)
                {
                    if (cmbEstadoEvento.Items[i].ToString() == estadoEvento)
                    {
                        cmbEstadoEvento.SelectedIndex = i;
                        break;
                    }
                }

                gbAsignarInmuebles.Enabled = true;
                nudCantidadInmueble.Enabled = true;

                btnGuardarEvento.Enabled = true;
            }
        }

        private void cmbEstadoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstadoEvento.SelectedItem != null)
            {
                gbAsignarInmuebles.Enabled = true;
                nudCantidadInmueble.Enabled = true;
                btnGuardarEvento.Enabled = true;
            }
        }        

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void btnGuardarEvento_Click(object sender, EventArgs e)
        {
            // Paso 1: Validar que se haya seleccionado un cliente
            if (!clienteEncontrado || !admEvento.HayClienteSeleccionado())
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
            if (admEvento.EsVacio(tipoEvento, nombreEvento, descripcionEvento, 
                numPersonas, direccionEvento, estadoEvento))
            {
                MessageBox.Show("No deben quedar campos vacíos en la información del evento.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Paso 4: Validar que se haya seleccionado al menos un inmueble
            if (seleccionesNumerosInmuebles.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un inmueble.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Paso 5: Validar cantidades de cada inmueble seleccionado
            for (int i = 0; i < seleccionesNumerosInmuebles.Count; i++)
            {
                string numeroInmueble = seleccionesNumerosInmuebles[i];
                int cantidadAsignada = seleccionesCantidades[i];
                
                if (cantidadAsignada <= 0)
                {
                    MessageBox.Show("Todos los inmuebles seleccionados deben tener una cantidad mayor a 0.", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!admEvento.EsCantidadValidaParaInmueble(numeroInmueble, cantidadAsignada))
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
            admEvento.LimpiarInmueblesSeleccionados();

            // Paso 8: Agregar los inmuebles seleccionados al controlador (AQUI se crean los objetos EventoInmueble)
            for (int i = 0; i < seleccionesNumerosInmuebles.Count; i++)
            {
                string numeroInmueble = seleccionesNumerosInmuebles[i];
                int cantidadAsignada = seleccionesCantidades[i];
                admEvento.ActualizarInmuebleSeleccionado(numeroInmueble, cantidadAsignada, fechaAsignacion);
            }

            // Paso 9: Generar Numero eventos y registrar evento
            int numEventos = admEvento.GenerarNuevoNumEventos();

            // Obtener la cantidad total de inmuebles para pasar al método
            int cantidadTotalInmuebles = 0;
            foreach (int cantidad in seleccionesCantidades)
            {
                cantidadTotalInmuebles += cantidad;
            }

            admEvento.RegistrarEventoCompleto(
                numEventos,
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
            MessageBox.Show("Evento registrado exitosamente con Num. de evento: " + numEventos.ToString(), 
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Paso 11: Limpiar formulario para nuevo registro
            LimpiarFormulario();
        }
        
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
        
        private void LimpiarFormulario()
        {
            // Limpiar sección de búsqueda
            txtCiRucCliente.Text = "";
            txtCiRucCliente.ReadOnly = false;
            txtCiRucCliente.Enabled = true;
            btnBuscarCliente.Enabled = true;
            clienteEncontrado = false;
            admEvento.LimpiarClienteSeleccionado();
            admEvento.LimpiarInmueblesSeleccionados();
            
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
            seleccionesNumerosInmuebles.Clear();
            seleccionesCantidades.Clear();
            filaActivaParaCantidad = -1;

            // Reiniciar bandera de actualización
            actualizandoSeleccion = false;
            
            // Volver al estado inicial
            ConfigurarEstadoInicial();
        }
        
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
        
        private void txtNombresCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        
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
            seleccionesNumerosInmuebles.Clear();
            seleccionesCantidades.Clear();

            admEvento.LlenarDescripcionInmuebleLocales(dgvInmuebles, Convert.ToString(cmbTipoInmueble.SelectedItem));
        }

        private void dvgInmuebles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (actualizandoSeleccion || e.RowIndex < 0)
            {
                return;
            }

            if (dgvInmuebles.Columns[e.ColumnIndex].Name != "colSeleccionar")
            {
                return;
            }

            object valorCelda = dgvInmuebles.Rows[e.RowIndex].Cells["colSeleccionar"].Value;
            bool marcado = false;
            if (valorCelda != null)
            {
                marcado = Convert.ToBoolean(valorCelda);
            }

            object numInmueblesObj = dgvInmuebles.Rows[e.RowIndex].Cells["colNumInmuebles"].Value;
            if (numInmueblesObj == null)
            {
                return;
            }
            string numInmuebles = Convert.ToString(numInmueblesObj);

            object cantidadDispObj = dgvInmuebles.Rows[e.RowIndex].Cells["colCantidadDisp"].Value;
            int cantidadDisponible = 0;
            if (cantidadDispObj != null)
            {
                cantidadDisponible = Convert.ToInt32(cantidadDispObj);
            }

            if (marcado)
            {
                if (!seleccionesNumerosInmuebles.Contains(numInmuebles))
                {
                    seleccionesNumerosInmuebles.Add(numInmuebles);
                    seleccionesCantidades.Add(cantidadDisponible);
                }

                filaActivaParaCantidad = e.RowIndex;
                cantidadMaximaDisponible = cantidadDisponible;

                nudCantidadInmueble.Enabled = true;
                
                if (cantidadDisponible > 0)
                {
                    nudCantidadInmueble.Maximum = cantidadDisponible;
                    nudCantidadInmueble.Value = cantidadDisponible;
                }
            }
            else
            {
                int index = seleccionesNumerosInmuebles.IndexOf(numInmuebles);
                if (index >= 0)
                {
                    seleccionesNumerosInmuebles.RemoveAt(index);
                    seleccionesCantidades.RemoveAt(index);
                }

                if (filaActivaParaCantidad == e.RowIndex)
                {
                    filaActivaParaCantidad = -1;
                    cantidadMaximaDisponible = 0;

                    bool encontroOtra = false;
                    for (int i = 0; i < dgvInmuebles.Rows.Count; i++)
                    {
                        object valor = dgvInmuebles.Rows[i].Cells["colSeleccionar"].Value;
                        if (valor != null && Convert.ToBoolean(valor) == true)
                        {
                            filaActivaParaCantidad = i;
                            object cantDispObj = dgvInmuebles.Rows[i].Cells["colCantidadDisp"].Value;
                            if (cantDispObj != null)
                            {
                                cantidadMaximaDisponible = Convert.ToInt32(cantDispObj);
                            }

                            object numInmueblesObjActual = dgvInmuebles.Rows[i].Cells["colNumInmuebles"].Value;
                            string numInmueblesActual = string.Empty;
                            if (numInmueblesObjActual != null)
                            {
                                numInmueblesActual = Convert.ToString(numInmueblesObjActual);
                            }
                            
                            int cantidadGuardada = cantidadMaximaDisponible;
                            if (seleccionesNumerosInmuebles.Contains(numInmueblesActual))
                            {
                                int indexGuardado = seleccionesNumerosInmuebles.IndexOf(numInmueblesActual);
                                if (indexGuardado >= 0 && indexGuardado < seleccionesCantidades.Count)
                                {
                                    cantidadGuardada = seleccionesCantidades[indexGuardado];
                                }
                            }

                            nudCantidadInmueble.Maximum = cantidadMaximaDisponible;
                            nudCantidadInmueble.Value = cantidadGuardada;
                            encontroOtra = true;
                            break;
                        }
                    }
                }
            }

            actualizandoSeleccion = false;
        }

        private void dvgInmuebles_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvInmuebles.IsCurrentCellDirty)
            {
                dgvInmuebles.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        
        private void dgvInmuebles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            // Verificar si la fila está seleccionada (marcada)
            object valorCelda = dgvInmuebles.Rows[e.RowIndex].Cells["colSeleccionar"].Value;
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
                object idInmuebleObj = dgvInmuebles.Rows[e.RowIndex].Cells["colNumInmuebles"].Value;
                object cantidadDispObj = dgvInmuebles.Rows[e.RowIndex].Cells["colCantidadDisp"].Value;

                if (idInmuebleObj != null && cantidadDispObj != null)
                {
                    string idInmueble = Convert.ToString(idInmuebleObj);
                    int cantidadDisponible = Convert.ToInt32(cantidadDispObj);
                    cantidadMaximaDisponible = cantidadDisponible;

                    // Obtener la cantidad guardada para este inmueble
                    int cantidadGuardada = cantidadDisponible;
                    if (seleccionesNumerosInmuebles.Contains(idInmueble))
                    {
                        int indexGuardado = seleccionesNumerosInmuebles.IndexOf(idInmueble);
                        if (indexGuardado >= 0 && indexGuardado < seleccionesCantidades.Count)
                        {
                            cantidadGuardada = seleccionesCantidades[indexGuardado];
                        }
                    }

                    // Configurar el NumericUpDown
                    nudCantidadInmueble.Enabled = true;
                    nudCantidadInmueble.Maximum = cantidadDisponible;
                    nudCantidadInmueble.Value = cantidadGuardada;
                }
            }
        }
        
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
            object idInmuebleObj = dgvInmuebles.Rows[filaActivaParaCantidad].Cells["colNumInmuebles"].Value;
            if (idInmuebleObj == null)
            {
                return;
            }

            string idInmueble = Convert.ToString(idInmuebleObj);
            int cantidadAsignada = Convert.ToInt32(nudCantidadInmueble.Value);

            // Validar que la cantidad no sea mayor a la disponible
            if (cantidadAsignada > cantidadMaximaDisponible && cantidadMaximaDisponible > 0)
            {
                nudCantidadInmueble.Value = cantidadMaximaDisponible;
                cantidadAsignada = cantidadMaximaDisponible;
            }

            // Actualizar en las selecciones temporales (solo datos, no objetos)
            int index = seleccionesNumerosInmuebles.IndexOf(idInmueble);
            if (index >= 0)
            {
                seleccionesCantidades[index] = cantidadAsignada;
            }
        }
    }
}