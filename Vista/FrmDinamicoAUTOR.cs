using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class FrmDinamicoAUTOR : Form
    {

        //Conecta y carga los datos
        AdmAutor adm = new AdmAutor();


        public FrmDinamicoAUTOR()
        {
            InitializeComponent();

            // Configuración visual
            this.Text = "Información del Autor";
            this.Size = new Size(450, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            MisComponentes();
        }

        private void MisComponentes()
        {
            //1. FOTO
            PictureBox pbFoto = new PictureBox();
            pbFoto.Location = new Point(130, 20);
            pbFoto.Size = new Size(180, 180);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.BorderStyle = BorderStyle.FixedSingle;

            //Obtener la ruta donde se está ejecutando el programa (bin\Debug)
            string rutaDirectorio = Application.StartupPath;

            //Combinar la ruta con el nombre de la foto
            //adm.Foto contiene el nombre del archivo de la foto
            string rutaCompleta = Path.Combine(rutaDirectorio, adm.Foto);

            if (string.IsNullOrEmpty(adm.Foto))
            {
                MessageBox.Show("ERROR: el adm.Foto está vacío, no se han cargado los datos.");
            }
            else
            {
                MessageBox.Show("Buscando foto en: " + rutaCompleta);
            }

            //Agregar el PictureBox al formulario
            if (File.Exists(rutaCompleta))//Si la foto existe
            {
                pbFoto.Image = Image.FromFile(rutaCompleta);//Cargar la imagen
            }
            else//Si no existe
            {
                MessageBox.Show("No encuentro la foto en: " + rutaCompleta);//Mandar mensaje de error y dira donde la esta buscando
                pbFoto.BackColor = Color.Gray;//Poner fondo gris
            }
            this.Controls.Add(pbFoto);//Agregar al formulario

            //--------------------------------------------------------------------//

            //2. NOMBRE
            Label lblNombre = new Label();
            lblNombre.Text = "Nombre Completo:";
            lblNombre.Location = new Point(50, 220);
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial", 10, FontStyle.Bold);
            this.Controls.Add(lblNombre);

            TextBox txtNombre = new TextBox();
            txtNombre.Text = adm.Nombre + " " + adm.Apellido;
            txtNombre.Location = new Point(50, 245);
            txtNombre.Size = new Size(330, 25);
            txtNombre.ReadOnly = true;
            txtNombre.BackColor = Color.White;
            this.Controls.Add(txtNombre);

            //3. CORREO
            Label lblCorreo = new Label();
            lblCorreo.Text = "Correo:";
            lblCorreo.Location = new Point(50, 280);
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Arial", 10, FontStyle.Bold);
            this.Controls.Add(lblCorreo);

            TextBox txtCorreo = new TextBox();
            txtCorreo.Text = adm.Correo;
            txtCorreo.Location = new Point(50, 305);
            txtCorreo.Size = new Size(330, 25);
            txtCorreo.ReadOnly = true;
            txtCorreo.BackColor = Color.White;
            this.Controls.Add(txtCorreo);

            //4. DESCRIPCION
            Label lblDesc = new Label();
            lblDesc.Text = "Descripción:";
            lblDesc.Location = new Point(50, 340);
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Arial", 10, FontStyle.Bold);
            this.Controls.Add(lblDesc);

            TextBox txtDesc = new TextBox();
            txtDesc.Text = adm.Descripcion;
            txtDesc.Location = new Point(50, 365);
            txtDesc.Size = new Size(330, 100);
            txtDesc.Multiline = true;
            txtDesc.ReadOnly = true;
            txtDesc.BackColor = Color.White;
            txtDesc.ScrollBars = ScrollBars.Vertical;
            this.Controls.Add(txtDesc);

            //5. BOTON
            Button btnAceptar = new Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.Location = new Point(170, 490);
            btnAceptar.Size = new Size(100, 35);
            btnAceptar.Click += (s, e) => { this.Close(); };

            this.Controls.Add(btnAceptar);
        }
    }

}
