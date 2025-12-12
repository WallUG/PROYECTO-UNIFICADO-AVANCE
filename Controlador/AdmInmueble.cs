using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{

    public class AdmInmueble
    {

        //VISUAL

        Inmueble inmu = null;

        //Lista Inmueble (Visual)
        static List<Inmueble> inmuebleL = new List<Inmueble>();

        // Array de Inmueble dinamico (Visual)
        string[] tipoIn = { "Telon de eventos", "Jardin", "Auditorio", "Sala de conferencia" };

        // Método para obtener un Inmueble
        public static Inmueble ObtenerInmueblePorId(int idInmueble)
        {
            return inmuebleL.Find(i => i.idInmueble == idInmueble);
        }

        // Método para obtener todos
        public static List<Inmueble> ObtenerTodosLosInmuebles()
        {
            return inmuebleL;
        }

        public void LlenarCombo(ComboBox cmbTipo)
        {
            foreach (string tipo in tipoIn)
            {
                cmbTipo.Items.Add(tipo);
            }
        }

        //Verificar si esta vacio (Visual) Disponibilidad y ID
        public bool EsVacio(int id, string nombre, string tipo, int cantidad, double precio)
        {
            bool flag = false;
            if (id <= 0 || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(tipo))
            {
                flag = true;
                MessageBox.Show("Error: Se necesita todos los campos llenos");
            }
            return flag;
        }

        //Registrar (Visual) Disponibilidad y ID
        public string Registrar(int id, string nombre, string tipo, int cantidad, double precio, bool disponible)
        {
            Inmueble inmu = new Inmueble(id, nombre, tipo, cantidad, precio);
            inmu.inmuebleDisponible = disponible;

            if (inmu.RegistrarInmueble())
            {
                inmuebleL.Add(inmu);
                return inmu.ToString();
            }
            else
            {
                return "Error: No se pudo registrar el inmueble";
            }
        }

        //LLenar (Visual)
        public void LlenarTabla(DataGridView dgvInmueble)
        {
            //dgvDocentes.DataSource=lista;
            int indice = 0;
            dgvInmueble.Rows.Clear();
            if (inmuebleL.Count > 0)
            {
                foreach (Inmueble i in inmuebleL)
                {
                    indice = dgvInmueble.Rows.Add();
                    dgvInmueble.Rows[indice].Cells["colNro"].Value = indice + 1;
                    dgvInmueble.Rows[indice].Cells["colID"].Value = i.idInmueble;
                    dgvInmueble.Rows[indice].Cells["colNombre"].Value = i.nombreInmueble;
                    dgvInmueble.Rows[indice].Cells["colTipo"].Value = i.tipoInmueble;
                    dgvInmueble.Rows[indice].Cells["colCantidad"].Value = i.cantidadInmuebleDisponible;
                    dgvInmueble.Rows[indice].Cells["colPrecio"].Value = i.precioInmueble;
                    dgvInmueble.Rows[indice].Cells["colDisponible"].Value = i.inmuebleDisponible;

                }


            }
        }



        //CONSOLA

        // Array de inmuebles
        public Inmueble[] inmuebles;
        public int contador;

        // Array de asignaciones EventoInmueble
        public EventoInmueble[] asignaciones;
        public int contadorAsignaciones;

        public Validacion validacion;

        public AdmInmueble()
        {
            inmuebles = new Inmueble[10];
            contador = 0;

            asignaciones = new EventoInmueble[10];
            contadorAsignaciones = 0;

            validacion = new Validacion();
            CargarDatos();
        }

        // Cargar datos quemados de prueba
        private void CargarDatos()
        {
            // Crear 2 inmuebles quemados
            inmuebles[0] = new Inmueble(1, "Silla Ejecutiva", "Mobiliario", 100, 5.50);
            inmuebles[1] = new Inmueble(2, "Mesa Rectangular", "Mobiliario", 30, 15.00);

            // Registrar los inmuebles
            inmuebles[0].RegistrarInmueble();
            inmuebles[1].RegistrarInmueble();

            contador = 2;

            // Crear 2 asignaciones quemadas
            EventoInmueble asignacion1 = new EventoInmueble(inmuebles[0], 20, DateTime.Now);
            asignacion1.AsignarCantidadInmueble();
            asignaciones[0] = asignacion1;

            EventoInmueble asignacion2 = new EventoInmueble(inmuebles[1], 5, DateTime.Now);
            asignacion2.AsignarCantidadInmueble();
            asignaciones[1] = asignacion2;

            contadorAsignaciones = 2;
        }

        // Registrar nuevo inmueble
        public string RegistrarInmueble(int id, string nombre, string tipo, int cantidad, double precio)
        {
            string mensaje = "";

            if (contador >= 10)
            {
                mensaje = "Error: No se pueden agregar mas inmuebles";
                return mensaje;
            }

            // Crear el inmueble
            Inmueble inmueble = new Inmueble(id, nombre, tipo, cantidad, precio);

            // Registrar el inmueble (valida internamente)
            if (inmueble.RegistrarInmueble())
            {
                inmuebles[contador] = inmueble;
                contador++;
                mensaje = "Inmueble registrado con exito\n\n";
                mensaje += "---------- INFORMACION DEL INMUEBLE ----------\n";
                mensaje += "ID: " + inmueble.idInmueble + "\n";
                mensaje += "Nombre: " + inmueble.nombreInmueble + "\n";
                mensaje += "Tipo: " + inmueble.tipoInmueble + "\n";
                mensaje += "Cantidad Disponible: " + inmueble.cantidadInmuebleDisponible + "\n";
                mensaje += "Precio: $" + inmueble.precioInmueble + "\n";
                mensaje += "Disponible: " + (inmueble.inmuebleDisponible ? "Si" : "No") + "\n";
                mensaje += "----------------------------------------------";
            }
            else
            {
                mensaje = "Error: No se pudo registrar el inmueble";
            }

            return mensaje;
        }

        // Mostrar todos los inmuebles
        public string MostrarInmuebles()
        {
            if (contador == 0)
            {
                return "No hay inmuebles registrados";
            }

            string lista = "\n---------- LISTA DE INMUEBLES ----------\n";
            for (int i = 0; i < contador; i++)
            {
                lista += "\n--- Inmueble " + (i + 1) + " ---\n";
                lista += "ID: " + inmuebles[i].idInmueble + "\n";
                lista += "Nombre: " + inmuebles[i].nombreInmueble + "\n";
                lista += "Tipo: " + inmuebles[i].tipoInmueble + "\n";
                lista += "Cantidad: " + inmuebles[i].cantidadInmuebleDisponible + "\n";
                lista += "Precio: $" + inmuebles[i].precioInmueble + "\n";
                lista += "Disponible: " + (inmuebles[i].inmuebleDisponible ? "Si" : "No") + "\n";
            }
            lista += "\n----------------------------------------";
            return lista;
        }

        // Registrar asignación EventoInmueble
        public string RegistrarAsignacion(int idInmueble, int cantidad)
        {
            if (contadorAsignaciones >= 10)
            {
                return "Error: No se pueden agregar mas asignaciones";
            }

            // Buscar el inmueble
            Inmueble inmueble = null;
            for (int i = 0; i < contador; i++)
            {
                if (inmuebles[i].idInmueble == idInmueble)
                {
                    inmueble = inmuebles[i];
                    break;
                }
            }

            if (inmueble == null)
            {
                return "Error: Inmueble no encontrado";
            }

            if (cantidad <= 0)
            {
                return "Error: La cantidad debe ser mayor a 0";
            }

            // Crear EventoInmueble
            DateTime fechaActual = DateTime.Now;
            EventoInmueble nuevaAsignacion = new EventoInmueble(inmueble, cantidad, fechaActual);

            if (nuevaAsignacion.AsignarCantidadInmueble())
            {
                asignaciones[contadorAsignaciones] = nuevaAsignacion;
                contadorAsignaciones++;

                string mensaje = "Asignacion registrada con exito\n\n";
                mensaje += "---------- DETALLE DE ASIGNACION ----------\n";
                mensaje += "Inmueble: " + inmueble.nombreInmueble + "\n";
                mensaje += "Cantidad asignada: " + cantidad + "\n";
                mensaje += "Fecha: " + fechaActual + "\n";
                mensaje += "Cantidad restante: " + inmueble.cantidadInmuebleDisponible + "\n";
                mensaje += "-------------------------------------------";
                return mensaje;
            }
            else
            {
                return "Error: No hay cantidad suficiente\nDisponible: " + inmueble.cantidadInmuebleDisponible;
            }
        }

        // Mostrar todas las asignaciones
        public string MostrarAsignaciones()
        {
            if (contadorAsignaciones == 0)
            {
                return "No hay asignaciones registradas";
            }

            string lista = "\n---------- LISTA DE ASIGNACIONES ----------\n";
            for (int i = 0; i < contadorAsignaciones; i++)
            {
                lista += "\n--- Asignacion " + (i + 1) + " ---\n";
                lista += "Inmueble: " + asignaciones[i].inmueble.nombreInmueble + "\n";
                lista += "Cantidad asignada: " + asignaciones[i].cantidadInmueble + "\n";
                lista += "Fecha: " + asignaciones[i].fechaAsignacionInmueble + "\n";
            }
            lista += "\n-------------------------------------------";
            return lista;
        }


    }


}


