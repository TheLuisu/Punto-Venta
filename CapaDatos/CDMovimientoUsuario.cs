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
    public class CDMovimientoUsuario
    {
        public List<MovimientosUsuario> Listar()
        {
            List<MovimientosUsuario> lista = new List<MovimientosUsuario>();

            using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select * from MOVIMIENTOS_USUARIO");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new MovimientosUsuario()
                            {
                                idMovUsuario = Convert.ToInt32(dr["idMovUsuario"]),
                                oUsuario = new Usuario() { idUsuario = Convert.ToInt32(dr["idUsuario"]) },
                                oRol = new Rol() { idRol = Convert.ToInt32(dr["idRol"]) },
                                documento = dr["documento"].ToString(),
                                nombreCompleto = dr["nombreCompleto"].ToString(),
                                correo = dr["correo"].ToString(),
                                password = dr["password"].ToString(),
                                tipoMovimiento = dr["tipoMovimiento"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<MovimientosUsuario>();
                }
            }
            return lista;
        }
    }
}
