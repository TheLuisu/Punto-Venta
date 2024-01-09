namespace CapaPresentacion
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fondoBlanco = new System.Windows.Forms.Label();
            this.nomUsuario = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.nombreCom = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.ConfirPass = new System.Windows.Forms.Label();
            this.LabelRol = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPassConfirm = new System.Windows.Forms.TextBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.buttonLimpiar = new FontAwesome.Sharp.IconButton();
            this.buttonEliminar = new FontAwesome.Sharp.IconButton();
            this.buttonGuardar = new FontAwesome.Sharp.IconButton();
            this.labelDetalleUser = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelBuscarPor = new System.Windows.Forms.Label();
            this.cbBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.ibSearch = new FontAwesome.Sharp.IconButton();
            this.ibLimpiar = new FontAwesome.Sharp.IconButton();
            this.txtIndice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // fondoBlanco
            // 
            this.fondoBlanco.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fondoBlanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fondoBlanco.Dock = System.Windows.Forms.DockStyle.Left;
            this.fondoBlanco.Location = new System.Drawing.Point(0, 0);
            this.fondoBlanco.Name = "fondoBlanco";
            this.fondoBlanco.Size = new System.Drawing.Size(253, 455);
            this.fondoBlanco.TabIndex = 0;
            // 
            // nomUsuario
            // 
            this.nomUsuario.AutoSize = true;
            this.nomUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nomUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomUsuario.Location = new System.Drawing.Point(38, 51);
            this.nomUsuario.Name = "nomUsuario";
            this.nomUsuario.Size = new System.Drawing.Size(125, 16);
            this.nomUsuario.TabIndex = 1;
            this.nomUsuario.Text = "Nombre de Usuario";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCorreo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(38, 136);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(49, 16);
            this.labelCorreo.TabIndex = 2;
            this.labelCorreo.Text = "Correo";
            // 
            // nombreCom
            // 
            this.nombreCom.AutoSize = true;
            this.nombreCom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nombreCom.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCom.Location = new System.Drawing.Point(38, 97);
            this.nombreCom.Name = "nombreCom";
            this.nombreCom.Size = new System.Drawing.Size(118, 16);
            this.nombreCom.TabIndex = 3;
            this.nombreCom.Text = "Nombre Completo";
            this.nombreCom.Click += new System.EventHandler(this.nombreCom_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(37, 178);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(81, 16);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Contraseña: ";
            this.labelPassword.Click += new System.EventHandler(this.password_Click);
            // 
            // ConfirPass
            // 
            this.ConfirPass.AutoSize = true;
            this.ConfirPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConfirPass.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirPass.Location = new System.Drawing.Point(38, 220);
            this.ConfirPass.Name = "ConfirPass";
            this.ConfirPass.Size = new System.Drawing.Size(137, 16);
            this.ConfirPass.TabIndex = 5;
            this.ConfirPass.Text = "Confirmar contraseña:";
            // 
            // LabelRol
            // 
            this.LabelRol.AutoSize = true;
            this.LabelRol.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelRol.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRol.Location = new System.Drawing.Point(37, 265);
            this.LabelRol.Name = "LabelRol";
            this.LabelRol.Size = new System.Drawing.Size(34, 16);
            this.LabelRol.TabIndex = 6;
            this.LabelRol.Text = "Rol: ";
            this.LabelRol.Click += new System.EventHandler(this.LabelRol_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(37, 308);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(48, 16);
            this.labelEstado.TabIndex = 7;
            this.labelEstado.Text = "Estado";
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(40, 70);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(178, 20);
            this.txtDoc.TabIndex = 8;
            this.txtDoc.TextChanged += new System.EventHandler(this.txtDoc_TextChanged);
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(41, 113);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(178, 20);
            this.txtNombreCompleto.TabIndex = 9;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(41, 155);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(178, 20);
            this.txtCorreo.TabIndex = 10;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(41, 197);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(178, 20);
            this.txtPass.TabIndex = 11;
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.Location = new System.Drawing.Point(41, 239);
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.Size = new System.Drawing.Size(178, 20);
            this.txtPassConfirm.TabIndex = 12;
            // 
            // cbRol
            // 
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(41, 284);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(178, 21);
            this.cbRol.TabIndex = 13;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(40, 327);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(179, 21);
            this.cbEstado.TabIndex = 14;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonLimpiar.IconColor = System.Drawing.Color.Black;
            this.buttonLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonLimpiar.Location = new System.Drawing.Point(126, 373);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(107, 23);
            this.buttonLimpiar.TabIndex = 16;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Red;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonEliminar.IconColor = System.Drawing.Color.Black;
            this.buttonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonEliminar.Location = new System.Drawing.Point(63, 402);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(108, 23);
            this.buttonEliminar.TabIndex = 17;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonGuardar.IconColor = System.Drawing.Color.Black;
            this.buttonGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonGuardar.Location = new System.Drawing.Point(12, 373);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(108, 23);
            this.buttonGuardar.TabIndex = 18;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelDetalleUser
            // 
            this.labelDetalleUser.AutoSize = true;
            this.labelDetalleUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDetalleUser.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalleUser.Location = new System.Drawing.Point(75, 19);
            this.labelDetalleUser.Name = "labelDetalleUser";
            this.labelDetalleUser.Size = new System.Drawing.Size(81, 21);
            this.labelDetalleUser.TabIndex = 19;
            this.labelDetalleUser.Text = "USUARIO";
            this.labelDetalleUser.Click += new System.EventHandler(this.labelDetalleUser_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSelect,
            this.Id,
            this.documento,
            this.nombreCompleto,
            this.correo,
            this.password,
            this.idRol,
            this.Rol,
            this.estadoValor,
            this.estado});
            this.dgvData.Location = new System.Drawing.Point(259, 43);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(727, 403);
            this.dgvData.TabIndex = 20;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // btnSelect
            // 
            this.btnSelect.HeaderText = "";
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ReadOnly = true;
            this.btnSelect.Width = 30;
            // 
            // Id
            // 
            this.Id.HeaderText = "idUsuario";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // documento
            // 
            this.documento.HeaderText = "Nombre de Usuario";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 150;
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.HeaderText = "Nombre Completo";
            this.nombreCompleto.Name = "nombreCompleto";
            this.nombreCompleto.ReadOnly = true;
            this.nombreCompleto.Width = 150;
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 150;
            // 
            // password
            // 
            this.password.HeaderText = "Contraseña";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // idRol
            // 
            this.idRol.HeaderText = "idRol";
            this.idRol.Name = "idRol";
            this.idRol.ReadOnly = true;
            this.idRol.Visible = false;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // estadoValor
            // 
            this.estadoValor.HeaderText = "Estado Valor";
            this.estadoValor.Name = "estadoValor";
            this.estadoValor.ReadOnly = true;
            this.estadoValor.Visible = false;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 35);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lista de usuarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(199, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(20, 20);
            this.txtID.TabIndex = 22;
            this.txtID.Text = "0";
            this.txtID.Visible = false;
            // 
            // labelBuscarPor
            // 
            this.labelBuscarPor.AutoSize = true;
            this.labelBuscarPor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBuscarPor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarPor.Location = new System.Drawing.Point(559, 16);
            this.labelBuscarPor.Name = "labelBuscarPor";
            this.labelBuscarPor.Size = new System.Drawing.Size(74, 16);
            this.labelBuscarPor.TabIndex = 23;
            this.labelBuscarPor.Text = "Buscar por:";
            this.labelBuscarPor.Click += new System.EventHandler(this.labelBuscarPor_Click);
            // 
            // cbBusqueda
            // 
            this.cbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusqueda.FormattingEnabled = true;
            this.cbBusqueda.Location = new System.Drawing.Point(639, 12);
            this.cbBusqueda.Name = "cbBusqueda";
            this.cbBusqueda.Size = new System.Drawing.Size(121, 21);
            this.cbBusqueda.TabIndex = 24;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(766, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(106, 20);
            this.txtBusqueda.TabIndex = 25;
            // 
            // ibSearch
            // 
            this.ibSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibSearch.IconColor = System.Drawing.Color.Black;
            this.ibSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibSearch.IconSize = 20;
            this.ibSearch.Location = new System.Drawing.Point(878, 8);
            this.ibSearch.Name = "ibSearch";
            this.ibSearch.Size = new System.Drawing.Size(43, 28);
            this.ibSearch.TabIndex = 26;
            this.ibSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibSearch.UseVisualStyleBackColor = true;
            this.ibSearch.Click += new System.EventHandler(this.ibSearch_Click);
            // 
            // ibLimpiar
            // 
            this.ibLimpiar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibLimpiar.IconColor = System.Drawing.Color.Black;
            this.ibLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibLimpiar.IconSize = 20;
            this.ibLimpiar.Location = new System.Drawing.Point(927, 8);
            this.ibLimpiar.Name = "ibLimpiar";
            this.ibLimpiar.Size = new System.Drawing.Size(43, 28);
            this.ibLimpiar.TabIndex = 27;
            this.ibLimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibLimpiar.UseVisualStyleBackColor = true;
            this.ibLimpiar.Click += new System.EventHandler(this.ibLimpiar_Click);
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(173, 19);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(20, 20);
            this.txtIndice.TabIndex = 28;
            this.txtIndice.Text = "-1";
            this.txtIndice.Visible = false;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(993, 455);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.ibLimpiar);
            this.Controls.Add(this.ibSearch);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cbBusqueda);
            this.Controls.Add(this.labelBuscarPor);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.labelDetalleUser);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.txtPassConfirm);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.LabelRol);
            this.Controls.Add(this.ConfirPass);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.nombreCom);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.nomUsuario);
            this.Controls.Add(this.fondoBlanco);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fondoBlanco;
        private System.Windows.Forms.Label nomUsuario;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label nombreCom;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label ConfirPass;
        private System.Windows.Forms.Label LabelRol;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtPassConfirm;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.ComboBox cbEstado;
        private FontAwesome.Sharp.IconButton buttonLimpiar;
        private FontAwesome.Sharp.IconButton buttonEliminar;
        private FontAwesome.Sharp.IconButton buttonGuardar;
        private System.Windows.Forms.Label labelDetalleUser;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labelBuscarPor;
        private System.Windows.Forms.ComboBox cbBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton ibSearch;
        private FontAwesome.Sharp.IconButton ibLimpiar;
        private System.Windows.Forms.DataGridViewButtonColumn btnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.TextBox txtIndice;
    }
}