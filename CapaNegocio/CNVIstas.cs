using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNVIstas
    {
        private CDVistas objcdVentasUsuarios = new CDVistas();

        public List<VentasUsuarios> Listar()
        {
            return objcdVentasUsuarios.Listar();
        }

        private CDVistas objcdComprasUsuario = new CDVistas();

        public List<ComprasUsuario> ListarComprasUsuario()
        {
            return objcdComprasUsuario.ListarComprasUsuario();
        }

        private CDVistas objcdStorage = new CDVistas();

        public List<Inventario> Storage()
        {
            return objcdStorage.Storage();
        }
    }
}
