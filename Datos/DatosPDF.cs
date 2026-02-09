using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Modelo;
using System;
using System.Collections.Generic;
using System.IO;

namespace Datos
{
    public class DatosPDF
    {
        private PdfFont boldFont;
        private PdfFont normalFont;

        public void GenerarPDFUni(string rutaPdf, Factura factura)
        {
            PdfWriter writer = null;
            PdfDocument pdf = null;
            Document document = null;

            try
            {
                writer = new PdfWriter(rutaPdf);
                pdf = new PdfDocument(writer);
                document = new Document(pdf, iText.Kernel.Geom.PageSize.A4.Rotate());

                PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont normalFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                document.Add(new Paragraph("Consulta de Datos de Factura de POE")
                    .SetFont(boldFont)
                    .SetFontColor(ColorConstants.BLUE)
                    .SetFontSize(16));

                document.Add(new Paragraph("\n"));

                Table table = new Table(10).UseAllAvailableWidth();
                table.AddHeaderCell(new Cell().Add(new Paragraph("Nro.factura").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Nombre Evento").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Numero Persona").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Cliente").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Fecha").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Monto").SetFont(boldFont)));
                //table.AddHeaderCell(new Cell().Add(new Paragraph("Estado").SetFont(boldFont)));
                //table.AddHeaderCell(new Cell().Add(new Paragraph("Valor Consulta").SetFont(boldFont)));

                table.AddCell(factura.NumeroFactura);
                table.AddCell(factura.Evento.NombreEvento);
                table.AddCell(factura.Evento.NumPersonasEvento.ToString());
                table.AddCell(factura.Evento.Cliente.Nombre);
                table.AddCell(factura.FechaEmision.ToString("dd/MM/yyyy"));
                table.AddCell(factura.Total.ToString());
                //table.AddCell(io.cita.Estado);
                //table.AddCell(Convert.ToDouble(io.cita.Medico.ValorConsulta).ToString());


                document.Add(table);
            }
            finally
            {
                if (document != null)
                    document.Close();
                else if (pdf != null)
                    pdf.Close();

                if (writer != null)
                    writer.Close();
            }
        }

        public bool ExisteArchivo(string rutaPdf)
        {
            return File.Exists(rutaPdf);
        }

        public void GenerarPDFListaInmuebles(string rutaPdf, List<Inmueble> inmuebles)
        {
                PdfWriter writer = null;
                PdfDocument pdf = null;
                Document document = null;
    
                try
                {
                    writer = new PdfWriter(rutaPdf);
                    pdf = new PdfDocument(writer);
                    document = new Document(pdf, iText.Kernel.Geom.PageSize.A4);
    
                    PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                    PdfFont normalFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
    
                    document.Add(new Paragraph("Lista de Inmuebles")
                        .SetFont(boldFont)
                        .SetFontColor(ColorConstants.BLUE)
                        .SetFontSize(16));
    
                    document.Add(new Paragraph("\n"));
    
                    Table table = new Table(5).UseAllAvailableWidth();
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Num").SetFont(boldFont)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Nombre").SetFont(boldFont)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Tipo").SetFont(boldFont)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Valor").SetFont(boldFont)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Estado").SetFont(boldFont)));
    
                    foreach (Inmueble inmueble in inmuebles)
                    {
                        table.AddCell(inmueble.numeroInmueble.ToString());
                        table.AddCell(inmueble.nombreInmueble ?? "N/A");
                        table.AddCell(inmueble.tipoInmueble ?? "N/A");
                        table.AddCell("$" + inmueble.precioInmueble.ToString("N2"));
                        table.AddCell(inmueble.Estado ?? "N/A");
                    }
    
