using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.Movimientos
{
    public partial class MVComprasUsuarios : Form
    {
        public MVComprasUsuarios()
        {
            InitializeComponent();
        }

        private void MVComprasUsuarios_Load(object sender, EventArgs e)
        {
            List<ComprasUsuario> lista = new CNVIstas().ListarComprasUsuario();

            foreach (ComprasUsuario item in lista)
            {
                dgvData.Rows.Add(new object[] {"",
                    item.oUsuario.documento,
                    item.oUsuario.nombreCompleto,
                    item.oCompra.idCompra,
                    item.oProducto.descripcion,
                    item.oProducto.nombre,
                    item.oDetalleCompra.cantidad,
                });
            }
        }
    }
}
