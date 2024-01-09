using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDVenta
    {
        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from VENTA");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    idcorrelativo = Convert.ToInt32(cmd.ExecuteScalar());

                }
                catch (Exception ex)
                {
                    idcorrelativo = 0;
                }
            }
            return idcorrelativo;
        }

        public bool RestarStock(int idproducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update producto set stock = stock - @cantidad where idproducto = @idproducto");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }

        public bool SumarStock(int idproducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update producto set stock = stock + @cantidad where idproducto = @idproducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }

        public bool Registrar(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
                {
                    SqlCommand cmd = new SqlCommand("usp_RegistrarVenta", oconexion);
                    cmd.Parameters.AddWithValue("idUsuario", obj.oUsuario.idUsuario);
                    cmd.Parameters.AddWithValue("tipoDocumento", obj.tipoDocumento);
                    cmd.Parameters.AddWithValue("numDocumento", obj.numDocumento);
                    cmd.Parameters.AddWithValue("documentoCliente", obj.documentoCliente);
                    cmd.Parameters.AddWithValue("nombreCliente", obj.nombreCliente);
                    cmd.Parameters.AddWithValue("montoPago", obj.montoPago);
                    cmd.Parameters.AddWithValue("montoCambio", obj.montoCambio);
                    cmd.Parameters.AddWithValue("montoTotal", obj.montoTotal);
                    cmd.Parameters.AddWithValue("detalleVenta", DetalleVenta);
                    cmd.Parameters.Add("resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }
            return Respuesta;
        }

        public Venta ObtenerVenta(string numero)
        {
            Venta obj = new Venta();

            using (SqlConnection conexion = new SqlConnection(ConexionDataBase.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select v.idVenta,u.nombreCompleto,");
                    query.AppendLine("v.documentoCliente,v.nombreCliente,");
                    query.AppendLine("v.tipoDocumento,v.numDocumento,");
                    query.AppendLine("v.montoPago,v.montoCambio,v.montoTotal,");
                    query.AppendLine("convert(char(10),v.fechaRegistro,103)[fechaRegistro]");
                    query.AppendLine("from VENTA v");
                    query.AppendLine("inner join USUARIO u on u.idUsuario = v.idUsuario");
                    query.AppendLine("where v.numDocumento = @numero");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Venta()
                            {
                                idVenta = int.Parse(dr["idVenta"].ToString()),
                                oUsuario = new Usuario() { nombreCompleto = dr["nombreCompleto"].ToString() },
                                documentoCliente = dr["documentoCliente"].ToString(),
                                nombreCliente = dr["nombreCliente"].ToString(),
                                tipoDocumento = dr["tipoDocumento"].ToString(),
                                numDocumento = dr["numDocumento"].ToString(),
                                montoPago = Convert.ToDecimal(dr["montoPago"].ToString()),
                                montoCambio = Convert.ToDecimal(dr["montoCambio"].ToString()),
                                montoTotal = Convert.ToDecimal(dr["montoTotal"].ToString()),
                                fechaRegistro = dr["fechaRegistro"].ToString()
                            };
                        }
                    }
                }
                catch
                {
                    obj = new Venta();
                }
            }
            return obj;
        }

        public List<DetalleVenta> ObtenerDetalleVenta(int idVenta)
        {
            List<DetalleVenta> oLista = new List<DetalleVenta>();

            using (SqlConnection conexion = new SqlConnection(ConexionDataBase.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.nombre,dv.precioVenta,dv.cantidad,dv.subTotal from DETALLE_VENTA dv");
                    query.AppendLine("inner join PRODUCTO p on p.idProducto = dv.idProducto");
                    query.AppendLine("where dv.idVenta = @idventa");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idventa", idVenta);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new DetalleVenta()
                            {
                                oProducto = new Producto() { nombre = dr["nombre"].ToString() },
                                precioVenta = Convert.ToDecimal(dr["precioVenta"].ToString()),
                                cantidad = Convert.ToInt32(dr["cantidad"].ToString()),
                                subTotal = Convert.ToDecimal(dr["subTotal"].ToString()),
                            });
                        }
                    }
                }
                catch
                {
                    oLista = new List<DetalleVenta>();
                }
            }
            return oLista;
        }
    }
}