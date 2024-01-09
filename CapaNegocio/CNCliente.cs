using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNCliente
    {
        private CDCliente objcdCliente = new CDCliente();

        public List<Cliente> Listar()
        {
            return objcdCliente.Listar();
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.documento == "")
            {
                Mensaje += "Es necesario el NOMBRE DE USUARIO del Cliente\n";
            }

            if (obj.nombreCompleto == "")
            {
                Mensaje += "Es necesario el NOMBRE del Cliente\n";
            }

            if (obj.correo == "")
            {
                Mensaje += "Es necesaria el CORREO del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcdCliente.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.documento == "")
            {
                Mensaje += "Es necesario el NOMBRE DE USUARIO del Cliente\n";
            }

            if (obj.nombreCompleto == "")
            {
                Mensaje += "Es necesario el NOMBRE del Cliente\n";
            }

            if (obj.correo == "")
            {
                Mensaje += "Es necesaria el CORREO del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcdCliente.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            return objcdCliente.Eliminar(obj, out Mensaje);
        }
    }
}
