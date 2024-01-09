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
    public class CDCliente
    {
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idCliente, documento, nombreCompleto, correo, telefono, estado from CLIENTE");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cliente()
                            {
                                idCliente = Convert.ToInt32(dr["idCliente"]),
                                documento = dr["documento"].ToString(),
                                nombreCompleto = dr["nombreCompleto"].ToString(),
                                correo = dr["correo"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Cliente>();
                }
            }

            return lista;
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            int idClienteGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARCLIENTE", oconexion);
                    cmd.Parameters.AddWithValue("documento", obj.documento);
                    cmd.Parameters.AddWithValue("nombreCompleto", obj.nombreCompleto);
                    cmd.Parameters.AddWithValue("correo", obj.correo);
                    cmd.Parameters.AddWithValue("telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("estado", obj.estado);

                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idClienteGenerado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                idClienteGenerado = 0;
                Mensaje = ex.Message;
            }

            return idClienteGenerado;
        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_EDITARCLIENTE", oconexion);
                    cmd.Parameters.AddWithValue("idCliente", obj.idCliente);
                    cmd.Parameters.AddWithValue("documento", obj.documento);
                    cmd.Parameters.AddWithValue("nombreCompleto", obj.nombreCompleto);
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

        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(ConexionDataBase.cadena))
                {
                    SqlCommand cmd = new SqlCommand("delete from cliente where idCliente = @id", oconexion);
                    cmd.Parameters.AddWithValue("@id", obj.idCliente);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false; 
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