                    document.Add(table);
                }
                finally
                {
                    if (document != null)
                        document.Close();
                    else if (pdf != null)
                        pdf.Close();
    
                    if (writer != null)
                        writer.Close();
            }
        }

        public void GenerarPDFListaReservas(string rutaPdf, List<Reserva> reservas)
        {
            PdfWriter writer = null;
            PdfDocument pdf = null;
            Document document = null;
            try
            {
                writer = new PdfWriter(rutaPdf);
                pdf = new PdfDocument(writer);
                document = new Document(pdf, iText.Kernel.Geom.PageSize.A4);
                PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont normalFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                document.Add(new Paragraph("Lista de Reservas")
                    .SetFont(boldFont)
                    .SetFontColor(ColorConstants.BLUE)
                    .SetFontSize(16));
                document.Add(new Paragraph("\n"));
                Table table = new Table(6).UseAllAvailableWidth();
                table.AddHeaderCell(new Cell().Add(new Paragraph("ID").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Código").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Evento").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Fecha").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Hora Inicio").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Hora Fin").SetFont(boldFont)));
                foreach (Reserva reserva in reservas)
                {
                    table.AddCell(reserva.IdReserva.ToString());
                    table.AddCell(reserva.CodigoReserva ?? "N/A");
                    table.AddCell(reserva.evento != null ? reserva.evento.NombreEvento : "N/A");
                    table.AddCell(reserva.FechaReserva.ToString("dd/MM/yyyy"));
                    table.AddCell(reserva.HoraInicio.ToString(@"hh\:mm"));
                    table.AddCell(reserva.HoraFin.ToString(@"hh\:mm"));
                }
                document.Add(table);
            }
            finally
            {
                if (document != null)
                    document.Close();
                else if (pdf != null)
                    pdf.Close();
                if (writer != null)
                    writer.Close();
            }
        }

        public void GenerarPDFListaClientes(string rutaPdf, List<Cliente> clientes)
        {
            PdfWriter writer = null;
            PdfDocument pdf = null;
            Document document = null;
            try
            {
                writer = new PdfWriter(rutaPdf);
                pdf = new PdfDocument(writer);
                document = new Document(pdf, iText.Kernel.Geom.PageSize.A4);
                PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont normalFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                document.Add(new Paragraph("Lista de Clientes")
                    .SetFont(boldFont)
                    .SetFontColor(ColorConstants.BLUE)
                    .SetFontSize(16));
                document.Add(new Paragraph("\n"));
                Table table = new Table(5).UseAllAvailableWidth();
                table.AddHeaderCell(new Cell().Add(new Paragraph("Nro Cliente").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Nombre").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Cédula/RUC").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Teléfono").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Correo Electrónico").SetFont(boldFont)));
                foreach (Cliente cliente in clientes)
                {
                    table.AddCell(cliente.NumeroCliente.ToString());
                    table.AddCell(cliente.ObtenerNombreCompleto());
                    table.AddCell(cliente.CedulaORuc ?? "N/A");
                    table.AddCell(cliente.Telefono ?? "N/A");
                    table.AddCell(cliente.CorreoElectronico ?? "N/A");
                }
                document.Add(table);
            }
            finally
            {
                if (document != null)
                    document.Close();
                else if (pdf != null)
                    pdf.Close();
                if (writer != null)
                    writer.Close();
            }
        }

        public void GenerarPDFListaEventos(string rutaPdf, List<Evento> eventos)
        {
            PdfWriter writer = null;
            PdfDocument pdf = null;
            Document document = null;
            try
            {
                writer = new PdfWriter(rutaPdf);
                pdf = new PdfDocument(writer);
                document = new Document(pdf, iText.Kernel.Geom.PageSize.A4);
                PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont normalFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                document.Add(new Paragraph("Lista de Eventos")
                    .SetFont(boldFont)
                    .SetFontColor(ColorConstants.BLUE)
                    .SetFontSize(16));
                document.Add(new Paragraph("\n"));
                Table table = new Table(5).UseAllAvailableWidth();
                table.AddHeaderCell(new Cell().Add(new Paragraph("Nro Evento").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Nombre").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Tipo").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Direccion").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Cliente").SetFont(boldFont)));
                foreach (Evento evento in eventos)
                {
                    table.AddCell(evento.NumEventos.ToString());
                    table.AddCell(evento.NombreEvento ?? "N/A");
                    table.AddCell(evento.TipoEvento ?? "N/A");
                    table.AddCell(evento.DireccionEvento);
                    table.AddCell(evento.Cliente != null ? evento.Cliente.ObtenerNombreCompleto() : "N/A");
                }
                document.Add(table);
            }
            finally
            {
                if (document != null)
                    document.Close();
                else if (pdf != null)
                    pdf.Close();
                if (writer != null)
                    writer.Close();
            }
        }

        public void GenerarPDF(string rutaPdf, List<Factura> facturas)
        {
            PdfWriter writer = null;
            PdfDocument pdf = null;
            Document document = null;

            try
            {
                writer = new PdfWriter(rutaPdf);
                pdf = new PdfDocument(writer);
                document = new Document(pdf, iText.Kernel.Geom.PageSize.A4.Rotate());

                PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont normalFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                document.Add(new Paragraph("Consulta de Datos de Factura de POE")
                    .SetFont(boldFont)
                    .SetFontColor(ColorConstants.BLUE)
                    .SetFontSize(16));

                document.Add(new Paragraph("\n"));

                Table table = new Table(6).UseAllAvailableWidth();
                table.AddHeaderCell(new Cell().Add(new Paragraph("Nro.factura").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Nombre Evento").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Numero Persona").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Cliente").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Fecha").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Monto").SetFont(boldFont)));
                //table.AddHeaderCell(new Cell().Add(new Paragraph("Estado").SetFont(boldFont)));
                //table.AddHeaderCell(new Cell().Add(new Paragraph("Valor Consulta").SetFont(boldFont)));
                foreach (Factura factura in facturas)
                {
                    table.AddCell(factura.NumeroFactura);
                    table.AddCell(factura.Evento.NombreEvento);
                    table.AddCell(factura.Evento.NumPersonasEvento.ToString());
                    table.AddCell(factura.Evento.Cliente.Nombre);
                    table.AddCell(factura.FechaEmision.ToString("dd/MM/yyyy"));
                    table.AddCell(factura.Total.ToString());
                    //table.AddCell(io.cita.Estado);
                    //table.AddCell(Convert.ToDouble(io.cita.Medico.ValorConsulta).ToString());
                }

                document.Add(table);
            }
            finally
            {
                if (document != null)
                    document.Close();
                else if (pdf != null)
                    pdf.Close();

                if (writer != null)
                    writer.Close();
            }
        }
    }
}
