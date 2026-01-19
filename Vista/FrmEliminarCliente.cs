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
    public partial class EliminarCliente : Form
    {
        AdmCliente AdmCliente = new AdmCliente();
        public EliminarCliente()
        {
            InitializeComponent();
            AdmCliente.CargarTablaCliente(dgvCliente);
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            int indice = 0;
            if (dgvCliente.SelectedRows.Count==1)
            {
                indice = dgvCliente.CurrentRow.Index;
                AdmCliente.EliminarCliente(indice, dgvCliente);
                //AdmCliente.CargarTablaCliente(dgvEliminarCliente);
            }
            else
            {
                MessageBox.Show("Seleccione un evento para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
