namespace CapaPresentacion
{
    partial class MenuInicial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.iconMenuUser = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuAdmin = new FontAwesome.Sharp.IconMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.submenuRegisterVenta = new FontAwesome.Sharp.IconMenuItem();
            this.submenuVerDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.submenuRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.submenuVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuMovimientos = new FontAwesome.Sharp.IconMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuInventario = new FontAwesome.Sharp.IconMenuItem();
            this.labelNameUsuario = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.DarkGreen;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(994, 73);
            this.menuTitulo.TabIndex = 0;
            this.menuTitulo.Text = "menuTitulo";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.DarkGreen;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitulo.Location = new System.Drawing.Point(12, 19);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(540, 34);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "SISTEMA DE VENTA DE COMPUTADORAS";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.AutoSize = false;
            this.menuPrincipal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuPrincipal.Dock = System.Windows.Forms.DockStyle.None;
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuUser,
            this.iconMenuAdmin,
            this.iconMenuVentas,
            this.iconMenuCompras,
            this.iconMenuClientes,
            this.iconMenuProveedores,
            this.iconMenuMovimientos,
            this.iconMenuInventario});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 73);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(994, 60);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            this.menuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuPrincipal_ItemClicked);
            // 
            // iconMenuUser
            // 
            this.iconMenuUser.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconMenuUser.IconColor = System.Drawing.Color.Black;
            this.iconMenuUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuUser.IconSize = 50;
            this.iconMenuUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuUser.Name = "iconMenuUser";
            this.iconMenuUser.Size = new System.Drawing.Size(62, 56);
            this.iconMenuUser.Text = "Usuario";
            this.iconMenuUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuUser.Click += new System.EventHandler(this.iconMenuUser_Click);
            // 
            // iconMenuAdmin
            // 
            this.iconMenuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.productoToolStripMenuItem});
            this.iconMenuAdmin.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconMenuAdmin.IconColor = System.Drawing.Color.Black;
            this.iconMenuAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuAdmin.IconSize = 50;
            this.iconMenuAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuAdmin.Name = "iconMenuAdmin";
            this.iconMenuAdmin.Size = new System.Drawing.Size(95, 56);
            this.iconMenuAdmin.Text = "Administrador";
            this.iconMenuAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuAdmin.Click += new System.EventHandler(this.iconMenuConfig_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // iconMenuVentas
            // 
            this.iconMenuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuRegisterVenta,
            this.submenuVerDetalleVenta});
            this.iconMenuVentas.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconMenuVentas.IconColor = System.Drawing.Color.Black;
            this.iconMenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuVentas.IconSize = 50;
            this.iconMenuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuVentas.Name = "iconMenuVentas";
            this.iconMenuVentas.Size = new System.Drawing.Size(62, 56);
            this.iconMenuVentas.Text = "Ventas";
            this.iconMenuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuRegisterVenta
            // 
            this.submenuRegisterVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuRegisterVenta.IconColor = System.Drawing.Color.Black;
            this.submenuRegisterVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuRegisterVenta.Name = "submenuRegisterVenta";
            this.submenuRegisterVenta.Size = new System.Drawing.Size(161, 22);
            this.submenuRegisterVenta.Text = "Registrar Ventas";
            this.submenuRegisterVenta.Click += new System.EventHandler(this.submenuRegisterVenta_Click);
            // 
            // submenuVerDetalleVenta
            // 
            this.submenuVerDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuVerDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.submenuVerDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuVerDetalleVenta.Name = "submenuVerDetalleVenta";
            this.submenuVerDetalleVenta.Size = new System.Drawing.Size(161, 22);
            this.submenuVerDetalleVenta.Text = "Ver Detalle Venta";
            this.submenuVerDetalleVenta.Click += new System.EventHandler(this.submenuVerDetalleVenta_Click);
            // 
            // iconMenuCompras
            // 
            this.iconMenuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuRegistrarCompra,
            this.submenuVerDetalleCompra});
            this.iconMenuCompras.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.iconMenuCompras.IconColor = System.Drawing.Color.Black;
            this.iconMenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuCompras.IconSize = 50;
            this.iconMenuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuCompras.Name = "iconMenuCompras";
            this.iconMenuCompras.Size = new System.Drawing.Size(67, 56);
            this.iconMenuCompras.Text = "Compras";
            this.iconMenuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuCompras.Click += new System.EventHandler(this.iconMenuCompras_Click);
            // 
            // submenuRegistrarCompra
            // 
            this.submenuRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuRegistrarCompra.IconColor = System.Drawing.Color.Black;
            this.submenuRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuRegistrarCompra.Name = "submenuRegistrarCompra";
            this.submenuRegistrarCompra.Size = new System.Drawing.Size(175, 22);
            this.submenuRegistrarCompra.Text = "Registrar Compras";
            this.submenuRegistrarCompra.Click += new System.EventHandler(this.submenuRegistrarCompra_Click);
            // 
            // submenuVerDetalleCompra
            // 
            this.submenuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuVerDetalleCompra.IconColor = System.Drawing.Color.Black;
            this.submenuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuVerDetalleCompra.Name = "submenuVerDetalleCompra";
            this.submenuVerDetalleCompra.Size = new System.Drawing.Size(175, 22);
            this.submenuVerDetalleCompra.Text = "Ver Detalle Compra";
            this.submenuVerDetalleCompra.Click += new System.EventHandler(this.submenuVerDetalleCompra_Click);
            // 
            // iconMenuClientes
            // 
            this.iconMenuClientes.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.iconMenuClientes.IconColor = System.Drawing.Color.Black;
            this.iconMenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuClientes.IconSize = 50;
            this.iconMenuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuClientes.Name = "iconMenuClientes";
            this.iconMenuClientes.Size = new System.Drawing.Size(62, 56);
            this.iconMenuClientes.Text = "Clientes";
            this.iconMenuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuClientes.Click += new System.EventHandler(this.iconMenuClientes_Click);
            // 
            // iconMenuProveedores
            // 
            this.iconMenuProveedores.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.iconMenuProveedores.IconColor = System.Drawing.Color.Black;
            this.iconMenuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuProveedores.IconSize = 50;
            this.iconMenuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuProveedores.Name = "iconMenuProveedores";
            this.iconMenuProveedores.Size = new System.Drawing.Size(84, 56);
            this.iconMenuProveedores.Text = "Proveedores";
            this.iconMenuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuProveedores.Click += new System.EventHandler(this.iconMenuProveedores_Click);
            // 
            // iconMenuMovimientos
            // 
            this.iconMenuMovimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.ventasDeUsuariosToolStripMenuItem,
            this.comprasDeUsuariosToolStripMenuItem,
            this.reportesDeVentasToolStripMenuItem});
            this.iconMenuMovimientos.IconChar = FontAwesome.Sharp.IconChar.PiedPiper;
            this.iconMenuMovimientos.IconColor = System.Drawing.Color.Black;
            this.iconMenuMovimientos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuMovimientos.IconSize = 50;
            this.iconMenuMovimientos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuMovimientos.Name = "iconMenuMovimientos";
            this.iconMenuMovimientos.Size = new System.Drawing.Size(102, 56);
            this.iconMenuMovimientos.Text = "Otras funciones";
            this.iconMenuMovimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuMovimientos.Click += new System.EventHandler(this.iconMenuReportes_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // ventasDeUsuariosToolStripMenuItem
            // 
            this.ventasDeUsuariosToolStripMenuItem.Name = "ventasDeUsuariosToolStripMenuItem";
            this.ventasDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ventasDeUsuariosToolStripMenuItem.Text = "Ventas de Usuarios";
            this.ventasDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.ventasDeUsuariosToolStripMenuItem_Click);
            // 
            // comprasDeUsuariosToolStripMenuItem
            // 
            this.comprasDeUsuariosToolStripMenuItem.Name = "comprasDeUsuariosToolStripMenuItem";
            this.comprasDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.comprasDeUsuariosToolStripMenuItem.Text = "Compras de Usuarios";
            this.comprasDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.comprasDeUsuariosToolStripMenuItem_Click);
            // 
            // reportesDeVentasToolStripMenuItem
            // 
            this.reportesDeVentasToolStripMenuItem.Name = "reportesDeVentasToolStripMenuItem";
            this.reportesDeVentasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.reportesDeVentasToolStripMenuItem.Text = "Reportes de Ventas";
            this.reportesDeVentasToolStripMenuItem.Click += new System.EventHandler(this.reportesDeVentasToolStripMenuItem_Click);
            // 
            // iconMenuInventario
            // 
            this.iconMenuInventario.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.iconMenuInventario.IconColor = System.Drawing.Color.Black;
            this.iconMenuInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuInventario.IconSize = 50;
            this.iconMenuInventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuInventario.Name = "iconMenuInventario";
            this.iconMenuInventario.Size = new System.Drawing.Size(72, 56);
            this.iconMenuInventario.Text = "Inventario";
            this.iconMenuInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuInventario.Click += new System.EventHandler(this.iconMenuInventario_Click);
            // 
            // labelNameUsuario
            // 
            this.labelNameUsuario.AutoSize = true;
            this.labelNameUsuario.BackColor = System.Drawing.Color.DarkGreen;
            this.labelNameUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNameUsuario.Location = new System.Drawing.Point(769, 32);
            this.labelNameUsuario.Name = "labelNameUsuario";
            this.labelNameUsuario.Size = new System.Drawing.Size(59, 16);
            this.labelNameUsuario.TabIndex = 3;
            this.labelNameUsuario.Text = "Usuario: ";
            this.labelNameUsuario.Click += new System.EventHandler(this.labelNameUsuario_Click);
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.BackColor = System.Drawing.Color.DarkGreen;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombreUsuario.Location = new System.Drawing.Point(723, 32);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(0, 16);
            this.labelNombreUsuario.TabIndex = 4;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.DarkGreen;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(819, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 16);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // contenedor
            // 
            this.contenedor.AutoSize = true;
            this.contenedor.Location = new System.Drawing.Point(0, 130);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(994, 451);
            this.contenedor.TabIndex = 6;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 580);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.labelNameUsuario);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menuTitulo;
            this.Name = "MenuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuInicial_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private FontAwesome.Sharp.IconMenuItem iconMenuUser;
        private FontAwesome.Sharp.IconMenuItem iconMenuAdmin;
        private System.Windows.Forms.Label labelNameUsuario;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconMenuItem iconMenuVentas;
        private FontAwesome.Sharp.IconMenuItem iconMenuCompras;
        private FontAwesome.Sharp.IconMenuItem iconMenuClientes;
        private FontAwesome.Sharp.IconMenuItem iconMenuProveedores;
        private FontAwesome.Sharp.IconMenuItem iconMenuMovimientos;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem submenuRegisterVenta;
        private FontAwesome.Sharp.IconMenuItem submenuVerDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem submenuRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem submenuVerDetalleCompra;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasDeUsuariosToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem iconMenuInventario;
        private System.Windows.Forms.ToolStripMenuItem reportesDeVentasToolStripMenuItem;
    }
}

