using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosEventoInmueble
    {
        SqlCommand cmd = null;

        public List<EventoInmueble> ConsultarEventosInmuebles(SqlConnection sql)
        {
            List<EventoInmueble> lista = new List<EventoInmueble>();
            EventoInmueble eventoInmueble = null;
            string comando = "SELECT * FROM EventoInmueble WHERE estado = 'A'";
            cmd = new SqlCommand();
            SqlDataReader tablaVirtual = null;
            try
            {
                cmd.Connection = sql;
                cmd.CommandText = comando;
                tablaVirtual = cmd.ExecuteReader();
                while (tablaVirtual.Read())
                {
                    eventoInmueble = new EventoInmueble();
                    eventoInmueble.cantidadInmueble = Convert.ToInt32(tablaVirtual["CantidadInmueble"]);
                    eventoInmueble.fechaAsignacionInmueble = Convert.ToDateTime(tablaVirtual["FechaAsignacionInmueble"]);
                    lista.Add(eventoInmueble);
                }
                tablaVirtual.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                if (tablaVirtual != null && !tablaVirtual.IsClosed)
                {
                    tablaVirtual.Close();
                }
            }
            return lista;
        }

        public EventoInmueble ConsultarEventosInmueblesPorId(int IdEvento, SqlConnection sql)
        {
            EventoInmueble eventoInmueble = null;
            string comando = "SELECT * FROM EventoInmueble WHERE IdEvento = @IdEvento AND estado = 'A'";
            cmd = new SqlCommand();
            SqlDataReader tablaVirtual = null;
            try
            {
                cmd.Connection = sql;
                cmd.CommandText = comando;
                cmd.Parameters.AddWithValue("@IdEvento", IdEvento);
                tablaVirtual = cmd.ExecuteReader();
                
                if (tablaVirtual.Read())
                {
                    eventoInmueble = new EventoInmueble();
                    eventoInmueble.idInmuebleEvento = Convert.ToInt32(tablaVirtual["IdInmueble"]);
                    eventoInmueble.cantidadInmueble = Convert.ToInt32(tablaVirtual["CantidadInmueble"]);
                    eventoInmueble.fechaAsignacionInmueble = Convert.ToDateTime(tablaVirtual["FechaAsignacionInmueble"]);
                    
                    // Cerrar el DataReader antes de hacer otra consulta
                    int idInmueble = eventoInmueble.idInmuebleEvento;
                    tablaVirtual.Close();
                    
                    // Ahora buscar el inmueble
                    DatosInmueble datosInmueble = new DatosInmueble();
                    Inmueble inmueble = datosInmueble.BuscarInmueblePorIdInmueble(idInmueble, sql);
                    
                    if (inmueble != null)
                    {
                        eventoInmueble.listaInmuebles.Add(inmueble);
                    }
                }
                else
                {
                    if (tablaVirtual != null && !tablaVirtual.IsClosed)
                    {
                        tablaVirtual.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                if (tablaVirtual != null && !tablaVirtual.IsClosed)
                {
                    tablaVirtual.Close();
                }
            }
            
            return eventoInmueble;
        }

        public string RegistrarEventoInmueble(int idEvento, EventoInmueble eventoInmueble, SqlConnection sql)
        {
            string msj = "";
            int test = 1;
            string comando = "INSERT INTO EventoInmueble(IdEvento, IdInmueble,CantidadInmueble, FechaAsignacionInmueble, Estado)" +
                " VALUES(@IdEvento, @IdInmueble ,@CantidadInmueble, @FechaAsignacionInmueble, @Estado)";
            cmd = new SqlCommand(comando, sql);
            cmd.Parameters.AddWithValue("@IdEvento", idEvento);
            cmd.Parameters.AddWithValue("@IdInmueble", eventoInmueble.inmueble.idInmueble);
            cmd.Parameters.AddWithValue("@CantidadInmueble", eventoInmueble.cantidadInmueble);
            cmd.Parameters.AddWithValue("@FechaAsignacionInmueble", DateTime.Now);
            cmd.Parameters.AddWithValue("@Estado", 'A'); //eliminado logico

            try
            {
                cmd.ExecuteNonQuery();
                msj = "EventoInmueble registrado correctamente!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                msj = "Error al registrar el eventoInmueble: " + ex.Message;
            }
            return msj;
        }
    }
}