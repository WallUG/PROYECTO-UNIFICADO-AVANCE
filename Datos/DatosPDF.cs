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



        public void GenerarPDF(string rutaPdf, List<Factura> facturas)
        {
            PdfWriter writer = null;
            PdfDocument pdf = null;
            Document document = null;

            try
            {
                writer = new PdfWriter(rutaPdf);
                pdf = new PdfDocument(writer);
                document = new Document(pdf, iText.Kernel.Geom.PageSize.A4);

                boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                normalFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                // Encabezado del documento
                AgregarEncabezado(document);

                // Información de generación
                AgregarInfoGeneracion(document, facturas.Count);

                // Agregar cada factura individualmente
                double totalGeneralFacturas = 0;
                for (int i = 0; i < facturas.Count; i++)
                {
                    AgregarFacturaIndividual(document, facturas[i], i + 1);
                    totalGeneralFacturas += facturas[i].Total;

                    // Agregar separador entre facturas (excepto la última)
                    if (i < facturas.Count - 1)
                    {
                        document.Add(new Paragraph("\n"));
                    }
                }

                // Resumen general de todas las facturas
                AgregarResumenGeneral(document, facturas, totalGeneralFacturas);

                // Pie de página
                AgregarPiePagina(document);
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

                document.Add(new Paragraph("Consulta de Datos de Paciente de POE")
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

        private void AgregarEncabezado(Document document)
        {
            Paragraph titulo = new Paragraph("REPORTE DE FACTURAS")
                .SetFont(boldFont)
                .SetFontSize(20)
                .SetFontColor(new DeviceRgb(0, 51, 102))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetMarginBottom(5);

            Paragraph subtitulo = new Paragraph("Sistema de Gestión de Eventos")
                .SetFont(normalFont)
                .SetFontSize(12)
                .SetFontColor(ColorConstants.DARK_GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetMarginBottom(20);

            document.Add(titulo);
            document.Add(subtitulo);

            // Línea separadora
            document.Add(new Paragraph("─────────────────────────────────────────────────────────────────")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontColor(new DeviceRgb(0, 51, 102))
                .SetMarginBottom(15));
        }

        private void AgregarInfoGeneracion(Document document, int cantidadFacturas)
        {
            Table infoTable = new Table(2).UseAllAvailableWidth();
            infoTable.SetMarginBottom(20);

            infoTable.AddCell(CrearCeldaInfo("Fecha de generación:", DateTime.Now.ToString("dd/MM/yyyy HH:mm")));
            infoTable.AddCell(CrearCeldaInfo("Total de facturas:", cantidadFacturas.ToString()));

            document.Add(infoTable);
        }

        private Cell CrearCeldaInfo(string etiqueta, string valor)
        {
            Paragraph p = new Paragraph()
                .Add(new Text(etiqueta + " ").SetFont(boldFont).SetFontSize(10))
                .Add(new Text(valor).SetFont(normalFont).SetFontSize(10));

            return new Cell()
                .Add(p)
                .SetBorder(iText.Layout.Borders.Border.NO_BORDER)
                .SetPadding(2);
        }

        private void AgregarFacturaIndividual(Document document, Factura factura, int numeroOrden)
        {
            // Encabezado de la factura
            string numeroFactura = !string.IsNullOrEmpty(factura.NumeroFactura)
                ? factura.NumeroFactura
                : "FAC-" + factura.Secuencial.ToString("D6");

            Table encabezadoFactura = new Table(2).UseAllAvailableWidth();
            encabezadoFactura.SetBackgroundColor(new DeviceRgb(0, 51, 102));
            encabezadoFactura.SetMarginBottom(10);

            Cell celdaNumero = new Cell()
                .Add(new Paragraph("FACTURA N° " + numeroFactura).SetFont(boldFont).SetFontSize(12))
                .SetFontColor(ColorConstants.WHITE)
                .SetBorder(iText.Layout.Borders.Border.NO_BORDER)
                .SetPadding(8);

            string fechaEmision = factura.FechaEmision != DateTime.MinValue
                ? factura.FechaEmision.ToString("dd/MM/yyyy")
                : DateTime.Now.ToString("dd/MM/yyyy");

            Cell celdaFecha = new Cell()
                .Add(new Paragraph("Fecha: " + fechaEmision).SetFont(normalFont).SetFontSize(10))
                .SetFontColor(ColorConstants.WHITE)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetBorder(iText.Layout.Borders.Border.NO_BORDER)
                .SetPadding(8);

            encabezadoFactura.AddCell(celdaNumero);
            encabezadoFactura.AddCell(celdaFecha);
            document.Add(encabezadoFactura);

            // Información del cliente y evento
            AgregarInfoClienteEvento(document, factura);

            // Detalles de la factura
            AgregarDetallesFactura(document, factura);

            // Totales de la factura
            AgregarTotalesFactura(document, factura);
        }

        private void AgregarInfoClienteEvento(Document document, Factura factura)
        {
            Table infoTable = new Table(2).UseAllAvailableWidth();
            infoTable.SetMarginBottom(10);

            // Columna Cliente
            string nombreCliente = "N/A";
            string cedulaCliente = "N/A";
            if (factura.Evento != null && factura.Evento.Cliente != null)
            {
                nombreCliente = factura.Evento.ObtenerNombreCliente();
                cedulaCliente = factura.Evento.Cliente.CedulaORuc ?? "N/A";
            }

            Cell celdaCliente = new Cell()
                .Add(new Paragraph("DATOS DEL CLIENTE").SetFont(boldFont).SetFontSize(10).SetFontColor(new DeviceRgb(0, 51, 102)))
                .Add(new Paragraph("Nombre: " + nombreCliente).SetFont(normalFont).SetFontSize(9))
                .Add(new Paragraph("CI/RUC: " + cedulaCliente).SetFont(normalFont).SetFontSize(9))
                .SetBorder(iText.Layout.Borders.Border.NO_BORDER)
                .SetPaddingRight(20);

            // Columna Evento
            string nombreEvento = "N/A";
            string tipoEvento = "N/A";
            string direccionEvento = "N/A";
            int numPersonas = 0;

            if (factura.Evento != null)
            {
                nombreEvento = factura.Evento.NombreEvento ?? "N/A";
                tipoEvento = factura.Evento.TipoEvento ?? "N/A";
                direccionEvento = factura.Evento.DireccionEvento ?? "N/A";
                numPersonas = factura.Evento.NumPersonasEvento;
            }

            Cell celdaEvento = new Cell()
                .Add(new Paragraph("DATOS DEL EVENTO").SetFont(boldFont).SetFontSize(10).SetFontColor(new DeviceRgb(0, 51, 102)))
                .Add(new Paragraph("Evento: " + nombreEvento).SetFont(normalFont).SetFontSize(9))
                .Add(new Paragraph("Tipo: " + tipoEvento).SetFont(normalFont).SetFontSize(9))
                .Add(new Paragraph("Dirección: " + direccionEvento).SetFont(normalFont).SetFontSize(9))
                .Add(new Paragraph("N° Personas: " + numPersonas.ToString()).SetFont(normalFont).SetFontSize(9))
                .SetBorder(iText.Layout.Borders.Border.NO_BORDER);

            infoTable.AddCell(celdaCliente);
            infoTable.AddCell(celdaEvento);
            document.Add(infoTable);
        }

        private void AgregarDetallesFactura(Document document, Factura factura)
        {
            document.Add(new Paragraph("Detalle de Servicios")
                .SetFont(boldFont)
                .SetFontSize(10)
                .SetFontColor(new DeviceRgb(0, 51, 102))
                .SetMarginTop(5)
                .SetMarginBottom(5));

            Table tablaDetalles = new Table(new float[] { 0.5f, 3f, 1f, 1.5f, 1.5f }).UseAllAvailableWidth();

            // Encabezados
            tablaDetalles.AddHeaderCell(CrearCeldaEncabezado("N°"));
            tablaDetalles.AddHeaderCell(CrearCeldaEncabezado("Descripción"));
            tablaDetalles.AddHeaderCell(CrearCeldaEncabezado("Cant."));
            tablaDetalles.AddHeaderCell(CrearCeldaEncabezado("P. Unit."));
            tablaDetalles.AddHeaderCell(CrearCeldaEncabezado("Subtotal"));

            // Filas de detalles
            if (factura.Detalles != null && factura.Detalles.Count > 0)
            {
                int numDetalle = 1;
                foreach (DetalleFactura detalle in factura.Detalles)
                {
                    tablaDetalles.AddCell(CrearCeldaDato(numDetalle.ToString(), TextAlignment.CENTER));
                    tablaDetalles.AddCell(CrearCeldaDato(detalle.Descripcion ?? "Sin descripción", TextAlignment.LEFT));
                    tablaDetalles.AddCell(CrearCeldaDato(detalle.Cantidad.ToString(), TextAlignment.CENTER));
                    tablaDetalles.AddCell(CrearCeldaDato("$" + detalle.PrecioUnitario.ToString("N2"), TextAlignment.RIGHT));
                    tablaDetalles.AddCell(CrearCeldaDato("$" + detalle.Subtotal.ToString("N2"), TextAlignment.RIGHT));
                    numDetalle++;
                }
            }
            else
            {
                // Si no hay detalles, mostrar información del evento como servicio
                tablaDetalles.AddCell(CrearCeldaDato("1", TextAlignment.CENTER));
                string descripcion = factura.Evento != null ? "Servicio de evento: " + factura.Evento.NombreEvento : "Servicio de evento";
                tablaDetalles.AddCell(CrearCeldaDato(descripcion, TextAlignment.LEFT));
                tablaDetalles.AddCell(CrearCeldaDato("1", TextAlignment.CENTER));
                tablaDetalles.AddCell(CrearCeldaDato("$" + factura.SubTotal.ToString("N2"), TextAlignment.RIGHT));
                tablaDetalles.AddCell(CrearCeldaDato("$" + factura.SubTotal.ToString("N2"), TextAlignment.RIGHT));
            }

            document.Add(tablaDetalles);
        }

        private void AgregarTotalesFactura(Document document, Factura factura)
        {
            Table tablaTotales = new Table(2);
            tablaTotales.SetWidth(200);
            tablaTotales.SetHorizontalAlignment(HorizontalAlignment.RIGHT);
            tablaTotales.SetMarginTop(10);
            tablaTotales.SetMarginBottom(15);

            // Subtotal
            tablaTotales.AddCell(CrearCeldaTotales("Subtotal:", false));
            tablaTotales.AddCell(CrearCeldaTotales("$" + factura.SubTotal.ToString("N2"), false));

            // Descuento (si aplica)
            if (factura.DescuentoAplicado > 0)
            {
                tablaTotales.AddCell(CrearCeldaTotales("Descuento (" + factura.Descuento + "%):", false));
                tablaTotales.AddCell(CrearCeldaTotales("-$" + factura.DescuentoAplicado.ToString("N2"), false));
            }

            // IVA
            tablaTotales.AddCell(CrearCeldaTotales("IVA (15%):", false));
            tablaTotales.AddCell(CrearCeldaTotales("$" + factura.Iva.ToString("N2"), false));

            // Total
            tablaTotales.AddCell(CrearCeldaTotales("TOTAL:", true));
            tablaTotales.AddCell(CrearCeldaTotales("$" + factura.Total.ToString("N2"), true));

            document.Add(tablaTotales);

            // Línea separadora entre facturas
            document.Add(new Paragraph("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontColor(ColorConstants.LIGHT_GRAY)
                .SetMarginTop(5));
        }

        private Cell CrearCeldaEncabezado(string texto)
        {
            return new Cell()
                .Add(new Paragraph(texto).SetFont(boldFont).SetFontSize(9))
                .SetBackgroundColor(new DeviceRgb(0, 51, 102))
                .SetFontColor(ColorConstants.WHITE)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetPadding(6);
        }

        private Cell CrearCeldaDato(string texto, TextAlignment alineacion)
        {
            return new Cell()
                .Add(new Paragraph(texto).SetFont(normalFont).SetFontSize(8))
                .SetTextAlignment(alineacion)
                .SetPadding(5)
                .SetBorderBottom(new iText.Layout.Borders.SolidBorder(ColorConstants.LIGHT_GRAY, 0.5f));
        }

        private Cell CrearCeldaTotales(string texto, bool esTotal)
        {
            PdfFont fuente = esTotal ? boldFont : normalFont;
            int tamano = esTotal ? 11 : 9;
            Color colorFondo = esTotal ? new DeviceRgb(0, 51, 102) : ColorConstants.WHITE;
            Color colorTexto = esTotal ? ColorConstants.WHITE : ColorConstants.BLACK;

            return new Cell()
                .Add(new Paragraph(texto).SetFont(fuente).SetFontSize(tamano))
                .SetBackgroundColor(colorFondo)
                .SetFontColor(colorTexto)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetPadding(5)
                .SetBorder(iText.Layout.Borders.Border.NO_BORDER);
        }

        private void AgregarResumenGeneral(Document document, List<Factura> facturas, double totalGeneral)
        {
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph("RESUMEN GENERAL")
                .SetFont(boldFont)
                .SetFontSize(14)
                .SetFontColor(new DeviceRgb(0, 51, 102))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetMarginBottom(10));

            double totalSubtotal = 0;
            double totalIva = 0;
            double totalDescuentos = 0;

            foreach (Factura factura in facturas)
            {
                totalSubtotal += factura.SubTotal;
                totalIva += factura.Iva;
                totalDescuentos += factura.DescuentoAplicado;
            }

            Table resumenTable = new Table(2);
            resumenTable.SetWidth(250);
            resumenTable.SetHorizontalAlignment(HorizontalAlignment.CENTER);

            resumenTable.AddCell(CrearCeldaResumenGeneral("Total Facturas:", facturas.Count.ToString()));
            resumenTable.AddCell(CrearCeldaResumenGeneral("Subtotal General:", "$" + totalSubtotal.ToString("N2")));
            
            if (totalDescuentos > 0)
            {
                resumenTable.AddCell(CrearCeldaResumenGeneral("Descuentos Aplicados:", "-$" + totalDescuentos.ToString("N2")));
            }
            
            resumenTable.AddCell(CrearCeldaResumenGeneral("IVA Total:", "$" + totalIva.ToString("N2")));
            resumenTable.AddCell(CrearCeldaResumenGeneralTotal("TOTAL GENERAL:", "$" + totalGeneral.ToString("N2")));

            document.Add(resumenTable);
        }

        private Cell CrearCeldaResumenGeneral(string etiqueta, string valor)
        {
            Paragraph p = new Paragraph()
                .Add(new Text(etiqueta + " ").SetFont(boldFont).SetFontSize(10))
                .Add(new Text(valor).SetFont(normalFont).SetFontSize(10));

            return new Cell(1, 2)
                .Add(p)
                .SetBorder(iText.Layout.Borders.Border.NO_BORDER)
                .SetPadding(3)
                .SetTextAlignment(TextAlignment.CENTER);
        }

        private Cell CrearCeldaResumenGeneralTotal(string etiqueta, string valor)
        {
            Paragraph p = new Paragraph()
                .Add(new Text(etiqueta + " ").SetFont(boldFont).SetFontSize(12))
                .Add(new Text(valor).SetFont(boldFont).SetFontSize(12));

            return new Cell(1, 2)
                .Add(p)
                .SetBackgroundColor(new DeviceRgb(0, 51, 102))
                .SetFontColor(ColorConstants.WHITE)
                .SetBorder(iText.Layout.Borders.Border.NO_BORDER)
                .SetPadding(8)
                .SetTextAlignment(TextAlignment.CENTER);
        }

        private void AgregarPiePagina(Document document)
        {
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph("─────────────────────────────────────────────────────────────────")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontColor(ColorConstants.LIGHT_GRAY));

            document.Add(new Paragraph("Documento generado automáticamente - Sistema de Gestión de Eventos POE")
                .SetFont(normalFont)
                .SetFontSize(8)
                .SetFontColor(ColorConstants.GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetMarginTop(10));
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
    }

}
