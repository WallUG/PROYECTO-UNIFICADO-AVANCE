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
    /// <summary>
    /// Formulario para listar todos los eventos registrados en el sistema.
    /// Muestra los eventos en un DataGridView.
    /// </summary>
    public partial class FrmListarEvento : Form
    {
        #region Campos y Variables
        
        // Controlador para la lógica de negocio de eventos
        private AdmEvento admEvento = new AdmEvento();
        
        #endregion

        #region Constructor
        
        /// <summary>
        /// Constructor del formulario de listado de eventos.
        /// Carga automáticamente los eventos al abrir el formulario.
        /// </summary>
        public FrmListarEvento()
        {
            InitializeComponent();

            // Cargar los eventos en el DataGridView
            CargarEventos();
        }
        
        #endregion

        #region Métodos de Carga de Datos
        
        /// <summary>
        /// Carga todos los eventos registrados en el DataGridView.
        /// </summary>
        private void CargarEventos()
        {
            admEvento.LlenarTabla(dgvEvento);
        }
        
        #endregion
    }
}
