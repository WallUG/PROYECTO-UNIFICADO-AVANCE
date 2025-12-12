using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Validacion
    {
        public string LeerLetras(string msj)
        {
            string respuesta = "";
            bool bandera = true;
            Console.Write(msj);
            respuesta = Console.ReadLine().Trim();
            for (int i = 0; i < respuesta.Length && bandera; i++)
            {
                if (!char.IsLetter(respuesta[i]) && !char.IsWhiteSpace(respuesta[i]))
                {
                    bandera = false;
                }
            }
            if (!bandera)
            {
                respuesta = "";
            }
            return respuesta;
        }

        public int LeerEnteros(string msj)
        {
            int respuesta = -1;
            string entrada = "";

            while (respuesta < 0)
            {
                try
                {
                    Console.Write(msj);
                    entrada = Console.ReadLine().Trim();
                    respuesta = int.Parse(entrada);

                    if (respuesta < 0)
                    {
                        Console.WriteLine("Error: Se esperaba un número entero positivo.");
                        Console.WriteLine("Por favor, intente nuevamente.\n");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: El valor ingresado no es un número válido.");
                    Console.WriteLine("Por favor, intente nuevamente.\n");
                    respuesta = -1;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: El número ingresado es demasiado grande o pequeño.");
                    Console.WriteLine("Por favor, intente nuevamente.\n");
                    respuesta = -1;
                }
            }

            return respuesta;
        }

        public string LeerDigitos(string msj, int longitud)
        {
            string respuesta = "";
            bool bandera = true;
            Console.Write(msj);
            respuesta = Console.ReadLine().Trim();
            if (respuesta.Length == longitud)
            {
                for (int i = 0; i < respuesta.Length && bandera; i++)
                {
                    if (!char.IsDigit(respuesta[i]))
                    {
                        bandera = false;
                    }
                }
            }
            else
            {
                bandera = false;
            }
            if (!bandera)
            {
                Console.WriteLine("Error: Se esperaba " + longitud + " digitos.");
                respuesta = "";
            }
            return respuesta;
        }

        public DateTime LeerFecha(string msj)
        {
            DateTime fecha = DateTime.Now;

            return fecha;
        }
    }
}
