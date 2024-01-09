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
using FontAwesome.Sharp;
using CapaNegocio;
using CapaPresentacion.Movimientos;

namespace CapaPresentacion
{
    public partial class MenuInicial : Form
    {

        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form formularioActivo = null;

        public MenuInicial(Usuario objusuario)
        {
            if (objusuario == null)
                usuarioActual = new Usuario() { documento = "ADMIN PREDEFINIDO", idUsuario = 1 };
            else
                usuarioActual = objusuario;

            InitializeComponent();
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void menuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void iconMenuConfig_Click(object sender, EventArgs e)
        {

        }

        private void labelNameUsuario_Click(object sender, EventArgs e)
        {

        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CNPermiso().Listar(usuarioActual.idUsuario);

            foreach (IconMenuItem iconmenu in menuPrincipal.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.nombreMenu == iconmenu.Name);
                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }

            }

            lblUsuario.Text = usuarioActual.documento;
        }

        private void abrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.DarkGreen;
            MenuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.DarkGreen;

            contenedor.Controls.Add(formulario);
            formulario.Show();


        }

        private void iconMenuUser_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(iconMenuAdmin, new frmCategoria());
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(iconMenuAdmin, new frmProductos());
        }

        private void submenuRegisterVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(iconMenuVentas, new frmVentas(usuarioActual));
        }

        private void submenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(iconMenuVentas, new frmDetalleVenta());
        }

        private void submenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(iconMenuCompras, new frmCompras(usuarioActual));
        }

        private void submenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(iconMenuCompras, new frmDetalleCompra());
        }

        private void iconMenuClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void iconMenuProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void iconMenuReportes_Click(object sender, EventArgs e)
        {           
        }

        private void iconMenuCompras_Click(object sender, EventArgs e)
        {
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(iconMenuMovimientos, new MVClientes());
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(iconMenuMovimientos, new MVUsuarios());
        }

        private void iconMenuInventario_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmInventario());
        }

        private void ventasDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(iconMenuMovimientos, new MVVentasUsuarios());
        }

        private void comprasDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(iconMenuMovimientos, new MVComprasUsuarios());
        }

        private void reportesDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(iconMenuMovimientos, new frmReportes());
        }
    }
}