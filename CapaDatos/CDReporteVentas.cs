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
    public class CDReporteVentas
    {
        public List<ReporteVentas> Venta(string fechainicio, string fechafin)
        {
            List<ReporteVentas> lista = new List<ReporteVentas>();

            using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("SP_REPORTEDIARIOVENTA", oconexion);
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteVentas()
                            {
                                fechaRegistro = dr["fechaRegistro"].ToString(),
                                tipoDocumento = dr["tipoDocumento"].ToString(),
                                numDocumento = dr["numDocumento"].ToString(),
                                montoTotal = dr["montoTotal"].ToString(),
                                nombreCompleto = dr["UsuarioRegistro"].ToString(),
                                documentoCliente = dr["documentoCliente"].ToString(),
                                nombreCliente = dr["nombreCliente"].ToString(),
                                codigo = dr["CodigoProducto"].ToString(),
                                nombre = dr["NombreProducto"].ToString(),
                                descripcion = dr["Categoria"].ToString(),
                                precioVenta = dr["precioVenta"].ToString(),
                                cantidad = dr["cantidad"].ToString(),
                                subTotal = dr["subTotal"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteVentas>();
                }
            }
            return lista;
        }
    }
}
