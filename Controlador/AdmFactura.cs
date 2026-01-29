using Datos;
using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Controlador
{
    public class AdmFactura
    {
        public static List<Factura> listaFacturas = new List<Factura>();
        static string numeroEditarFactura;
        public List<Cliente> listaCliente = AdmCliente.ObtenerTodosLosClientes();
        public List<Reserva> listaReserva = AdmReserva.ObtenerTodosLasReservas();
        public List<Evento> listaEvento = AdmEvento.ObtenerTodosLosEventos();
        Conexion cn = new Conexion();
        DatosFactura datosFac = null;
        int IdFacturaDB;

        public AdmFactura()
        {
            ConsultarFacturasBDD();
        }

        public void BuscarCliente(ComboBox cmNumeroEvento, GroupBox groupBoxCliente, string cedula)
        {
            if (cedula == "") {
                MessageBox.Show("Campo requerido");
                return;
            }

            if(listaEvento.Count == 0)
            {
                foreach (Cliente item in listaCliente)
                {
                    if (item.CedulaORuc == cedula)
                    {
                        foreach (Control c in groupBoxCliente.Controls)
                        {
                            if (c is TextBox txt)
                            {
                                switch (txt.Name)
                                {
                                    case "txtNumeroCliente":
                                        txt.Text = item.NumeroCliente.ToString();
                                        break;

                                    case "txtNombreCliente":
                                        txt.Text = item.Nombre;
                                        break;

                                    case "txtApellidoCliente":
                                        txt.Text = item.Apellido;
                                        break;

                                    case "txtTelefonoCliente":
                                        txt.Text = item.Telefono;
                                        break;
                                    case "txtCorreoCliente":
                                        txt.Text = item.CorreoElectronico;
                                        break;
                                    case "txtDireccionCliente":
                                        txt.Text = item.Direccion;
                                        break;
                                }
                            }
                        }
                        MessageBox.Show("Cliente encontrado");
                    }
                }

                MessageBox.Show("El clientes seleccionado no EXISTE o no cuenta con eventos asociados en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (Evento item in listaEvento)
            {
                if (item.Cliente.CedulaORuc == cedula)
                {
                    foreach (Control c in groupBoxCliente.Controls)
                    {
                        if (c is TextBox txt)
                        {
                            switch (txt.Name)
                            {
                                case "txtNumeroCliente":
                                    txt.Text = item.Cliente.NumeroCliente.ToString();
                                    break;

                                case "txtNombreCliente":
                                    txt.Text = item.Cliente.Nombre;
                                    break;

                                case "txtApellidoCliente":
                                    txt.Text = item.Cliente.Apellido;
                                    break;

                                case "txtTelefonoCliente":
                                    txt.Text = item.Cliente.Telefono;
                                    break;
                                case "txtCorreoCliente":
                                    txt.Text = item.Cliente.CorreoElectronico;
                                    break;
                                case "txtDireccionCliente":
                                    txt.Text = item.Cliente.Direccion;
                                    break;
                            }
                        }
                    }
                    MessageBox.Show("Cliente encontrado");
                    llenarComboNumeroEvento(cmNumeroEvento, item.Cliente.Id);
                    return;
                }
            }

            // Si llegó aquí, no encontró nada
            MessageBox.Show("No se encontró el cliente");
        }

        public void llenarComboNumeroEvento(ComboBox cmbIdEvento, int idCliente)
        {
            // Limpia los items antes de rellenar
            cmbIdEvento.Items.Clear();
            cmbIdEvento.SelectedIndex = -1;
            cmbIdEvento.Text = "";

            // Rellenar el ComboBox con los numeros de evento del cliente
            foreach (Evento fac in listaEvento)
            {

                if (fac.Cliente.Id == idCliente)
                {
                    cmbIdEvento.Items.Add(fac.NumEventos);
                }
            }
        }

        public void cargarEventoPorId(GroupBox groupBoxEvento, GroupBox groupBoxFactura, DataGridView dgvDetallesFactura, int idEvento)
        {
            foreach (Evento item in listaEvento)
            {
                if (item.IdEvento == idEvento)
                {
                    foreach (Control c in groupBoxEvento.Controls)
                    {
                        if (c is TextBox txt)
                        {
                            switch (txt.Name)
                            {
                                case "txtTipoEvento":
                                    txt.Text = item.TipoEvento;
                                    break;

                                case "txtNombreEvento":
                                    txt.Text = item.NombreEvento;
                                    break;

                                case "txtDescripcionEvento":
                                    txt.Text = item.DescripcionEvento;
                                    break;

                                case "txtNumPersonasEvento":
                                    txt.Text = item.NumPersonasEvento.ToString();
                                    break;
                                case "txtEstadoEvento":
                                    txt.Text = item.EstadoEvento;
                                    break;
                            }
                        }
                    }

                    foreach (Reserva resr in listaReserva)
                    {
                        if (resr.evento.IdEvento == idEvento)
                        {
                            foreach (Control c in groupBoxEvento.Controls)
                            {
                                if (c is TextBox txt)
                                {
                                    switch (txt.Name)
                                    {
                                        case "txtReservaFecha":
                                            txt.Text = resr.FechaReserva.ToString();
                                            break;
                                    }
                                }
                            }
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No hay reserva asociada a este evento");
                        }
                    }


                    MessageBox.Show("Evento Cargado");
                    CargarTablaDetalle(dgvDetallesFactura, idEvento);
                    CargaFacturaExistente(groupBoxFactura, idEvento);
                    return;
                }
            }
        }

        private void CargaFacturaExistente(GroupBox groupBoxFactura, int idEvento)
        {
            foreach (Factura fac in listaFacturas)
            {
                if (fac.Evento.IdEvento == idEvento)
                {
                    foreach (Control c in groupBoxFactura.Controls)
                    {
                        if (c is TextBox txt)
                        {
                            switch (txt.Name)
                            {
                                case "txtIdFactura":
                                    txt.Text = fac.IdFactura.ToString();
                                    break;
                                case "txtNumeroFactura":
                                    txt.Text = fac.NumeroFactura;
                                    break;
                                case "txtEstadoFactura":
                                    txt.Text = fac.Estado;
                                    break;
                                case "txtSubtotal":
                                    txt.Text = fac.SubTotal.ToString();
                                    break;
                                case "txtImpuestos":
                                    txt.Text = fac.Iva.ToString();
                                    break;
                                case "txtTotal":
                                    txt.Text = fac.Total.ToString();
                                    break;
                            }
                        }
                        if (c is Button btn)
                        {
                            btn.Enabled = false;
                        }
                    }
                    MessageBox.Show("Factura existente cargada, para editar dirijase a el apartado de edicion.");
                    break;
                }
                else
                {
                    limpiarDatos(groupBoxFactura);
                }
            }
        }

        public void CargarTablaDetalle(DataGridView dgvDetallesFactura, int idEvento)
        {
            int indice = 0;
            dgvDetallesFactura.Rows.Clear();
            foreach (Evento item in listaEvento)
            {
                if (item.IdEvento == idEvento) {
                    foreach (EventoInmueble eInm in item.EventoInmueble)
                    {
                        dgvDetallesFactura.Rows.Add();
                        dgvDetallesFactura.Rows[indice].Cells["colIdDetalle"].Value = eInm.ObtenerNumInmuebles();
                        dgvDetallesFactura.Rows[indice].Cells["colNombre"].Value = eInm.inmueble.nombreInmueble;
                        dgvDetallesFactura.Rows[indice].Cells["colCantidad"].Value = eInm.cantidadInmueble;
                        dgvDetallesFactura.Rows[indice].Cells["colPrecioUnitario"].Value = eInm.inmueble.precioInmueble;
                        dgvDetallesFactura.Rows[indice].Cells["colSubtotal"].Value = eInm.CalcularMontoInmueble();
                        indice++;
                    }
                }
            }
        }

        public void CargarTablaFacturas(DataGridView dgvFacturas)
        {
            dgvFacturas.Rows.Clear();
            int indice = 0;

            //if (listaFacturas.Count == 0)
            //{
            //    MessageBox.Show("No hay facturas registradas en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            foreach (Factura factura in listaFacturas)
            {
                dgvFacturas.Rows.Add();
                dgvFacturas.Rows[indice].Cells["Nro"].Value = indice+1;
                dgvFacturas.Rows[indice].Cells["colNumeroFactura"].Value = factura.NumeroFactura;
                dgvFacturas.Rows[indice].Cells["colCliente"].Value = 
                    factura.Evento.Cliente.Nombre + " " + factura.Evento.Cliente.Apellido;
                dgvFacturas.Rows[indice].Cells["colCedulaCliente"].Value = factura.Evento.Cliente.CedulaORuc;
                dgvFacturas.Rows[indice].Cells["colEvento"].Value = factura.Evento.NombreEvento;
                dgvFacturas.Rows[indice].Cells["colTipoEvento"].Value = factura.Evento.TipoEvento;
                dgvFacturas.Rows[indice].Cells["colFechaEmision"].Value = factura.FechaEmision.ToString("dd/MM/yyyy");
                dgvFacturas.Rows[indice].Cells["colSubtotal"].Value = "$" + factura.SubTotal.ToString("N2");
                dgvFacturas.Rows[indice].Cells["colIVA"].Value = "$" + factura.Iva.ToString("N2");
                dgvFacturas.Rows[indice].Cells["colTotal"].Value = "$" + factura.Total.ToString("N2");
                dgvFacturas.Rows[indice].Cells["colEstado"].Value = factura.Estado;

                indice++;
            }
        }

        public string GenerarNumeroFacturaAuto(List<Factura> listaFacturas, int establecimiento, int puntoEmision)
        {
            int secuencial = 1;

            if (listaFacturas.Count > 0)
            {
                // Obtener el secuencial más alto existente
                secuencial = listaFacturas.Max(f => f.Secuencial) + 1;
            }

            string est = establecimiento.ToString("D3");
            string pto = puntoEmision.ToString("D3");
            string sec = secuencial.ToString("D8");

            return est + "-" + pto + "-" + sec;
        }

        // Genera los detalles de factura a partir de los EventoInmueble
        public void GenerarDetallesFactura(Factura factura)
        {
            factura.Detalles.Clear();
            int idDetalle = 1;

            if (factura.Evento?.EventoInmueble != null)
            {
                foreach (EventoInmueble item in factura.Evento.EventoInmueble)
                {
                    string descripcion = item.inmueble.nombreInmueble + " - " + item.inmueble.tipoInmueble;
                    DetalleFactura detalle = new DetalleFactura(
                        idDetalle,
                        descripcion,
                        item.cantidadInmueble,
                        item.inmueble.precioInmueble
                    );

                    factura.Detalles.Add(detalle);
                    idDetalle++;
                }
            }
        }

        // Calcula el subtotal sumando los subtotales de cada detalle
        public void CalcularSubTotal(Factura factura)
        {
            float SubTotal = 0;
            factura.SubTotal = SubTotal;
            if (factura.Detalles != null && factura.Detalles.Count > 0)
            {
                foreach (DetalleFactura detalle in factura.Detalles)
                {
                    factura.SubTotal += detalle.Subtotal;
                }
            }
        }

        public void generarFactura(GroupBox groupBoxFactura, int idEvento, string descuento)
        {
            Factura factura = null;

            foreach (Evento item in listaEvento)
            {
                if (item.IdEvento == idEvento)
                {
                    // Verificar si ya existe una factura para este evento
                    bool facturaExiste = false;
                    foreach (Factura fac in listaFacturas)
                    {
                        if (fac.Evento.IdEvento == idEvento)
                        {
                            if(fac.Estado == "Anulada")
                            {
                                facturaExiste = false;
                                break;
                            }
                            facturaExiste = true;
                            break; // Salir del bucle una vez encontrada
                        }
                    }

                    if (facturaExiste)
                    {
                        MessageBox.Show("Ya existe una factura para este evento, anule la existente para crear una nueva");
                        return; // Salir del método
                    }
                    else
                    {
                        // Crear la nueva factura
                        int nuevoIndice = listaFacturas.Count + 1;
                        factura = new Factura(item);
                        //listaFacturas.Add(factura);
                        MessageBox.Show("Descuento de: " + descuento);
                        GenerarDetallesFactura(factura);
                        CalcularSubTotal(factura);
                        factura.GenerarFactura(descuento);
                        factura.NumeroFactura = GenerarNumeroFacturaAuto(listaFacturas, 1, nuevoIndice);
                        RegistrarFacturaBDD(factura);
                        RegistrarDetallesFacturaBDD(factura);
                    }

                    // Actualizar los controles del GroupBox
                    foreach (Control c in groupBoxFactura.Controls)
                    {
                        if (c is TextBox txt)
                        {
                            switch (txt.Name)
                            {
                                case "txtNumeroFactura":
                                    txt.Text = factura.NumeroFactura;
                                    break;
                                case "txtIdFactura":
                                    txt.Text = factura.IdFactura.ToString();
                                    break;
                                case "txtSubtotal":
                                    txt.Text = factura.SubTotal.ToString();
                                    break;
                                case "txtImpuestos":
                                    txt.Text = factura.Iva.ToString();
                                    break;
                                case "txtTotal":
                                    txt.Text = factura.Total.ToString();
                                    break;
                                case "txtEstadoFactura":
                                    txt.Text = factura.Estado;
                                    break;
                                case "txtDescuento":
                                    if (factura.Descuento > 0)
                                        txt.Text = factura.Descuento.ToString();
                                    else
                                    {
                                        txt.Text = "No Aplica";
                                    }
                                    break;
                                case "txtDescuentoAplicado":
                                    if (factura.Descuento > 0)
                                        txt.Text = factura.DescuentoAplicado.ToString();
                                    else
                                    {
                                        txt.Text = "No Aplica";
                                    }
                                    break;
                            }
                        }

                        if (c is DateTimePicker dtp)
                        {
                            switch (dtp.Name)
                            {
                                case "dtpFechaEmision":
                                    dtp.Value = factura.FechaEmision;
                                    break;
                            }
                        }
                    }

                    break; // Salir del bucle de eventos una vez procesado
                }
            }
        }

        public void ActualizarFacturaInfo(GroupBox groupBoxFactura, string numeroFacturas)
        {
            foreach (Factura item in listaFacturas)
            {
                if (item.NumeroFactura == numeroFacturas)
                {

                    foreach (Control c in groupBoxFactura.Controls)
                    {
                        if (c is TextBox txt)
                        {
                            switch (txt.Name)
                            {
                                case "txtNumeroFactura":
                                    txt.Text = item.NumeroFactura;
                                    break;
                                case "txtIdFactura":
                                    txt.Text = item.IdFactura.ToString();
                                    break;
                                case "txtSubtotal":
                                    txt.Text = item.SubTotal.ToString();
                                    break;
                                case "txtImpuestos":
                                    txt.Text = item.Iva.ToString();
                                    break;
                                case "txtTotal":
                                    txt.Text = item.Total.ToString();
                                    break;
                                case "txtEstadoFactura":
                                    txt.Text = item.Estado;
                                    break;
                            }
                        }

                        if (c is DateTimePicker dtp)
                        {
                            switch (dtp.Name)
                            {
                                case "dtpFechaEmision":
                                    dtp.Value = item.FechaEmision;
                                    break;
                            }
                        }
                    }
                }
            }
        }

        public void EmitirFactura(GroupBox groupBoxFactura,string numeroFacturas)
        {
            
            foreach (Factura factura in listaFacturas)
            {
                if (factura.NumeroFactura == numeroFacturas)
                {
                    //if(factura.Estado == "Anulada")
                    //{
                    //    MessageBox.Show("No se puede emitir una factura previamente anulada.");
                    //}
                    //else
                    if(factura.Estado == "Emitida")
                    {
                        MessageBox.Show("La factura ya ha sido emitida.");
                    }
                    else {
                        factura.EmitirFactura();
                        MessageBox.Show("Factura Emitida");
                        ActualizarFacturaInfo(groupBoxFactura, numeroFacturas);
                        return;
                    }
                }
            }
        }

        public void AnularFactura(GroupBox groupBoxFactura,string numeroFacturas)
        {
            foreach (Factura factura in listaFacturas)
            {
                if (factura.NumeroFactura == numeroFacturas)
                {
                    if (factura.Estado == "Anulada")
                    {
                        MessageBox.Show("No se puede anular una factura ya anulada.");
                    }
                    else
                    {
                        factura.AnularFactura();
                        MessageBox.Show("Factura Anulada");
                        ActualizarFacturaInfo(groupBoxFactura, numeroFacturas);
                        return;
                    }
                }
            }
        }

        public int GetCantidadLista()
        {
            return listaFacturas.Count;
        }

        public void EliminarFactura(int indice, DataGridView dvgFacturas)
        {
            string numeroFacturas = dvgFacturas.Rows[indice].Cells["colNumeroFactura"].Value.ToString();
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar la factura seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                for (int i = 0; i < listaFacturas.Count; i++)
                {
                    if (listaFacturas[i].NumeroFactura == numeroFacturas)
                    {
                        EliminarFacturaBDD(numeroFacturas);
                        listaFacturas.RemoveAt(i);
                        MessageBox.Show("Factura eliminada correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
        }

        public void limpiarDatos(GroupBox groupBoxFactura)
        {
            foreach (Control c in groupBoxFactura.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.Clear();
                }
                if (c is DateTimePicker dtp)
                {
                    dtp.Value = DateTime.Now;
                }
                if (c is Button btn)
                {
                    btn.Enabled = true;
                }
            }
        }

        public void limpiarDatos(GroupBox groupBoxEvento, GroupBox groupBoxFactura, GroupBox groupBoxDetalles)
        {
            foreach (Control c in groupBoxEvento.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.Clear();
                }
            }
            foreach (Control c in groupBoxFactura.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.Clear();
                }
                if (c is DateTimePicker dtp)
                {
                    dtp.Value = DateTime.Now;
                }
            }
            foreach (Control c in groupBoxDetalles.Controls)
            {
                if (c is DataGridView dgv)
                {
                    dgv.Rows.Clear();
                }
            }
        }

        public void verificarFiltros(string txtNumCedula, string txtNumFactura, DataGridView dgvFacturas)
        {
            dgvFacturas.Rows.Clear();
            int indice = 0;

            string filtro = "";
            if (!string.IsNullOrWhiteSpace(txtNumCedula))
            {
                filtro = "Cedula";
            }
            else if (!string.IsNullOrWhiteSpace(txtNumFactura))
            {
                filtro = "Factura";
            }

            foreach (Factura factura in listaFacturas)
            {
                if (filtro == "Cedula")
                {
                    if(factura.Evento.Cliente.CedulaORuc == txtNumCedula)
                    {
                        dgvFacturas.Rows.Add();
                        dgvFacturas.Rows[indice].Cells["Nro"].Value = indice + 1;
                        dgvFacturas.Rows[indice].Cells["colNumeroFactura"].Value = factura.NumeroFactura;
                        dgvFacturas.Rows[indice].Cells["colCliente"].Value =
                            factura.Evento.Cliente.Nombre + " " + factura.Evento.Cliente.Apellido;
                        dgvFacturas.Rows[indice].Cells["colCedulaCliente"].Value = factura.Evento.Cliente.CedulaORuc;
                        dgvFacturas.Rows[indice].Cells["colEvento"].Value = factura.Evento.NombreEvento;
                        dgvFacturas.Rows[indice].Cells["colTipoEvento"].Value = factura.Evento.TipoEvento;
                        dgvFacturas.Rows[indice].Cells["colFechaEmision"].Value = factura.FechaEmision.ToString("dd/MM/yyyy");
                        dgvFacturas.Rows[indice].Cells["colSubtotal"].Value = "$" + factura.SubTotal.ToString("N2");
                        dgvFacturas.Rows[indice].Cells["colIVA"].Value = "$" + factura.Iva.ToString("N2");
                        dgvFacturas.Rows[indice].Cells["colTotal"].Value = "$" + factura.Total.ToString("N2");
                        dgvFacturas.Rows[indice].Cells["colEstado"].Value = factura.Estado;
                        indice++;
                    }
                }else if(filtro == "Factura")
                {
                    if (factura.NumeroFactura == txtNumFactura)
                    {
                        dgvFacturas.Rows.Add();
                        dgvFacturas.Rows[indice].Cells["Nro"].Value = indice + 1;
                        dgvFacturas.Rows[indice].Cells["colNumeroFactura"].Value = factura.NumeroFactura;
                        dgvFacturas.Rows[indice].Cells["colCliente"].Value =
                            factura.Evento.Cliente.Nombre + " " + factura.Evento.Cliente.Apellido;
                        dgvFacturas.Rows[indice].Cells["colCedulaCliente"].Value = factura.Evento.Cliente.CedulaORuc;
                        dgvFacturas.Rows[indice].Cells["colEvento"].Value = factura.Evento.NombreEvento;
                        dgvFacturas.Rows[indice].Cells["colTipoEvento"].Value = factura.Evento.TipoEvento;
                        dgvFacturas.Rows[indice].Cells["colFechaEmision"].Value = factura.FechaEmision.ToString("dd/MM/yyyy");
                        dgvFacturas.Rows[indice].Cells["colSubtotal"].Value = "$" + factura.SubTotal.ToString("N2");
                        dgvFacturas.Rows[indice].Cells["colIVA"].Value = "$" + factura.Iva.ToString("N2");
                        dgvFacturas.Rows[indice].Cells["colTotal"].Value = "$" + factura.Total.ToString("N2");
                        dgvFacturas.Rows[indice].Cells["colEstado"].Value = factura.Estado;
                        indice++;
                    }
                }
            }
        }

        public bool EsVacio(string txtNumCedula, string txtNumFactura)
        {
            if (string.IsNullOrWhiteSpace(txtNumCedula) && string.IsNullOrWhiteSpace(txtNumFactura))
            {
                return true;
            }
            return false;
        }

        public void guardarNumeroEditarFactura(int indice, DataGridView dgvFacturas)
        {
            string numeroFactura = dgvFacturas.Rows[indice].Cells["colNumeroFactura"].Value.ToString();
            numeroEditarFactura = numeroFactura;
        }

        public bool EsEditable(int indice,DataGridView dgvFacturas)
        {
            string numeroFactura = dgvFacturas.Rows[indice].Cells["colNumeroFactura"].Value.ToString();
            foreach (Factura factura in listaFacturas)
            {
                if (factura.NumeroFactura == numeroFactura)
                {
                    if (factura.Estado == "Emitida")
                    {
                        MessageBox.Show("La factura ya ha sido emitida y no puede ser editada.");
                        return false;
                    }
                    else if (factura.Estado == "Anulada")
                    {
                        MessageBox.Show("La factura está anulada y no puede ser editada.");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return true;
        }

        public string ObtenerNumeroFacturaEditar()
        {
            return numeroEditarFactura;
        }

        public Factura ObtenerFacturaPorNumero(string numeroFactura)
        {
            foreach (Factura factura in listaFacturas)
            {
                if (factura.NumeroFactura == numeroFactura)
                {
                    return factura;
                }
            }
            return null;
        }

        public void CargarFacturaParaEditar(GroupBox groupBoxCliente, GroupBox groupBoxEvento, 
            GroupBox groupBoxFactura, DataGridView dgvDetalles)
        {
            Factura factura = ObtenerFacturaPorNumero(numeroEditarFactura);
            
            if (factura == null)
            {
                MessageBox.Show("No se encontró la factura a editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cargar datos del cliente
            foreach (Control c in groupBoxCliente.Controls)
            {
                if (c is TextBox txt)
                {
                    switch (txt.Name)
                    {
                        case "txtNumeroCliente":
                            txt.Text = factura.Evento.Cliente.NumeroCliente.ToString();
                            break;
                        case "txtCedula":
                            txt.Text = factura.Evento.Cliente.CedulaORuc;
                            break;
                        case "txtNombreCliente":
                            txt.Text = factura.Evento.Cliente.Nombre;
                            break;
                        case "txtApellidoCliente":
                            txt.Text = factura.Evento.Cliente.Apellido;
                            break;
                        case "txtTelefonoCliente":
                            txt.Text = factura.Evento.Cliente.Telefono;
                            break;
                        case "txtCorreoCliente":
                            txt.Text = factura.Evento.Cliente.CorreoElectronico;
                            break;
                        case "txtDireccionCliente":
                            txt.Text = factura.Evento.Cliente.Direccion;
                            break;
                    }
                }
            }

            // Cargar datos del evento
            foreach (Control c in groupBoxEvento.Controls)
            {
                if (c is TextBox txt)
                {
                    switch (txt.Name)
                    {
                        case "txtIdEvento":
                            txt.Text = factura.Evento.IdEvento.ToString();
                            break;
                        case "txtNumeroEvento":
                            txt.Text = factura.Evento.NumEventos.ToString();
                            break;
                        case "txtTipoEvento":
                            txt.Text = factura.Evento.TipoEvento;
                            break;
                        case "txtNombreEvento":
                            txt.Text = factura.Evento.NombreEvento;
                            break;
                        case "txtDescripcionEvento":
                            txt.Text = factura.Evento.DescripcionEvento;
                            break;
                        case "txtNumPersonasEvento":
                            txt.Text = factura.Evento.NumPersonasEvento.ToString();
                            break;
                        case "txtEstadoEvento":
                            txt.Text = factura.Evento.EstadoEvento;
                            break;
                    }
                }
            }

            // Cargar datos de la factura
            foreach (Control c in groupBoxFactura.Controls)
            {
                if (c is TextBox txt)
                {
                    switch (txt.Name)
                    {
                        case "txtIdFactura":
                            txt.Text = factura.IdFactura.ToString();
                            break;
                        case "txtNumeroFactura":
                            txt.Text = factura.NumeroFactura;
                            break;
                        case "txtEstadoFactura":
                            txt.Text = factura.Estado;
                            break;
                        case "txtSubtotal":
                            txt.Text = factura.SubTotal.ToString("N2");
                            break;
                        case "txtImpuestos":
                            txt.Text = factura.Iva.ToString("N2");
                            break;
                        case "txtTotal":
                            txt.Text = factura.Total.ToString("N2");
                            break;
                        case "txtDescuento":
                            if (factura.Descuento > 0)
                                txt.Text = factura.Descuento.ToString();
                            else
                            {
                                txt.Text = "No Aplica";
                            }
                            break;
                        case "txtDescuentoAplicado":
                            if (factura.Descuento > 0)
                                txt.Text = factura.DescuentoAplicado.ToString();
                            else
                            {
                                txt.Text = "No Aplica";
                            }
                            break;
                    }
                }
                if (c is DateTimePicker dtp)
                {
                    if (dtp.Name == "dtpFechaEmision")
                    {
                        dtp.Value = factura.FechaEmision;
                    }
                }
            }

            // Cargar detalles de la factura
            CargarDetallesFacturaEditar(dgvDetalles, factura);
        }

        private void CargarDetallesFacturaEditar(DataGridView dgvDetalles, Factura factura)
        {
            dgvDetalles.Rows.Clear();
            int indice = 0;

            if (factura.Evento != null)
            {
                foreach (DetalleFactura eInm in factura.Detalles)
                {
                    dgvDetalles.Rows.Add();
                    dgvDetalles.Rows[indice].Cells["colIdDetalle"].Value = eInm.NumDetalle;
                    dgvDetalles.Rows[indice].Cells["colNombre"].Value = eInm.Descripcion;//inmueble.nombreInmueble;
                    dgvDetalles.Rows[indice].Cells["colCantidad"].Value = eInm.Cantidad;
                    dgvDetalles.Rows[indice].Cells["colPrecioUnitario"].Value = eInm.PrecioUnitario.ToString("N2");
                    dgvDetalles.Rows[indice].Cells["colSubtotal"].Value = eInm.Subtotal.ToString("N2");
                    indice++;
                }
            }
        }

        public bool ActualizarDescuentoFactura(string nuevoDescuento, GroupBox groupBoxFactura)
        {
            Factura factura = ObtenerFacturaPorNumero(numeroEditarFactura);
            
            if (factura == null)
            {
                MessageBox.Show("No se encontró la factura a actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (factura.Estado != "Pendiente")
            {
                MessageBox.Show("Solo se pueden editar facturas con estado Pendiente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Recalcular la factura con el nuevo descuento
            GenerarDetallesFactura(factura);
            CalcularSubTotal(factura);

            // Aplicar el nuevo descuento

            try
            {
                double subtotalOriginal = factura.SubTotal;

                if (!string.IsNullOrWhiteSpace(nuevoDescuento) && nuevoDescuento != "0" && nuevoDescuento != "0.00")
                {
                    double porcentajeDescuento = double.Parse(nuevoDescuento);
                    factura.Descuento = (int)porcentajeDescuento;

                    if (porcentajeDescuento > 1)
                    {
                        porcentajeDescuento = porcentajeDescuento / 100.0;
                    }

                    if (porcentajeDescuento >= 0 && porcentajeDescuento <= 1)
                    {
                        double descuentoMonto = subtotalOriginal * porcentajeDescuento;
                        factura.DescuentoAplicado = (int)descuentoMonto;
                        factura.SubTotal = subtotalOriginal - descuentoMonto;
                    }
                }
                else
                {
                    MessageBox.Show("Descuento no válido, se aplicará '0%'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    factura.Descuento = 0;
                }
            }
            catch (Exception)
            {
                //
            }

            factura.CalcularIVA();
            factura.CalcularTotal();

            // Actualizar los controles del formulario
            foreach (Control c in groupBoxFactura.Controls)
            {
                if (c is TextBox txt)
                {
                    switch (txt.Name)
                    {
                        case "txtSubtotal":
                            txt.Text = factura.SubTotal.ToString("N2");
                            break;
                        case "txtImpuestos":
                            txt.Text = factura.Iva.ToString("N2");
                            break;
                        case "txtTotal":
                            txt.Text = factura.Total.ToString("N2");
                            break;
                        case "txtDescuento":
                            if(factura.Descuento > 0)
                                txt.Text = factura.Descuento.ToString();
                            else {
                                txt.Text = "No Aplica";
                            }
                            break;
                        case "txtDescuentoAplicado":
                            if (factura.Descuento > 0)
                                txt.Text = factura.DescuentoAplicado.ToString();
                            else
                            {
                                txt.Text = "No Aplica";
                            }
                            break;
                    }
                }
            }

            return true;
        }

        public bool GuardarCambiosFactura(string nuevoDescuento)
        {
            Factura factura = ObtenerFacturaPorNumero(numeroEditarFactura);
            
            if (factura == null)
            {
                MessageBox.Show("No se encontró la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (factura.Estado != "Pendiente")
            {
                MessageBox.Show("Solo se pueden guardar cambios en facturas con estado Pendiente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            MessageBox.Show("Los cambios han sido guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public bool EmitirFacturaEdicion(GroupBox groupBoxFactura)
        {
            Factura factura = ObtenerFacturaPorNumero(numeroEditarFactura);
            
            if (factura == null)
            {
                MessageBox.Show("No se encontró la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (factura.Estado == "Emitida")
            {
                MessageBox.Show("La factura ya ha sido emitida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (factura.Estado == "Anulada")
            {
                MessageBox.Show("No se puede emitir una factura anulada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            factura.EmitirFactura();
            
            // Actualizar el estado en el formulario
            foreach (Control c in groupBoxFactura.Controls)
            {
                if (c is TextBox txt && txt.Name == "txtEstadoFactura")
                {
                    txt.Text = factura.Estado;
                    break;
                }
            }

            MessageBox.Show("Factura emitida correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public bool AnularFacturaEdicion(GroupBox groupBoxFactura)
        {
            Factura factura = ObtenerFacturaPorNumero(numeroEditarFactura);

            if (factura == null)
            {
                MessageBox.Show("No se encontró la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (factura.Estado == "Anulada")
            {
                MessageBox.Show("La factura ya está anulada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea anular esta factura?",
                "Confirmar anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                factura.AnularFactura();

                // Actualizar el estado en el formulario
                foreach (Control c in groupBoxFactura.Controls)
                {
                    if (c is TextBox txt && txt.Name == "txtEstadoFactura")
                    {
                        txt.Text = factura.Estado;
                        break;
                    }
                }

                MessageBox.Show("Factura anulada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            return false;
        }

        public void RegistrarDetallesFacturaBDD(Factura factura)
        {
            cn = new Conexion();
            datosFac = new DatosFactura();
            string msj = cn.Conectar();
            string resp = "";
            if (msj[0] == '1')
            {
                foreach (DetalleFactura detalle in factura.Detalles)
                {
                    detalle.IdFactura = IdFacturaDB;
                    resp = datosFac.RegistrarDetalleFactura(detalle, cn.sql);
                    if (resp[0] == '1')
                    {
                        //MessageBox.Show("Detalle de Factura guardado en BDD");
                    }
                    else if (resp[0] == '0')
                    {
                        MessageBox.Show(resp);
                    }
                }
                cn.Desconectar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj);
            }
        }

        public void Conectar()
        {
            cn = new Conexion();
            string res = cn.Conectar();
            if (res[0] == '1')
            {
                MessageBox.Show("Conexión exitosa");
            }
            else if (res[0] == '0')
            {
                MessageBox.Show(res, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrarFacturaBDD(Factura factura)
        {
            cn = new Conexion();
            datosFac = new DatosFactura();
            string msj = cn.Conectar();
            string resp = "";
            if (msj[0] == '1')
            {
                resp = datosFac.RegistrarFactura(factura, cn.sql);
                if (resp[0] == '0')
                {
                    MessageBox.Show(resp);
                }
                else
                {
                    MessageBox.Show("Datos de Factura guardados en BDD");
                    IdFacturaDB = int.Parse(resp);
                    factura.IdFactura = IdFacturaDB;
                }
                cn.Desconectar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj);
            }
        }

        private void ConsultarFacturasBDD()
        {
            cn = new Conexion();
            datosFac = new DatosFactura();
            string msj = cn.Conectar();
            if (msj[0] == '1')
            {
                listaFacturas = datosFac.ConsultarFacturas(cn.sql);
                if(listaFacturas.Count == 0)
                {
                    MessageBox.Show("No hay facturas registradas en la base de datos.");
                }
                cn.Desconectar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj);
            }
        }

        private void EliminarFacturaBDD(string NumeroFactura)
        {
            cn = new Conexion();
            datosFac = new DatosFactura();
            string msj = cn.Conectar();
            if (msj[0] == '1')
            {
                datosFac.EliminarFactura(NumeroFactura, cn.sql);
                cn.Desconectar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj);
            }
        }
    }
}
