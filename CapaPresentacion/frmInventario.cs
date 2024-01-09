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

namespace CapaPresentacion
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            List<Inventario> lista = new CNVIstas().Storage();

            foreach (Inventario item in lista)
            {
                dgvData.Rows.Add(new object[] {"",
                    item.oCategoria.descripcion,
                    item.oProducto.codigo,
                    item.oProducto.nombre,
                    item.oProducto.descripcion,
                    item.oProducto.stock
                });
            }
        }
    }
}
