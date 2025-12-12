using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Reserva
    {
        //metodos get y set
        public int IdReserva { get; set; }
        public Evento evento { get; set; }
        public DateTime FechaReserva { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public string EstadoReserva { get; set; }
        public string TipoSolicitud { get; set; }

        //DATOS QUEMADOS DE LA CLASE EVENTO
        public string Cliente { get; set; }
        public string TipoEvento { get; set; }
        public string NombreEvento { get; set; }
        public string DescripcionEvento { get; set; }
        public int CantPersonas { get; set; }
        public string EstadoEvento { get; set; }
        
        private static int contadorID = 1;

        public Reserva()
        {
            IdReserva = contadorID;
            contadorID = contadorID + 1;
            EstadoReserva = "Confirmada";
            TipoSolicitud = "";

            //DATOS QUEMADOS DE LA CLASE EVENTO
            Cliente = "Leonardo Pluas Larrea";
            TipoEvento = "Fiesta";
            NombreEvento = "Fiesta Navideña Empresarial";
            DescripcionEvento = "Fiesta Navideña con el personal querido de la empresa para cerrar el año 2025 a lo grande";
            CantPersonas = 50;

        }

        public Reserva(int id, Evento even, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin, string tipoSolicitud)
        {
            IdReserva = id;
            evento = even;
            FechaReserva = fecha;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            TipoSolicitud = tipoSolicitud;
        }

        public void CrearReserva(DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin, string tipoSolicitud)
        {
            FechaReserva = fecha;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            TipoSolicitud = tipoSolicitud;
        }

        //Mostraar datos 
        public string MostrarReserva()
        {
            string mensaje = "\n===== RESERVA #" + IdReserva + " =====" +
                             "\n--- DATOS DEL EVENTO ---" +
                             "\nCliente: " + Cliente +
                             "\nTipo de Evento: " + TipoEvento +
                             "\nTipo de Solicitud: " + TipoSolicitud +
                             "\nNombre del Evento: " + NombreEvento +
                             "\nDescripcion: " + DescripcionEvento +
                             "\nCantidad de Personas: " + CantPersonas +
                             "\nFecha del evento: " + FechaReserva.ToString("dd/MM/yyyy") +
                             "\nHora Inicio: " + HoraInicio +
                             "\nHora Fin: " + HoraFin +
                             "\nEstado de la reserva: " + EstadoReserva;

            return mensaje;
        }
    }
}
