using Controlador;
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

namespace Visual
{
    public partial class FrmDinamicoAutorReserva : Form
    {
        AdmAutor admAutor;

        public FrmDinamicoAutorReserva()
        {
            InitializeComponent();

            // Cargamos los datos del autor desde la BDD
            admAutor = new AdmAutor("Reservas");

            // Configuramos la ventana y los controles al iniciar
            ConfigurarVentana();
            CrearControles();
        }

        private void ConfigurarVentana()
        {
            this.Text = "Información del Autor";
            this.Size = new Size(500, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.FromArgb(240, 244, 248);
        }

        private void CrearControles()
        {
            int posY = 20;
            int margenIzq = 30;

            // --- TÍTULO PRINCIPAL ---
            Label lblTitulo = new Label();
            lblTitulo.Text = "DATOS DEL AUTOR";
            lblTitulo.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(41, 128, 185);
            lblTitulo.AutoSize = true;
            this.Controls.Add(lblTitulo);
            lblTitulo.Location = new Point((this.ClientSize.Width - lblTitulo.Width) / 2, posY);
            posY += 60;

            // --- PANEL CONTENEDOR ---
            Panel panelDatos = new Panel();
            panelDatos.Location = new Point(margenIzq, posY);
            panelDatos.Size = new Size(440, 400);
            panelDatos.BackColor = Color.White;
            panelDatos.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(panelDatos);

            int posYPanel = 20;

            // --- FOTO DEL AUTOR ---
            PictureBox pbFoto = new PictureBox();
            pbFoto.Size = new Size(120, 140);
            pbFoto.Location = new Point((panelDatos.Width - pbFoto.Width) / 2, posYPanel);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.BorderStyle = BorderStyle.Fixed3D;
            pbFoto.BackColor = Color.LightGray;

            // Intentar cargar la foto desde la ruta de la BDD
            if (!string.IsNullOrEmpty(admAutor.Foto))
            {
                string rutaFoto = admAutor.Foto;

                // Si es una ruta relativa, la combinamos con la ruta de la aplicación
                if (!Path.IsPathRooted(rutaFoto))
                {
                    rutaFoto = Path.Combine(Application.StartupPath, admAutor.Foto);
                }

                if (File.Exists(rutaFoto))
                {
                    try
                    {
                        pbFoto.Image = Image.FromFile(rutaFoto);
                    }
                    catch
                    {
                        // Si hay error al cargar, dejamos el fondo gris
                        AgregarTextoEnPictureBox(pbFoto, "Sin foto");
                    }
                }
                else
                {
                    AgregarTextoEnPictureBox(pbFoto, "Foto no encontrada");
                }
            }
            else
            {
                AgregarTextoEnPictureBox(pbFoto, "Sin foto");
            }

            panelDatos.Controls.Add(pbFoto);
            posYPanel += 160;

            // --- SEPARADOR ---
            Panel separador1 = new Panel();
            separador1.Location = new Point(20, posYPanel);
            separador1.Size = new Size(400, 2);
            separador1.BackColor = Color.FromArgb(189, 195, 199);
            panelDatos.Controls.Add(separador1);
            posYPanel += 15;

            // --- NOMBRE ---
            CrearCampoInfo(panelDatos, "Nombre:", admAutor.Nombre, ref posYPanel);

            // --- APELLIDO ---
            CrearCampoInfo(panelDatos, "Apellido:", admAutor.Apellido, ref posYPanel);

            // --- CORREO ---
            CrearCampoInfo(panelDatos, "Correo:", admAutor.Correo, ref posYPanel);

            // --- DESCRIPCIÓN ---
            Label lblDescTitulo = new Label();
            lblDescTitulo.Text = "Descripción:";
            lblDescTitulo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblDescTitulo.ForeColor = Color.FromArgb(52, 73, 94);
            lblDescTitulo.AutoSize = true;
            lblDescTitulo.Location = new Point(20, posYPanel);
            panelDatos.Controls.Add(lblDescTitulo);
            posYPanel += 25;

            TextBox txtDescripcion = new TextBox();
            txtDescripcion.Text = string.IsNullOrEmpty(admAutor.Descripcion)
                ? "Sin descripción"
                : admAutor.Descripcion;
            txtDescripcion.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            txtDescripcion.Location = new Point(20, posYPanel);
            txtDescripcion.Size = new Size(400, 60);
            txtDescripcion.Multiline = true;
            txtDescripcion.ReadOnly = true;
            txtDescripcion.BackColor = Color.FromArgb(236, 240, 241);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            panelDatos.Controls.Add(txtDescripcion);
            posYPanel += 70;

            // --- RUTA DE FOTO (Informativa) ---
            Label lblFotoRutaTitulo = new Label();
            lblFotoRutaTitulo.Text = "Ruta foto:";
            lblFotoRutaTitulo.Font = new Font("Segoe UI", 8, FontStyle.Italic);
            lblFotoRutaTitulo.ForeColor = Color.Gray;
            lblFotoRutaTitulo.AutoSize = true;
            lblFotoRutaTitulo.Location = new Point(20, posYPanel);
            panelDatos.Controls.Add(lblFotoRutaTitulo);
            posYPanel += 18;

            Label lblFotoRuta = new Label();
            lblFotoRuta.Text = string.IsNullOrEmpty(admAutor.Foto)
                ? "No especificada"
                : admAutor.Foto;
            lblFotoRuta.Font = new Font("Segoe UI", 8, FontStyle.Regular);
            lblFotoRuta.ForeColor = Color.DimGray;
            lblFotoRuta.AutoSize = true;
            lblFotoRuta.MaximumSize = new Size(400, 0);
            lblFotoRuta.Location = new Point(20, posYPanel);
            panelDatos.Controls.Add(lblFotoRuta);

            // --- BOTÓN CERRAR ---
            Button btnCerrar = new Button();
            btnCerrar.Text = "CERRAR";
            btnCerrar.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnCerrar.Size = new Size(150, 45);
            btnCerrar.Location = new Point((this.ClientSize.Width - btnCerrar.Width) / 2, 520);
            btnCerrar.BackColor = Color.FromArgb(231, 76, 60);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Click += BtnCerrar_Click;
            this.Controls.Add(btnCerrar);

            // Efecto hover en el botón
            btnCerrar.MouseEnter += (s, e) => btnCerrar.BackColor = Color.FromArgb(192, 57, 43);
            btnCerrar.MouseLeave += (s, e) => btnCerrar.BackColor = Color.FromArgb(231, 76, 60);
        }

        // Método auxiliar para crear campos de información
        private void CrearCampoInfo(Panel panel, string etiqueta, string valor, ref int posY)
        {
            // Etiqueta
            Label lblTitulo = new Label();
            lblTitulo.Text = etiqueta;
            lblTitulo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(52, 73, 94);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(20, posY);
            panel.Controls.Add(lblTitulo);

            // Valor
            Label lblValor = new Label();
            lblValor.Text = string.IsNullOrEmpty(valor) ? "No especificado" : valor;
            lblValor.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblValor.ForeColor = Color.FromArgb(44, 62, 80);
            lblValor.AutoSize = true;
            lblValor.MaximumSize = new Size(280, 0);
            lblValor.Location = new Point(150, posY);
            panel.Controls.Add(lblValor);

            posY += 35;
        }

        // Método auxiliar para agregar texto a un PictureBox sin imagen
        private void AgregarTextoEnPictureBox(PictureBox pb, string texto)
        {
            Bitmap bmp = new Bitmap(pb.Width, pb.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);
                g.DrawString(texto, new Font("Segoe UI", 9), Brushes.DarkGray,
                    new RectangleF(0, pb.Height / 2 - 10, pb.Width, 20),
                    new StringFormat { Alignment = StringAlignment.Center });
            }
            pb.Image = bmp;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}