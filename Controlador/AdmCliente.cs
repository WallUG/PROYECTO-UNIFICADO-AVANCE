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
            static List<Cliente> listaCliente;
            private int contadorId;

            public AdmCliente()
            {
                listaCliente = new List<Cliente>();
                contadorId = 1;
            }

            public bool AgregarCliente(string nombre, string apellido, string cedula, string telefono, string correoElectronico, string direccion)
            {
                try
                {
                    Cliente nuevoCliente = new Cliente
                    {
                        Id = contadorId++,
                        Nombre = nombre,
                        Apellido = apellido,
                        CedulaORuc = cedula,
                        Telefono = telefono,
                        CorreoElectronico = correoElectronico,
                        Direccion = direccion
                    };
                    listaCliente.Add(nuevoCliente);
                    return true;
                }
                catch
                {
                    return false;
                }
            }


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

            public int ObtenerCantidadClientes()
            {
                return listaCliente.Count;
            }
            public bool ExisteCedula(string cedula)
            {
                foreach (var cliente in listaCliente)
                {
                    if (cliente.CedulaORuc == cedula)
                    {
                        return true;
                    }
                }
                return false;
            }

        }
    }
