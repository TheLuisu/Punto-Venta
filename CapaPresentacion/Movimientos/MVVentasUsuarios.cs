using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Movimientos
{
    public partial class MVVentasUsuarios : Form
    {
        public MVVentasUsuarios()
        {
            InitializeComponent();
        }

        private void MVVentasUsuarios_Load(object sender, EventArgs e)
        {
            List<VentasUsuarios> lista = new CNVIstas().Listar();

            foreach (VentasUsuarios item in lista)
            {
                dgvData.Rows.Add(new object[] {"",
                    item.oUsuario.documento,
                    item.oUsuario.nombreCompleto,
                    item.oVenta.idVenta,
                    item.oVenta.nombreCliente,
                    item.oProducto.nombre,
                    item.oDetalleVenta.cantidad,                    
                });
            }
        }
    }
}
