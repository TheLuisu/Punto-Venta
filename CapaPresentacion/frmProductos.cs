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
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            cbEstado.Items.Add(new opcionCombo() { Valor = 1, Texto = "Activo" });
            cbEstado.Items.Add(new opcionCombo() { Valor = 0, Texto = "No Activo" });
            cbEstado.DisplayMember = "Texto";
            cbEstado.ValueMember = "Valor";
            cbEstado.SelectedIndex = 0;

            List<Categoria> listaCategoria = new CNCategoria().Listar();

            foreach (Categoria item in listaCategoria)
            {
                cbCategoria.Items.Add(new opcionCombo() { Valor = item.idCategoria, Texto = item.descripcion });
            }
            cbCategoria.DisplayMember = "Texto";
            cbCategoria.ValueMember = "Valor";
            cbCategoria.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSelect")
                {
                    cbBusqueda.Items.Add(new opcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbBusqueda.DisplayMember = "Texto";
            cbBusqueda.ValueMember = "Valor";
            cbBusqueda.SelectedIndex = 0;

            //MOSTRAR TODOS LOS USUARIOS DE LA BASE DE DATOS
            List<Producto> listaProducto = new CNProducto().Listar();

            foreach (Producto item in listaProducto)
            {
                dgvData.Rows.Add(new object[] {
                    "",
                    item.idProducto,
                    item.codigo,
                    item.nombre,
                    item.descripcion,
                    item.oCategoria.idCategoria,
                    item.oCategoria.descripcion,
                    item.stock,
                    item.precioCompra,
                    item.precioVenta,
                    item.estado == true ?1 : 0,
                    item.estado == true ? "Activo" : "No Activo"
                });
            }

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            Producto objProducto = new Producto()
            {
                idProducto = Convert.ToInt32(txtID.Text),
                codigo = txtCod.Text,
                nombre = txtNombre.Text,
                descripcion = txtDescrip.Text,
                oCategoria = new Categoria() { idCategoria = Convert.ToInt32(((opcionCombo)cbCategoria.SelectedItem).Valor) },
                estado = Convert.ToInt32(((opcionCombo)cbEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objProducto.idProducto == 0)
            {
                int idProductoGenerado = new CNProducto().Registrar(objProducto, out Mensaje);

                if (idProductoGenerado != 0)
                {
                    dgvData.Rows.Add(new object[] {"",
                        idProductoGenerado,
                        txtCod.Text,
                        txtNombre.Text,
                        txtDescrip.Text,
                        ((opcionCombo)cbCategoria.SelectedItem).Valor.ToString(),
                        ((opcionCombo)cbCategoria.SelectedItem).Texto.ToString(),
                        "0",
                        "0.00",
                        "0.00",
                        ((opcionCombo)cbEstado.SelectedItem).Valor.ToString(),
                        ((opcionCombo)cbEstado.SelectedItem).Texto.ToString()
                        });
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            }
            else
            {
                bool resultado = new CNProducto().Editar(objProducto, out Mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Id"].Value = txtID.Text;
                    row.Cells["codigo"].Value = txtCod.Text;
                    row.Cells["nombre"].Value = txtNombre.Text;
                    row.Cells["descripcion"].Value = txtDescrip.Text;
                    row.Cells["idCategoria"].Value = ((opcionCombo)cbCategoria.SelectedItem).Valor.ToString();
                    row.Cells["categoria"].Value = ((opcionCombo)cbCategoria.SelectedItem).Texto.ToString();
                    row.Cells["estadoValor"].Value = ((opcionCombo)cbEstado.SelectedItem).Valor.ToString();
                    row.Cells["estado"].Value = ((opcionCombo)cbEstado.SelectedItem).Texto.ToString();

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            }
        }

        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtID.Text = "0";
            txtCod.Text = "";
            txtNombre.Text = "";
            txtDescrip.Text = "";
            cbCategoria.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check_1_icon.Width;
                var h = Properties.Resources.check_1_icon.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check_1_icon, new Rectangle(x, y, w, h));
                e.Handled = true;

            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnSelect")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtID.Text = dgvData.Rows[indice].Cells["Id"].Value.ToString();
                    txtCod.Text = dgvData.Rows[indice].Cells["codigo"].Value.ToString();
                    txtNombre.Text = dgvData.Rows[indice].Cells["nombre"].Value.ToString();
                    txtDescrip.Text = dgvData.Rows[indice].Cells["descripcion"].Value.ToString();

                    foreach (opcionCombo OC in cbCategoria.Items)
                    {
                        if (Convert.ToInt32(OC.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["idCategoria"].Value))
                        {
                            int indice_combo = cbCategoria.Items.IndexOf(OC);
                            cbCategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (opcionCombo OC in cbEstado.Items)
                    {
                        if (Convert.ToInt32(OC.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["estadoValor"].Value))
                        {
                            int indice_combo = cbEstado.Items.IndexOf(OC);
                            cbEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtID.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar a este producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Mensaje = string.Empty;
                    Producto objProducto = new Producto()
                    {
                        idProducto = Convert.ToInt32(txtID.Text),
                    };
                    bool respuesta = new CNProducto().Eliminar(objProducto, out Mensaje);

                    if (respuesta)
                    {
                        dgvData.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(Mensaje);
                    }
                }
            }
        }

        private void ibSearch_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((opcionCombo)cbBusqueda.SelectedItem).Valor.ToString();

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void ibLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}