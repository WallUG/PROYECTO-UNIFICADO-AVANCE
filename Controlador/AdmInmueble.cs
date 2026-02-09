using Datos;
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
        Conexion conexion = new Conexion();

        //BB
        DatosInmueble datosInmueble = null;

        static string numeroEditarInmueble;
        Inmueble inmu = null;

        //Lista Inmueble (Visual)
        static List<Inmueble> inmuebleL = new List<Inmueble>();

        // Array de Inmueble dinamico (Visual)
        private static string[] tipoIn = { "Locales", "Accesorios", "Servicios"};


        //PARA EL SELECT
        public AdmInmueble()
        {
            ConsultarInmuebleBB();
        }

        private void ConsultarInmuebleBB()
        {
            conexion = new Conexion();
            string res = conexion.Conectar();
            datosInmueble = new DatosInmueble();//
            string resp = "";//

            if (res[0] == '1')
            {

                //Registrar Inmueble en la BB
                inmuebleL = datosInmueble.ConsultarInmueble(inmu, conexion.sql);//nuevo
                if (inmuebleL.Count == 0)
                {
                    MessageBox.Show("No existen registros de Inmuebles en BDD");
                }
                conexion.Desconectar();

            }
            else if (res[0] == '0')
            {
                MessageBox.Show(res);
            }

        }

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

        public  List<Inmueble> ObtenerListaInmuebles()
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
        // En AdmInmueble.cs

        public bool EsVacio(string nombre, string tipo, int cantidad, double precio)
        {
            // 1. Validar cadenas vacías
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Error: Se necesita llenar todos los campos de texto.");
                return true; // Retorna true porque "está vacío" o invalido
            }

            // 2. Validar que el precio sea mayor a 0
            if (precio <= 0)
            {
                MessageBox.Show("Error: El precio debe ser mayor a 0.");
                return true; // Retorna true indicando error
            }

            // 3. (Opcional) Validar cantidad si es necesario
            if (cantidad <= 0)
            {
                MessageBox.Show("Error: La cantidad debe ser mayor a 0.");
                return true;
            }

            return false; // Todo está correcto
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

            //REGISTRAR BB --------------
            RegistrarInmuebleBB(inmu);

            if (inmu.RegistrarInmueble())//llama a metodo del modelo
            {
                inmu.inmuebleDisponible = disponible;
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
                        //Llamar al metodo de eliminar en la BB
                        EliminarClienteBDD(inmuebleL[i]);
                        inmuebleL.RemoveAt(i);
                        MessageBox.Show("Inmueble eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
        }

        public void Conectar()
        {
            conexion = new Conexion();
            string res = conexion.Conectar();

            if (res[0] == '1')
            {
                MessageBox.Show("Conexión a la Base de Datos exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Desconectar();
            }
            else if (res[0] == '0')
            {
                MessageBox.Show(res, "Error de conexión a la Base de Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Verificar si es editable
        public bool EsEditable(int indice, DataGridView dgvInmueble)
        {
            string NumeroInmueble = dgvInmueble.Rows[indice].Cells["colNumeroInmueble"].Value.ToString();
            foreach (Inmueble inmu in inmuebleL)
            {
                if (inmu.numeroInmueble == NumeroInmueble)
                {
                    if (inmu.cantidadInmuebleDisponible == 0)
                    {
                        MessageBox.Show("No puede ser editado no hay inmuebles.");
                        return false;
                    }
                    else if (inmu.inmuebleDisponible == false)
                    {
                        MessageBox.Show("No puede ser editado no hay imueble disponible.");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return true;
        }

        //Guardar numero editar inmueble
        public void guardarNumeroEditarInmueble(int indice, DataGridView dgvInmueble)
        {
            string numeroInmueble = dgvInmueble.Rows[indice].Cells["colNumeroInmueble"].Value.ToString();
            numeroEditarInmueble = numeroInmueble;
        }

        public string ObtenerNumeroInmuebleEditar()
        {
            return numeroEditarInmueble;
        }

        // Obtener inmueble por numero para editar
        public Inmueble ObtenerInmueblePorNumero(string numeroInmueble)
        {
            foreach (Inmueble inmueble in inmuebleL)
            {
                if (inmueble.numeroInmueble == numeroInmueble)
                {
                    return inmueble;
                }
            }
            return null;
        }

        // Obtener inmueble por numero para editar
        public void CargarInmuebleParaEditar(GroupBox groupBoxInmueble)
        {
            Inmueble inmueble = ObtenerInmueblePorNumero(numeroEditarInmueble);

            if (inmueble == null)
            {
                MessageBox.Show("No se encontró el inmueble a editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cargar datos del inmueble en los TextBox correspondientes
            foreach (Control c in groupBoxInmueble.Controls)
            {
                if (c is TextBox txt)
                {
                    switch (txt.Name)
                    {
                        case "txtNombre":
                            txt.Text = inmueble.nombreInmueble;
                            break;

                    }
                }

                if (c is ComboBox cmb)
                {
                    switch (cmb.Name)
                    {
                        case "cmbTipo":
                            for (int i= 0; i <cmb.Items.Count; i++)
                            {
                                if (cmb.Items[i].ToString() == inmueble.tipoInmueble)
                                {
                                    cmb.SelectedIndex=i;
                                    break;
                                }
                            }
                            break;

                    }
                }

                if (c is NumericUpDown up)
                {
                    switch (up.Name)
                    {
                        case "nudCantidad":
                            up.Text = inmueble.cantidadInmuebleDisponible.ToString();
                            break;
                        case "nudPrecio":
                            up.Text = inmueble.precioInmueble.ToString();
                            break;

                    }
                }

                if (c is CheckBox chk)
                {
                    if (chk.Name == "chkDisponibilidad")
                    {
                        chk.Checked = inmueble.inmuebleDisponible;
                    }
                }

            }
        }

        public void ModificarInmueble(string nombre, string tipo, int cantidad, double precio, bool disponible)
        {
            Inmueble inm = ObtenerInmueblePorNumero(numeroEditarInmueble);
            if (inm != null)
            {
                inm.nombreInmueble = nombre;
                inm.tipoInmueble = tipo;
                inm.cantidadInmuebleDisponible = cantidad;
                inm.precioInmueble = precio;
                inm.inmuebleDisponible = disponible;
                EditarInmuebleBB(inm);
                MessageBox.Show("Inmueble modificado correctamente.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró el inmueble a modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //PARA EL INSERT
        private void RegistrarInmuebleBB(Inmueble inmu)//Nuevo metodo BB - Creo nueva clase
        {
            conexion = new Conexion();
            string res = conexion.Conectar();
            datosInmueble = new DatosInmueble();//
            string resp = "";//

            if (res[0] == '1')
            {

                //Registrar Inmueble en la BB
                resp = datosInmueble.RegistrarInmueble(inmu, conexion.sql);//nuevo
                if (resp[0] == '1')
                {
                    MessageBox.Show("Datos de Inmueble guardado en BDD"); ;
                }
                else if(resp[0] == '0')
                {
                    MessageBox.Show(resp, "Error al guardar en BDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conexion.Desconectar();
            }
            else if (res[0] == '0')
            {
                MessageBox.Show(res, "Error de conexión a la Base de Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Llamar al metodo de eliminar en la BB
        public void EliminarClienteBDD(Inmueble inmu)
        {
            conexion = new Conexion();
            DatosInmueble datosInmueble = new DatosInmueble();
            string msj = conexion.Conectar();
            if (msj[0] == '1')
            {
                datosInmueble.EliminarCliente(inmu, conexion.sql);
                conexion.Desconectar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj);
            }
        }

        //PARA EL EDITAR BDD
        public string EditarInmuebleBB(Inmueble inmu)//Nuevo metodo BB
        {
            conexion = new Conexion();
            string res = conexion.Conectar();
            datosInmueble = new DatosInmueble();//
            string resp = "";//
            if (res[0] == '1')
            {
                //Registrar Inmueble en la BB
                resp = datosInmueble.EditarInmueble(inmu, conexion.sql);//nuevo
                if (resp[0] == '1')
                {
                    //MessageBox.Show("Datos de Inmueble editado en BDD"); ;
                }
                else if (resp[0] == '0')
                {
                    MessageBox.Show(resp, "Error al editar en BDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conexion.Desconectar();
                return resp;
            }
            else if (res[0] == '0')
            {
                MessageBox.Show(res, "Error de conexión a la Base de Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return res;
            }
            return res;

        }
    }
}


