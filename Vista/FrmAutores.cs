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
    public partial class FrmAutores : Form
    {
        public FrmAutores()
        {
            InitializeComponent();
        }

        private void lblAutor01_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chichanda Josue\n \nIngeniería en Software\nUniversidad de Guayaquil", "Autor de modulo cliente");
        }

        private void lblAutor02_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Castillo Daniel\nIngeniería en Software\nUniversidad de Guayaquil", "Autor de modulo evento");
        }

        private void lblAutor03_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Garcia Gustavo\nIngeniería en Software\nUniversidad de Guayaquil", "Autor de modulo Factura");
        }

        private void lblAutor04_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Plaus Leonardo\nIngeniería en Software\nUniversidad de Guayaquil", "Autor de modulo Inmueble");
        }

        private void lblAutor05_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zambrano Nick\nIngeniería en Software\nUniversidad de Guayaquil", "Autor de modulo Reserva");
        }

        private void FrmAutores_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
