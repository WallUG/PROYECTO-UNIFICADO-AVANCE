using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos//TODAS LAS SENTENCIAS
{
    public class DatosInmueble//Debe ser public
    {
        SqlCommand cmd = null;

        public List<Inmueble> ConsultarInmueble(Inmueble inmu, SqlConnection sql)//nuevo (SELECT)
        {
            List<Inmueble> inmuebleL = new List<Inmueble>();
            Inmueble inmueble = null;
            string comando = "SELECT * FROM Inmueble WHERE Estado='A'";
            cmd = new SqlCommand();//creo el comando
            SqlDataReader tablaVirtual = null;
            try
            {
                cmd.Connection = sql;
                cmd.CommandText = comando;
                tablaVirtual = cmd.ExecuteReader();

                while (tablaVirtual.Read())
                {
                    inmueble = new Inmueble("", "", "", 0, 0.0);
                    inmueble.idInmueble = Convert.ToInt32(tablaVirtual["idInmueble"]);
                    inmueble.nombreInmueble = tablaVirtual["nombreInmueble"].ToString().Trim();
                    inmueble.tipoInmueble = tablaVirtual["tipoInmueble"].ToString().Trim();
                    inmueble.cantidadInmuebleDisponible = Convert.ToInt32(tablaVirtual["cantidadInmuebleDisponible"]);
                    inmueble.precioInmueble = Convert.ToDouble(tablaVirtual["precioInmueble"]);
                    inmueble.inmuebleDisponible = Convert.ToBoolean(tablaVirtual["inmuebleDisponible"]);
                    inmueble.numeroInmueble = tablaVirtual["numeroInmueble"].ToString().Trim();
                    //inmueble.Estado = tablaVirtual["Estado"].ToString();//ESTADO
                    inmuebleL.Add(inmueble);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al consultar el inmueble: " + ex.Message);
            }
            return inmuebleL;
        }


        public void EliminarCliente(Inmueble inmu, SqlConnection sql)
        {
            SqlCommand cmd = null;
            string comando = "UPDATE Inmueble SET Estado=@Estado WHERE numeroInmueble=@numeroInmueble";
            cmd = new SqlCommand(comando, sql);
            cmd.Parameters.AddWithValue("@numeroInmueble", inmu.numeroInmueble);
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


        public string RegistrarInmueble(Inmueble inmu, SqlConnection sql)//nuevo (INSERT)
        {
            string msj = "";
            string comando = "INSERT INTO Inmueble (nombreInmueble, tipoInmueble, cantidadInmuebleDisponible, precioInmueble, inmuebleDisponible, numeroInmueble, Estado)" +
                             "VALUES (@nombreInmueble, @tipoInmueble, @cantidadInmuebleDisponible, @precioInmueble, @inmuebleDisponible, @numeroInmueble, @Estado)";//ESTADO
            cmd = new SqlCommand(comando, sql);
            try
            {
                cmd.Parameters.AddWithValue("@nombreInmueble", inmu.nombreInmueble);
                cmd.Parameters.AddWithValue("@tipoInmueble", inmu.tipoInmueble);
                cmd.Parameters.AddWithValue("@cantidadInmuebleDisponible", inmu.cantidadInmuebleDisponible);
                cmd.Parameters.AddWithValue("@precioInmueble", inmu.precioInmueble);
                cmd.Parameters.AddWithValue("@inmuebleDisponible", inmu.inmuebleDisponible);
                cmd.Parameters.AddWithValue("@numeroInmueble", inmu.numeroInmueble);
                cmd.Parameters.AddWithValue("@Estado", 'A');//ESTADO

                //cmd.Parameters.AddWithValue("@Estado", inmu.Estado);//ESTADO
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    msj = "1- Inmueble registrado exitosamente.";
                }
                else
                {
                    msj = "0- No se pudo registrar el inmueble.";
                }
            }
            catch (Exception e)
            {
                msj = "0- Error al registrar el inmueble: " + e.Message;
            }
            return msj;
        }


        //METODO PARA BDD - BUSCAR INMUEBLE POR NUMERO PARA EVENTO
        public Inmueble BuscarInmueblePorIdInmueble(int idInmueble, SqlConnection sql)
        {
            SqlCommand cmd = null;
            SqlDataReader TablaVirtual = null;
            Inmueble inmueble = null;

            string comando = "SELECT * FROM Inmueble WHERE idInmueble = @idInmueble AND Estado = 'A'";

            cmd = new SqlCommand(comando, sql);
            cmd.Parameters.AddWithValue("@idInmueble", idInmueble);

            try
            {
                cmd.Connection = sql;

                TablaVirtual = cmd.ExecuteReader();

                if (TablaVirtual.Read())
                {
                    inmueble = new Inmueble("", "", "",0,0.0);

                    inmueble.idInmueble = Convert.ToInt32(TablaVirtual["idInmueble"]);
                    inmueble.numeroInmueble = TablaVirtual["numeroInmueble"].ToString().Trim();
                    inmueble.nombreInmueble = TablaVirtual["nombreInmueble"].ToString().Trim();
                    inmueble.tipoInmueble = TablaVirtual["tipoInmueble"].ToString().Trim();

                    inmueble.cantidadInmuebleDisponible = Convert.ToInt32(TablaVirtual["cantidadInmuebleDisponible"]);
                    inmueble.precioInmueble = Convert.ToDouble(TablaVirtual["precioInmueble"]);
                    inmueble.inmuebleDisponible = Convert.ToBoolean(TablaVirtual["inmuebleDisponible"]);

                    //inmueble.Estado = TablaVirtual["Estado"].ToString().Trim();
                }
                TablaVirtual.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar inmueble: " + ex.Message);
            }

            return inmueble;
        }





    }
}
