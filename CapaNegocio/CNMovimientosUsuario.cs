using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class CNMovimientosUsuario
    {
        private CDMovimientoUsuario objcdMovimientosCliente = new CDMovimientoUsuario();

        public List<MovimientosUsuario> Listar()
        {
            return objcdMovimientosCliente.Listar();
        }
    }
}