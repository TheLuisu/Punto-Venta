using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNReporteVentas
    {
        private CDReporteVentas objcd_reporte = new CDReporteVentas();

        public List<ReporteVentas> Venta(string fechainicio, string fechafin)
        {
            return objcd_reporte.Venta(fechainicio, fechafin);
        }
    }
}
