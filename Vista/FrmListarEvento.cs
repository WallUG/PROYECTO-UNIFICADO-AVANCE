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
    public partial class FrmListarEvento : Form
    {        
        // Controlador para la lógica de negocio de eventos
        private AdmEvento admEvento = new AdmEvento();
        
        public FrmListarEvento()
        {
            InitializeComponent();

            // Cargar los eventos en el DataGridView
            CargarEventos();
        }
        
        private void CargarEventos()
        {
            admEvento.LlenarTabla(dgvEvento);
        }
    }
}
