using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        private static string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
        public SqlConnection sql { get; set; }
        public string Conectar()
        {
            try
            {
                sql = new SqlConnection(cadenaConexion);
                sql.ConnectionString = cadenaConexion;
                sql.Open();
                return "Conexión exitosa!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Desconectar()
        {
            try
            {
                sql.Close();
                return "Desconexión exitosa!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}