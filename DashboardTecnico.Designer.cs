namespace ProyectoBasesII
{
    partial class DashboardTecnico
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelMenuSuperior = new System.Windows.Forms.Panel();
            this.panelDesktopTecnico = new System.Windows.Forms.Panel();
            this.lblTextHora = new System.Windows.Forms.Label();
            this.lblHoraActual = new System.Windows.Forms.Label();
            this.lblTituloDktp = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarServicio = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnServicios = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelMenuSuperior.SuspendLayout();
            this.panelDesktopTecnico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnServicios);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnRegistrarServicio);
            this.panelMenu.Controls.Add(this.panelMenuSuperior);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 730);
            this.panelMenu.TabIndex = 0;
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
            // panelDesktopTecnico
            // 
            this.panelDesktopTecnico.Controls.Add(this.lblTextHora);
            this.panelDesktopTecnico.Controls.Add(this.lblHoraActual);
            this.panelDesktopTecnico.Controls.Add(this.lblTituloDktp);
            this.panelDesktopTecnico.Controls.Add(this.lblSaludo);
            this.panelDesktopTecnico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopTecnico.Location = new System.Drawing.Point(250, 75);
            this.panelDesktopTecnico.Name = "panelDesktopTecnico";
            this.panelDesktopTecnico.Size = new System.Drawing.Size(832, 655);
            this.panelDesktopTecnico.TabIndex = 2;
            // 
            // lblTextHora
            // 
            this.lblTextHora.AutoSize = true;
            this.lblTextHora.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextHora.Location = new System.Drawing.Point(23, 137);
            this.lblTextHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextHora.Name = "lblTextHora";
            this.lblTextHora.Size = new System.Drawing.Size(77, 32);
            this.lblTextHora.TabIndex = 9;
            this.lblTextHora.Text = "Hora:";
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.AutoSize = true;
            this.lblHoraActual.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraActual.Location = new System.Drawing.Point(100, 137);
            this.lblHoraActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(0, 32);
            this.lblHoraActual.TabIndex = 8;
            // 
            // lblTituloDktp
            // 
            this.lblTituloDktp.AutoSize = true;
            this.lblTituloDktp.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold);
            this.lblTituloDktp.Location = new System.Drawing.Point(20, 87);
            this.lblTituloDktp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloDktp.Name = "lblTituloDktp";
            this.lblTituloDktp.Size = new System.Drawing.Size(544, 50);
            this.lblTituloDktp.TabIndex = 7;
            this.lblTituloDktp.Text = "¡Bienvenido a Derrapa Zone!";
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(25, 66);
            this.lblSaludo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(179, 23);
            this.lblSaludo.TabIndex = 6;
            this.lblSaludo.Text = "Hola de nuevo  Tecnico";
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo.Image = global::ProyectoBasesII.Properties.Resources.DerrapaZone;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(201, 131);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
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
            // btnRegistrarServicio
            // 
            this.btnRegistrarServicio.FlatAppearance.BorderSize = 0;
            this.btnRegistrarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarServicio.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarServicio.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.btnRegistrarServicio.IconColor = System.Drawing.Color.White;
            this.btnRegistrarServicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarServicio.IconSize = 32;
            this.btnRegistrarServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarServicio.Location = new System.Drawing.Point(0, 145);
            this.btnRegistrarServicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarServicio.Name = "btnRegistrarServicio";
            this.btnRegistrarServicio.Size = new System.Drawing.Size(250, 44);
            this.btnRegistrarServicio.TabIndex = 10;
            this.btnRegistrarServicio.Tag = "Registrar Servicio";
            this.btnRegistrarServicio.Text = "Registrar Servicio";
            this.btnRegistrarServicio.UseVisualStyleBackColor = true;
            this.btnRegistrarServicio.Click += new System.EventHandler(this.btnRegistrarServicio_Click);
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
            this.btnClientes.Location = new System.Drawing.Point(0, 197);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(250, 44);
            this.btnClientes.TabIndex = 12;
            this.btnClientes.Tag = "Clientes";
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.btnServicios.IconColor = System.Drawing.Color.White;
            this.btnServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServicios.IconSize = 32;
            this.btnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.Location = new System.Drawing.Point(0, 249);
            this.btnServicios.Margin = new System.Windows.Forms.Padding(4);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(250, 44);
            this.btnServicios.TabIndex = 13;
            this.btnServicios.Tag = "Servicios";
            this.btnServicios.Text = "Servicios";
            this.btnServicios.UseVisualStyleBackColor = true;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnLogOut.IconColor = System.Drawing.Color.White;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 28;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 686);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(250, 44);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Tag = "Cerrar Sesion";
            this.btnLogOut.Text = "Cerrar Sesion";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
            this.btnMinimizar.TabIndex = 11;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
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
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // DashboardTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 730);
            this.Controls.Add(this.panelDesktopTecnico);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardTecnico";
            this.Text = "DashboardTecnico";
            this.panelMenu.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMenuSuperior.ResumeLayout(false);
            this.panelDesktopTecnico.ResumeLayout(false);
            this.panelDesktopTecnico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMenuSuperior;
        private System.Windows.Forms.Panel panelDesktopTecnico;
        private System.Windows.Forms.Label lblTextHora;
        private System.Windows.Forms.Label lblHoraActual;
        private System.Windows.Forms.Label lblTituloDktp;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.PictureBox Logo;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnRegistrarServicio;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnServicios;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
    }
}