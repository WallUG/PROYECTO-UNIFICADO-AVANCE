using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DetalleFactura
    {
        public int IdDetalle { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double Subtotal { get; private set; }

        public DetalleFactura()
        {
        }

        public DetalleFactura(int idDetalle, string descripcion, int cantidad, double precioUnitario)
        {
            this.IdDetalle = idDetalle;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.PrecioUnitario = precioUnitario;
            CalcularSubtotal();
        }

        public void CalcularSubtotal()
        {
            Subtotal = Cantidad * PrecioUnitario;
        }
    }
}
