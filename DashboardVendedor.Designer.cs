namespace ProyectoBasesII
{
    partial class DashboardVendedor
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnGestionarEjem = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarVenta = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarCliente = new FontAwesome.Sharp.IconButton();
            this.panelMenuSuperior = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.panelDesktopVendedor = new System.Windows.Forms.Panel();
            this.lblTextHora = new System.Windows.Forms.Label();
            this.lblHoraActual = new System.Windows.Forms.Label();
            this.lblTituloDktp = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelMenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelDesktopVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnGestionarEjem);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.btnRegistrarVenta);
            this.panelMenu.Controls.Add(this.btnRegistrarCliente);
            this.panelMenu.Controls.Add(this.panelMenuSuperior);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 730);
            this.panelMenu.TabIndex = 0;
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.btnClientes.IconColor = System.Drawing.Color.White;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 32;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 322);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(250, 44);
            this.btnClientes.TabIndex = 11;
            this.btnClientes.Tag = "Clientes";
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnLogOut.IconColor = System.Drawing.Color.White;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 28;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 686);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(250, 44);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Tag = "Cerrar Sesion";
            this.btnLogOut.Text = "Cerrar Sesion";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnGestionarEjem
            // 
            this.btnGestionarEjem.FlatAppearance.BorderSize = 0;
            this.btnGestionarEjem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarEjem.ForeColor = System.Drawing.Color.White;
            this.btnGestionarEjem.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            this.btnGestionarEjem.IconColor = System.Drawing.Color.White;
            this.btnGestionarEjem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionarEjem.IconSize = 32;
            this.btnGestionarEjem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarEjem.Location = new System.Drawing.Point(0, 270);
            this.btnGestionarEjem.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionarEjem.Name = "btnGestionarEjem";
            this.btnGestionarEjem.Size = new System.Drawing.Size(250, 44);
            this.btnGestionarEjem.TabIndex = 9;
            this.btnGestionarEjem.Tag = "Inventario Ejemplares";
            this.btnGestionarEjem.Text = "Inventario Ejemplares";
            this.btnGestionarEjem.UseVisualStyleBackColor = true;
            this.btnGestionarEjem.Click += new System.EventHandler(this.btnGestionarEjem_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.btnVentas.IconColor = System.Drawing.Color.White;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 32;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 374);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(250, 44);
            this.btnVentas.TabIndex = 8;
            this.btnVentas.Tag = "Ventas";
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.FlatAppearance.BorderSize = 0;
            this.btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnRegistrarVenta.IconColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarVenta.IconSize = 35;
            this.btnRegistrarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(0, 218);
            this.btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(250, 44);
            this.btnRegistrarVenta.TabIndex = 3;
            this.btnRegistrarVenta.Tag = "Registrar Venta";
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCliente.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnRegistrarCliente.IconColor = System.Drawing.Color.White;
            this.btnRegistrarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarCliente.IconSize = 35;
            this.btnRegistrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(0, 166);
            this.btnRegistrarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(250, 44);
            this.btnRegistrarCliente.TabIndex = 2;
            this.btnRegistrarCliente.Tag = "Registrar Cliente";
            this.btnRegistrarCliente.Text = "Registrar Cliente";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // panelMenuSuperior
            // 
            this.panelMenuSuperior.Controls.Add(this.btnMenu);
            this.panelMenuSuperior.Controls.Add(this.Logo);
            this.panelMenuSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelMenuSuperior.Name = "panelMenuSuperior";
            this.panelMenuSuperior.Size = new System.Drawing.Size(250, 131);
            this.panelMenuSuperior.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(205, 49);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(41, 38);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo.Image = global::ProyectoBasesII.Properties.Resources.DerrapaZone;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(201, 131);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(141)))), ((int)(((byte)(139)))));
            this.panelHeader.Controls.Add(this.btnMinimizar);
            this.panelHeader.Controls.Add(this.label4);
            this.panelHeader.Controls.Add(this.btnCerrar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(250, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(832, 75);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.LightGray;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.LightGray;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizar.IconColor = System.Drawing.Color.Black;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 20;
            this.btnMinimizar.Location = new System.Drawing.Point(731, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(54, 29);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 50);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dashboard";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Red;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 20;
            this.btnCerrar.Location = new System.Drawing.Point(781, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(51, 29);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelDesktopVendedor
            // 
            this.panelDesktopVendedor.Controls.Add(this.lblTextHora);
            this.panelDesktopVendedor.Controls.Add(this.lblHoraActual);
            this.panelDesktopVendedor.Controls.Add(this.lblTituloDktp);
            this.panelDesktopVendedor.Controls.Add(this.lblSaludo);
            this.panelDesktopVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopVendedor.Location = new System.Drawing.Point(250, 75);
            this.panelDesktopVendedor.Name = "panelDesktopVendedor";
            this.panelDesktopVendedor.Size = new System.Drawing.Size(832, 655);
            this.panelDesktopVendedor.TabIndex = 2;
            // 
            // lblTextHora
            // 
            this.lblTextHora.AutoSize = true;
            this.lblTextHora.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextHora.Location = new System.Drawing.Point(23, 148);
            this.lblTextHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextHora.Name = "lblTextHora";
            this.lblTextHora.Size = new System.Drawing.Size(77, 32);
            this.lblTextHora.TabIndex = 5;
            this.lblTextHora.Text = "Hora:";
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.AutoSize = true;
            this.lblHoraActual.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraActual.Location = new System.Drawing.Point(100, 148);
            this.lblHoraActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(0, 32);
            this.lblHoraActual.TabIndex = 4;
            // 
            // lblTituloDktp
            // 
            this.lblTituloDktp.AutoSize = true;
            this.lblTituloDktp.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold);
            this.lblTituloDktp.Location = new System.Drawing.Point(15, 84);
            this.lblTituloDktp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloDktp.Name = "lblTituloDktp";
            this.lblTituloDktp.Size = new System.Drawing.Size(544, 50);
            this.lblTituloDktp.TabIndex = 3;
            this.lblTituloDktp.Text = "¡Bienvenido a Derrapa Zone!";
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(25, 66);
            this.lblSaludo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(195, 23);
            this.lblSaludo.TabIndex = 2;
            this.lblSaludo.Text = "Hola de nuevo  Vendedor";
            // 
            // DashboardVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1082, 730);
            this.Controls.Add(this.panelDesktopVendedor);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardVendedor";
            this.panelMenu.ResumeLayout(false);
            this.panelMenuSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelDesktopVendedor.ResumeLayout(false);
            this.panelDesktopVendedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelDesktopVendedor;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblTituloDktp;
        private System.Windows.Forms.Panel panelMenuSuperior;
        private System.Windows.Forms.Label lblTextHora;
        private System.Windows.Forms.Label lblHoraActual;
        private System.Windows.Forms.PictureBox Logo;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnRegistrarCliente;
        private FontAwesome.Sharp.IconButton btnRegistrarVenta;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnGestionarEjem;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private FontAwesome.Sharp.IconButton btnClientes;
    }
}