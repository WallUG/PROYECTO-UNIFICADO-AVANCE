using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class FrmEliminarFactura : Form
    {
        AdmFactura admFactura = new AdmFactura();
        public FrmEliminarFactura()
        {
            InitializeComponent();
            admFactura.CargarTablaFacturas(dgvFacturas);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
