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

namespace Controlador
{
    public class AdmFactura
    {

        public static List<Factura> listaFacturas = new List<Factura>();
        public List<EventoInmueble> listaEventoInmueble = AdmEventoInmueble.ObtenerTodosLosInmuebles();
        public List<Cliente> listaCliente = AdmCliente.ObtenerTodosLosClientes();
        public List<Reserva> listaReserva = AdmReserva.ObtenerTodosLasReservas();
        public List<Evento> listaEvento = AdmEvento.ObtenerTodosLosEventos();

        public void BuscarCliente(ComboBox cmbIdEvento, GroupBox groupBoxCliente, string cedula)
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
                                    case "txtIdCliente":
                                        txt.Text = item.Id.ToString();
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
                                case "txtIdCliente":
                                    txt.Text = item.Cliente.Id.ToString();
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
                    llenarComboIdEvento(cmbIdEvento, item.Cliente.Id);
                    return;
                }
            }

            // Si llegó aquí, no encontró nada
            MessageBox.Show("No se encontró el cliente");
        }

        public void llenarComboIdEvento(ComboBox cmbIdEvento, int idCliente)
        {
            // Limpia los items antes de rellenar
            cmbIdEvento.Items.Clear();
            cmbIdEvento.SelectedIndex = -1;
            cmbIdEvento.Text = "";

            // Rellenar el ComboBox con los ID de evento del cliente
            foreach (Evento fac in listaEvento)
            {

                if (fac.Cliente.Id == idCliente)
                {
                    cmbIdEvento.Items.Add(fac.IdEvento);
                }
            }
        }

        public void cargarEventoPorId(GroupBox groupBoxEvento, DataGridView dgvDetallesFactura, int idEvento)
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

                    foreach (Reserva resr in listaReserva) {
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
                    return;
                }
            }
        }

        public void CargarTablaDetalle(DataGridView dgvDetallesFactura, int idEvento)
        {
            //dgvDocentes.DataSource=lista;
            int indice = 0;
            dgvDetallesFactura.Rows.Clear();
            foreach (Evento item in listaEvento)
            {
                if (item.IdEvento == idEvento) {
                    foreach (EventoInmueble eInm in item.EventoInmueble)
                    {
                        dgvDetallesFactura.Rows.Add();
                        dgvDetallesFactura.Rows[indice].Cells["colIdDetalle"].Value = eInm.inmueble.idInmueble;
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

            return $"{est}-{pto}-{sec}";
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
                        factura = new Factura(nuevoIndice, item);
                        listaFacturas.Add(factura);
                        MessageBox.Show("Descuento de: " + descuento);
                        factura.GenerarFactura(descuento);
                        factura.NumeroFactura = GenerarNumeroFacturaAuto(listaFacturas, 1, nuevoIndice);
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
                                    txt.Text = factura.Descuento;
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
            string numeroFacturas = dvgFacturas.Rows[indice].Cells["colIdFactura"].Value.ToString();
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar la factura seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                for (int i = 0; i < listaFacturas.Count; i++)
                {
                    if (listaFacturas[i].NumeroFactura == numeroFacturas)
                    {
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
                if(c is Button btn)
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
    }
}
