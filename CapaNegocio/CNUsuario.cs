using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNUsuario
    {
        private CDUsuario objcdusuario = new CDUsuario();

        public List<Usuario> Listar()
        {
            return objcdusuario.Listar();
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.documento == "")
            {
                Mensaje += "Es necesario el NOMBRE DE USUARIO del usuario\n";
            }

            if (obj.nombreCompleto == "")
            {
                Mensaje += "Es necesario el NOMBRE del usuario\n";
            }

            if (obj.password == "")
            {
                Mensaje += "Es necesaria la CONTRASEÑA del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcdusuario.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.documento == "")
            {
                Mensaje += "Es necesario el NOMBRE DE USUARIO del usuario\n";
            }

            if (obj.nombreCompleto == "")
            {
                Mensaje += "Es necesario el NOMBRE del usuario\n";
            }

            if (obj.password == "")
            {
                Mensaje += "Es necesaria la CONTRASEÑA del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcdusuario.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return objcdusuario.Eliminar(obj, out Mensaje);
        }
    }
}