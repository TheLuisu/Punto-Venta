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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void fondoBlanco_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            Cliente objCliente = new Cliente()
            {
                idCliente = Convert.ToInt32(txtID.Text),
                documento = txtDoc.Text,
                nombreCompleto = txtNombreCompleto.Text,
                correo = txtCorreo.Text,
                telefono = txtTelefono.Text,
                estado = Convert.ToInt32(((opcionCombo)cbEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objCliente.idCliente == 0)
            {
                int idClienteGenerado = new CNCliente().Registrar(objCliente, out Mensaje);

                if (idClienteGenerado != 0)
                {
                    dgvData.Rows.Add(new object[] {"",
                        idClienteGenerado,
                        txtDoc.Text,
                        txtNombreCompleto.Text,
                        txtCorreo.Text,
                        txtTelefono.Text,
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
                bool resultado = new CNCliente().Editar(objCliente, out Mensaje);
            
                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Id"].Value = txtID.Text;
                    row.Cells["documento"].Value = txtDoc.Text;
                    row.Cells["nombreCompleto"].Value = txtNombreCompleto.Text;
                    row.Cells["correo"].Value = txtCorreo.Text;
                    row.Cells["telefono"].Value = txtTelefono.Text;
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

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtID.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar a este cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Mensaje = string.Empty;
                    Cliente objCliente = new Cliente()
                    {
                        idCliente = Convert.ToInt32(txtID.Text),
                    };
                    bool respuesta = new CNCliente().Eliminar(objCliente, out Mensaje);

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

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cbEstado.Items.Add(new opcionCombo() { Valor = 1, Texto = "Activo" });
            cbEstado.Items.Add(new opcionCombo() { Valor = 0, Texto = "No Activo" });
            cbEstado.DisplayMember = "Texto";
            cbEstado.ValueMember = "Valor";
            cbEstado.SelectedIndex = 0;

            List<Cliente> listaCliente = new CNCliente().Listar();

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
            List<Cliente> lista = new CNCliente().Listar();

            foreach (Cliente item in lista)
            {
                dgvData.Rows.Add(new object[] {
                    "",
                    item.idCliente,
                    item.documento,
                    item.nombreCompleto,
                    item.correo,
                    item.telefono,
                    item.estado == true ?1 : 0,
                    item.estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtID.Text = "0";
            txtDoc.Text = "";
            txtNombreCompleto.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            cbEstado.SelectedIndex = 0;
        }

        private void txtDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnSelect")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtID.Text = dgvData.Rows[indice].Cells["Id"].Value.ToString();
                    txtDoc.Text = dgvData.Rows[indice].Cells["documento"].Value.ToString();
                    txtNombreCompleto.Text = dgvData.Rows[indice].Cells["nombreCompleto"].Value.ToString();
                    txtCorreo.Text = dgvData.Rows[indice].Cells["correo"].Value.ToString();
                    txtTelefono.Text = dgvData.Rows[indice].Cells["telefono"].Value.ToString();

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

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
