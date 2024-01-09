using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class VentasUsuarios
    {
        public Usuario oUsuario { get; set; }
        public Venta oVenta { get; set; }
        public DetalleVenta oDetalleVenta { get; set; }
        public Producto oProducto { get; set; }
    }
}
