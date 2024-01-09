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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void nombreCom_Click(object sender, EventArgs e)
        {

        }

        private void LabelRol_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtID.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar a este usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        idUsuario = Convert.ToInt32(txtID.Text),
                    };
                    bool respuesta = new CNUsuario().Eliminar(objusuario, out Mensaje);

                    if (respuesta)
                    {
                        dgvData.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(Mensaje);
                    }
                }
            }
        }

        private void txtDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvData.Columns[e.ColumnIndex].Name == "btnSelect")
            {
                int indice = e.RowIndex;

                if(indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtID.Text = dgvData.Rows[indice].Cells["Id"].Value.ToString();
                    txtDoc.Text = dgvData.Rows[indice].Cells["documento"].Value.ToString();
                    txtNombreCompleto.Text = dgvData.Rows[indice].Cells["nombreCompleto"].Value.ToString();
                    txtCorreo.Text = dgvData.Rows[indice].Cells["correo"].Value.ToString();
                    txtPass.Text = dgvData.Rows[indice].Cells["password"].Value.ToString();
                    txtPassConfirm.Text = dgvData.Rows[indice].Cells["password"].Value.ToString();

                    foreach (opcionCombo OC in cbRol.Items)
                    {
                        if (Convert.ToInt32(OC.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["idRol"].Value))
                        {
                            int indice_combo = cbRol.Items.IndexOf(OC);
                            cbRol.SelectedIndex = indice_combo;
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

        private void labelDetalleUser_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cbEstado.Items.Add(new opcionCombo(){ Valor = 1, Texto = "Activo" });
            cbEstado.Items.Add(new opcionCombo() { Valor = 0, Texto = "No Activo" });
            cbEstado.DisplayMember = "Texto";
            cbEstado.ValueMember = "Valor";
            cbEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CNRol().Listar();

            foreach (Rol item in listaRol)
            {
                cbRol.Items.Add(new opcionCombo() { Valor = item.idRol, Texto = item.descripcion });
            }
            cbRol.DisplayMember = "Texto";
            cbRol.ValueMember = "Valor";
            cbRol.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvData.Columns){
                if (columna.Visible == true && columna.Name != "btnSelect")
                {
                    cbBusqueda.Items.Add(new opcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbBusqueda.DisplayMember = "Texto";
            cbBusqueda.ValueMember = "Valor";
            cbBusqueda.SelectedIndex = 0;

            //MOSTRAR TODOS LOS USUARIOS DE LA BASE DE DATOS
            List<Usuario> listaUsuario = new CNUsuario().Listar();

            foreach (Usuario item in listaUsuario)
            {
                dgvData.Rows.Add(new object[] {"",item.idUsuario, item.documento, item.nombreCompleto, item.correo, item.password,
                item.oRol.idRol, item.oRol.descripcion, item.estado == true ?1 : 0, item.estado == true ? "Activo" : "No Activo"
                });
            }

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            Usuario objusuario = new Usuario()
            {
                idUsuario = Convert.ToInt32(txtID.Text),
                documento = txtDoc.Text,
                nombreCompleto = txtNombreCompleto.Text,
                correo = txtCorreo.Text,
                password = txtPass.Text,
                oRol = new Rol() { idRol = Convert.ToInt32(((opcionCombo)cbRol.SelectedItem).Valor)},
                estado = Convert.ToInt32(((opcionCombo)cbEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objusuario.idUsuario == 0)
            {
                int idUsuarioGenerado = new CNUsuario().Registrar(objusuario, out Mensaje);

                if (idUsuarioGenerado != 0)
                {
                    dgvData.Rows.Add(new object[] {"",idUsuarioGenerado, txtDoc.Text, txtNombreCompleto.Text, txtCorreo.Text,txtPass.Text,
                ((opcionCombo)cbRol.SelectedItem).Valor.ToString(),
                ((opcionCombo)cbRol.SelectedItem).Texto.ToString(),
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
                bool resultado = new CNUsuario().Editar(objusuario, out Mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Id"].Value = txtID.Text;
                    row.Cells["documento"].Value = txtDoc.Text;
                    row.Cells["nombreCompleto"].Value = txtNombreCompleto.Text;
                    row.Cells["correo"].Value = txtCorreo.Text;
                    row.Cells["password"].Value = txtPass.Text;
                    row.Cells["idRol"].Value = ((opcionCombo)cbRol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((opcionCombo)cbRol.SelectedItem).Texto.ToString();
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
            txtDoc.Text = "";
            txtNombreCompleto.Text = "";
            txtPassConfirm.Text = "";
            txtPass.Text = "";
            txtCorreo.Text = "";
            cbRol.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
        }

        private void labelBuscarPor_Click(object sender, EventArgs e)
        {

        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if(e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check_1_icon.Width;
                var h = Properties.Resources.check_1_icon.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check_1_icon,new Rectangle(x, y, w, h));
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
    }
}