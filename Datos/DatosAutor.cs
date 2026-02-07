using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
        public class DatosAutor
        {
            SqlCommand cmd = null;

            // METODO PARA CONSULTAR ESTUDIANTE-AUTOR (SELECT)
            public Autor ObtenerEstudiante(SqlConnection sql, string Modulos)
            {
                Autor est = null;
                string comando = "SELECT * FROM Autores WHERE Modulo = @Modulo";
                cmd = new SqlCommand(comando, sql);
                cmd.Parameters.AddWithValue("@Modulo", Modulos);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        est = new Autor();
                        est.Nombre = reader["Nombre"].ToString().Trim();
                        est.Apellido = reader["Apellido"].ToString().Trim();
                        est.Correo = reader["Correo"].ToString().Trim();
                        est.Carrera = reader["Carrera"].ToString().Trim();
                        est.Descripcion = reader["Descripcion"].ToString().Trim();
                        est.Foto = reader["Foto"].ToString().Trim();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al consultar estudiante: " + ex.Message);
                }
                return est;
            }
        }
}
