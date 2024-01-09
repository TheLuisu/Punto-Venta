using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class MovimientosCliente
    {
        public int idMovCliente { get; set; }
        public Cliente oCliente { get; set; }
        public string nombreCompleto { get; set; }
        public string tipoMovimiento { get; set; }
        public string fechaRegistro { get; set; }
    }
}
