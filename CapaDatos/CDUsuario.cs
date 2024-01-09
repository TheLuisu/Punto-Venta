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
    public class CDUsuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.idUsuario, u.documento, u.nombreCompleto, u.correo, u.password, u.estado, r.idRol, r.descripcion from usuario u");
                    query.AppendLine("inner join ROL r on r.idRol = u.idRol; ");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                idUsuario = Convert.ToInt32(dr["idUsuario"]),
                                documento = dr["documento"].ToString(),
                                nombreCompleto = dr["nombreCompleto"].ToString(),
                                correo = dr["correo"].ToString(),
                                password = dr["password"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"]),
                                oRol = new Rol()
                                {
                                    idRol = Convert.ToInt32(dr["idRol"]),
                                    descripcion = dr["descripcion"].ToString()
                                }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
            }

            return lista;
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            int idUsuarioGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("documento", obj.documento);
                    cmd.Parameters.AddWithValue("nombreCompleto", obj.nombreCompleto);
                    cmd.Parameters.AddWithValue("correo", obj.correo);
                    cmd.Parameters.AddWithValue("password", obj.password);
                    cmd.Parameters.AddWithValue("idRol", obj.oRol.idRol);
                    cmd.Parameters.AddWithValue("estado", obj.estado);

                    cmd.Parameters.Add("idUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idUsuarioGenerado = Convert.ToInt32(cmd.Parameters["idUsuarioResultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                idUsuarioGenerado = 0;
                Mensaje = ex.Message;
            }

            return idUsuarioGenerado;
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("idUsuario", obj.idUsuario);
                    cmd.Parameters.AddWithValue("documento", obj.documento);
                    cmd.Parameters.AddWithValue("nombreCompleto", obj.nombreCompleto);
                    cmd.Parameters.AddWithValue("correo", obj.correo);
                    cmd.Parameters.AddWithValue("password", obj.password);
                    cmd.Parameters.AddWithValue("idRol", obj.oRol.idRol);
                    cmd.Parameters.AddWithValue("estado", obj.estado);

                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
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

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("idUsuario", obj.idUsuario);

                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
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
