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
        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            int indice = 0;
            if (dgvEliminarCliente.SelectedRows.Count==1)
            {
                indice = dgvEliminarCliente.CurrentRow.Index;
                AdmCliente.EliminarCliente(indice, dgvEliminarCliente);
                //AdmCliente.CargarTablaCliente(dgvEliminarCliente);
            }
            else
            {
                MessageBox.Show("Seleccione un evento para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
