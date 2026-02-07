using Datos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public class AdmAutor
    {
        Conexion conexion = new Conexion();
        DatosAutor datosEst = new DatosAutor();

        //Variables públicas para almacenar los datos del estudiante
        public string Nombre = "";
        public string Apellido = "";
        public string Correo = "";
        public string carrera = "";
        public string Descripcion = "";
        public string Foto = "";

        public AdmAutor(string Modulo)
        {
            CargarDatosBDD(Modulo);
        }

        //
        private void CargarDatosBDD(string Modulo)
        {
            string mensaje = conexion.Conectar();

            if (mensaje[0] == '1')
            {
                // Pedimos el objeto a la capa Datos
                Autor autor = datosEst.ObtenerEstudiante(conexion.sql, Modulo);

                if (autor != null)
                {
                    //Asignamos los valores a las variables públicas
                    this.Nombre = autor.Nombre;
                    this.Apellido = autor.Apellido;
                    this.Correo = autor.Correo;
                    this.carrera = autor.Carrera;
                    this.Descripcion = autor.Descripcion;
                    this.Foto = autor.Foto;
                }

                conexion.Desconectar();
            }
            else
            {
                MessageBox.Show("Error de conexión: " + mensaje);
            }
        }


    }
}
