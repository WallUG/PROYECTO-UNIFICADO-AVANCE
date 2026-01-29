using Datos;
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
        static List<Cliente> listaCliente = new List<Cliente>();
        private int contadorId;
        Conexion Cn = null;
        public AdmCliente()
        {
            //listaCliente = new List<Cliente>();
            ConsultarClientesBDD();
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


        
        public static Cliente ObtenerClientePorIdentificacion(string cedula)
        {
            return listaCliente.Find(c => c.CedulaORuc == cedula);
        }

       
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

               
                if (!correo.Contains("@") || !correo.Contains("."))
                {
                    Console.WriteLine("  El formato del correo no es válido");
                    flag = false;
                    continue;
                }

                
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

                for (int i = 0; i < listaCliente.Count; i++)
                {
                    if (listaCliente[i].CedulaORuc == cedula)
                    {
                        MessageBox.Show("El cliente con la cédula " + cedula + " ya está registrado en el sistema.");

                        return;
                    }


                }  int idCliente = listaCliente.Count + 1;

                
                Cliente cliente = new Cliente(idCliente, nombre, apellido, cedula, telefono, correo, direccion);
                listaCliente.Add(cliente);
                RegistrarClienteBDD(cliente);
                MessageBox.Show(" Cliente registrado con exito");
            }catch (Exception ex)
            {
                MessageBox.Show(" Error al registrar el cliente: " + ex.Message);

            }
        }

        public void MostrarClientes(DataGridView dgvCliente)
        {
            dgvCliente.Rows.Clear();
            int indice = 0;

            if(listaCliente.Count == 0)
            {
                MessageBox.Show("No hay Clientes registrados");
            }

            foreach (Cliente cliente in listaCliente)
            {
                dgvCliente.Rows.Add();
                dgvCliente.Rows[indice].Cells["colId"].Value = cliente.Id;
                dgvCliente.Rows[indice].Cells["colNombre"].Value = cliente.Nombre;
                dgvCliente.Rows[indice].Cells["colApellidos"].Value = cliente.Apellido;
                dgvCliente.Rows[indice].Cells["colCedula"].Value = cliente.CedulaORuc;
                dgvCliente.Rows[indice].Cells["colTelefono"].Value = cliente.Telefono;
                dgvCliente.Rows[indice].Cells["colCorreo"].Value = cliente.CorreoElectronico;
                indice++;
            }
        }




        public void EliminarCliente(int indice, DataGridView dgvCliente)
        {
            string cedula = dgvCliente.Rows[indice].Cells["colCedula"].Value.ToString();
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar el cliente con cédula "
                + cedula + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                EliminarClienteBDD(ObtenerClientePorIdentificacion(cedula));
                listaCliente.RemoveAt(indice);

                MostrarClientes(dgvCliente);
                MessageBox.Show("Cliente eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        public int GetCantidadLista()
        {
            listaCliente.Count();
            return listaCliente.Count;
        }

        public void FiltrarCliente(string cedulaoruc, DataGridView dgvClientes)
        {
           Cliente clt= listaCliente.Find(c => c.CedulaORuc == cedulaoruc);
            if (clt != null)
            {
                dgvClientes.Rows.Clear();
                dgvClientes.Rows.Add();
                int indice = dgvClientes.Rows.Add();
                dgvClientes.Rows[indice].Cells["colId"].Value = clt.Id;
                dgvClientes.Rows[indice].Cells["colNombre"].Value = clt.Nombre;
                dgvClientes.Rows[indice].Cells["colApellidos"].Value = clt.Apellido;
                dgvClientes.Rows[indice].Cells["colCedula"].Value = clt.CedulaORuc;
                dgvClientes.Rows[indice].Cells["colTelefono"].Value = clt.Telefono;
                dgvClientes.Rows[indice].Cells["colCorreo"].Value = clt.CorreoElectronico;
            }
            else
            {
                MessageBox.Show("No se encontró ningún cliente con la cédula o RUC proporcionada.");
            }
        }

        public void Conectar()
        {
            Cn = new Conexion();
            string res = Cn.Conectar();
            if (res[0] == '1')
            {
                MessageBox.Show("Conexión exitosa");
            }
            else if (res[0] == '0')
            {
                MessageBox.Show(res, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrarClienteBDD(Cliente cliente)
        {
            Cn = new Conexion();
            DatosCliente datosCli = new DatosCliente();
            string msj = Cn.Conectar();
            string resp = "";
            if (msj[0] == '1')
            {
                resp = datosCli.RegistrarCLiente(cliente, Cn.sql);
                if (resp[0] == '1')
                {
                    MessageBox.Show("Datos de cliente guardados en BDD");
                }
                else if (resp[0] == '0')
                {
                    MessageBox.Show(resp);
                }
                Cn.Desconectar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj);
            }
        }

        public void ConsultarClientesBDD()
        {
            Cn = new Conexion();
            DatosCliente datosCli = new DatosCliente();
            string msj = Cn.Conectar();
            if (msj[0] == '1')
            {
                listaCliente = datosCli.ListarClientes(Cn.sql);
                Cn.Desconectar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj);
            }
        }

        public void EliminarClienteBDD(Cliente cliente)
        {
            Cn = new Conexion();
            DatosCliente datosCli = new DatosCliente();
            string msj = Cn.Conectar();
            if (msj[0] == '1')
            {
                datosCli.EliminarCliente(cliente, Cn.sql);
                Cn.Desconectar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj);
            }
        }
    }
}
