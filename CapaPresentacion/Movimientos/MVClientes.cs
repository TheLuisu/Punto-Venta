using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.Movimientos
{
    public partial class MVClientes : Form
    {
        public MVClientes()
        {
            InitializeComponent();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void MVClientes_Load(object sender, EventArgs e)
        {
            List<MovimientosCliente> lista = new CNMovimientosCliente().Listar();

            foreach (MovimientosCliente item in lista)
            {
                dgvData.Rows.Add(new object[] {"",item.idMovCliente, item.oCliente.idCliente, item.nombreCompleto, item.tipoMovimiento
                });
            }
        }
    }
}
