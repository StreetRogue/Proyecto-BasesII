namespace ProyectoBasesII.UserControls
{
    partial class RegistrarVentaControl
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
            this.cbxVehiculoEjemplar = new CustomBox.RJControls.RJComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnRegistrarEjem = new CustomBox.RJControls.RJButton();
            this.lblRegVenta = new System.Windows.Forms.Label();
            this.cbxVendedor = new CustomBox.RJControls.RJComboBox();
            this.lblSelecEjemplar = new System.Windows.Forms.Label();
            this.lblVentaVendedor = new System.Windows.Forms.Label();
            this.cbxCedulaClienteVenta = new CustomBox.RJControls.RJComboBox();
            this.lblSelecCliente = new System.Windows.Forms.Label();
            this.lblNombreClienteVenta = new System.Windows.Forms.Label();
            this.lblPrecioEjemplar = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.pbxImgVenta = new System.Windows.Forms.PictureBox();
            this.cbxEjemplarVenta = new CustomBox.RJControls.RJComboBox();
            this.lblSelecEjemplarVenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxVehiculoEjemplar
            // 
            this.cbxVehiculoEjemplar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxVehiculoEjemplar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxVehiculoEjemplar.BorderSize = 1;
            this.cbxVehiculoEjemplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxVehiculoEjemplar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbxVehiculoEjemplar.ForeColor = System.Drawing.Color.DimGray;
            this.cbxVehiculoEjemplar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxVehiculoEjemplar.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxVehiculoEjemplar.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxVehiculoEjemplar.Location = new System.Drawing.Point(459, 242);
            this.cbxVehiculoEjemplar.Margin = new System.Windows.Forms.Padding(4);
            this.cbxVehiculoEjemplar.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbxVehiculoEjemplar.Name = "cbxVehiculoEjemplar";
            this.cbxVehiculoEjemplar.Padding = new System.Windows.Forms.Padding(1);
            this.cbxVehiculoEjemplar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxVehiculoEjemplar.Size = new System.Drawing.Size(287, 43);
            this.cbxVehiculoEjemplar.TabIndex = 24;
            this.cbxVehiculoEjemplar.Texts = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(425, 93);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 430);
            this.panel2.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(540, 550);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 1);
            this.panel1.TabIndex = 20;
            // 
            // lblStock
            // 
            this.lblStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(448, 522);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(83, 28);
            this.lblStock.TabIndex = 19;
            this.lblStock.Text = "Cliente:";
            // 
            // btnRegistrarEjem
            // 
            this.btnRegistrarEjem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnRegistrarEjem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnRegistrarEjem.BorderColor = System.Drawing.Color.Red;
            this.btnRegistrarEjem.BorderRadius = 20;
            this.btnRegistrarEjem.BorderSize = 0;
            this.btnRegistrarEjem.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEjem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEjem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarEjem.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarEjem.Location = new System.Drawing.Point(113, 489);
            this.btnRegistrarEjem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarEjem.Name = "btnRegistrarEjem";
            this.btnRegistrarEjem.Size = new System.Drawing.Size(200, 49);
            this.btnRegistrarEjem.TabIndex = 18;
            this.btnRegistrarEjem.Text = "Registrar";
            this.btnRegistrarEjem.TextColor = System.Drawing.Color.White;
            this.btnRegistrarEjem.UseVisualStyleBackColor = false;
            this.btnRegistrarEjem.Click += new System.EventHandler(this.btnRegistrarEjem_Click);
            // 
            // lblRegVenta
            // 
            this.lblRegVenta.AutoSize = true;
            this.lblRegVenta.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRegVenta.Location = new System.Drawing.Point(326, 28);
            this.lblRegVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegVenta.Name = "lblRegVenta";
            this.lblRegVenta.Size = new System.Drawing.Size(195, 32);
            this.lblRegVenta.TabIndex = 17;
            this.lblRegVenta.Text = "Registrar Venta";
            // 
            // cbxVendedor
            // 
            this.cbxVendedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxVendedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxVendedor.BorderSize = 1;
            this.cbxVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxVendedor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbxVendedor.ForeColor = System.Drawing.Color.DimGray;
            this.cbxVendedor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxVendedor.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxVendedor.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxVendedor.Location = new System.Drawing.Point(459, 139);
            this.cbxVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxVendedor.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbxVendedor.Name = "cbxVendedor";
            this.cbxVendedor.Padding = new System.Windows.Forms.Padding(1);
            this.cbxVendedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxVendedor.Size = new System.Drawing.Size(287, 43);
            this.cbxVendedor.TabIndex = 16;
            this.cbxVendedor.Texts = "";
            // 
            // lblSelecEjemplar
            // 
            this.lblSelecEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelecEjemplar.AutoSize = true;
            this.lblSelecEjemplar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecEjemplar.Location = new System.Drawing.Point(453, 202);
            this.lblSelecEjemplar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecEjemplar.Name = "lblSelecEjemplar";
            this.lblSelecEjemplar.Size = new System.Drawing.Size(221, 28);
            this.lblSelecEjemplar.TabIndex = 15;
            this.lblSelecEjemplar.Text = "Seleccione el vehiculo";
            // 
            // lblVentaVendedor
            // 
            this.lblVentaVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVentaVendedor.AutoSize = true;
            this.lblVentaVendedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaVendedor.Location = new System.Drawing.Point(449, 93);
            this.lblVentaVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentaVendedor.Name = "lblVentaVendedor";
            this.lblVentaVendedor.Size = new System.Drawing.Size(230, 28);
            this.lblVentaVendedor.TabIndex = 14;
            this.lblVentaVendedor.Text = "Seleccione el vendedor";
            // 
            // cbxCedulaClienteVenta
            // 
            this.cbxCedulaClienteVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxCedulaClienteVenta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxCedulaClienteVenta.BorderSize = 1;
            this.cbxCedulaClienteVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxCedulaClienteVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbxCedulaClienteVenta.ForeColor = System.Drawing.Color.DimGray;
            this.cbxCedulaClienteVenta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxCedulaClienteVenta.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxCedulaClienteVenta.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxCedulaClienteVenta.Location = new System.Drawing.Point(460, 436);
            this.cbxCedulaClienteVenta.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCedulaClienteVenta.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbxCedulaClienteVenta.Name = "cbxCedulaClienteVenta";
            this.cbxCedulaClienteVenta.Padding = new System.Windows.Forms.Padding(1);
            this.cbxCedulaClienteVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxCedulaClienteVenta.Size = new System.Drawing.Size(287, 43);
            this.cbxCedulaClienteVenta.TabIndex = 26;
            this.cbxCedulaClienteVenta.Texts = "";
            // 
            // lblSelecCliente
            // 
            this.lblSelecCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelecCliente.AutoSize = true;
            this.lblSelecCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecCliente.Location = new System.Drawing.Point(454, 396);
            this.lblSelecCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecCliente.Name = "lblSelecCliente";
            this.lblSelecCliente.Size = new System.Drawing.Size(308, 28);
            this.lblSelecCliente.TabIndex = 25;
            this.lblSelecCliente.Text = "Seleccione la cédula del cliente";
            // 
            // lblNombreClienteVenta
            // 
            this.lblNombreClienteVenta.AutoSize = true;
            this.lblNombreClienteVenta.Location = new System.Drawing.Point(540, 522);
            this.lblNombreClienteVenta.Name = "lblNombreClienteVenta";
            this.lblNombreClienteVenta.Size = new System.Drawing.Size(15, 16);
            this.lblNombreClienteVenta.TabIndex = 27;
            this.lblNombreClienteVenta.Text = "--";
            // 
            // lblPrecioEjemplar
            // 
            this.lblPrecioEjemplar.AutoSize = true;
            this.lblPrecioEjemplar.Location = new System.Drawing.Point(540, 584);
            this.lblPrecioEjemplar.Name = "lblPrecioEjemplar";
            this.lblPrecioEjemplar.Size = new System.Drawing.Size(23, 16);
            this.lblPrecioEjemplar.TabIndex = 30;
            this.lblPrecioEjemplar.Text = "----";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(540, 612);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 1);
            this.panel3.TabIndex = 29;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(448, 584);
            this.lblPrecioVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(76, 28);
            this.lblPrecioVenta.TabIndex = 28;
            this.lblPrecioVenta.Text = "Precio:";
            // 
            // pbxImgVenta
            // 
            this.pbxImgVenta.Image = global::ProyectoBasesII.Properties.Resources.ventaEjemplar;
            this.pbxImgVenta.Location = new System.Drawing.Point(42, 93);
            this.pbxImgVenta.Margin = new System.Windows.Forms.Padding(4);
            this.pbxImgVenta.Name = "pbxImgVenta";
            this.pbxImgVenta.Size = new System.Drawing.Size(349, 359);
            this.pbxImgVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImgVenta.TabIndex = 23;
            this.pbxImgVenta.TabStop = false;
            // 
            // cbxEjemplarVenta
            // 
            this.cbxEjemplarVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxEjemplarVenta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxEjemplarVenta.BorderSize = 1;
            this.cbxEjemplarVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxEjemplarVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbxEjemplarVenta.ForeColor = System.Drawing.Color.DimGray;
            this.cbxEjemplarVenta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxEjemplarVenta.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxEjemplarVenta.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxEjemplarVenta.Location = new System.Drawing.Point(464, 340);
            this.cbxEjemplarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEjemplarVenta.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbxEjemplarVenta.Name = "cbxEjemplarVenta";
            this.cbxEjemplarVenta.Padding = new System.Windows.Forms.Padding(1);
            this.cbxEjemplarVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxEjemplarVenta.Size = new System.Drawing.Size(287, 43);
            this.cbxEjemplarVenta.TabIndex = 32;
            this.cbxEjemplarVenta.Texts = "";
            // 
            // lblSelecEjemplarVenta
            // 
            this.lblSelecEjemplarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelecEjemplarVenta.AutoSize = true;
            this.lblSelecEjemplarVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecEjemplarVenta.Location = new System.Drawing.Point(458, 300);
            this.lblSelecEjemplarVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecEjemplarVenta.Name = "lblSelecEjemplarVenta";
            this.lblSelecEjemplarVenta.Size = new System.Drawing.Size(224, 28);
            this.lblSelecEjemplarVenta.TabIndex = 31;
            this.lblSelecEjemplarVenta.Text = "Seleccione el ejemplar";
            // 
            // RegistrarVentaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxEjemplarVenta);
            this.Controls.Add(this.lblSelecEjemplarVenta);
            this.Controls.Add(this.lblPrecioEjemplar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.lblNombreClienteVenta);
            this.Controls.Add(this.cbxCedulaClienteVenta);
            this.Controls.Add(this.lblSelecCliente);
            this.Controls.Add(this.cbxVehiculoEjemplar);
            this.Controls.Add(this.pbxImgVenta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.btnRegistrarEjem);
            this.Controls.Add(this.lblRegVenta);
            this.Controls.Add(this.cbxVendedor);
            this.Controls.Add(this.lblSelecEjemplar);
            this.Controls.Add(this.lblVentaVendedor);
            this.Name = "RegistrarVentaControl";
            this.Size = new System.Drawing.Size(924, 654);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomBox.RJControls.RJComboBox cbxVehiculoEjemplar;
        private System.Windows.Forms.PictureBox pbxImgVenta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStock;
        private CustomBox.RJControls.RJButton btnRegistrarEjem;
        private System.Windows.Forms.Label lblRegVenta;
        private CustomBox.RJControls.RJComboBox cbxVendedor;
        private System.Windows.Forms.Label lblSelecEjemplar;
        private System.Windows.Forms.Label lblVentaVendedor;
        private CustomBox.RJControls.RJComboBox cbxCedulaClienteVenta;
        private System.Windows.Forms.Label lblSelecCliente;
        private System.Windows.Forms.Label lblNombreClienteVenta;
        private System.Windows.Forms.Label lblPrecioEjemplar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPrecioVenta;
        private CustomBox.RJControls.RJComboBox cbxEjemplarVenta;
        private System.Windows.Forms.Label lblSelecEjemplarVenta;
    }
}
