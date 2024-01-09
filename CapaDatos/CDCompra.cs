using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class CDCompra
    {
        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from COMPRA");
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


        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;


            using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarCompra", oconexion);
                    cmd.Parameters.AddWithValue("idUsuario", obj.oUsuario.idUsuario);
                    cmd.Parameters.AddWithValue("idProveedor", obj.oProveedor.idProveedor);
                    cmd.Parameters.AddWithValue("tipoDocumento", obj.tipoDocumento);
                    cmd.Parameters.AddWithValue("numDocumento", obj.numDocumento);
                    cmd.Parameters.AddWithValue("montoTotal", obj.montoTotal);
                    cmd.Parameters.AddWithValue("detalleCompra", DetalleCompra);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    Mensaje = ex.Message;
                }
            }
            return Respuesta;
        }

        public Compra ObtenerCompra(string numero)
        {
            Compra obj = new Compra();
            using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select c.idCompra,");
                    query.AppendLine("u.nombreCompleto,");
                    query.AppendLine("pr.documento,pr.razonSocial,");
                    query.AppendLine("c.tipoDocumento,c.numDocumento,c.montoTotal,convert(char(10), c.fechaRegistro, 103)[fechaRegistro]");
                    query.AppendLine("from COMPRA c");
                    query.AppendLine("inner join USUARIO u on u.idUsuario = c.idUsuario");
                    query.AppendLine("inner join PROVEEDOR pr on pr.idProveedor = c.idProveedor");
                    query.AppendLine("where c.numDocumento = @numero");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Compra()
                            {
                                idCompra = Convert.ToInt32(dr["idCompra"]),
                                oUsuario = new Usuario() { nombreCompleto = dr["nombreCompleto"].ToString() },
                                oProveedor = new Proveedor() { documento = dr["documento"].ToString(), razonSocial = dr["razonSocial"].ToString() },
                                tipoDocumento = dr["tipoDocumento"].ToString(),
                                numDocumento = dr["numDocumento"].ToString(),
                                montoTotal = Convert.ToDecimal(dr["montoTotal"].ToString()),
                                fechaRegistro = dr["fechaRegistro"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    obj = new Compra();
                }
            }
            return obj;
        }

        public List<DetalleCompra> ObtenerDetalleCompra(int idcompra)
        {
            List<DetalleCompra> oLista = new List<DetalleCompra>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionDataBase.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select p.nombre,dc.precioCompra,dc.cantidad,dc.montoTotal from DETALLE_COMPRA dc");
                    query.AppendLine("inner join PRODUCTO p on p.idProducto = dc.idProducto");
                    query.AppendLine("where dc.idCompra =  @idcompra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idcompra", idcompra);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new DetalleCompra()
                            {
                                oProducto = new Producto() { nombre = dr["nombre"].ToString() },
                                precioCompra = Convert.ToDecimal(dr["precioCompra"].ToString()),
                                cantidad = Convert.ToInt32(dr["cantidad"].ToString()),
                                montoTotal = Convert.ToDecimal(dr["montoTotal"].ToString()),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<DetalleCompra>();
            }
            return oLista;
        }
    }
}