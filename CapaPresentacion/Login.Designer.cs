namespace CapaPresentacion
{
    partial class Login
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
            this.FondoGreen = new System.Windows.Forms.Label();
            this.LabelPuntoVenta = new System.Windows.Forms.Label();
            this.labelInicioSesion = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FondoGreen
            // 
            this.FondoGreen.BackColor = System.Drawing.Color.DarkGreen;
            this.FondoGreen.Dock = System.Windows.Forms.DockStyle.Left;
            this.FondoGreen.Location = new System.Drawing.Point(0, 0);
            this.FondoGreen.Name = "FondoGreen";
            this.FondoGreen.Size = new System.Drawing.Size(195, 262);
            this.FondoGreen.TabIndex = 0;
            this.FondoGreen.Click += new System.EventHandler(this.FondoGreen_Click);
            // 
            // LabelPuntoVenta
            // 
            this.LabelPuntoVenta.AutoSize = true;
            this.LabelPuntoVenta.BackColor = System.Drawing.Color.DarkGreen;
            this.LabelPuntoVenta.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPuntoVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelPuntoVenta.Location = new System.Drawing.Point(3, 23);
            this.LabelPuntoVenta.Name = "LabelPuntoVenta";
            this.LabelPuntoVenta.Size = new System.Drawing.Size(192, 27);
            this.LabelPuntoVenta.TabIndex = 1;
            this.LabelPuntoVenta.Text = "PUNTO DE VENTA";
            // 
            // labelInicioSesion
            // 
            this.labelInicioSesion.AutoSize = true;
            this.labelInicioSesion.BackColor = System.Drawing.Color.DarkGreen;
            this.labelInicioSesion.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInicioSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInicioSesion.Location = new System.Drawing.Point(12, 64);
            this.labelInicioSesion.Name = "labelInicioSesion";
            this.labelInicioSesion.Size = new System.Drawing.Size(170, 23);
            this.labelInicioSesion.TabIndex = 2;
            this.labelInicioSesion.Text = "INICIO DE SESION";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Megaport;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 110;
            this.iconPictureBox1.Location = new System.Drawing.Point(39, 107);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(112, 110);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.Location = new System.Drawing.Point(265, 42);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(72, 22);
            this.LabelUsuario.TabIndex = 4;
            this.LabelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(250, 107);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(101, 22);
            this.labelContraseña.TabIndex = 5;
            this.labelContraseña.Text = "Contraseña";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(230, 67);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(150, 20);
            this.textUser.TabIndex = 6;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(230, 132);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(150, 20);
            this.textPass.TabIndex = 7;
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonIniciar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonIniciar.Location = new System.Drawing.Point(214, 185);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(95, 23);
            this.buttonIniciar.TabIndex = 8;
            this.buttonIniciar.Text = "Iniciar Sesion";
            this.buttonIniciar.UseVisualStyleBackColor = false;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(315, 185);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(95, 23);
            this.buttonSalir.TabIndex = 9;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 262);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.labelInicioSesion);
            this.Controls.Add(this.LabelPuntoVenta);
            this.Controls.Add(this.FondoGreen);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FondoGreen;
        private System.Windows.Forms.Label LabelPuntoVenta;
        private System.Windows.Forms.Label labelInicioSesion;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonSalir;
    }
}