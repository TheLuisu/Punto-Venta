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
    public partial class frmDetalleVenta : Form
    {
        public frmDetalleVenta()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Venta oVenta = new CNVenta().ObtenerVenta(txtbusqueda.Text);

            if (oVenta.idVenta != 0)
            {
                txtnumerodocumento.Text = oVenta.numDocumento;

                txtfecha.Text = oVenta.fechaRegistro;
                txttipodocumento.Text = oVenta.tipoDocumento;
                txtusuario.Text = oVenta.oUsuario.nombreCompleto;


                txtdoccliente.Text = oVenta.documentoCliente;
                txtnombrecliente.Text = oVenta.nombreCliente;

                dgvdata.Rows.Clear();
                foreach (DetalleVenta dv in oVenta.oDetalleVenta)
                {
                    dgvdata.Rows.Add(new object[] { dv.oProducto.nombre, dv.precioVenta, dv.cantidad, dv.subTotal });
                }

                txtmontototal.Text = oVenta.montoTotal.ToString("0.00");
                txtmontopago.Text = oVenta.montoPago.ToString("0.00");
                txtmontocambio.Text = oVenta.montoCambio.ToString("0.00");
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdoccliente.Text = "";
            txtnombrecliente.Text = "";

            dgvdata.Rows.Clear();
            txtmontototal.Text = "0.00";
            txtmontopago.Text = "0.00";
            txtmontocambio.Text = "0.00";
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
