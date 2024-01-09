using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNProducto
    {
        private CDProducto objcdProducto = new CDProducto();

        public List<Producto> Listar()
        {
            return objcdProducto.Listar();
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.codigo == "")
            {
                Mensaje += "Es necesario el CODIGO del Producto\n";
            }

            if (obj.nombre == "")
            {
                Mensaje += "Es necesario el NOMBRE del Producto\n";
            }

            if (obj.descripcion == "")
            {
                Mensaje += "Es necesaria la DESCRIPCION del Producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcdProducto.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.codigo == "")
            {
                Mensaje += "Es necesario el CODIGO del Producto\n";
            }

            if (obj.nombre == "")
            {
                Mensaje += "Es necesario el NOMBRE del Producto\n";
            }

            if (obj.descripcion == "")
            {
                Mensaje += "Es necesaria la DESCRIPCION del Producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcdProducto.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return objcdProducto.Eliminar(obj, out Mensaje);
        }
    }
}
