namespace CapaPresentacion
{
    partial class frmCategoria
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
            this.ibLimpiar = new FontAwesome.Sharp.IconButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.ibSearch = new FontAwesome.Sharp.IconButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cbBusqueda = new System.Windows.Forms.ComboBox();
            this.labelBuscarPor = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.labelDetalleUser = new System.Windows.Forms.Label();
            this.buttonGuardar = new FontAwesome.Sharp.IconButton();
            this.buttonEliminar = new FontAwesome.Sharp.IconButton();
            this.buttonLimpiar = new FontAwesome.Sharp.IconButton();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.nomDescripcion = new System.Windows.Forms.Label();
            this.fondoBlanco = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // ibLimpiar
            // 
            this.ibLimpiar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibLimpiar.IconColor = System.Drawing.Color.Black;
            this.ibLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibLimpiar.IconSize = 20;
            this.ibLimpiar.Location = new System.Drawing.Point(944, 8);
            this.ibLimpiar.Name = "ibLimpiar";
            this.ibLimpiar.Size = new System.Drawing.Size(30, 28);
            this.ibLimpiar.TabIndex = 55;
            this.ibLimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibLimpiar.UseVisualStyleBackColor = true;
            this.ibLimpiar.Click += new System.EventHandler(this.ibLimpiar_Click);
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
            this.descripcion,
            this.estadoValor,
            this.estado});
            this.dgvData.Location = new System.Drawing.Point(276, 43);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(709, 393);
            this.dgvData.TabIndex = 48;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // ibSearch
            // 
            this.ibSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibSearch.IconColor = System.Drawing.Color.Black;
            this.ibSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibSearch.IconSize = 20;
            this.ibSearch.Location = new System.Drawing.Point(895, 8);
            this.ibSearch.Name = "ibSearch";
            this.ibSearch.Size = new System.Drawing.Size(30, 28);
            this.ibSearch.TabIndex = 54;
            this.ibSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibSearch.UseVisualStyleBackColor = true;
            this.ibSearch.Click += new System.EventHandler(this.ibSearch_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(783, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(93, 20);
            this.txtBusqueda.TabIndex = 53;
            // 
            // cbBusqueda
            // 
            this.cbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusqueda.FormattingEnabled = true;
            this.cbBusqueda.Location = new System.Drawing.Point(656, 12);
            this.cbBusqueda.Name = "cbBusqueda";
            this.cbBusqueda.Size = new System.Drawing.Size(108, 21);
            this.cbBusqueda.TabIndex = 52;
            // 
            // labelBuscarPor
            // 
            this.labelBuscarPor.AutoSize = true;
            this.labelBuscarPor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBuscarPor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarPor.Location = new System.Drawing.Point(576, 16);
            this.labelBuscarPor.Name = "labelBuscarPor";
            this.labelBuscarPor.Size = new System.Drawing.Size(74, 16);
            this.labelBuscarPor.TabIndex = 51;
            this.labelBuscarPor.Text = "Buscar por:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(216, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(18, 20);
            this.txtID.TabIndex = 50;
            this.txtID.Text = "0";
            this.txtID.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 35);
            this.label1.TabIndex = 49;
            this.label1.Text = "Lista de categorias";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(190, 19);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(18, 20);
            this.txtIndice.TabIndex = 56;
            this.txtIndice.Text = "-1";
            this.txtIndice.Visible = false;
            // 
            // labelDetalleUser
            // 
            this.labelDetalleUser.AutoSize = true;
            this.labelDetalleUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDetalleUser.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalleUser.Location = new System.Drawing.Point(68, 18);
            this.labelDetalleUser.Name = "labelDetalleUser";
            this.labelDetalleUser.Size = new System.Drawing.Size(98, 21);
            this.labelDetalleUser.TabIndex = 47;
            this.labelDetalleUser.Text = "CATEGORIA";
            this.labelDetalleUser.Click += new System.EventHandler(this.labelDetalleUser_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonGuardar.IconColor = System.Drawing.Color.Black;
            this.buttonGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonGuardar.Location = new System.Drawing.Point(72, 162);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(106, 23);
            this.buttonGuardar.TabIndex = 46;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Red;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonEliminar.IconColor = System.Drawing.Color.Black;
            this.buttonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonEliminar.Location = new System.Drawing.Point(73, 220);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(106, 23);
            this.buttonEliminar.TabIndex = 45;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonLimpiar.IconColor = System.Drawing.Color.Black;
            this.buttonLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonLimpiar.Location = new System.Drawing.Point(73, 191);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(105, 23);
            this.buttonLimpiar.TabIndex = 44;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(32, 124);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(177, 21);
            this.cbEstado.TabIndex = 43;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(31, 71);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(176, 20);
            this.txtDescrip.TabIndex = 37;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(29, 105);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(48, 16);
            this.labelEstado.TabIndex = 36;
            this.labelEstado.Text = "Estado";
            // 
            // nomDescripcion
            // 
            this.nomDescripcion.AutoSize = true;
            this.nomDescripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nomDescripcion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomDescripcion.Location = new System.Drawing.Point(29, 52);
            this.nomDescripcion.Name = "nomDescripcion";
            this.nomDescripcion.Size = new System.Drawing.Size(76, 16);
            this.nomDescripcion.TabIndex = 30;
            this.nomDescripcion.Text = "Descripcion";
            // 
            // fondoBlanco
            // 
            this.fondoBlanco.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fondoBlanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fondoBlanco.Dock = System.Windows.Forms.DockStyle.Left;
            this.fondoBlanco.Location = new System.Drawing.Point(0, 0);
            this.fondoBlanco.Name = "fondoBlanco";
            this.fondoBlanco.Size = new System.Drawing.Size(251, 441);
            this.fondoBlanco.TabIndex = 29;
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
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 150;
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
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 441);
            this.Controls.Add(this.ibLimpiar);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.ibSearch);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cbBusqueda);
            this.Controls.Add(this.labelBuscarPor);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.labelDetalleUser);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.nomDescripcion);
            this.Controls.Add(this.fondoBlanco);
            this.Name = "frmCategoria";
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton ibLimpiar;
        private System.Windows.Forms.DataGridView dgvData;
        private FontAwesome.Sharp.IconButton ibSearch;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cbBusqueda;
        private System.Windows.Forms.Label labelBuscarPor;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.Label labelDetalleUser;
        private FontAwesome.Sharp.IconButton buttonGuardar;
        private FontAwesome.Sharp.IconButton buttonEliminar;
        private FontAwesome.Sharp.IconButton buttonLimpiar;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label nomDescripcion;
        private System.Windows.Forms.Label fondoBlanco;
        private System.Windows.Forms.DataGridViewButtonColumn btnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}