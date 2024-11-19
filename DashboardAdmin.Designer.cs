namespace ProyectoBasesII
{
    partial class DashboardAdmin
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenuSuperior = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblTextHora = new System.Windows.Forms.Label();
            this.lblHoraActual = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblTituloDktp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnRegVehiculo = new CustomBox.RJControls.RJButton();
            this.btnRegEmpleado = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnServicios = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.btnProv = new FontAwesome.Sharp.IconButton();
            this.btnGestionarEjem = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarServicio = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarVenta = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarCliente = new FontAwesome.Sharp.IconButton();
            this.btnRegEjemplar = new CustomBox.RJControls.RJButton();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelMenuSuperior.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.panelMenu.Controls.Add(this.btnRegVehiculo);
            this.panelMenu.Controls.Add(this.btnRegEmpleado);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnServicios);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.btnProv);
            this.panelMenu.Controls.Add(this.btnGestionarEjem);
            this.panelMenu.Controls.Add(this.btnRegistrarServicio);
            this.panelMenu.Controls.Add(this.btnRegistrarVenta);
            this.panelMenu.Controls.Add(this.btnRegistrarCliente);
            this.panelMenu.Controls.Add(this.btnRegEjemplar);
            this.panelMenu.Controls.Add(this.panelMenuSuperior);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 730);
            this.panelMenu.TabIndex = 0;
            // 
            // panelMenuSuperior
            // 
            this.panelMenuSuperior.Controls.Add(this.btnMenu);
            this.panelMenuSuperior.Controls.Add(this.Logo);
            this.panelMenuSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelMenuSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenuSuperior.Name = "panelMenuSuperior";
            this.panelMenuSuperior.Size = new System.Drawing.Size(250, 131);
            this.panelMenuSuperior.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(141)))), ((int)(((byte)(139)))));
            this.panelHeader.Controls.Add(this.label4);
            this.panelHeader.Controls.Add(this.btnMinimizar);
            this.panelHeader.Controls.Add(this.btnCerrar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(250, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(832, 75);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 50);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dashboard";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.lblTextHora);
            this.panelDesktop.Controls.Add(this.lblHoraActual);
            this.panelDesktop.Controls.Add(this.lblSaludo);
            this.panelDesktop.Controls.Add(this.lblTituloDktp);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(250, 75);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(832, 655);
            this.panelDesktop.TabIndex = 2;
            // 
            // lblTextHora
            // 
            this.lblTextHora.AutoSize = true;
            this.lblTextHora.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextHora.Location = new System.Drawing.Point(31, 148);
            this.lblTextHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextHora.Name = "lblTextHora";
            this.lblTextHora.Size = new System.Drawing.Size(77, 32);
            this.lblTextHora.TabIndex = 3;
            this.lblTextHora.Text = "Hora:";
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.AutoSize = true;
            this.lblHoraActual.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraActual.Location = new System.Drawing.Point(109, 148);
            this.lblHoraActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(0, 32);
            this.lblHoraActual.TabIndex = 2;
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(25, 66);
            this.lblSaludo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(225, 23);
            this.lblSaludo.TabIndex = 1;
            this.lblSaludo.Text = "Hola de nuevo Administrador";
            // 
            // lblTituloDktp
            // 
            this.lblTituloDktp.AutoSize = true;
            this.lblTituloDktp.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold);
            this.lblTituloDktp.Location = new System.Drawing.Point(15, 84);
            this.lblTituloDktp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloDktp.Name = "lblTituloDktp";
            this.lblTituloDktp.Size = new System.Drawing.Size(544, 50);
            this.lblTituloDktp.TabIndex = 0;
            this.lblTituloDktp.Text = "¡Bienvenido a Derrapa Zone!";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
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
            this.btnMinimizar.TabIndex = 1;
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
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRegVehiculo
            // 
            this.btnRegVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnRegVehiculo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnRegVehiculo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnRegVehiculo.BorderRadius = 0;
            this.btnRegVehiculo.BorderSize = 0;
            this.btnRegVehiculo.FlatAppearance.BorderSize = 0;
            this.btnRegVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnRegVehiculo.Image = global::ProyectoBasesII.Properties.Resources.addCar1;
            this.btnRegVehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegVehiculo.Location = new System.Drawing.Point(0, 251);
            this.btnRegVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegVehiculo.Name = "btnRegVehiculo";
            this.btnRegVehiculo.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnRegVehiculo.Size = new System.Drawing.Size(246, 44);
            this.btnRegVehiculo.TabIndex = 11;
            this.btnRegVehiculo.Tag = "Registrar Vehículo";
            this.btnRegVehiculo.Text = "Registrar Vehículo";
            this.btnRegVehiculo.TextColor = System.Drawing.Color.White;
            this.btnRegVehiculo.UseVisualStyleBackColor = false;
            this.btnRegVehiculo.Click += new System.EventHandler(this.btnRegVehiculo_Click);
            // 
            // btnRegEmpleado
            // 
            this.btnRegEmpleado.FlatAppearance.BorderSize = 0;
            this.btnRegEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegEmpleado.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            this.btnRegEmpleado.IconColor = System.Drawing.Color.White;
            this.btnRegEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegEmpleado.IconSize = 28;
            this.btnRegEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegEmpleado.Location = new System.Drawing.Point(0, 148);
            this.btnRegEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegEmpleado.Name = "btnRegEmpleado";
            this.btnRegEmpleado.Size = new System.Drawing.Size(250, 44);
            this.btnRegEmpleado.TabIndex = 10;
            this.btnRegEmpleado.Tag = "Registrar Empleado";
            this.btnRegEmpleado.Text = "Registrar Empleado";
            this.btnRegEmpleado.UseVisualStyleBackColor = true;
            this.btnRegEmpleado.Click += new System.EventHandler(this.btnRegEmpleado_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Tag = "Cerrar Sesion";
            this.btnLogOut.Text = "Cerrar Sesion";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
            this.btnServicios.Location = new System.Drawing.Point(0, 615);
            this.btnServicios.Margin = new System.Windows.Forms.Padding(4);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(250, 44);
            this.btnServicios.TabIndex = 8;
            this.btnServicios.Tag = "Servicios";
            this.btnServicios.Text = "Servicios";
            this.btnServicios.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.btnVentas.IconColor = System.Drawing.Color.White;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 32;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 563);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(250, 44);
            this.btnVentas.TabIndex = 7;
            this.btnVentas.Tag = "Ventas";
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnProv
            // 
            this.btnProv.FlatAppearance.BorderSize = 0;
            this.btnProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProv.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry;
            this.btnProv.IconColor = System.Drawing.Color.White;
            this.btnProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProv.IconSize = 35;
            this.btnProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProv.Location = new System.Drawing.Point(0, 511);
            this.btnProv.Margin = new System.Windows.Forms.Padding(4);
            this.btnProv.Name = "btnProv";
            this.btnProv.Size = new System.Drawing.Size(250, 44);
            this.btnProv.TabIndex = 6;
            this.btnProv.Tag = "Proveedores";
            this.btnProv.Text = "Proveedores";
            this.btnProv.UseVisualStyleBackColor = true;
            this.btnProv.Click += new System.EventHandler(this.btnProv_Click);
            // 
            // btnGestionarEjem
            // 
            this.btnGestionarEjem.FlatAppearance.BorderSize = 0;
            this.btnGestionarEjem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarEjem.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            this.btnGestionarEjem.IconColor = System.Drawing.Color.White;
            this.btnGestionarEjem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionarEjem.IconSize = 32;
            this.btnGestionarEjem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarEjem.Location = new System.Drawing.Point(0, 459);
            this.btnGestionarEjem.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionarEjem.Name = "btnGestionarEjem";
            this.btnGestionarEjem.Size = new System.Drawing.Size(250, 44);
            this.btnGestionarEjem.TabIndex = 5;
            this.btnGestionarEjem.Tag = "Inventario Ejemplares";
            this.btnGestionarEjem.Text = "Inventario Ejemplares";
            this.btnGestionarEjem.UseVisualStyleBackColor = true;
            this.btnGestionarEjem.Click += new System.EventHandler(this.btnGestionarEjem_Click);
            // 
            // btnRegistrarServicio
            // 
            this.btnRegistrarServicio.FlatAppearance.BorderSize = 0;
            this.btnRegistrarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarServicio.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.btnRegistrarServicio.IconColor = System.Drawing.Color.White;
            this.btnRegistrarServicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarServicio.IconSize = 32;
            this.btnRegistrarServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarServicio.Location = new System.Drawing.Point(0, 407);
            this.btnRegistrarServicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarServicio.Name = "btnRegistrarServicio";
            this.btnRegistrarServicio.Size = new System.Drawing.Size(250, 44);
            this.btnRegistrarServicio.TabIndex = 4;
            this.btnRegistrarServicio.Tag = "Registrar Servicio";
            this.btnRegistrarServicio.Text = "Registrar Servicio";
            this.btnRegistrarServicio.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.FlatAppearance.BorderSize = 0;
            this.btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnRegistrarVenta.IconColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarVenta.IconSize = 35;
            this.btnRegistrarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(-4, 355);
            this.btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(250, 44);
            this.btnRegistrarVenta.TabIndex = 2;
            this.btnRegistrarVenta.Tag = "Registrar Venta";
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnRegistrarCliente.IconColor = System.Drawing.Color.White;
            this.btnRegistrarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarCliente.IconSize = 35;
            this.btnRegistrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(0, 199);
            this.btnRegistrarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(250, 44);
            this.btnRegistrarCliente.TabIndex = 1;
            this.btnRegistrarCliente.Tag = "Registrar Cliente";
            this.btnRegistrarCliente.Text = "Registrar Cliente";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // btnRegEjemplar
            // 
            this.btnRegEjemplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnRegEjemplar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnRegEjemplar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnRegEjemplar.BorderRadius = 0;
            this.btnRegEjemplar.BorderSize = 0;
            this.btnRegEjemplar.FlatAppearance.BorderSize = 0;
            this.btnRegEjemplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegEjemplar.ForeColor = System.Drawing.Color.White;
            this.btnRegEjemplar.Image = global::ProyectoBasesII.Properties.Resources.addEjemplar;
            this.btnRegEjemplar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegEjemplar.Location = new System.Drawing.Point(0, 303);
            this.btnRegEjemplar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegEjemplar.Name = "btnRegEjemplar";
            this.btnRegEjemplar.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnRegEjemplar.Size = new System.Drawing.Size(250, 44);
            this.btnRegEjemplar.TabIndex = 0;
            this.btnRegEjemplar.Tag = "Registrar Ejemplar";
            this.btnRegEjemplar.Text = "Registrar Ejemplar";
            this.btnRegEjemplar.TextColor = System.Drawing.Color.White;
            this.btnRegEjemplar.UseVisualStyleBackColor = false;
            this.btnRegEjemplar.Click += new System.EventHandler(this.btnRegEjemplar_Click);
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
            this.btnMenu.TabIndex = 1;
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
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1082, 730);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardAdmin";
            this.panelMenu.ResumeLayout(false);
            this.panelMenuSuperior.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMenuSuperior;
        private System.Windows.Forms.PictureBox Logo;
        private FontAwesome.Sharp.IconButton btnMenu;
        private CustomBox.RJControls.RJButton btnRegEjemplar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnRegistrarCliente;
        private FontAwesome.Sharp.IconButton btnRegistrarVenta;
        private FontAwesome.Sharp.IconButton btnRegistrarServicio;
        private FontAwesome.Sharp.IconButton btnGestionarEjem;
        private FontAwesome.Sharp.IconButton btnProv;
        private FontAwesome.Sharp.IconButton btnServicios;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblTituloDktp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHoraActual;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTextHora;
        private FontAwesome.Sharp.IconButton btnRegEmpleado;
        private CustomBox.RJControls.RJButton btnRegVehiculo;
    }
}