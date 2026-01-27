using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ConexionBDD
    {
        private static string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexionCastilloDaniel"].ConnectionString;
        public SqlConnection sql { get; set; }
        public string Conectar()
        {
            try
            {
                sql = new SqlConnection(cadenaConexion);
                sql.ConnectionString = cadenaConexion;
                sql.Open();
                return "1";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "0" + ex.Message;
            }
        }

        public string Desconectar()
        {
            try
            {
                sql.Close();
                return "1";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "0" + ex.Message;
            }
        }
    }
}