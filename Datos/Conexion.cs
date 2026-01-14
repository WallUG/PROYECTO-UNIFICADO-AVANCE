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
        public string conectar()
        {
            try
            {
                sql = new SqlConnection(cadenaConexion);
                sql.ConnectionString = cadenaConexion;
                sql.Open();
                return "Conexion exitosa";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string desconectar()
        {
            try
            {
                sql.Close();
                return "Desconexion exitosa";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
