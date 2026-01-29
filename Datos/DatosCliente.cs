using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosCliente
    {
        public string RegistrarCLiente(Cliente cliente, SqlConnection cn)
        {
            SqlCommand cmd = null;

            string msj = "";
            string comando = "INSERT INTO Cliente(NumeroCliente,CedulaCliente,Nombres,Apellidos,NumeroCelular, Correo, Direccion, Estado" +
                ") VALUES(@NumeroCliente,@CedulaCliente,@Nombres,@Apellidos,@NumeroCelular,@Correo," +
                "@Direccion,@Estado)";

            cmd = new SqlCommand(comando, cn);
            cmd.Parameters.AddWithValue("@NumeroCliente", cliente.NumeroCliente);
            cmd.Parameters.AddWithValue("@CedulaCliente", cliente.CedulaORuc);
            cmd.Parameters.AddWithValue("@Nombres", cliente.Nombre);
            cmd.Parameters.AddWithValue("@Apellidos", cliente.Apellido);
            cmd.Parameters.AddWithValue("@NumeroCelular", cliente.Telefono);
            cmd.Parameters.AddWithValue("@Correo", cliente.CorreoElectronico);
            cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
            cmd.Parameters.AddWithValue("@Estado", 'A');

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

        public void EliminarCliente(Cliente cliente, SqlConnection cn)
        {
            SqlCommand cmd = null;
            string comando = "UPDATE Cliente SET Estado=@Estado WHERE CedulaCliente=@CedulaCliente";
            cmd = new SqlCommand(comando, cn);
            cmd.Parameters.AddWithValue("@CedulaCliente", cliente.CedulaORuc);
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

        public List<Cliente> ListarClientes(SqlConnection cn)
        {
            SqlCommand cmd = null;
            SqlDataReader TablaVirtual = null;
            List<Cliente> lista = new List<Cliente>();
            string comando = "SELECT * FROM Cliente WHERE Estado = 'A'";
            cmd = new SqlCommand(comando, cn);
            try
            {
                cmd.Connection = cn;
                cmd.CommandText = comando;
                TablaVirtual = cmd.ExecuteReader();
                while (TablaVirtual.Read())
                {
                    Cliente cliente = new Cliente(0,"","","","","","");
                    cliente.Id = Convert.ToInt32(TablaVirtual["IdCliente"]);
                    cliente.CedulaORuc = TablaVirtual["CedulaCliente"].ToString().Trim();
                    cliente.Nombre = TablaVirtual["Nombres"].ToString().Trim();
                    cliente.Apellido = TablaVirtual["Apellidos"].ToString().Trim();
                    cliente.Telefono = TablaVirtual["NumeroCelular"].ToString().Trim();
                    cliente.CorreoElectronico = TablaVirtual["Correo"].ToString().Trim();
                    cliente.Direccion = TablaVirtual["Direccion"].ToString().Trim();
                    lista.Add(cliente);
                }
                TablaVirtual.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }

        //Buscar cliente por cédula para daniel
        public Cliente BuscarClientePorIDCliente(int idCliente, SqlConnection cn)
        {
            SqlCommand cmd = null;
            SqlDataReader TablaVirtual = null;
            Cliente cliente = null;
            string comando = "SELECT * FROM Cliente WHERE IdCliente = @IdCliente AND Estado = 'A'";
            cmd = new SqlCommand(comando, cn);
            cmd.Parameters.AddWithValue("@IdCliente", idCliente);
            try
            {
                cmd.Connection = cn;
                cmd.CommandText = comando;
                TablaVirtual = cmd.ExecuteReader();
                if (TablaVirtual.Read())
                {
                    cliente = new Cliente(0, "", "", "", "", "", "");
                    cliente.Id = Convert.ToInt32(TablaVirtual["IdCliente"]);
                    cliente.NumeroCliente = Convert.ToInt32(TablaVirtual["NumeroCliente"]);
                    cliente.CedulaORuc = TablaVirtual["CedulaCliente"].ToString().Trim();
                    cliente.Nombre = TablaVirtual["Nombres"].ToString().Trim();
                    cliente.Apellido = TablaVirtual["Apellidos"].ToString().Trim();
                    cliente.Telefono = TablaVirtual["NumeroCelular"].ToString().Trim();
                    cliente.CorreoElectronico = TablaVirtual["Correo"].ToString().Trim();
                    cliente.Direccion = TablaVirtual["Direccion"].ToString().Trim();
                }
                TablaVirtual.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cliente;
        }
    }
}