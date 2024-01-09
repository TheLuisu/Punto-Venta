using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class MovimientosUsuario
    {
        public int idMovUsuario { get; set; }
        public Usuario oUsuario { get; set; }
        public Rol oRol { get; set; }
        public string documento { get; set; }
        public string nombreCompleto { get; set; }
        public string correo { get; set; }
        public string password { get; set; }
        public string tipoMovimiento { get; set; }
        public string fechaRegistro { get; set; }
    }
}
