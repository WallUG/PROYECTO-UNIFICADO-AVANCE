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

namespace Visual
{
    public partial class FrmListarReserva : Form
    {
        AdmReserva admReser = new AdmReserva();
        public FrmListarReserva()
        {
            InitializeComponent();
            admReser.LlenarTabla(dgvReservas);
        }
    }
}
