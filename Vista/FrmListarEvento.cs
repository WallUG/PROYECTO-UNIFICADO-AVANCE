//CASTILLO MERA DANIEL FERNANDO
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
    /*
    Formulario para listar todos los eventos registrados en el sistema.
    Muestra los eventos en un DataGridView.
    */
    public partial class FrmListarEvento : Form
    {        
        // Controlador para la lógica de negocio de eventos
        private AdmEvento admEvento = new AdmEvento();
        
        /*
        Constructor del formulario de listado de eventos.
        Carga automáticamente los eventos al abrir el formulario.
        */
        public FrmListarEvento()
        {
            InitializeComponent();

            // Cargar los eventos en el DataGridView
            CargarEventos();
        }
        
        /*
        Carga todos los eventos registrados en el DataGridView.
        */
        private void CargarEventos()
        {
            admEvento.LlenarTabla(dgvEvento);
        }
    }
}
