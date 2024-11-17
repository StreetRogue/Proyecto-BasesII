namespace ProyectoBasesII.UserControls
{
    partial class RegistrarEjemplarControl
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
            this.lblEjemplarProv = new System.Windows.Forms.Label();
            this.lblSelecVehiculo = new System.Windows.Forms.Label();
            this.cbxProovedor = new CustomBox.RJControls.RJComboBox();
            this.lblRegEjemplar = new System.Windows.Forms.Label();
            this.btnRegistrarEjem = new CustomBox.RJControls.RJButton();
            this.lblStock = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStockEjemplar = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxVehiculo = new CustomBox.RJControls.RJComboBox();
            this.pbxImgCarros = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEjemplarProv
            // 
            this.lblEjemplarProv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjemplarProv.AutoSize = true;
            this.lblEjemplarProv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemplarProv.Location = new System.Drawing.Point(299, 93);
            this.lblEjemplarProv.Name = "lblEjemplarProv";
            this.lblEjemplarProv.Size = new System.Drawing.Size(194, 21);
            this.lblEjemplarProv.TabIndex = 1;
            this.lblEjemplarProv.Text = "Seleccione el Proovedor";
            // 
            // lblSelecVehiculo
            // 
            this.lblSelecVehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelecVehiculo.AutoSize = true;
            this.lblSelecVehiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecVehiculo.Location = new System.Drawing.Point(302, 181);
            this.lblSelecVehiculo.Name = "lblSelecVehiculo";
            this.lblSelecVehiculo.Size = new System.Drawing.Size(180, 21);
            this.lblSelecVehiculo.TabIndex = 3;
            this.lblSelecVehiculo.Text = "Seleccione el vehículo";
            // 
            // cbxProovedor
            // 
            this.cbxProovedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxProovedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxProovedor.BorderSize = 1;
            this.cbxProovedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProovedor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbxProovedor.ForeColor = System.Drawing.Color.DimGray;
            this.cbxProovedor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxProovedor.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxProovedor.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxProovedor.Location = new System.Drawing.Point(307, 130);
            this.cbxProovedor.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxProovedor.Name = "cbxProovedor";
            this.cbxProovedor.Padding = new System.Windows.Forms.Padding(1);
            this.cbxProovedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxProovedor.Size = new System.Drawing.Size(215, 35);
            this.cbxProovedor.TabIndex = 4;
            this.cbxProovedor.Texts = "";
            // 
            // lblRegEjemplar
            // 
            this.lblRegEjemplar.AutoSize = true;
            this.lblRegEjemplar.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRegEjemplar.Location = new System.Drawing.Point(179, 23);
            this.lblRegEjemplar.Name = "lblRegEjemplar";
            this.lblRegEjemplar.Size = new System.Drawing.Size(185, 25);
            this.lblRegEjemplar.TabIndex = 6;
            this.lblRegEjemplar.Text = "Registrar Ejemplar";
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
            this.btnRegistrarEjem.Location = new System.Drawing.Point(356, 351);
            this.btnRegistrarEjem.Name = "btnRegistrarEjem";
            this.btnRegistrarEjem.Size = new System.Drawing.Size(150, 40);
            this.btnRegistrarEjem.TabIndex = 7;
            this.btnRegistrarEjem.Text = "Registrar";
            this.btnRegistrarEjem.TextColor = System.Drawing.Color.White;
            this.btnRegistrarEjem.UseVisualStyleBackColor = false;
            // 
            // lblStock
            // 
            this.lblStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(302, 268);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(228, 21);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Ingrese el stock del ejemplar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(403, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 1);
            this.panel1.TabIndex = 9;
            // 
            // txtStockEjemplar
            // 
            this.txtStockEjemplar.BackColor = System.Drawing.SystemColors.Control;
            this.txtStockEjemplar.BorderColor = System.Drawing.Color.Transparent;
            this.txtStockEjemplar.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtStockEjemplar.BorderRadius = 0;
            this.txtStockEjemplar.BorderSize = 2;
            this.txtStockEjemplar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtStockEjemplar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStockEjemplar.Location = new System.Drawing.Point(403, 297);
            this.txtStockEjemplar.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockEjemplar.Multiline = false;
            this.txtStockEjemplar.Name = "txtStockEjemplar";
            this.txtStockEjemplar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStockEjemplar.PasswordChar = false;
            this.txtStockEjemplar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtStockEjemplar.PlaceholderText = "";
            this.txtStockEjemplar.Size = new System.Drawing.Size(60, 35);
            this.txtStockEjemplar.TabIndex = 10;
            this.txtStockEjemplar.Texts = "";
            this.txtStockEjemplar.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(281, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 312);
            this.panel2.TabIndex = 11;
            // 
            // cbxVehiculo
            // 
            this.cbxVehiculo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxVehiculo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxVehiculo.BorderSize = 1;
            this.cbxVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVehiculo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbxVehiculo.ForeColor = System.Drawing.Color.DimGray;
            this.cbxVehiculo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxVehiculo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxVehiculo.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxVehiculo.Location = new System.Drawing.Point(307, 214);
            this.cbxVehiculo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxVehiculo.Name = "cbxVehiculo";
            this.cbxVehiculo.Padding = new System.Windows.Forms.Padding(1);
            this.cbxVehiculo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxVehiculo.Size = new System.Drawing.Size(215, 35);
            this.cbxVehiculo.TabIndex = 13;
            this.cbxVehiculo.Texts = "";
            // 
            // pbxImgCarros
            // 
            this.pbxImgCarros.Image = global::ProyectoBasesII.Properties.Resources.ImgCarros;
            this.pbxImgCarros.Location = new System.Drawing.Point(24, 93);
            this.pbxImgCarros.Name = "pbxImgCarros";
            this.pbxImgCarros.Size = new System.Drawing.Size(251, 312);
            this.pbxImgCarros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImgCarros.TabIndex = 12;
            this.pbxImgCarros.TabStop = false;
            // 
            // RegistrarEjemplarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxVehiculo);
            this.Controls.Add(this.pbxImgCarros);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtStockEjemplar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.btnRegistrarEjem);
            this.Controls.Add(this.lblRegEjemplar);
            this.Controls.Add(this.cbxProovedor);
            this.Controls.Add(this.lblSelecVehiculo);
            this.Controls.Add(this.lblEjemplarProv);
            this.Name = "RegistrarEjemplarControl";
            this.Size = new System.Drawing.Size(603, 453);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEjemplarProv;
        private System.Windows.Forms.Label lblSelecVehiculo;
        private CustomBox.RJControls.RJComboBox cbxProovedor;
        private System.Windows.Forms.Label lblRegEjemplar;
        private CustomBox.RJControls.RJButton btnRegistrarEjem;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJTextBox txtStockEjemplar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbxImgCarros;
        private CustomBox.RJControls.RJComboBox cbxVehiculo;
    }
}
