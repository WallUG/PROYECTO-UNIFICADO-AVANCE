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
        //static List<Cliente> listaCliente = new List<Cliente>();


        //// Método para obtener un cliente
        //public static Cliente ObtenerClientePorId(string cedula)
        //{
        //    return listaCliente.Find(c => c.CedulaORuc == cedula);
        //}

        //// Método para obtener todos
        //public static List<Cliente> ObtenerTodosLosClientes()
        //{
        //    return listaCliente;
        //}

        //// Método para agregar un cliente
        //public AdmCliente()
        //{
        //    listaCliente.Add(new Cliente(1,"Josue Leon", "Chichanda Velasquez", "0987654321", "0967706781", "chichanda@gmail.com","Guayas-Duran"));
        //}
        private List<Cliente> clientes;
        private int contadorId;


        public AdmCliente()
        {
            clientes = new List<Cliente>();
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
                clientes.Add(nuevoCliente);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Cliente> ObtenerTodosLosClientes()
        {
            return clientes;
        }

        public int ObtenerCantidadClientes()
        {
            return clientes.Count;
        }
        public bool ExisteCedula(string cedula)
        {
            foreach (var cliente in clientes)
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
