using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Datos
{
    public class DatosReserva
    {
        SqlCommand cmd = null;
        DatosEvento datosEvento = new DatosEvento();
        public List<Reserva> ConsultarReservas(SqlConnection cn)
        {
            List<Reserva> lista = new List<Reserva>();
            Reserva reserva = null;
            string comando = "SELECT * FROM Reserva WHERE Estado='A'";
            cmd = new SqlCommand();
            SqlDataReader tablaVirtual = null;
            try
            {
                cmd.Connection = cn;
                cmd.CommandText = comando;
                tablaVirtual = cmd.ExecuteReader();
                while (tablaVirtual.Read())
                {
                    reserva = new Reserva();
                    reserva.evento = datosEvento.BuscarEventoPorIDEvento(Convert.ToInt32(tablaVirtual["IdEvento"]), cmd.Connection);
                    reserva.IdReserva = Convert.ToInt32(tablaVirtual["idReserva"]);
                    reserva.CodigoReserva = tablaVirtual["CodigoReserva"].ToString();
                    reserva.FechaReserva = DateTime.Parse(tablaVirtual["FechaReserva"].ToString());
                    reserva.HoraInicio = (TimeSpan)(tablaVirtual["HoraInicio"]);
                    reserva.HoraFin = (TimeSpan)(tablaVirtual["HoraFin"]);
                    reserva.EstadoReserva = tablaVirtual["EstadoReserva"].ToString();
                    reserva.TipoSolicitud = tablaVirtual["TipoSolicitud"].ToString();
                    reserva.Estado = tablaVirtual["Estado"].ToString();
                    lista.Add(reserva);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }

        public string RegistrarReserva(Reserva nuevaReserva, SqlConnection cn)
        {
            string msj = "";
            string comando = "INSERT INTO Reserva(CodigoReserva,IdEvento" +
                ",FechaReserva,HoraInicio,HoraFin,EstadoReserva,TipoSolicitud,FechaCreacion,Estado) VALUES(@CodigoReserva, @IdEvento," +
                "@FechaReserva, @HoraInicio, @HoraFin, @EstadoReserva, @TipoSolicitud, @FechaCreacion, @Estado)";
            cmd = new SqlCommand(comando, cn);
            cmd.Parameters.AddWithValue("@CodigoReserva", nuevaReserva.CodigoReserva);
            cmd.Parameters.AddWithValue("@IdEvento", nuevaReserva.evento.IdEvento);
            cmd.Parameters.AddWithValue("@FechaReserva", nuevaReserva.FechaReserva.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@HoraInicio", nuevaReserva.HoraInicio);
            cmd.Parameters.AddWithValue("@HoraFin", nuevaReserva.HoraFin);
            cmd.Parameters.AddWithValue("@EstadoReserva", nuevaReserva.EstadoReserva);
            cmd.Parameters.AddWithValue("@TipoSolicitud", nuevaReserva.TipoSolicitud);
            cmd.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
            cmd.Parameters.AddWithValue("@Estado", 'A'); //Eliminado lógico
            try
            {
                cmd.ExecuteNonQuery();
                msj = "1";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                msj = "0" + ex.Message;

            }
            return msj;
        }
        public string EliminarReservaBBD(string CodigoReserva, SqlConnection cn)
        {
            string msj = "";
            string comando = "UPDATE Reserva SET Estado=@Estado WHERE CodigoReserva=@CodigoReserva"; //Eliminado LOGICO
            cmd = new SqlCommand(comando, cn);
            cmd.Parameters.AddWithValue("@CodigoReserva", CodigoReserva);
            cmd.Parameters.AddWithValue("@Estado", 'I'); //Eliminado logico 'I' inactivo
            try
            {
                cmd.ExecuteNonQuery();
                msj = "1";
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                msj = "0" + ex.Message;
            }
            return msj;
        }
    }
}
