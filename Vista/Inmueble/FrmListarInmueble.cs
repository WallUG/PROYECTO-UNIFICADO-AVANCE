using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    public partial class FrmListarInmueble : Form
    {
        AdmInmueble admInmueble = new AdmInmueble();//creamos una instancia
        public FrmListarInmueble()
        {
            InitializeComponent();//iniciamos los controladores
            admInmueble.LlenarTabla(dgvInmueble);//llamamos al metodo llenar tabla
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Boolean resul = admInmueble.EsFiltroVacio(txtNumeroInmueble.Text, txtTipoInmueble.Text);
            if (resul)
            {
                MessageBox.Show("No ha ingresado ningun filtro", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                admInmueble.LlenarTabla(dgvInmueble);
            }
            else
            {
                admInmueble.verificarFiltros(txtNumeroInmueble.Text, txtTipoInmueble.Text, dgvInmueble);
            }

            MessageBox.Show("Lista actualizada correctamente.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectradionButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNumeroInmueble.Checked)
            {
                txtNumeroInmueble.Enabled = true;
                txtNumeroInmueble.Clear(); // Limpia el campo al habilitar
                txtTipoInmueble.Enabled = false;
                txtTipoInmueble.Clear(); // Limpia el campo al deshabilitar
            }
            else if (rbTipoInmueble.Checked)
            {
                txtTipoInmueble.Enabled = true;
                txtTipoInmueble.Clear(); // Limpia el campo al habilitar
                txtNumeroInmueble.Enabled = false;
                txtNumeroInmueble.Clear(); // Limpia el campo al deshabilitar
            }
        }

        private void btnGenerarPDF(object sender, EventArgs e)
        {
            //Preguntar dónde guardar el archivo PDF
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivos PDF (*.pdf)|*.pdf";
            guardar.FileName = "ListadoInmuebles.pdf";

            //if (guardar.ShowDialog() == DialogResult.OK)
            //{
                try
                {
                    //Llama a la logica para generar el PDF
                    AdmPDF control = new AdmPDF();
                    control.GenerarPDFInmueble(guardar.FileName);

                    MessageBox.Show("PDF Generado con exito", "PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Abrir el PDF automáticamente después de crearlo
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = guardar.FileName;
                    psi.UseShellExecute = true;
                    Process.Start(psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear el PDF: " + ex.Message);
                }
            //}

        }
    }
}
