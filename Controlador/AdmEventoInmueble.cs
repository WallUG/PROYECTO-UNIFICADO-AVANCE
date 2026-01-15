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
        static List<EventoInmueble> listaEventoInmueblesTemp = new List<EventoInmueble>();

        public static string[] ObtenerTiposInmueble()
        {
            return AdmInmueble.ObtenerTiposInmueble();
        }

        public static EventoInmueble CrearEventoInmueble(Inmueble inmueble, int cantidad, DateTime fechaAsignacion)
        {
            EventoInmueble eventoInmueble = new EventoInmueble();
            eventoInmueble.inmueble = inmueble;
            eventoInmueble.cantidadInmueble = cantidad;
            eventoInmueble.fechaAsignacionInmueble = fechaAsignacion;
            
            return eventoInmueble;
        }

        public static void AgregarInmuebleTemp(EventoInmueble eventoInmueble)
        {
            bool existe = false;
            for (int i = 0; i < listaEventoInmueblesTemp.Count; i++)
            {
                if (listaEventoInmueblesTemp[i].ObtenerNumInmuebles() == eventoInmueble.ObtenerNumInmuebles())
                {
                    listaEventoInmueblesTemp[i] = eventoInmueble;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                listaEventoInmueblesTemp.Add(eventoInmueble);
            }
        }

        public static void EliminarInmuebleTemp(string numeroInmueble)
        {
            for (int i = listaEventoInmueblesTemp.Count - 1; i >= 0; i--)
            {
                if (listaEventoInmueblesTemp[i].ObtenerNumInmuebles() == numeroInmueble)
                {
                    listaEventoInmueblesTemp.RemoveAt(i);
                    break;
                }
            }
        }

        public static List<EventoInmueble> ObtenerTodosLosInmueblesTemp()
        {
            return listaEventoInmueblesTemp;
        }

        public static void LimpiarInmueblesTemp()
        {
            listaEventoInmueblesTemp.Clear();
        }

        public static EventoInmueble ObtenerInmuebleTempPorNumero(string numeroInmueble)
        {
            for (int i = 0; i < listaEventoInmueblesTemp.Count; i++)
            {
                if (listaEventoInmueblesTemp[i].ObtenerNumInmuebles() == numeroInmueble)
                {
                    return listaEventoInmueblesTemp[i];
                }
            }
            return null;
        }

        public static int ObtenerCantidadInmueblesTemp()
        {
            return listaEventoInmueblesTemp.Count;
        }
    }
}