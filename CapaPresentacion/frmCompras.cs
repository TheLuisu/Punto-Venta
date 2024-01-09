using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCompras : Form
    {
        private Usuario _Usuario;

        public frmCompras(Usuario ousuario = null)
        {
            _Usuario = ousuario;

            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            cbotipodocumento.Items.Add(new opcionCombo() { Valor = "Ticket", Texto = "Ticket" });
            cbotipodocumento.Items.Add(new opcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtidproveedor.Text = "0";
            txtidproducto.Text = "0";
        }

        private void btnbuscarproveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproveedor.Text = modal._Proveedor.idProveedor.ToString();
                    txtdocproveedor.Text = modal._Proveedor.documento;
                    txtnombreproveedor.Text = modal._Proveedor.razonSocial;
                }
                else
                {
                    txtdocproveedor.Select();
                }
            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.idProducto.ToString();
                    txtcodproducto.Text = modal._Producto.codigo;
                    txtproducto.Text = modal._Producto.nombre;
                    txtpreciocompra.Select();
                }
                else
                {
                    txtcodproducto.Select();
                }
            }
        }

        private void txtcodproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                Producto oProducto = new CNProducto().Listar().Where(p => p.codigo == txtcodproducto.Text && p.estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtcodproducto.BackColor = Color.Honeydew;
                    txtidproducto.Text = oProducto.idProducto.ToString();
                    txtproducto.Text = oProducto.nombre;
                    txtpreciocompra.Select();
                }
                else
                {
                    txtcodproducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                }
            }
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            bool producto_existe = false;

            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtpreciocompra.Text, out preciocompra))
            {
                MessageBox.Show("Precio Compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpreciocompra.Select();
                return;
            }

            if (!decimal.TryParse(txtprecioventa.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecioventa.Select();
                return;
            }

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                dgvdata.Rows.Add(new object[] {
                    txtidproducto.Text,
                    txtproducto.Text,
                    preciocompra.ToString("0.00"),
                    precioventa.ToString("0.00"),
                    txtcantidad.Value.ToString(),
                    (txtcantidad.Value * preciocompra).ToString("0.00")

                });

                calcularTotal();
                limpiarProducto();
                txtcodproducto.Select();
            }
        }

        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodproducto.Text = "";
            txtcodproducto.BackColor = Color.White;
            txtproducto.Text = "";
            txtpreciocompra.Text = "";
            txtprecioventa.Text = "";
            txtcantidad.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txttotalpagar.Text = total.ToString("0.00");
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.Close_2_icon.Width;
                var h = Properties.Resources.Close_2_icon.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Close_2_icon, new Rectangle(x, y, w, h));
                e.Handled = true;

            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    dgvdata.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }

        private void txtpreciocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpreciocompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void cbotipodocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtidproveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("idProducto", typeof(int));
            detalle_compra.Columns.Add("precioCompra", typeof(decimal));
            detalle_compra.Columns.Add("precioVenta", typeof(decimal));
            detalle_compra.Columns.Add("cantidad", typeof(int));
            detalle_compra.Columns.Add("montoTotal", typeof(decimal));

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                detalle_compra.Rows.Add(
                    new object[] {
                       Convert.ToInt32(row.Cells["idProducto"].Value.ToString()),
                       row.Cells["precioCompra"].Value.ToString(),
                       row.Cells["precioVenta"].Value.ToString(),
                       row.Cells["cantidad"].Value.ToString(),
                       row.Cells["subTotal"].Value.ToString()
                    });
            }

            int idcorrelativo = new CNCompra().ObtenerCorrelativo();
            string numerodocumento = string.Format("{0:00000}", idcorrelativo);

            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario() { idUsuario = _Usuario.idUsuario },
                oProveedor = new Proveedor() { idProveedor = Convert.ToInt32(txtidproveedor.Text) },
                tipoDocumento = ((opcionCombo)cbotipodocumento.SelectedItem).Texto,
                numDocumento = numerodocumento,
                montoTotal = Convert.ToDecimal(txttotalpagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CNCompra().Registrar(oCompra, detalle_compra, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra generada:\n" + numerodocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numerodocumento);

                txtidproveedor.Text = "0";
                txtdocproveedor.Text = "";
                txtnombreproveedor.Text = "";
                dgvdata.Rows.Clear();
                calcularTotal();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
