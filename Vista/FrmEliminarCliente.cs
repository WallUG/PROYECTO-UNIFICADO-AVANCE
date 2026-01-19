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
    public partial class FrmEliminarCliente : Form
    {
        AdmCliente admCliente = new AdmCliente();
        public FrmEliminarCliente()
        {
            admCliente.MostrarClientes(dgvCliente);
            InitializeComponent();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            int indice = 0;
            if (dgvCliente.SelectedRows.Count == 1)
            {
                indice = dgvCliente.CurrentRow.Index;
                admCliente.EliminarCliente(indice, dgvCliente);
                //AdmCliente.CargarTablaCliente(dgvEliminarCliente);
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
