using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class FrmAutorDinamico : Form
    {
        // Componentes dinámicos
        private PictureBox pbFotoAutor;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblCarrera;
        private Label lblDescripcion;
        private Label lblTitulo;
        private Panel panelContenedor;
        private Button btnCerrar;
        private Button btnCargarFoto;

        // Datos del autor
        private string nombreAutor;
        private string carreraAutor;
        private string universidadAutor;
        private string moduloAutor;
        private string urlImagen;

        public FrmAutorDinamico()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CrearComponentesDinamicos();
            CargarDatosAutorBDD();
        }

        private void ConfigurarFormulario()
        {
            // Configuración del formulario
            this.Text = "Autor del Módulo Factura";
            this.Size = new Size(450, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.WhiteSmoke;
        }

        private void CargarDatosAutorBDD()
        {
            try
            {
                AdmFactura adm = new AdmFactura();
                adm.GenerarInfoAutor(lblNombre, lblApellido, lblCarrera, lblDescripcion, pbFotoAutor);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar datos del autor: " + ex.Message);
            }
        }

        private void CrearComponentesDinamicos()
        {
            // Panel contenedor principal
            panelContenedor = new Panel
            {
                Size = new Size(400, 480),
                Location = new Point(20, 20),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(panelContenedor);

            // Título del formulario
            lblTitulo = new Label
            {
                Text = "Información del Autor",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.DarkSlateBlue,
                AutoSize = false,
                Size = new Size(380, 35),
                Location = new Point(10, 10),
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelContenedor.Controls.Add(lblTitulo);

            // PictureBox para la foto del autor
            pbFotoAutor = new PictureBox
            {
                Size = new Size(150, 180),
                Location = new Point(125, 55),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.LightGray
            };
            // Cargar imagen desde la URL de la base de datos
            CargarImagenDesdeUrl();
            panelContenedor.Controls.Add(pbFotoAutor);

            // Label para el nombre (desde la BDD)
            lblNombre = new Label
            {
                Text = nombreAutor,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                AutoSize = false,
                Size = new Size(380, 35),
                Location = new Point(10, 290),
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelContenedor.Controls.Add(lblNombre);

            // Label para la carrera (desde la BDD)
            lblApellido = new Label
            {
                Text = carreraAutor,
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                ForeColor = Color.DarkSlateGray,
                AutoSize = false,
                Size = new Size(380, 30),
                Location = new Point(10, 330),
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelContenedor.Controls.Add(lblApellido);

            // Label para la universidad (desde la BDD)
            lblCarrera = new Label
            {
                Text = universidadAutor,
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                ForeColor = Color.DarkSlateGray,
                AutoSize = false,
                Size = new Size(380, 30),
                Location = new Point(10, 365),
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelContenedor.Controls.Add(lblCarrera);

            // Label para el módulo (desde la BDD)
            lblDescripcion = new Label
            {
                Text = "Autor del Módulo: " + moduloAutor,
                Font = new Font("Segoe UI", 11, FontStyle.Italic),
                ForeColor = Color.SeaGreen,
                AutoSize = false,
                Size = new Size(380, 30),
                Location = new Point(10, 400),
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelContenedor.Controls.Add(lblDescripcion);

            // Botón cerrar
            btnCerrar = new Button
            {
                Text = "Cerrar",
                Size = new Size(120, 35),
                Location = new Point(140, 440),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.IndianRed,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.Click += BtnCerrar_Click;
            panelContenedor.Controls.Add(btnCerrar);
        }

        private void CargarImagenDesdeUrl()
        {
            try
            {
                if (!string.IsNullOrEmpty(urlImagen))
                {
                    // La URL apunta a una ruta dentro del proyecto
                    string rutaImagen = ObtenerRutaCompleta(urlImagen);

                    if (File.Exists(rutaImagen))
                    {
                        // Usar FileStream para evitar bloqueo del archivo
                        using (FileStream fs = new FileStream(rutaImagen, FileMode.Open, FileAccess.Read))
                        {
                            pbFotoAutor.Image = Image.FromStream(fs);
                        }
                        return;
                    }
                }

                // Si no hay URL o no existe el archivo, crear placeholder
                CrearImagenPlaceholder();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar imagen: " + ex.Message);
                CrearImagenPlaceholder();
            }
        }

        private string ObtenerRutaCompleta(string rutaImagenParam)
        {
            // Si la ruta es absoluta, devolverla tal cual
            if (Path.IsPathRooted(rutaImagenParam))
            {
                return rutaImagenParam;
            }

            // Si es relativa, combinarla con el directorio de la aplicación
            string baseDir = Application.StartupPath;

            // Intentar diferentes ubicaciones comunes
            string[] posiblesRutas = new string[]
            {
                Path.Combine(baseDir, rutaImagenParam),
                Path.Combine(baseDir, "Imagenes", rutaImagenParam),
                Path.Combine(baseDir, "Resources", rutaImagenParam),
                Path.Combine(baseDir, "..", "..", rutaImagenParam),
                Path.Combine(baseDir, "..", "..", "Imagenes", rutaImagenParam),
                Path.Combine(baseDir, "..", "..", "Resources", rutaImagenParam)
            };

            foreach (string ruta in posiblesRutas)
            {
                string rutaNormalizada = Path.GetFullPath(ruta);
                if (File.Exists(rutaNormalizada))
                {
                    return rutaNormalizada;
                }
            }

            // Si no se encuentra en ninguna ubicación, devolver la ruta original combinada
            return Path.Combine(baseDir, rutaImagenParam);
        }

        private void CrearImagenPlaceholder()
        {
            // Crear un placeholder visual cuando no hay imagen
            Bitmap placeholder = new Bitmap(150, 180);
            using (Graphics g = Graphics.FromImage(placeholder))
            {
                g.Clear(Color.LightGray);
                g.DrawString("Sin Foto", new Font("Segoe UI", 12), Brushes.DarkGray,
                    new RectangleF(0, 75, 150, 30),
                    new StringFormat { Alignment = StringAlignment.Center });
            }
            pbFotoAutor.Image = placeholder;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
