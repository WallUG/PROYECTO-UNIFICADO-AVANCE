        using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Factura
    {
        public int Secuencial { get; set; }
        public string IdFactura { get; set; }
        public int NumeroFactura { get; set; }
        public Evento Evento { get; set; }
        public DateTime FechaEmision { get; set; }
        public double SubTotal { get; set; }
        public double Iva { get; set; }
        public string Descuento { get; set; }
        public List<DetalleFactura> Detalles { get; set; }
        public string Estado { get; set; }
        public double Total { get; set; }

        public Factura(int numeroFactura, Evento evento, DateTime fechaEmision, double subTotal, double iva, double total)
        {
            this.NumeroFactura = numeroFactura;
            this.Evento = evento;
            this.FechaEmision = fechaEmision;
            this.SubTotal = subTotal;
            this.Iva = iva;
            this.Total = total;
            this.Estado = "Pendiente";
            this.Detalles = new List<DetalleFactura>();
        }

        public Factura(int numeroFactura, Evento evento)
        {
            this.NumeroFactura = numeroFactura;
            this.Evento = evento;
            this.SubTotal = 0;
            this.Total = 0;
            this.Descuento = "No aplica";
            this.Detalles = new List<DetalleFactura>();
            this.Estado = "Pendiente";
        }

        // Genera los detalles de factura a partir de los EventoInmueble
        public void GenerarDetallesFactura()
        {
            Detalles.Clear();
            int idDetalle = 1;

            if (Evento?.EventoInmueble != null)
            {
                foreach (EventoInmueble item in Evento.EventoInmueble)
                {
                    string descripcion = item.inmueble.nombreInmueble + " - " + item.inmueble.tipoInmueble;
                    DetalleFactura detalle = new DetalleFactura(
                        idDetalle,
                        descripcion,
                        item.cantidadInmueble,
                        item.inmueble.precioInmueble
                    );
                    Detalles.Add(detalle);
                    idDetalle++;
                }
            }
        }

        // Calcula el subtotal sumando los subtotales de cada detalle
        public void CalcularSubTotal()
        {
            SubTotal = 0;
            if (Detalles != null && Detalles.Count > 0)
            {
                foreach (DetalleFactura detalle in Detalles)
                {
                    SubTotal += detalle.Subtotal;
                }
            }
        }

        public void CalcularIVA()
        {
            Iva = SubTotal * 0.15; // IVA del 15%
        }

        public void CalcularTotal()
        {
            Total = SubTotal + Iva;
        }

        public void GenerarFactura(string descuento)
        {
            FechaEmision = DateTime.Now;
            GenerarDetallesFactura(); // Generar detalles autom�ticamente
            CalcularSubTotal();
            AplicarDescuento(descuento);
            CalcularIVA();
            CalcularTotal();
        }

        private void AplicarDescuento(string descuento)
        {
            try
            {
                if (descuento != "0.00" && descuento != "0" && !string.IsNullOrWhiteSpace(descuento))
                {
                    double porcentajeDescuento = double.Parse(descuento);
                    // Si el descuento es mayor a 1, asumimos que viene como porcentaje (ej: 10 para 10%)
                    // y lo convertimos a decimal (0.10)
                    if (porcentajeDescuento > 1)
                    {
                        porcentajeDescuento = porcentajeDescuento / 100.0;
                    }

                    // Validar que el descuento est� entre 0% y 100%
                    if (porcentajeDescuento >= 0 && porcentajeDescuento <= 1)
                    {
                        double descuentoMonto = SubTotal * porcentajeDescuento;
                        this.Descuento = descuentoMonto.ToString("F2"); // Guarda el monto del descuento
                        SubTotal -= descuentoMonto;
                    }
                    else
                    {
                        this.Descuento = "No aplica";
                    }
                }
            }catch(Exception ex)
            {
                
            }
        }

        public void EmitirFactura()
        {
            Estado = "Emitida";
        }

        public void AnularFactura()
        {
            Estado = "Anulada";
        }
    }
}
