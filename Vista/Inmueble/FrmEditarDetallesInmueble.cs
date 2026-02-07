using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmEditarDetallesInmueble : Form
    {
        AdmInmueble admInmueble = new AdmInmueble();
        public FrmEditarDetallesInmueble()
        {
            AdmInmueble admInmueble = new AdmInmueble();
            InitializeComponent();
            admInmueble.LlenarCombo(cmbTipo);
            CargarDatosInmueble();
        }

        private void CargarDatosInmueble()
        {
            string numeroInmueble = admInmueble.ObtenerNumeroInmuebleEditar();

            if (string.IsNullOrEmpty(numeroInmueble))
            {
                MessageBox.Show("No se ha seleccionado ningun Inmueble para editar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            admInmueble.CargarInmuebleParaEditar(groupBoxInmueble);
        }

        //Tipo de inmueble
        private void selectTipoInmueble(object sender, EventArgs e)//muestra, desabilita, habilita (combo box)
        {
            if (Convert.ToString(cmbTipo.SelectedItem) == "Locales")
            {
                txtDescripcion.Text = "Locales comerciales como tiendas, restaurantes, etc.";
                nudCantidad.Value = 1;
                nudCantidad.Enabled = false;
                return;
            }
            else if (Convert.ToString(cmbTipo.SelectedItem) == "Accesorios")
            {
                txtDescripcion.Text = "Accesorios como Carpa, sillas, etc.";
                nudCantidad.Enabled = true;
                return;
            }
            else
            {
                txtDescripcion.Text = "Servicios como bodega, cocina, comedor, etc.";
                nudCantidad.Enabled = true;
            }
        }

        //Nombre del inmueble
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permite usar teclas de control como backspace
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            //Permite usar letras y espacios
            char c = e.KeyChar;
            if (!Char.IsLetter(c) && c != ' ')
            {
                e.Handled = true;
                return;
            }
        }

        //Boton guardar de inmueble
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(txtID.Text.Trim());

            //Capturar datos de los controles
            string nombre = txtNombre.Text.Trim();
            string tipo = (string)cmbTipo.SelectedItem;
            int cantidad = (int)nudCantidad.Value;
            double precio = (double)nudPrecio.Value;
            bool disponible = chkDisponibilidad.Checked;

            string contenido = "";

            //Recoge los datos el metodo para validar los campos
            if (!admInmueble.EsVacio(nombre, tipo, cantidad, precio))
            {
                //Registrar en el controlador
                admInmueble.ModificarInmueble(nombre, tipo, cantidad, precio, disponible);
                this.Close();
                //Mostrar resultado
                //txtContenido.Text = contenido;//mostrar resultados
            }
            else
            {
                // Si hay campos vacios
                MessageBox.Show("Debe completar todos los campos");
            }
        }


    }
}
