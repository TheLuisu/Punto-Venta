using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNMovimientosCliente
    {
        private CDMovimientoCliente objcdMovimientosCliente = new CDMovimientoCliente();

        public List<MovimientosCliente> Listar()
        {
            return objcdMovimientosCliente.Listar();
        }
    }
}
