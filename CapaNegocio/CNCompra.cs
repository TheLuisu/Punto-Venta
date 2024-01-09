using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class CNCompra
    {
        private CDCompra objcd_compra = new CDCompra();

        public int ObtenerCorrelativo()
        {
            return objcd_compra.ObtenerCorrelativo();
        }

        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            return objcd_compra.Registrar(obj, DetalleCompra, out Mensaje);
        }

        public Compra ObtenerCompra(string numero)
        {

            Compra oCompra = objcd_compra.ObtenerCompra(numero);

            if (oCompra.idCompra != 0)
            {
                List<DetalleCompra> oDetalleCompra = objcd_compra.ObtenerDetalleCompra(oCompra.idCompra);

                oCompra.oDetalleCompra = oDetalleCompra;
            }
            return oCompra;
        }
    }
}
