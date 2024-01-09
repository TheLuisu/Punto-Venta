using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNPermiso
    {
        private CDPermiso objcdpermiso = new CDPermiso();

        public List<Permiso> Listar(int idUsuario)
        {
            return objcdpermiso.Listar(idUsuario);
        }
    }
}
