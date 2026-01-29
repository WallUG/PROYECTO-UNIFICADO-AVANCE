using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Datos
{
    public class DatosFactura
    {
        SqlCommand cmd = null;
        int idFactura;

        public void EliminarFactura(string NumeroFactura, SqlConnection cn)
        {
            SqlCommand cmd = null;
            string comando = "UPDATE Factura SET Estado=@Estado WHERE NumeroFactura=@NumeroFactura";
            cmd = new SqlCommand(comando, cn);
            cmd.Parameters.AddWithValue("@NumeroFactura", NumeroFactura);
            cmd.Parameters.AddWithValue("@Estado", 'I');
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Factura> ConsultarFacturas(SqlConnection cn)
        {
            List<Factura> listaFacturas = new List<Factura>();
            Factura factura = null;
            Evento evento = null;
            string msj = "";
            string comando = "SELECT * FROM Factura WHERE Estado = 'A'";
            cmd = new SqlCommand(comando, cn);
            SqlDataReader TablaVirtual = null;
            try
            {
                cmd.Connection = cn;
                cmd.CommandText = comando;
                TablaVirtual = cmd.ExecuteReader();
                if (TablaVirtual.HasRows)
                {
                    while (TablaVirtual.Read())
                    {
                        factura = new Factura(evento);
                        factura.IdFactura = TablaVirtual.GetInt32(0);
                        factura.Secuencial = TablaVirtual.GetInt32(1);
                        factura.NumeroFactura = TablaVirtual.GetString(2);
                        factura.Evento = new DatosEvento().BuscarEventoPorIDEvento(Convert.ToInt32(TablaVirtual["IdEvento"]), cn);
                        factura.Detalles.Add(new DatosFactura().ConsultarDetalleFactura(factura.IdFactura, cn));
                        factura.FechaEmision = TablaVirtual.GetDateTime(4);
                        factura.SubTotal = Convert.ToDouble(TablaVirtual.GetDecimal(5));
                        factura.Iva = Convert.ToDouble(TablaVirtual.GetDecimal(6));
                        factura.Descuento = TablaVirtual.GetInt32(7);
                        factura.Total = Convert.ToDouble(TablaVirtual.GetDecimal(8));
                        factura.Estado = TablaVirtual.GetString(9);
                        listaFacturas.Add(factura);
                    }
                    msj = "1";
                }
                else
                {
                    msj = "0No hay facturas registradas.";
                }
                TablaVirtual.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                msj = "0" + ex.Message;
            }
            return listaFacturas;
        }

        public DetalleFactura ConsultarDetalleFactura(int IdFactura, SqlConnection cn)
        {
            DetalleFactura detalleFactura = null;
            string msj = "";
            string comando = "SELECT * FROM DetalleFactura WHERE IdFactura = @IdFactura AND Estado = 'A'";
            cmd = new SqlCommand(comando, cn);
            cmd.Parameters.AddWithValue("@IdFactura", IdFactura);
            SqlDataReader TablaVirtual = null;
            try
            {
                cmd.Connection = cn;
                cmd.CommandText = comando;
                TablaVirtual = cmd.ExecuteReader();
                if (TablaVirtual.HasRows)
                {
                    while (TablaVirtual.Read())
                    {
                        detalleFactura = new DetalleFactura();
                        detalleFactura.IdDetalle = TablaVirtual.GetInt32(0);
                        detalleFactura.IdFactura = TablaVirtual.GetInt32(1);
                        detalleFactura.NumDetalle = TablaVirtual.GetInt32(2);
                        detalleFactura.Descripcion = TablaVirtual.GetString(3);
                        detalleFactura.Cantidad = TablaVirtual.GetInt32(4);
                        detalleFactura.PrecioUnitario = Convert.ToDouble(TablaVirtual.GetDecimal(5));
                        detalleFactura.Subtotal = Convert.ToDouble(TablaVirtual.GetDecimal(6));
                    }
                    msj = "1";
                }
                else
                {
                    msj = "0No hay detalles de factura registradas.";
                }
                TablaVirtual.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                msj = "0" + ex.Message;
            }
            return detalleFactura;
        }

        public string RegistrarDetalleFactura(DetalleFactura detalleFactura, SqlConnection cn)
        {
            string msj = "";
            string comando = "INSERT INTO DetalleFactura(IdFactura,NumeroDetalle,Descripcion,Cantidad,PrecioUnitario,Subtotal" +
                ",Estado) VALUES(@IdFactura,@NumeroDetalle,@Descripcion,@Cantidad,@PrecioUnitario,@SubTotal,@Estado)"; ; //+
                                                                   //"SELECT CAST(SCOPE_IDENTITY() AS INT)";
            cmd = new SqlCommand(comando, cn);
            cmd.Parameters.AddWithValue("@IdFactura", detalleFactura.IdFactura);
            cmd.Parameters.AddWithValue("@NumeroDetalle", detalleFactura.IdDetalle);
            cmd.Parameters.AddWithValue("@Descripcion", detalleFactura.Descripcion);
            cmd.Parameters.AddWithValue("@Cantidad", detalleFactura.Cantidad);
            cmd.Parameters.AddWithValue("@PrecioUnitario", detalleFactura.PrecioUnitario);
            cmd.Parameters.AddWithValue("@SubTotal", detalleFactura.Subtotal);
            cmd.Parameters.AddWithValue("@Estado", 'A');

            try
            {
                cmd.ExecuteNonQuery();
                //idSecundario = (int)cmd.ExecuteScalar();
                msj = "1";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                msj = "0" + ex.Message;
            }
            return msj;
        }

        public string RegistrarFactura(Factura factura, SqlConnection cn)
        {
            string msj = "";
            string comando = "INSERT INTO Factura(Secuencial,NumeroFactura,IdEvento,FechaEmision, SubTotal, Iva, Descuento," +
                "Total,EstadoFactura,Estado) VALUES(@Secuencial,@NumeroFactura,@IdEvento,@FechaEmision,@SubTotal," +
                "@Iva,@Descuento,@Total,@EstadoFactura,@Estado) " + "SELECT CAST(SCOPE_IDENTITY() AS INT)";

            cmd = new SqlCommand(comando, cn);
            cmd.Parameters.AddWithValue("@Secuencial", factura.Secuencial);
            cmd.Parameters.AddWithValue("@NumeroFactura", factura.NumeroFactura);
            cmd.Parameters.AddWithValue("@IdEvento", factura.Evento.IdEvento);
            cmd.Parameters.AddWithValue("@FechaEmision", factura.FechaEmision.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@SubTotal", factura.SubTotal);
            cmd.Parameters.AddWithValue("@Iva", factura.Iva);
            cmd.Parameters.AddWithValue("@Total", factura.Total);
            cmd.Parameters.AddWithValue("@Descuento", factura.Descuento);
            cmd.Parameters.AddWithValue("@EstadoFactura", factura.Estado);
            cmd.Parameters.AddWithValue("@Estado", 'A');

            try
            {
                //cmd.ExecuteNonQuery();
                idFactura = (int)cmd.ExecuteScalar();
                msj = idFactura.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                msj = "0" + ex.Message;
            }
            return msj;
        }
    }
}
