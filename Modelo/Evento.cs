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
        public int NumModificacionesEvento { get; set; }
        
        public List<EventoInmueble> EventoInmueble { get; set; }

        public Evento(int idEvento, Cliente cliente, string tipoEvento, string nombreEvento, string descripcionEvento, int numPersonasEvento, string direccionEvento, string estadoEvento, List<EventoInmueble> eventoInmueble)
        {
            this.IdEvento = idEvento;
            this.Cliente = cliente;
            this.TipoEvento = tipoEvento;
            this.NombreEvento = nombreEvento;
            this.DescripcionEvento = descripcionEvento;
            this.NumPersonasEvento = numPersonasEvento;
            this.DireccionEvento = direccionEvento;
            this.EstadoEvento = estadoEvento;
            this.EventoInmueble = eventoInmueble;
            this.NumModificacionesEvento = 0;
        }
        public Evento(int idEvento, int numEventos, Cliente cliente, string tipoEvento, string nombreEvento, string descripcionEvento, int numPersonasEvento, string direccionEvento, string estadoEvento, List<EventoInmueble> eventoInmueble)
        {
            this.IdEvento = idEvento;
            this.NumEventos = numEventos;
            this.Cliente = cliente;
            this.TipoEvento = tipoEvento;
            this.NombreEvento = nombreEvento;
            this.DescripcionEvento = descripcionEvento;
            this.NumPersonasEvento = numPersonasEvento;
            this.DireccionEvento = direccionEvento;
            this.EstadoEvento = estadoEvento;
            this.EventoInmueble = eventoInmueble;
            this.NumModificacionesEvento = 0;
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
    }
}