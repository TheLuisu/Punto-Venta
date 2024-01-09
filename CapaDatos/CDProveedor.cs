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
    public class CDProveedor
    {
        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();

            using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idProveedor,documento,razonSocial,correo,telefono,estado from PROVEEDOR");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Proveedor()
                            {
                                idProveedor = Convert.ToInt32(dr["idProveedor"]),
                                documento = dr["documento"].ToString(),
                                razonSocial = dr["razonSocial"].ToString(),
                                correo = dr["correo"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Proveedor>();
                }
            }
            return lista;
        }

        public int Registrar(Proveedor obj, out string Mensaje)
        {
            int idProveedorgenerado = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarProveedor", oconexion);
                    cmd.Parameters.AddWithValue("documento", obj.documento);
                    cmd.Parameters.AddWithValue("razonSocial", obj.razonSocial);
                    cmd.Parameters.AddWithValue("correo", obj.correo);
                    cmd.Parameters.AddWithValue("telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("estado", obj.estado);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idProveedorgenerado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idProveedorgenerado = 0;
                Mensaje = ex.Message;
            }
            return idProveedorgenerado;
        }

        public bool Editar(Proveedor obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_ModificarProveedor", oconexion);
                    cmd.Parameters.AddWithValue("idProveedor", obj.idProveedor);
                    cmd.Parameters.AddWithValue("documento", obj.documento);
                    cmd.Parameters.AddWithValue("razonSocial", obj.razonSocial);
                    cmd.Parameters.AddWithValue("correo", obj.correo);
                    cmd.Parameters.AddWithValue("telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("estado", obj.estado);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;
        }


        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarProveedor", oconexion);
                    cmd.Parameters.AddWithValue("IdProveedor", obj.idProveedor);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;
        }
    }
}
