using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{

        // Clase Inmueble (Clase principal)
        public class Inmueble
        {
            // Atributos
            public int idInmueble { get; set; }
            public string nombreInmueble { get; set; }
            public string tipoInmueble { get; set; }
            public int cantidadInmuebleDisponible { get; set; }
            public double precioInmueble { get; set; }
            public bool inmuebleDisponible { get; set; }
            public string numeroInmueble { get; set; }//filtro

        // Constructor con parámetros
        // Añadir parametro numeroInmbueble1
        public Inmueble(int id, string numeroInmueble1, string nombre, string tipo, int cantidad, double precio)
            {
                idInmueble = id;
                numeroInmueble = numeroInmueble1;
                nombreInmueble = nombre;
                tipoInmueble = tipo;
                cantidadInmuebleDisponible = cantidad;
                precioInmueble = precio;
                inmuebleDisponible = true;
            }

        // Metodo registrarInmueble
        public bool RegistrarInmueble()
            {
                if (nombreInmueble == "" || cantidadInmuebleDisponible <= 0 || precioInmueble < 0)
                {
                    return false;
                }
                inmuebleDisponible = true;
                return true;
            }

            // Metodo mostrarInmueble
            public void MostrarInmueble()
            {
                Console.WriteLine("ID: " + idInmueble);
                Console.WriteLine("Nombre: " + nombreInmueble);
                Console.WriteLine("Tipo: " + tipoInmueble);
                Console.WriteLine("Cantidad Disponible: " + cantidadInmuebleDisponible);
                Console.WriteLine("Precio: $" + precioInmueble);
                Console.WriteLine("Disponible: " + (inmuebleDisponible ? "Si" : "No"));
            }

            public override string ToString()
            {
                return "ID: " + idInmueble +
                       "\nNombre: " + nombreInmueble +
                       "\nTipo: " + tipoInmueble +
                       "\nCantidad Disponible: " + cantidadInmuebleDisponible +
                       "\nPrecio: $" + precioInmueble.ToString("F2") +
                       "\nDisponible: " + (inmuebleDisponible ? "Sí" : "No");
            }
    }

}
