//CASTILLO MERA DANIEL FERNANDO
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class AdmEventoInmueble
    {
        static List<EventoInmueble> listaEventoInmuebles = new List<EventoInmueble>();

        public static EventoInmueble CrearEventoInmueble(Inmueble inmueble, int cantidad, DateTime fechaAsignacion)
        {
            EventoInmueble eventoInmueble = new EventoInmueble();
            eventoInmueble.inmueble = inmueble;
            eventoInmueble.cantidadInmueble = cantidad;
            eventoInmueble.fechaAsignacionInmueble = fechaAsignacion;
            
            return eventoInmueble;
        }

        public static List<EventoInmueble> ObtenerTodosLosInmuebles()
        {
            return listaEventoInmuebles;
        }

    }
}