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
    public class CDMovimientoCliente
    {
        public List<MovimientosCliente> Listar()
        {
            List<MovimientosCliente> lista = new List<MovimientosCliente>();

            using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select * from MOVIMIENTOS_CLIENTE");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new MovimientosCliente()
                            {
                                idMovCliente = Convert.ToInt32(dr["idMovCliente"]),
                                oCliente = new Cliente() { idCliente = Convert.ToInt32(dr["idCliente"]) },
                                nombreCompleto = dr["nombreCompleto"].ToString(),
                                tipoMovimiento = dr["tipoMovimiento"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<MovimientosCliente>();
                }
            }
            return lista;
        }
    }
}
