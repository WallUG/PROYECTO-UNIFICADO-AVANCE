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
        public int NumEventos { get; set; }
        public string TipoEvento { get; set; }
        public Cliente Cliente { get; set; }
        public string NombreEvento { get; set; }
        public string DescripcionEvento { get; set; }
        public int NumPersonasEvento { get; set; }
        public string DireccionEvento { get; set; }
        public string EstadoEvento { get; set; }
        
        public List<EventoInmueble> EventoInmueble { get; set; }

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
        public Evento(int idEvento, int numEventos, Cliente cliente, string tipoEvento, string nombreEvento, string descripcionEvento, int numPersonasEvento, string direccionEvento, string estadoEvento, List<EventoInmueble> eventoInmueble)
        {
            IdEvento = idEvento;
            NumEventos = numEventos;
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
                for (int i = 0; i < EventoInmueble.Count; i++)
                {
                    total = total + EventoInmueble[i].cantidadInmueble;
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
            
            // Mostrar información de inmuebles asignados
            if (EventoInmueble != null && EventoInmueble.Count > 0)
            {
                info.AppendLine("=== INMUEBLES ASIGNADOS ===");
                for (int i = 0; i < EventoInmueble.Count; i++)
                {
                    EventoInmueble ei = EventoInmueble[i];
                    if (ei.inmueble != null)
                    {
                        info.AppendLine("Inmueble: " + ei.inmueble.nombreInmueble + " - Cantidad: " + ei.cantidadInmueble.ToString());
                    }
                }
            }
            
            return info.ToString();
        }
    }
}