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
            if (inmueble != null)
            {
                return inmueble.precioInmueble * cantidadInmueble;
            }
            return 0;
        }

        // Metodo para obtener el ID del inmueble asociado
        public int ObtenerIdInmueble()
        {
            if (inmueble != null)
            {
                return inmueble.idInmueble;
            }
            return 0;
        }

        // Metodo para obtener el nombre del inmueble asociado
        public string ObtenerNombreInmueble()
        {
            if (inmueble != null)
            {
                return inmueble.nombreInmueble;
            }
            return "";
        }

        // Metodo para obtener la cantidad disponible del inmueble asociado
        public int ObtenerCantidadDisponibleInmueble()
        {
            if (inmueble != null)
            {
                return inmueble.cantidadInmuebleDisponible;
            }
            return 0;
        }

        // Metodo para obtener el tipo del inmueble asociado
        public string ObtenerTipoInmueble()
        {
            if (inmueble != null)
            {
                return inmueble.tipoInmueble;
            }
            return "";
        }

        // Metodo para obtener el precio del inmueble asociado
        public double ObtenerPrecioInmueble()
        {
            if (inmueble != null)
            {
                return inmueble.precioInmueble;
            }
            return 0;
        }

        // Metodo para verificar si el inmueble esta disponible
        public bool EstaDisponible()
        {
            if (inmueble != null)
            {
                return inmueble.inmuebleDisponible;
            }
            return false;
        }

        // Metodo para verificar si la cantidad a asignar es valida (menor o igual a la disponible)
        public bool EsCantidadValida(int cantidadSolicitada)
        {
            if (inmueble != null)
            {
                return cantidadSolicitada > 0 && cantidadSolicitada <= inmueble.cantidadInmuebleDisponible;
            }
            return false;
        }

        // Metodo para actualizar la cantidad asignada
        public void ActualizarCantidadAsignada(int nuevaCantidad)
        {
            cantidadInmueble = nuevaCantidad;
        }

        // Metodo para actualizar la fecha de asignacion
        public void ActualizarFechaAsignacion(DateTime nuevaFecha)
        {
            fechaAsignacionInmueble = nuevaFecha;
        }
    }
}
