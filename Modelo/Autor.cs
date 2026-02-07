using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Autor
    {
        // Propiedades de la BDD
        public int idAutor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Carrera { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        // Constructor vacío
        public Autor() { }

        // Constructor lleno
        public Autor(string nombre, string apellido, string correo, string carrera, string descripcion, string foto)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Carrera = carrera;
            Descripcion = descripcion;
            Foto = foto;
        }
    }
}
