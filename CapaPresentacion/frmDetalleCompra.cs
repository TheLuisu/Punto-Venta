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
    public partial class frmDetalleCompra : Form
    {
        public frmDetalleCompra()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Compra oCompra = new CNCompra().ObtenerCompra(txtbusqueda.Text);

            if (oCompra.idCompra != 0)
            {

                txtnumerodocumento.Text = oCompra.numDocumento;

                txtfecha.Text = oCompra.fechaRegistro;
                txttipodocumento.Text = oCompra.tipoDocumento;
                txtusuario.Text = oCompra.oUsuario.nombreCompleto;
                txtdocproveedor.Text = oCompra.oProveedor.documento;
                txtnombreproveedor.Text = oCompra.oProveedor.razonSocial;

                dgvdata.Rows.Clear();
                foreach (DetalleCompra dc in oCompra.oDetalleCompra)
                {
                    dgvdata.Rows.Add(new object[] { dc.oProducto.nombre, dc.precioCompra, dc.cantidad, dc.montoTotal });
                }
                txtmontototal.Text = oCompra.montoTotal.ToString("0.00");
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdocproveedor.Text = "";
            txtnombreproveedor.Text = "";

            dgvdata.Rows.Clear();
            txtmontototal.Text = "0.00";
        }

        private void frmDetalleCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
