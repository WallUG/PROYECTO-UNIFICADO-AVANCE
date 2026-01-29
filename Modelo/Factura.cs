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
        public int IdFactura { get; set; }
        public string NumeroFactura { get; set; }
        public Evento Evento { get; set; }
        public DateTime FechaEmision { get; set; }
        public double SubTotal { get; set; }
        public double Iva { get; set; }
        public int Descuento { get; set; }
        public float DescuentoAplicado { get; set; }
        public List<DetalleFactura> Detalles { get; set; }
        public string Estado { get; set; }
        public double Total { get; set; }

        public Factura(int idFactura, Evento evento, DateTime fechaEmision, double subTotal, double iva, double total)
        {
            this.IdFactura = idFactura;
            this.Evento = evento;
            this.FechaEmision = fechaEmision;
            this.SubTotal = subTotal;
            this.Iva = iva;
            this.Total = total;
            this.Estado = "Pendiente";
            this.Detalles = new List<DetalleFactura>();
        }

        public Factura( Evento evento)
        {
            //this.IdFactura = idFactura;
            this.Evento = evento;
            this.SubTotal = 0;
            this.Total = 0;
            this.Descuento = 0;
            this.Detalles = new List<DetalleFactura>();
            this.Estado = "Pendiente";
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
            AplicarDescuento(descuento);
            CalcularIVA();
            CalcularTotal();
        }

        public void AplicarDescuento(string descuento)
        {
            try
            {
                if (descuento != "0.00" && descuento != "0" && !string.IsNullOrWhiteSpace(descuento))
                {

                    double porcentajeDescuento = float.Parse(descuento);
                    this.Descuento = (int)porcentajeDescuento; // Guarda el porcentaje del descuento

                    if (porcentajeDescuento > 1)
                    {
                        porcentajeDescuento = porcentajeDescuento / 100.0;
                    }

                    if (porcentajeDescuento >= 0 && porcentajeDescuento <= 1)
                    {
                        double descuentoMonto = SubTotal * porcentajeDescuento;
                        this.DescuentoAplicado = (int)descuentoMonto; // Guarda el monto del descuento
                        SubTotal -= descuentoMonto;
                    }
                    else
                    {
                        this.Descuento = 0;
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
