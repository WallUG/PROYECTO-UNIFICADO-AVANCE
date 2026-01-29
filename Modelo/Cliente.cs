using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente
    {
        public int Id { get; set; }
        public int NumeroCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CedulaORuc { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Direccion { get; set; }

        public Cliente()
        {
            Id = 0;
            Nombre = "";
            Apellido = "";
            CedulaORuc = "";
            Telefono = "";
            CorreoElectronico = "";
            Direccion = "";
        }

        public Cliente(int id, string nombre, string apellido, string cedulaORuc, string telefono, string correoElectronico, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            CedulaORuc = cedulaORuc;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
            Direccion = direccion;
        }

        public string ObtenerNombreCompleto()
        {
            return Nombre + " " + Apellido;
        }
    }
}
