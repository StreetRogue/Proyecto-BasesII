namespace ProyectoBasesII.UserControls
{
    partial class RegistrarVehiculoControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPrecioVehiculo = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAnioVehiculo = new System.Windows.Forms.Label();
            this.btnRegistrarVehiculo = new CustomBox.RJControls.RJButton();
            this.lblRegVehiculo = new System.Windows.Forms.Label();
            this.lblSelecVehiculo = new System.Windows.Forms.Label();
            this.lblModeloVehi = new System.Windows.Forms.Label();
            this.txtModeloVehiculo = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMarcaVehiculo = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPrecioVehiculo = new System.Windows.Forms.Label();
            this.dtpAnioVehiculo = new RJCodeAdvance.RJControls.RJDatePicker();
            this.pbxImgCarros = new System.Windows.Forms.PictureBox();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.cbxProveedores = new RJCodeAdvance.RJControls.RJComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(412, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 420);
            this.panel2.TabIndex = 22;
            // 
            // txtPrecioVehiculo
            // 
            this.txtPrecioVehiculo.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrecioVehiculo.BorderColor = System.Drawing.Color.Transparent;
            this.txtPrecioVehiculo.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtPrecioVehiculo.BorderRadius = 0;
            this.txtPrecioVehiculo.BorderSize = 2;
            this.txtPrecioVehiculo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtPrecioVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioVehiculo.Location = new System.Drawing.Point(426, 374);
            this.txtPrecioVehiculo.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrecioVehiculo.Multiline = false;
            this.txtPrecioVehiculo.Name = "txtPrecioVehiculo";
            this.txtPrecioVehiculo.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtPrecioVehiculo.PasswordChar = false;
            this.txtPrecioVehiculo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecioVehiculo.PlaceholderText = "";
            this.txtPrecioVehiculo.Size = new System.Drawing.Size(276, 44);
            this.txtPrecioVehiculo.TabIndex = 21;
            this.txtPrecioVehiculo.Texts = "";
            this.txtPrecioVehiculo.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(426, 418);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 1);
            this.panel1.TabIndex = 20;
            // 
            // lblAnioVehiculo
            // 
            this.lblAnioVehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnioVehiculo.AutoSize = true;
            this.lblAnioVehiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioVehiculo.Location = new System.Drawing.Point(421, 250);
            this.lblAnioVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnioVehiculo.Name = "lblAnioVehiculo";
            this.lblAnioVehiculo.Size = new System.Drawing.Size(297, 28);
            this.lblAnioVehiculo.TabIndex = 19;
            this.lblAnioVehiculo.Text = "Seleccione el año del vehículo";
            // 
            // btnRegistrarVehiculo
            // 
            this.btnRegistrarVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnRegistrarVehiculo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnRegistrarVehiculo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnRegistrarVehiculo.BorderRadius = 20;
            this.btnRegistrarVehiculo.BorderSize = 0;
            this.btnRegistrarVehiculo.FlatAppearance.BorderSize = 0;
            this.btnRegistrarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVehiculo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVehiculo.Location = new System.Drawing.Point(464, 525);
            this.btnRegistrarVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarVehiculo.Name = "btnRegistrarVehiculo";
            this.btnRegistrarVehiculo.Size = new System.Drawing.Size(200, 49);
            this.btnRegistrarVehiculo.TabIndex = 18;
            this.btnRegistrarVehiculo.Text = "Registrar";
            this.btnRegistrarVehiculo.TextColor = System.Drawing.Color.White;
            this.btnRegistrarVehiculo.UseVisualStyleBackColor = false;
            this.btnRegistrarVehiculo.Click += new System.EventHandler(this.btnRegistrarVehiculo_Click);
            // 
            // lblRegVehiculo
            // 
            this.lblRegVehiculo.AutoSize = true;
            this.lblRegVehiculo.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRegVehiculo.Location = new System.Drawing.Point(290, 9);
            this.lblRegVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegVehiculo.Name = "lblRegVehiculo";
            this.lblRegVehiculo.Size = new System.Drawing.Size(228, 32);
            this.lblRegVehiculo.TabIndex = 17;
            this.lblRegVehiculo.Text = "Registrar Vehículo";
            // 
            // lblSelecVehiculo
            // 
            this.lblSelecVehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelecVehiculo.AutoSize = true;
            this.lblSelecVehiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecVehiculo.Location = new System.Drawing.Point(421, 143);
            this.lblSelecVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecVehiculo.Name = "lblSelecVehiculo";
            this.lblSelecVehiculo.Size = new System.Drawing.Size(289, 28);
            this.lblSelecVehiculo.TabIndex = 15;
            this.lblSelecVehiculo.Text = "Ingrese la marca del vehículo";
            // 
            // lblModeloVehi
            // 
            this.lblModeloVehi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModeloVehi.AutoSize = true;
            this.lblModeloVehi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloVehi.Location = new System.Drawing.Point(421, 50);
            this.lblModeloVehi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModeloVehi.Name = "lblModeloVehi";
            this.lblModeloVehi.Size = new System.Drawing.Size(302, 28);
            this.lblModeloVehi.TabIndex = 14;
            this.lblModeloVehi.Text = "Ingrese el modelo del vehículo";
            // 
            // txtModeloVehiculo
            // 
            this.txtModeloVehiculo.BackColor = System.Drawing.SystemColors.Control;
            this.txtModeloVehiculo.BorderColor = System.Drawing.Color.Transparent;
            this.txtModeloVehiculo.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtModeloVehiculo.BorderRadius = 0;
            this.txtModeloVehiculo.BorderSize = 2;
            this.txtModeloVehiculo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtModeloVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtModeloVehiculo.Location = new System.Drawing.Point(426, 83);
            this.txtModeloVehiculo.Margin = new System.Windows.Forms.Padding(5);
            this.txtModeloVehiculo.Multiline = false;
            this.txtModeloVehiculo.Name = "txtModeloVehiculo";
            this.txtModeloVehiculo.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtModeloVehiculo.PasswordChar = false;
            this.txtModeloVehiculo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtModeloVehiculo.PlaceholderText = "";
            this.txtModeloVehiculo.Size = new System.Drawing.Size(292, 44);
            this.txtModeloVehiculo.TabIndex = 26;
            this.txtModeloVehiculo.Texts = "";
            this.txtModeloVehiculo.UnderlinedStyle = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(426, 127);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 1);
            this.panel3.TabIndex = 25;
            // 
            // txtMarcaVehiculo
            // 
            this.txtMarcaVehiculo.BackColor = System.Drawing.SystemColors.Control;
            this.txtMarcaVehiculo.BorderColor = System.Drawing.Color.Transparent;
            this.txtMarcaVehiculo.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtMarcaVehiculo.BorderRadius = 0;
            this.txtMarcaVehiculo.BorderSize = 2;
            this.txtMarcaVehiculo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtMarcaVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMarcaVehiculo.Location = new System.Drawing.Point(426, 176);
            this.txtMarcaVehiculo.Margin = new System.Windows.Forms.Padding(5);
            this.txtMarcaVehiculo.Multiline = false;
            this.txtMarcaVehiculo.Name = "txtMarcaVehiculo";
            this.txtMarcaVehiculo.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtMarcaVehiculo.PasswordChar = false;
            this.txtMarcaVehiculo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMarcaVehiculo.PlaceholderText = "";
            this.txtMarcaVehiculo.Size = new System.Drawing.Size(292, 44);
            this.txtMarcaVehiculo.TabIndex = 28;
            this.txtMarcaVehiculo.Texts = "";
            this.txtMarcaVehiculo.UnderlinedStyle = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(426, 220);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 1);
            this.panel4.TabIndex = 27;
            // 
            // lblPrecioVehiculo
            // 
            this.lblPrecioVehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioVehiculo.AutoSize = true;
            this.lblPrecioVehiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVehiculo.Location = new System.Drawing.Point(421, 341);
            this.lblPrecioVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioVehiculo.Name = "lblPrecioVehiculo";
            this.lblPrecioVehiculo.Size = new System.Drawing.Size(290, 28);
            this.lblPrecioVehiculo.TabIndex = 29;
            this.lblPrecioVehiculo.Text = "Ingrese el precio del vehículo";
            // 
            // dtpAnioVehiculo
            // 
            this.dtpAnioVehiculo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.dtpAnioVehiculo.BorderSize = 0;
            this.dtpAnioVehiculo.CustomFormat = "yyyy";
            this.dtpAnioVehiculo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpAnioVehiculo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAnioVehiculo.Location = new System.Drawing.Point(426, 281);
            this.dtpAnioVehiculo.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpAnioVehiculo.Name = "dtpAnioVehiculo";
            this.dtpAnioVehiculo.ShowUpDown = true;
            this.dtpAnioVehiculo.Size = new System.Drawing.Size(276, 35);
            this.dtpAnioVehiculo.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.dtpAnioVehiculo.TabIndex = 30;
            this.dtpAnioVehiculo.TextColor = System.Drawing.Color.White;
            // 
            // pbxImgCarros
            // 
            this.pbxImgCarros.Image = global::ProyectoBasesII.Properties.Resources.imgVehiculo;
            this.pbxImgCarros.Location = new System.Drawing.Point(27, 82);
            this.pbxImgCarros.Margin = new System.Windows.Forms.Padding(4);
            this.pbxImgCarros.Name = "pbxImgCarros";
            this.pbxImgCarros.Size = new System.Drawing.Size(365, 420);
            this.pbxImgCarros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImgCarros.TabIndex = 23;
            this.pbxImgCarros.TabStop = false;
            // 
            // lblProveedores
            // 
            this.lblProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.Location = new System.Drawing.Point(421, 438);
            this.lblProveedores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(238, 28);
            this.lblProveedores.TabIndex = 31;
            this.lblProveedores.Text = "Seleccione el proveedor";
            // 
            // cbxProveedores
            // 
            this.cbxProveedores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxProveedores.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxProveedores.BorderSize = 1;
            this.cbxProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxProveedores.ForeColor = System.Drawing.Color.DimGray;
            this.cbxProveedores.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxProveedores.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxProveedores.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxProveedores.Location = new System.Drawing.Point(426, 470);
            this.cbxProveedores.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxProveedores.Name = "cbxProveedores";
            this.cbxProveedores.Padding = new System.Windows.Forms.Padding(1);
            this.cbxProveedores.Size = new System.Drawing.Size(276, 32);
            this.cbxProveedores.TabIndex = 32;
            this.cbxProveedores.Texts = "";
            
            // 
            // RegistrarVehiculoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxProveedores);
            this.Controls.Add(this.lblProveedores);
            this.Controls.Add(this.dtpAnioVehiculo);
            this.Controls.Add(this.lblPrecioVehiculo);
            this.Controls.Add(this.txtMarcaVehiculo);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtModeloVehiculo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pbxImgCarros);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPrecioVehiculo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAnioVehiculo);
            this.Controls.Add(this.btnRegistrarVehiculo);
            this.Controls.Add(this.lblRegVehiculo);
            this.Controls.Add(this.lblSelecVehiculo);
            this.Controls.Add(this.lblModeloVehi);
            this.Name = "RegistrarVehiculoControl";
            this.Size = new System.Drawing.Size(804, 590);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxImgCarros;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJTextBox txtPrecioVehiculo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAnioVehiculo;
        private CustomBox.RJControls.RJButton btnRegistrarVehiculo;
        private System.Windows.Forms.Label lblRegVehiculo;
        private System.Windows.Forms.Label lblSelecVehiculo;
        private System.Windows.Forms.Label lblModeloVehi;
        private RJCodeAdvance.RJControls.RJTextBox txtModeloVehiculo;
        private System.Windows.Forms.Panel panel3;
        private RJCodeAdvance.RJControls.RJTextBox txtMarcaVehiculo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPrecioVehiculo;
        private RJCodeAdvance.RJControls.RJDatePicker dtpAnioVehiculo;
        private System.Windows.Forms.Label lblProveedores;
        private RJCodeAdvance.RJControls.RJComboBox cbxProveedores;
    }
}
