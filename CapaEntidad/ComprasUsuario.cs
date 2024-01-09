using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ComprasUsuario
    {
        public Usuario oUsuario { get; set; }
        public Compra oCompra { get; set; }
        public DetalleCompra oDetalleCompra { get; set; }
        public Producto oProducto { get; set; }
    }
}