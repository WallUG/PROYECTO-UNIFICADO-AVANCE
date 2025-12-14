using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public bool Esvacio(string nombre, string apellido, string cedula, string telefono, string correo, string direccion)
        {
            bool flag = true;
            Cliente cliente = new Cliente();
            if (!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(apellido) && !String.IsNullOrEmpty(cedula) &&
                !String.IsNullOrEmpty(telefono) && !String.IsNullOrEmpty(correo) && !String.IsNullOrEmpty(direccion))
            {

                if (EsCorreo(correo))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    MessageBox.Show(" El Correo no es correcto");

                }




            }
            else
            {
                flag = false;
                MessageBox.Show(" Error: Se necesita todos los campos llenos");

            }
            //if (flag) 
            //{
            //    cliente = new Cliente(cedula, apellido, cedula, correo,telefono,direccion);


            //}
            return flag;
        }

        private bool EsCorreo(string correo)
        {
            bool flag = true;
            while (flag)
            {

                // Validación 1: debe tener formato válido (contiene @ y .)
                if (!correo.Contains("@") || !correo.Contains("."))
                {
                    Console.WriteLine("  El formato del correo no es válido");
                    flag = false;
                    continue;
                }

                // Validación 2: @ debe estar antes del punto
                int posicionArroba = correo.IndexOf("@");
                int posicionPunto = correo.LastIndexOf(".");

                if (posicionArroba > posicionPunto)
                {
                    Console.WriteLine("   El formato del correo no es válido");
                    flag = false;
                    continue;
                }

                return flag;
            }

            return flag;
        }

        public void Registrar(string nombre, string apellido, string cedula, string telefono, string correo, string direccion)
        {
            try
            {
                int idCliente = listaCliente.Count + 1;
                //Bug solucionado : se agrego el parametro idCliente en la creacion del cliente
                Cliente cliente = new Cliente(idCliente, nombre, apellido, cedula, correo, telefono, direccion);
                listaCliente.Add(cliente);
                MessageBox.Show(" Cliente registrado con exito");
            }catch (Exception ex)
            {
                MessageBox.Show(" Error al registrar el cliente: " + ex.Message);

            }
        }

        public void MostrarClientes(DataGridView dgvClientes)
        {
            dgvClientes.Rows.Clear();
            int indice = 0;

            foreach (Cliente cliente in listaCliente)
            {
                indice = dgvClientes.Rows.Add();
                dgvClientes.Rows[indice].Cells["colID"].Value = cliente.Id;
                dgvClientes.Rows[indice].Cells["colNombre"].Value = cliente.Nombre;
                dgvClientes.Rows[indice].Cells["colApellidos"].Value = cliente.Apellido;
                dgvClientes.Rows[indice].Cells["colCedula"].Value = cliente.CedulaORuc;
                dgvClientes.Rows[indice].Cells["colNumCedular"].Value = cliente.Telefono;
                dgvClientes.Rows[indice].Cells["colCorreo"].Value = cliente.CorreoElectronico;
            }
        }
    }
}
