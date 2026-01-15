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
    public partial class FrmEditarDetallesEvento : Form
    {
        private AdmEvento admEvento = new AdmEvento();
        public FrmEditarDetallesEvento()
        {
            InitializeComponent();
        }

        private void FrmEditarDetallesEvento_Load(object sender, EventArgs e)
        {
            CargarDatosEvento();
        }

        private void CargarDatosEvento()
        {
            int numEventos = admEvento.ObtenerNumeroEventoEditar();

            if (numEventos == 0)
            {
                MessageBox.Show("No se ha seleccionado ningún evento para editar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            admEvento.CargarEventoParaEditar(gbInformacionCliente, gbCreacionEvento,
                gbAsignarInmuebles, gbListaInmueblesSele);
        }
    }
}
