using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosEvento
    {
        SqlCommand cmd = null;

        public string RegistrarEvento(Evento evento, SqlConnection sql)
        {
            string msj = "";
            string comando = "INSERT INTO Evento(NumEventos, IdCliente, TipoEvento, NombreEvento, DescripcionEvento," +
                "NumPersonasEvento, DireccionEvento, EstadoEvento, NumModificacionesEvento," +
                "FechaCreacion, Estado) VALUES(@NumEventos, @IdCliente, @TipoEvento, @NombreEvento," +
                "@DescripcionEvento, @NumPersonasEvento, @DireccionEvento, @EstadoEvento," +
                "@NumModificacionesEvento, @FechaCreacion, @Estado)";

            cmd = new SqlCommand(comando, sql);
            cmd.Parameters.AddWithValue("@NumEventos", evento.NumEventos);
            cmd.Parameters.AddWithValue("@IdCliente", evento.Cliente.Id);
            cmd.Parameters.AddWithValue("@TipoEvento", evento.TipoEvento);
            cmd.Parameters.AddWithValue("@NombreEvento", evento.NombreEvento);
            cmd.Parameters.AddWithValue("@DescripcionEvento", evento.DescripcionEvento);
            cmd.Parameters.AddWithValue("@NumPersonasEvento", evento.NumPersonasEvento);
            cmd.Parameters.AddWithValue("@DireccionEvento", evento.DireccionEvento);
            cmd.Parameters.AddWithValue("@EstadoEvento", evento.EstadoEvento);
            cmd.Parameters.AddWithValue("@NumModificacionesEvento", evento.NumModificacionesEvento);
            cmd.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
            cmd.Parameters.AddWithValue("@Estado", 'A'); //eliminado logico

            try
            {
                cmd.ExecuteNonQuery();
                msj = "Evento registrado correctamente!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                msj = "Error al registrar el evento: " + ex.Message;
            }
            return msj;
        }

        public List<Evento> ConsultarEventos(SqlConnection sql)
        {
            List<Evento> lista = new List<Evento>();
            Cliente cliente = new Cliente();
            Evento evento = null;
            string comando = "SELECT * FROM Evento WHERE estado = 'A'";
            cmd = new SqlCommand();
            SqlDataReader tablaVirtual = null;
            try
            {
                cmd.Connection = sql;
                cmd.CommandText = comando;
                tablaVirtual = cmd.ExecuteReader();

                while (tablaVirtual.Read())
                {
                    evento = new Evento(0, cliente, "", "", "", 0, "", "", new List<EventoInmueble>());
                    evento.IdEvento = Convert.ToInt32(tablaVirtual["IdEvento"]);
                    evento.NumEventos = Convert.ToInt32(tablaVirtual["NumEventos"]);
                    evento.Cliente = new DatosCliente().BuscarClientePorIDCliente(Convert.ToInt32(tablaVirtual["IdCliente"]), cmd.Connection);
                    evento.TipoEvento = tablaVirtual["TipoEvento"].ToString();
                    evento.NombreEvento = tablaVirtual["NombreEvento"].ToString();
                    evento.DescripcionEvento = tablaVirtual["DescripcionEvento"].ToString();
                    evento.NumPersonasEvento = Convert.ToInt32(tablaVirtual["NumPersonasEvento"]);
                    evento.DireccionEvento = tablaVirtual["DireccionEvento"].ToString();
                    evento.EstadoEvento = tablaVirtual["EstadoEvento"].ToString();
                    evento.NumModificacionesEvento = Convert.ToInt32(tablaVirtual["NumModificacionesEvento"]);
                    lista.Add(evento);
                }
                tablaVirtual.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }

        public void EliminarEventos(Evento evento, SqlConnection cn)
        {
            SqlCommand cmd = null;
            string comando = "UPDATE Evento SET Estado=@Estado WHERE NumEventos=@NumEventos";
            cmd = new SqlCommand(comando, cn);
            cmd.Parameters.AddWithValue("@NumEventos", evento.NumEventos);
            cmd.Parameters.AddWithValue("@Estado", 'I');
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Evento BuscarEventoPorIDEvento(int idEvento, SqlConnection cn)
        {
            List<Evento> lista = new List<Evento>();
            Cliente cliente = new Cliente();
            Evento evento = null;
            SqlCommand cmd = null;
            SqlDataReader tablaVirtual = null;

            string comando = "SELECT * FROM Evento WHERE IdEvento = @IdEvento AND Estado = 'A'";
            cmd = new SqlCommand(comando, cn);
            cmd.Parameters.AddWithValue("@IdEvento", idEvento);
            try
            {
                cmd.Connection = cn;
                cmd.CommandText = comando;
                tablaVirtual = cmd.ExecuteReader();
                if (tablaVirtual.Read())
                {
                    evento = new Evento(0, cliente, "", "", "", 0, "", "", new List<EventoInmueble>());
                    evento.IdEvento = Convert.ToInt32(tablaVirtual["IdEvento"]);
                    evento.NumEventos = Convert.ToInt32(tablaVirtual["NumEventos"]);
                    evento.Cliente = new DatosCliente().BuscarClientePorIDCliente(Convert.ToInt32(tablaVirtual["IdCliente"]), cn);
                    evento.TipoEvento = tablaVirtual["TipoEvento"].ToString();
                    evento.NombreEvento = tablaVirtual["NombreEvento"].ToString();
                    evento.DescripcionEvento = tablaVirtual["DescripcionEvento"].ToString();
                    evento.NumPersonasEvento = Convert.ToInt32(tablaVirtual["NumPersonasEvento"]);
                    evento.DireccionEvento = tablaVirtual["DireccionEvento"].ToString();
                    evento.EstadoEvento = tablaVirtual["EstadoEvento"].ToString();
                    evento.NumModificacionesEvento = Convert.ToInt32(tablaVirtual["NumModificacionesEvento"]);
                    lista.Add(evento);
                }
                tablaVirtual.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return evento;
        }
    }
}