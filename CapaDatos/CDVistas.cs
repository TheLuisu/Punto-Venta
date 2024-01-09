using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDVistas
    {
        public List<VentasUsuarios> Listar()
        {
            List<VentasUsuarios> lista = new List<VentasUsuarios>();

            using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select * from VENTAS_USUARIO");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new VentasUsuarios()
                            {
                                oUsuario = new Usuario() {
                                    documento = dr["NombreUsuario"].ToString(),
                                    nombreCompleto = dr["nombreCompleto"].ToString(),
                                },
                                oVenta = new Venta()
                                {
                                    idVenta = Convert.ToInt32(dr["idVenta"]),
                                    nombreCliente = dr["nombreCliente"].ToString(),
                                },
                                oProducto= new Producto()
                                {                                   
                                    nombre = dr["nombre"].ToString(),
                                },
                                oDetalleVenta = new DetalleVenta()
                                {
                                    cantidad = Convert.ToInt32(dr["cantidad"]),
                                }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<VentasUsuarios>();
                }
            }
            return lista;
        }

        public List<ComprasUsuario> ListarComprasUsuario()
        {
            List<ComprasUsuario> lista = new List<ComprasUsuario>();

            using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select * from COMPRAS_USUARIO");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ComprasUsuario()
                            {
                                oUsuario = new Usuario()
                                {
                                    documento = dr["NombreUsuario"].ToString(),
                                    nombreCompleto = dr["nombreCompleto"].ToString(),
                                },
                                oCompra = new Compra()
                                {
                                    idCompra = Convert.ToInt32(dr["idCompra"]),
                                },
                                oProducto = new Producto()
                                {
                                    descripcion = dr["descripcion"].ToString(),
                                    nombre = dr["nombre"].ToString(),
                                },
                                oDetalleCompra = new DetalleCompra()
                                {
                                    cantidad = Convert.ToInt32(dr["cantidad"]),
                                }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ComprasUsuario>();
                }
            }
            return lista;
        }

        public List<Inventario> Storage()
        {
            List<Inventario> lista = new List<Inventario>();

            using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select * from PRODUCTOS_CAT");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Inventario()
                            {
                                oCategoria = new Categoria()
                                {
                                    descripcion = dr["categoria"].ToString(),                                    
                                },                               
                                oProducto = new Producto()
                                {
                                    codigo = dr["codigo"].ToString(),
                                    nombre = dr["nombre"].ToString(),
                                    descripcion = dr["marca"].ToString(),
                                    stock = Convert.ToInt32(dr["stock"]),
                                }                              
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Inventario>();
                }
            }
            return lista;
        }
    }
}
