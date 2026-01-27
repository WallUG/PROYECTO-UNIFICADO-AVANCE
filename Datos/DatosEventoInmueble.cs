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
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }

        public string RegistrarEventoInmueble(EventoInmueble eventoInmueble, SqlConnection sql)
        {
            string msj = "";
            string comando = "INSERT INTO EventoInmueble(CantidadInmueble, FechaAsignacionInmueble, Estado)"+
                " VALUES(@CantidadInmueble, @FechaAsignacionInmueble, @Estado)";
            cmd = new SqlCommand(comando, sql);
            cmd.Parameters.AddWithValue("@CantidadInmueble", eventoInmueble.cantidadInmueble);
            cmd.Parameters.AddWithValue("@FechaAsignacionInmueble", eventoInmueble.fechaAsignacionInmueble.ToString("yyy-MM-dd"));
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