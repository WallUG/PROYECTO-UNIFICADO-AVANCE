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
        private static string[] tipoIn = { "Locales", "Accesorios", "Servicios"};

        public static string[] ObtenerTiposInmueble()
        {
            return tipoIn;
        }

        // Método para obtener un Inmueble
        public static Inmueble ObtenerInmueblePorNumInmuebles(string numeroInmueble)
        {
            return inmuebleL.Find(i => i.numeroInmueble == numeroInmueble);
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

        //Verificar si esta vacio (Visual)
        public bool EsVacio(string nombre, string tipo, int cantidad, double precio)
        {
            bool flag = false;
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(tipo))
            {
                flag = true;
                MessageBox.Show("Error: Se necesita todos los campos llenos");
            }
            return flag;
        }

        //Registrar (Visual) Hace la logica
        public string Registrar(string nombre, string tipo, int cantidad, double precio, bool disponible)
        {
            //int id = inmuebleL.Count() + 1;
            //Pasar el parametro numeroInmueble - CORREGIDO: Comienza desde 1
            //string numero = "00" + id.ToString();//construyo el numero del inmueble personalizado

            int numeroInmueble = inmuebleL.Count() + 1;
            string numero = "00" + numeroInmueble.ToString();
            Inmueble inmu = new Inmueble(numero, nombre, tipo, cantidad, precio);//ID
            inmu.inmuebleDisponible = disponible;

            if (inmu.RegistrarInmueble())//llama a metodo del modelo
            {
                inmuebleL.Add(inmu);//agrega a la lista
                return inmu.ToString();//muestra el texto
            }
            else
            {
                return "Error: No se pudo registrar el inmueble";
            }
        }

        //LLenar con los datos (Visual)
        public void LlenarTabla(DataGridView dgvInmueble)
        {
            //dgvDocentes.DataSource=lista;
            int indice = 0;//para enumeracion
            dgvInmueble.Rows.Clear();//limpia
            if (inmuebleL.Count > 0) //Verifica que haya inmuebles
            {
                foreach (Inmueble i in inmuebleL)//Recorre cada inmueble
                {
                    indice = dgvInmueble.Rows.Add();//por cada uno agrega una fila nueva
                    //llena la celda
                    dgvInmueble.Rows[indice].Cells["colNro"].Value = indice + 1;
                    //dgvInmueble.Rows[indice].Cells["colID"].Value = i.idInmueble;
                    dgvInmueble.Rows[indice].Cells["colNumeroInmueble"].Value = i.numeroInmueble;
                    dgvInmueble.Rows[indice].Cells["colNombre"].Value = i.nombreInmueble;
                    dgvInmueble.Rows[indice].Cells["colTipo"].Value = i.tipoInmueble;
                    dgvInmueble.Rows[indice].Cells["colCantidad"].Value = i.cantidadInmuebleDisponible;
                    dgvInmueble.Rows[indice].Cells["colPrecio"].Value = i.precioInmueble;
                    dgvInmueble.Rows[indice].Cells["colDisponible"].Value = i.inmuebleDisponible;

                }


            }
        }


        public void verificarFiltros(string txtNumeroInmueble, string txtTipoInmueble, DataGridView dgvInmueble)/////////
        {
            dgvInmueble.Rows.Clear();
            int indice = 0;

            string filtro = "";
            if (!string.IsNullOrWhiteSpace(txtNumeroInmueble))
            {
                filtro = "Numero";
            }
            else if (!string.IsNullOrWhiteSpace(txtTipoInmueble))
            {
                filtro = "Tipo";
            }

            foreach (Inmueble i in inmuebleL)
            {
                if (filtro == "Numero")
                {
                    if (i.numeroInmueble == txtNumeroInmueble)
                    {
                        indice = dgvInmueble.Rows.Add();//por cada uno agrega una fila nueva
                        //llena la celda
                        dgvInmueble.Rows[indice].Cells["colNro"].Value = indice + 1;
                        //dgvInmueble.Rows[indice].Cells["colID"].Value = i.idInmueble;
                        dgvInmueble.Rows[indice].Cells["colNumeroInmueble"].Value = i.numeroInmueble;
                        dgvInmueble.Rows[indice].Cells["colNombre"].Value = i.nombreInmueble;
                        dgvInmueble.Rows[indice].Cells["colTipo"].Value = i.tipoInmueble;
                        dgvInmueble.Rows[indice].Cells["colCantidad"].Value = i.cantidadInmuebleDisponible;
                        dgvInmueble.Rows[indice].Cells["colPrecio"].Value = i.precioInmueble;
                        dgvInmueble.Rows[indice].Cells["colDisponible"].Value = i.inmuebleDisponible;
                        indice++;
                    }
                }
                else if (filtro == "Tipo")
                {
                    if (i.tipoInmueble == txtTipoInmueble)
                    {
                        indice = dgvInmueble.Rows.Add();//por cada uno agrega una fila nueva
                        //llena la celda
                        dgvInmueble.Rows[indice].Cells["colNro"].Value = indice + 1;
                        //dgvInmueble.Rows[indice].Cells["colID"].Value = i.idInmueble;
                        dgvInmueble.Rows[indice].Cells["colNumeroInmueble"].Value = i.numeroInmueble;
                        dgvInmueble.Rows[indice].Cells["colNombre"].Value = i.nombreInmueble;
                        dgvInmueble.Rows[indice].Cells["colTipo"].Value = i.tipoInmueble;
                        dgvInmueble.Rows[indice].Cells["colCantidad"].Value = i.cantidadInmuebleDisponible;
                        dgvInmueble.Rows[indice].Cells["colPrecio"].Value = i.precioInmueble;
                        dgvInmueble.Rows[indice].Cells["colDisponible"].Value = i.inmuebleDisponible;
                        indice++;
                    }
                }
            }
        }

        //Filtro vacio
        public bool EsFiltroVacio(string txtNumeroInmueble, string txtTipoInmueble)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroInmueble) && string.IsNullOrWhiteSpace(txtTipoInmueble))
            {
                return true;
            }
            return false;
        }


        //Método para obtener la cantidad de inmuebles en la lista
        public int GetCantidadLista()
        {
            return inmuebleL.Count;
        }

        //Eliminar Inmueble (Visual)
        public void EliminarInmueble(int indice, DataGridView dvgInmueble)
        {
            string numeroInmueble = dvgInmueble.Rows[indice].Cells["colNumeroInmueble"].Value.ToString();
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar el inmueble seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                for (int i = 0; i < inmuebleL.Count; i++)
                {
                    if (inmuebleL[i].numeroInmueble == numeroInmueble)
                    {
                        inmuebleL.RemoveAt(i);
                        MessageBox.Show("Inmueble eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
        }
    }
}


