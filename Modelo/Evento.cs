//CASTILLO MERA DANIEL FERNANDO
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Evento
    {
        public int IdEvento { get; set; }
        
        public string TipoEvento { get; set; }
        public Cliente Cliente { get; set; }
        public string NombreEvento { get; set; }
        public string DescripcionEvento { get; set; }
        public int NumPersonasEvento { get; set; }
        public string DireccionEvento { get; set; }
        public string EstadoEvento { get; set; }
        
        public List<EventoInmueble> EventoInmueble { get; set; }
        
        //constructor con parametros
        public Evento(int idEvento, Cliente cliente, string tipoEvento, string nombreEvento, string descripcionEvento, int numPersonasEvento, string direccionEvento, string estadoEvento, List<EventoInmueble> eventoInmueble)
        {
            IdEvento = idEvento;
            Cliente = cliente;
            TipoEvento = tipoEvento;
            NombreEvento = nombreEvento;
            DescripcionEvento = descripcionEvento;
            NumPersonasEvento = numPersonasEvento;
            DireccionEvento = direccionEvento;
            EstadoEvento = estadoEvento;
            EventoInmueble = eventoInmueble;

        }
        
        public string ObtenerNombreCliente()
        {
            if (Cliente != null)
            {
                return Cliente.ObtenerNombreCompleto();
            }
            return "Sin cliente asignado";
        }
        
        public int ObtenerTotalInmuebles()
        {
            int total = 0;
            if (EventoInmueble != null)
            {
                foreach (EventoInmueble ei in EventoInmueble)
                {
                    total = total + ei.cantidadInmueble;
                }
            }
            return total;
        }
        
        public string mostrarEvento()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("=== INFORMACIÓN DEL EVENTO ===");
            info.AppendLine("ID Evento: " + IdEvento.ToString());
            info.AppendLine("Cliente: " + ObtenerNombreCliente());
            info.AppendLine("Tipo de Evento: " + TipoEvento);
            info.AppendLine("Nombre del Evento: " + NombreEvento);
            info.AppendLine("Descripción: " + DescripcionEvento);
            info.AppendLine("Número de Personas: " + NumPersonasEvento.ToString());
            info.AppendLine("Dirección: " + DireccionEvento);
            info.AppendLine("Estado: " + EstadoEvento);
            return info.ToString();
        }
    }
}