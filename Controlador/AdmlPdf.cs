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
    public class AdmlPdf
    {
        AdmFactura ctrFac = new AdmFactura();
        DatosPDF datosPdf = new DatosPDF();

        public void GenerarPDF(string rutaPdf)
        {
            List<Factura> facturas = ctrFac.GetFacturas();
            datosPdf.GenerarPDF(rutaPdf, facturas);
        }

        public bool ExistePDF(string rutaPdf)
        {
            return datosPdf.ExisteArchivo(rutaPdf);

        }
    }
}
