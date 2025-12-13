//CASTILLO MERA DANIEL FERNANDO
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    /// <summary>
    /// Administra la creación de datos para la relación EventoInmueble.
    /// Proporciona métodos para crear asignaciones de inmuebles a eventos.
    /// </summary>
    public class AdmEventoInmueble
    {
        // Crear la lista para almacenar los inmuebles asignados
        static List<EventoInmueble> lista = new List<EventoInmueble>();


        #region Métodos de Creación
        
        /// <summary>
        /// Crea un EventoInmueble con los datos proporcionados.
        /// </summary>
        /// <param name="inmueble">Inmueble a asignar</param>
        /// <param name="cantidad">Cantidad a asignar</param>
        /// <param name="fechaAsignacion">Fecha de la asignación</param>
        /// <returns>Objeto EventoInmueble creado</returns>
        public static EventoInmueble CrearEventoInmueble(Inmueble inmueble, int cantidad, DateTime fechaAsignacion)
        {
            EventoInmueble eventoInmueble = new EventoInmueble();
            eventoInmueble.inmueble = inmueble;
            eventoInmueble.cantidadInmueble = cantidad;
            eventoInmueble.fechaAsignacionInmueble = fechaAsignacion;
            
            return eventoInmueble;
        }

        // Método para obtener todos
        public static List<EventoInmueble> ObtenerTodosLosInmuebles()
        {
            return lista;
        }

        #endregion
    }
}