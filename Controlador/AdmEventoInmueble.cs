//CASTILLO MERA DANIEL FERNANDO
using Datos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public class AdmEventoInmueble
    {
        public static List<EventoInmueble> listaEventoInmueblesTemp = new List<EventoInmueble>();
        ConexionBDD cnBDD = null;
        DatosEventoInmueble datosEventoInmueble = null;
        static AdmEvento admEvento = new AdmEvento();
        static int idEvento;

        public AdmEventoInmueble()
        {
            // Constructor vacío - La consulta se debe hacer explícitamente cuando se necesite
        }

        // Método público para consultar cuando sea necesario
        public void CargarEventosInmueblesDesdeBaseDatos()
        {
            ConsultarEventoInmuebleBDD();
        }

        private void ConsultarEventoInmuebleBDD()
        {
            cnBDD = new ConexionBDD();
            datosEventoInmueble = new DatosEventoInmueble();
            string msj = cnBDD.Conectar();

            if (msj[0] == '1')
            {
                listaEventoInmueblesTemp = datosEventoInmueble.ConsultarEventosInmuebles(cnBDD.sql);
                if (listaEventoInmueblesTemp.Count == 0)
                {
                    MessageBox.Show("No existen registros en la Base de Datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cnBDD.Desconectar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj, "Error de conexión a la Base de Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static string[] ObtenerTiposInmueble()
        {
            return AdmInmueble.ObtenerTiposInmueble();
        }

        public static EventoInmueble CrearEventoInmueble(Inmueble inmueble, int cantidad, DateTime fechaAsignacion)
        {
            EventoInmueble eventoInmueble = new EventoInmueble();
            eventoInmueble.inmueble = inmueble;
            eventoInmueble.cantidadInmueble = cantidad;
            eventoInmueble.fechaAsignacionInmueble = fechaAsignacion;
            
            return eventoInmueble;
        }

        public static void AgregarInmuebleTemp(EventoInmueble eventoInmueble)
        {
            bool existe = false;
            for (int i = 0; i < listaEventoInmueblesTemp.Count; i++)
            {
                if (listaEventoInmueblesTemp[i].ObtenerNumInmuebles() == eventoInmueble.ObtenerNumInmuebles())
                {
                    listaEventoInmueblesTemp[i] = eventoInmueble;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                listaEventoInmueblesTemp.Add(eventoInmueble);
                idEvento = admEvento.ObtenerNumeroEventoEditar();
                // Nota: Si necesitas registrar en BDD, hacerlo desde donde se llama este método
                // o descomentar y crear instancia solo cuando sea necesario:
                // new AdmEventoInmueble().RegistrarEventoInmuebleBDD(idEvento, eventoInmueble);
            }
        }

        public static void EliminarInmuebleTemp(string numeroInmueble)
        {
            for (int i = listaEventoInmueblesTemp.Count - 1; i >= 0; i--)
            {
                if (listaEventoInmueblesTemp[i].ObtenerNumInmuebles() == numeroInmueble)
                {
                    listaEventoInmueblesTemp.RemoveAt(i);
                    break;
                }
            }
        }

        public static void LimpiarInmueblesTemp()
        {
            listaEventoInmueblesTemp.Clear();
        }

        public static EventoInmueble ObtenerInmuebleTempPorNumero(string numeroInmueble)
        {
            for (int i = 0; i < listaEventoInmueblesTemp.Count; i++)
            {
                if (listaEventoInmueblesTemp[i].ObtenerNumInmuebles() == numeroInmueble)
                {
                    return listaEventoInmueblesTemp[i];
                }
            }
            return null;
        }

        public static int ObtenerCantidadInmueblesTemp()
        {
            return listaEventoInmueblesTemp.Count;
        }

        private void RegistrarEventoInmuebleBDD(int idEvento, EventoInmueble eventoInmueble)
        {
            cnBDD = new ConexionBDD();
            datosEventoInmueble = new DatosEventoInmueble();
            string msj = cnBDD.Conectar();
            string resp = "";

            if (msj[0] == '1')
            {
                resp = datosEventoInmueble.RegistrarEventoInmueble(idEvento, eventoInmueble, cnBDD.sql);
                if (resp[0] == '1')
                {
                    MessageBox.Show("Los datos del Evento se registraron en la Base de Datos exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resp[0] == '0')
                {
                    MessageBox.Show(resp, "Error al guardar los datos del Evento en la Base de Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cnBDD.Desconectar();
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show(msj, "Error de conexión a la Base de Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}