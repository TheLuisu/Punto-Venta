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
    public partial class MVUsuarios : Form
    {
        public MVUsuarios()
        {
            InitializeComponent();
        }

        private void MVUsuarios_Load(object sender, EventArgs e)
        {
            List<MovimientosUsuario> lista = new CNMovimientosUsuario().Listar();

            foreach (MovimientosUsuario item in lista)
            {
                dgvData.Rows.Add(new object[] {"",
                    item.idMovUsuario,
                    item.oUsuario.idUsuario,
                    item.oRol.idRol,
                    item.documento,
                    item.nombreCompleto,
                    item.correo,
                    item.password,
                    item.tipoMovimiento
                });
            }
        }
    }
}
