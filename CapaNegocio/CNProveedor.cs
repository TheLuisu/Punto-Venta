using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNProveedor
    {
        private CDProveedor objcd_Proveedor = new CDProveedor();

        public List<Proveedor> Listar()
        {
            return objcd_Proveedor.Listar();
        }

        public int Registrar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.documento == "")
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (obj.razonSocial == "")
            {
                Mensaje += "Es necesario la razon social del Proveedor\n";
            }

            if (obj.correo == "")
            {
                Mensaje += "Es necesario la correo del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Proveedor.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.documento == "")
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (obj.razonSocial == "")
            {
                Mensaje += "Es necesario la razon social del Proveedor\n";
            }

            if (obj.correo == "")
            {
                Mensaje += "Es necesario la correo del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Proveedor.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            return objcd_Proveedor.Eliminar(obj, out Mensaje);
        }
    }
}
