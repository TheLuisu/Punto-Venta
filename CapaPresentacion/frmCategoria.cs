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

namespace CapaPresentacion
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void labelDetalleUser_Click(object sender, EventArgs e)
        {

        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cbEstado.Items.Add(new opcionCombo() { Valor = 1, Texto = "Activo" });
            cbEstado.Items.Add(new opcionCombo() { Valor = 0, Texto = "No Activo" });
            cbEstado.DisplayMember = "Texto";
            cbEstado.ValueMember = "Valor";
            cbEstado.SelectedIndex = 0;

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
            List<Categoria> lista = new CNCategoria().Listar();

            foreach (Categoria item in lista)
            {
                dgvData.Rows.Add(new object[] {"",item.idCategoria, item.descripcion, item.estado == true ?1 : 0, item.estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            Categoria obj = new Categoria()
            {
                idCategoria = Convert.ToInt32(txtID.Text),
                descripcion = txtDescrip.Text,
                estado = Convert.ToInt32(((opcionCombo)cbEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (obj.idCategoria == 0)
            {
                int idCategoriaGenerado = new CNCategoria().Registrar(obj, out Mensaje);

                if (idCategoriaGenerado != 0)
                {
                    dgvData.Rows.Add(new object[] {"",idCategoriaGenerado, txtDescrip.Text,
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
                bool resultado = new CNCategoria().Editar(obj, out Mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Id"].Value = txtID.Text;
                    row.Cells["descripcion"].Value = txtDescrip.Text;
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
            txtDescrip.Text = "";
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
                    txtDescrip.Text = dgvData.Rows[indice].Cells["descripcion"].Value.ToString();

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
                if (MessageBox.Show("¿Desea eliminar a la categoria?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Mensaje = string.Empty;
                    Categoria obj = new Categoria()
                    {
                        idCategoria = Convert.ToInt32(txtID.Text),
                    };
                    bool respuesta = new CNCategoria().Eliminar(obj, out Mensaje);

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
    }
}
