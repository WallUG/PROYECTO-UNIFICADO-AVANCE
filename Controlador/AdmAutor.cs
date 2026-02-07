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

        public AdmAutor()
        {
            CargarDatosBDD();
        }

        //
        private void CargarDatosBDD()
        {
            string mensaje = conexion.Conectar();

            if (mensaje[0] == '1')
            {
                // Pedimos el objeto a la capa Datos
                Autor obj = datosEst.ObtenerEstudiante(conexion.sql);

                if (obj != null)
                {
                    //Asignamos los valores a las variables públicas
                    this.Nombre = obj.Nombre;
                    this.Apellido = obj.Apellido;
                    this.Correo = obj.Correo;
                    this.carrera = obj.Carrera;
                    this.Descripcion = obj.Descripcion;
                    this.Foto = obj.Foto;
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
