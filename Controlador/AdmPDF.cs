using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Controlador;

namespace Controlador
{
    public class AdmPDF
    {
        AdmFactura ctrFac = new AdmFactura();
        AdmInmueble admInmueble = new AdmInmueble();
        DatosPDF datosPdf = new DatosPDF();

        public void GenerarPDF(string rutaPdf)
        {
            List<Factura> facturas = ctrFac.GetFacturas();
            datosPdf.GenerarPDF(rutaPdf, facturas);
        }

        public void GenerarPDFInmueble(string rutaPdf)
        {
            List<Inmueble> inmuebles = admInmueble.ObtenerListaInmuebles();
            datosPdf.GenerarPDFListaInmuebles(rutaPdf, inmuebles);
        }

        public void GenerarPDFRegistro(string rutaPdf, string num)
        {
            Factura factura = ctrFac.ObtenerFacturaPorNumero(num);
            datosPdf.GenerarPDFUni(rutaPdf, factura);
        }

        public bool ExistePDF(string rutaPdf)
        {
            return datosPdf.ExisteArchivo(rutaPdf);

        }
    }
}
