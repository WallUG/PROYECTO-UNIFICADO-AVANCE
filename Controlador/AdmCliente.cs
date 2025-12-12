using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
        public class AdmCliente
        {
            static List<Cliente> listaCliente = new List<Cliente>();


            // Método para obtener un cliente
            public static Cliente ObtenerClientePorId(string cedula)
            {
                return listaCliente.Find(c => c.CedulaORuc == cedula);
            }

            // Método para obtener todos
            public static List<Cliente> ObtenerTodosLosClientes()
            {
                return listaCliente;
            }
        }
    }
