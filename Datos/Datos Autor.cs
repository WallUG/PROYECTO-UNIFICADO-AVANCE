using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Datos
{
    public class Datos_Autor
    {
        SqlCommand cmd = null;

        public Autor Obtener_Autor_Factura(SqlConnection sql)
        {
            Autor autor = null;
            string comando = "SELECT NombreAutor, CarreraAutor, UniversidadAutor, ModuloAutor, UrlImagen FROM Autores WHERE ModuloAutor = 'Factura'";
            cmd = new SqlCommand(comando, sql);
            
            try
            {
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    autor = new Autor
                    {
                        NombreAutor = lector["NombreAutor"].ToString().Trim(),
                        CarreraAutor = lector["CarreraAutor"].ToString().Trim(),
                        UniversidadAutor = lector["UniversidadAutor"].ToString().Trim(),
                        ModuloAutor = lector["ModuloAutor"].ToString().Trim(),
                        UrlImagen = lector["UrlImagen"].ToString().Trim()
                    };
                }
                lector.Close();
                return autor;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el autor del módulo Factura: " + ex.Message);
                return null;
            }
        }

        public Autor Obtener_Autor_Por_Modulo(SqlConnection sql, string modulo)
        {
            Autor autor = null;
            string comando = "SELECT NombreAutor, CarreraAutor, UniversidadAutor, ModuloAutor, UrlImagen FROM Autores WHERE ModuloAutor = @Modulo";
            cmd = new SqlCommand(comando, sql);
            cmd.Parameters.AddWithValue("@Modulo", modulo);

            try
            {
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    autor = new Autor
                    {
                        NombreAutor = lector["NombreAutor"].ToString().Trim(),
                        CarreraAutor = lector["CarreraAutor"].ToString().Trim(),
                        UniversidadAutor = lector["UniversidadAutor"].ToString().Trim(),
                        ModuloAutor = lector["ModuloAutor"].ToString().Trim(),
                        UrlImagen = lector["UrlImagen"].ToString().Trim()
                    };
                }
                lector.Close();
                return autor;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el autor del módulo " + modulo + ": " + ex.Message);
                return null;
            }
        }
    }
}
