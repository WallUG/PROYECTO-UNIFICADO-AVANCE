using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmEditarDetallesEvento : Form
    {
        private AdmEvento admEvento = new AdmEvento();
        private int numeroEventoEditar = 0;
        private List<string> seleccionesNumerosInmuebles = new List<string>();
        private List<int> seleccionesCantidades = new List<int>();
        private int filaActivaParaCantidad = -1;
        private int cantidadMaximaDisponible = 0;
        private bool actualizandoSeleccion = false;

        public FrmEditarDetallesEvento()
        {
            InitializeComponent();
        }

        private void FrmEditarDetallesEvento_Load(object sender, EventArgs e)
        {
            numeroEventoEditar = admEvento.ObtenerNumeroEventoEditar();

            if (numeroEventoEditar == 0)
            {
                MessageBox.Show("No se ha seleccionado ningún evento para editar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            bool eventoExiste = admEvento.ExisteEventoParaEditar(numeroEventoEditar);

            if (!eventoExiste)
            {
                MessageBox.Show("No se encontró el evento a editar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ConfigurarFormularioEdicion();
            CargarDatosEvento();
            ConfigurarEventos();
        }

        private void ConfigurarFormularioEdicion()
        {
            txtCiRucCliente.ReadOnly = true;
            txtCiRucCliente.BackColor = SystemColors.Control;
            txtNombresCliente.ReadOnly = true;
            txtNombresCliente.BackColor = SystemColors.Control;
            txtApellidosCliente.ReadOnly = true;
            txtApellidosCliente.BackColor = SystemColors.Control;

            admEvento.LlenarTiposEvento(cmbTipoEvento);
            admEvento.LlenarEstadosEventoEditables(cmbEstadoEvento);
            admEvento.LlenarComboTipo(cmbTipoInmueble);

            gbInformacionCliente.Enabled = true;
            gbCreacionEvento.Enabled = true;
            gbAsignarInmuebles.Enabled = true;
            gbListaInmueblesSele.Enabled = true;
            btnGuardarEvento.Enabled = true;

            nudCantidadInmueble.Enabled = false;
        }

        private void CargarDatosEvento()
        {
            admEvento.PrepararEdicionEvento(numeroEventoEditar);

            txtCiRucCliente.Text = admEvento.ObtenerCedulaClienteEvento(numeroEventoEditar);
            txtNombresCliente.Text = admEvento.ObtenerNombresClienteEvento(numeroEventoEditar);
            txtApellidosCliente.Text = admEvento.ObtenerApellidosClienteEvento(numeroEventoEditar);

            string tipoEvento = admEvento.ObtenerTipoEventoPorNumero(numeroEventoEditar);
            int indiceTipo = admEvento.ObtenerIndiceTipoEvento(tipoEvento);
            if (indiceTipo >= 0)
            {
                cmbTipoEvento.SelectedIndex = indiceTipo;
            }

            txtNombreEvento.Text = admEvento.ObtenerNombreEventoPorNumero(numeroEventoEditar);
            txtDescripcionEvento.Text = admEvento.ObtenerDescripcionEventoPorNumero(numeroEventoEditar);
            txtNumPersonasEvento.Text = admEvento.ObtenerNumPersonasEventoPorNumero(numeroEventoEditar).ToString();
            txtbDireccionUbicacion.Text = admEvento.ObtenerDireccionEventoPorNumero(numeroEventoEditar);

            string estadoEvento = admEvento.ObtenerEstadoEventoPorNumero(numeroEventoEditar);
            int indiceEstado = admEvento.ObtenerIndiceEstadoEventoEditable(estadoEvento);
            if (indiceEstado >= 0)
            {
                cmbEstadoEvento.SelectedIndex = indiceEstado;
            }

            seleccionesNumerosInmuebles = admEvento.ObtenerNumerosInmueblesEvento(numeroEventoEditar);
            seleccionesCantidades = admEvento.ObtenerCantidadesInmueblesEvento(numeroEventoEditar);

            DateTime fechaInmueble = admEvento.ObtenerFechaAsignacionInmueblesEvento(numeroEventoEditar);
            if (fechaInmueble != DateTime.MinValue)
            {
                dtpFechaAsignacionInmueble.Value = fechaInmueble;
            }

            ActualizarTablaInmueblesActual();
        }

        private void ConfigurarEventos()
        {
            cmbTipoInmueble.SelectedIndexChanged += cmbTipoInmueble_SelectedIndexChanged;
            dgvInmuebles.CellValueChanged += dgvInmuebles_CellValueChanged;
            dgvInmuebles.CurrentCellDirtyStateChanged += dgvInmuebles_CurrentCellDirtyStateChanged;
            dgvInmuebles.CellClick += dgvInmuebles_CellClick;
            nudCantidadInmueble.ValueChanged += nudCantidadInmueble_ValueChanged;
            nudCantidadInmueble.KeyPress += nudCantidadInmueble_KeyPress;
            btnGuardarEvento.Click += btnGuardarEvento_Click;
            txtNumPersonasEvento.KeyPress += txtNumPersonasEvento_KeyPress;
        }

        private void cmbTipoInmueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            filaActivaParaCantidad = -1;
            cantidadMaximaDisponible = 0;
            nudCantidadInmueble.Enabled = false;

            if (cmbTipoInmueble.SelectedItem != null)
            {
                string tipoSeleccionado = cmbTipoInmueble.SelectedItem.ToString();
                admEvento.LlenarDescripcionInmuebleLocales(dgvInmuebles, tipoSeleccionado);
                RestaurarSeleccionesPrevias();
            }
        }

        private void RestaurarSeleccionesPrevias()
        {
            actualizandoSeleccion = true;

            for (int i = 0; i < dgvInmuebles.Rows.Count; i++)
            {
                object numInmObj = dgvInmuebles.Rows[i].Cells["colNumInmuebles"].Value;
                if (numInmObj != null)
                {
                    string numeroInmueble = Convert.ToString(numInmObj);

                    for (int j = 0; j < seleccionesNumerosInmuebles.Count; j++)
                    {
                        if (seleccionesNumerosInmuebles[j] == numeroInmueble)
                        {
                            dgvInmuebles.Rows[i].Cells["colSeleccionar"].Value = true;
                            break;
                        }
                    }
                }
            }

            actualizandoSeleccion = false;
        }

        private void dgvInmuebles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
                bool yaExiste = false;
                for (int i = 0; i < seleccionesNumerosInmuebles.Count; i++)
                {
                    if (seleccionesNumerosInmuebles[i] == numInmuebles)
                    {
                        yaExiste = true;
                        break;
                    }
                }

                if (!yaExiste)
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
                int index = -1;
                for (int i = 0; i < seleccionesNumerosInmuebles.Count; i++)
                {
                    if (seleccionesNumerosInmuebles[i] == numInmuebles)
                    {
                        index = i;
                        break;
                    }
                }

                if (index >= 0)
                {
                    seleccionesNumerosInmuebles.RemoveAt(index);
                    seleccionesCantidades.RemoveAt(index);
                    admEvento.EliminarInmuebleTemp(numInmuebles);
                }

                if (filaActivaParaCantidad == e.RowIndex)
                {
                    filaActivaParaCantidad = -1;
                    cantidadMaximaDisponible = 0;
                    BuscarOtraFilaSeleccionada();
                }
            }

            ActualizarTablaInmueblesActual();
            actualizandoSeleccion = false;
        }

        private void BuscarOtraFilaSeleccionada()
        {
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
                    for (int j = 0; j < seleccionesNumerosInmuebles.Count; j++)
                    {
                        if (seleccionesNumerosInmuebles[j] == numInmueblesActual)
                        {
                            cantidadGuardada = seleccionesCantidades[j];
                            break;
                        }
                    }

                    nudCantidadInmueble.Maximum = cantidadMaximaDisponible;
                    nudCantidadInmueble.Value = cantidadGuardada;
                    break;
                }
            }
        }

        private void dgvInmuebles_CurrentCellDirtyStateChanged(object sender, EventArgs e)
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

            object valorCelda = dgvInmuebles.Rows[e.RowIndex].Cells["colSeleccionar"].Value;
            bool estaMarcada = false;
            if (valorCelda != null)
            {
                estaMarcada = Convert.ToBoolean(valorCelda);
            }

            if (estaMarcada)
            {
                filaActivaParaCantidad = e.RowIndex;

                object idInmuebleObj = dgvInmuebles.Rows[e.RowIndex].Cells["colNumInmuebles"].Value;
                object cantidadDispObj = dgvInmuebles.Rows[e.RowIndex].Cells["colCantidadDisp"].Value;

                if (idInmuebleObj != null && cantidadDispObj != null)
                {
                    string idInmueble = Convert.ToString(idInmuebleObj);
                    int cantidadDisponible = Convert.ToInt32(cantidadDispObj);
                    cantidadMaximaDisponible = cantidadDisponible;

                    int cantidadGuardada = cantidadDisponible;
                    for (int i = 0; i < seleccionesNumerosInmuebles.Count; i++)
                    {
                        if (seleccionesNumerosInmuebles[i] == idInmueble)
                        {
                            cantidadGuardada = seleccionesCantidades[i];
                            break;
                        }
                    }

                    nudCantidadInmueble.Enabled = true;
                    nudCantidadInmueble.Maximum = cantidadDisponible;
                    nudCantidadInmueble.Value = cantidadGuardada;
                }
            }
        }

        private void nudCantidadInmueble_ValueChanged(object sender, EventArgs e)
        {
            if (filaActivaParaCantidad < 0 || !nudCantidadInmueble.Enabled)
            {
                return;
            }

            if (filaActivaParaCantidad >= dgvInmuebles.Rows.Count)
            {
                return;
            }

            object idInmuebleObj = dgvInmuebles.Rows[filaActivaParaCantidad].Cells["colNumInmuebles"].Value;
            if (idInmuebleObj == null)
            {
                return;
            }

            string idInmueble = Convert.ToString(idInmuebleObj);
            int cantidadAsignada = Convert.ToInt32(nudCantidadInmueble.Value);

            if (cantidadAsignada > cantidadMaximaDisponible && cantidadMaximaDisponible > 0)
            {
                nudCantidadInmueble.Value = cantidadMaximaDisponible;
                cantidadAsignada = cantidadMaximaDisponible;
            }

            for (int i = 0; i < seleccionesNumerosInmuebles.Count; i++)
            {
                if (seleccionesNumerosInmuebles[i] == idInmueble)
                {
                    seleccionesCantidades[i] = cantidadAsignada;
                    break;
                }
            }

            ActualizarTablaInmueblesActual();
        }

        private void nudCantidadInmueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            bool esDigito = Char.IsDigit(caracter);
            bool esBackspace = (caracter == (char)Keys.Back);
            bool esDelete = (caracter == (char)Keys.Delete);

            if (!esDigito && !esBackspace && !esDelete)
            {
                e.Handled = true;
                return;
            }

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

        private void ActualizarTablaInmueblesActual()
        {
            dgvInmueblesActual.Rows.Clear();

            if(seleccionesNumerosInmuebles.Count == 0)
            {
                admEvento.ActualizarTablaInmueblesActual(dgvInmueblesActual);
            }

            for (int i = 0; i < seleccionesNumerosInmuebles.Count; i++)
            {
                string numeroInmueble = seleccionesNumerosInmuebles[i];
                int cantidadAsignada = seleccionesCantidades[i];

                int cantidadDisponibleReal = admEvento.ObtenerCantidadRealDisponible(numeroInmueble);

                if (cantidadDisponibleReal == 0)
                {
                    continue;
                }

                if (cantidadAsignada > cantidadDisponibleReal)
                {
                    seleccionesCantidades[i] = cantidadDisponibleReal;
                    cantidadAsignada = cantidadDisponibleReal;
                }

                DateTime fechaAsignacion = dtpFechaAsignacionInmueble.Value;

                admEvento.SincronizarInmuebleTemp(numeroInmueble, cantidadAsignada, fechaAsignacion);

                string nombreInmueble = admEvento.ObtenerNombreInmueble(numeroInmueble);
                bool disponible = admEvento.ObtenerDisponibilidadInmueble(numeroInmueble);

                int indice = dgvInmueblesActual.Rows.Add();
                dgvInmueblesActual.Rows[indice].Cells["colNumInmueblesAct"].Value = numeroInmueble;
                dgvInmueblesActual.Rows[indice].Cells["colNombreAct"].Value = nombreInmueble;
                dgvInmueblesActual.Rows[indice].Cells["colDisponibleAct"].Value = disponible;
                dgvInmueblesActual.Rows[indice].Cells["colCantDispAct"].Value = cantidadAsignada;
                dgvInmueblesActual.Rows[indice].Cells["colFechaAsignacionAct"].Value = fechaAsignacion.ToShortDateString();
            }
        }

        private void btnGuardarEvento_Click(object sender, EventArgs e)
        {
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

            if (admEvento.EsVacio(tipoEvento, nombreEvento, descripcionEvento,
                numPersonas, direccionEvento, estadoEvento))
            {
                MessageBox.Show("No deben quedar campos vacíos en la información del evento.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (seleccionesNumerosInmuebles.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un inmueble.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                    MessageBox.Show("La cantidad asignada para el inmueble " + numeroInmueble + " excede la cantidad disponible.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DateTime fechaAsignacion = dtpFechaAsignacionInmueble.Value;

            admEvento.LimpiarInmueblesSeleccionados();

            for (int i = 0; i < seleccionesNumerosInmuebles.Count; i++)
            {
                string numeroInmueble = seleccionesNumerosInmuebles[i];
                int cantidadAsignada = seleccionesCantidades[i];
                admEvento.ActualizarInmuebleSeleccionado(numeroInmueble, cantidadAsignada, fechaAsignacion);
            }

            int numEventos = admEvento.ObtenerNumeroEventoEditar();

            bool resultado = admEvento.ActualizarEventoExistente(
                numEventos,
                tipoEvento,
                nombreEvento,
                descripcionEvento,
                numPersonas,
                direccionEvento,
                estadoEvento
            );

            if (resultado)
            {
                MessageBox.Show("Evento actualizado exitosamente. Num. de evento: " + numEventos.ToString(),
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdmEventoInmueble.LimpiarInmueblesTemp();

                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el evento.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
