using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    // Clase EventoInmueble (clase dependiente)
    public class EventoInmueble
    {
        // Atributos
        public Inmueble inmueble;
        public int cantidadInmueble;
        public DateTime fechaAsignacionInmueble;

        // Constructor vacío
        public EventoInmueble() { }

        // Constructor con parámetros
        public EventoInmueble(Inmueble inm, int cantidad, DateTime fecha)
        {
            inmueble = inm;
            cantidadInmueble = cantidad;
            fechaAsignacionInmueble = fecha;
        }

        // Metodo asignarCantidadInmueble
        public bool AsignarCantidadInmueble()
        {
            if (inmueble == null)
            {
                return false;
            }

            if (inmueble.cantidadInmuebleDisponible >= cantidadInmueble && cantidadInmueble > 0)
            {
                inmueble.cantidadInmuebleDisponible = inmueble.cantidadInmuebleDisponible - cantidadInmueble;
                return true;
            }
            return false;
        }

        // Metodo mostrarCantidadInmueble
        public void MostrarCantidadInmueble()
        {
            if (inmueble != null)
            {
                Console.WriteLine("Inmueble: " + inmueble.nombreInmueble);
                Console.WriteLine("Cantidad asignada: " + cantidadInmueble);
                Console.WriteLine("Fecha asignacion: " + fechaAsignacionInmueble);
            }
        }

        public double CalcularMontoInmueble()
        {
            return inmueble.precioInmueble * cantidadInmueble;
        }
    }
}
