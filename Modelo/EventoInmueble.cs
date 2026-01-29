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
        public int idInmuebleEvento { get; set; }

        public int idEvento { get; set; }
        public Inmueble inmueble { get; set; }
        public int cantidadInmueble { get; set; }
        public DateTime fechaAsignacionInmueble { get; set; }
        public List<Inmueble> listaInmuebles = new List<Inmueble>();
        public int cantidadAsignada;
        public DateTime fechaAsignacion;

        public EventoInmueble(Inmueble inmueble, int cantidadInmueble, DateTime fechaAsignacionInmueble, List<Inmueble> listaInmuebles)
        {
            this.inmueble = inmueble;
            this.cantidadInmueble = cantidadInmueble;
            this.fechaAsignacionInmueble = fechaAsignacionInmueble;
            this.listaInmuebles = listaInmuebles;
        }

        public EventoInmueble(Inmueble inmueble, int cantidadAsignada, DateTime fechaAsignacion)
        {
            this.idEvento = idEvento;
            this.inmueble = inmueble;
            this.cantidadAsignada = cantidadAsignada;
            this.fechaAsignacion = fechaAsignacion;
        }

        public EventoInmueble()
        {
        }

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

        public string ObtenerNumInmuebles()
        {
            if (inmueble != null)
            {
                return inmueble.numeroInmueble;
            }
            return "";
        }

        public string ObtenerNombreInmueble()
        {
            if (inmueble != null)
            {
                return inmueble.nombreInmueble;
            }
            return "";
        }

        public int ObtenerCantidadDisponibleInmueble()
        {
            if (inmueble != null)
            {
                return inmueble.cantidadInmuebleDisponible;
            }
            return 0;
        }

        public string ObtenerTipoInmueble()
        {
            if (inmueble != null)
            {
                return inmueble.tipoInmueble;
            }
            return "";
        }

        public double ObtenerPrecioInmueble()
        {
            if (inmueble != null)
            {
                return inmueble.precioInmueble;
            }
            return 0;
        }

        public bool EstaDisponible()
        {
            if (inmueble != null)
            {
                return inmueble.inmuebleDisponible;
            }
            return false;
        }

        public bool EsCantidadValida(int cantidadSolicitada)
        {
            if (inmueble != null)
            {
                return cantidadSolicitada > 0 && cantidadSolicitada <= inmueble.cantidadInmuebleDisponible;
            }
            return false;
        }

        public void ActualizarCantidadAsignada(int nuevaCantidad)
        {
            cantidadInmueble = nuevaCantidad;
        }

        public void ActualizarFechaAsignacion(DateTime nuevaFecha)
        {
            fechaAsignacionInmueble = nuevaFecha;
        }
    }
}