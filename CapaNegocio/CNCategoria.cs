using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNCategoria
    {
        private CDCategoria objcdCategoria = new CDCategoria();

        public List<Categoria> Listar()
        {
            return objcdCategoria.Listar();
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.descripcion == "")
            {
                Mensaje += "Es necesaria la DESCRIPCION de la Categoria\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcdCategoria.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.descripcion == "")
            {
                Mensaje += "Es necesaria la DESCRIPCION de la Categoria\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcdCategoria.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            return objcdCategoria.Eliminar(obj, out Mensaje);
        }
    }
}