namespace ProyectoBasesII.UserControls
{
    partial class ModificarInventarioEjemplaresControl
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
            this.cbxVehiculo = new CustomBox.RJControls.RJComboBox();
            this.pbxImgCarros = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnModificarEjem = new CustomBox.RJControls.RJButton();
            this.lblModificarEjemplar = new System.Windows.Forms.Label();
            this.cbxProovedor = new CustomBox.RJControls.RJComboBox();
            this.lblSelecVehiculo = new System.Windows.Forms.Label();
            this.lblEjemplarProv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxVehiculo
            // 
            this.cbxVehiculo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxVehiculo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxVehiculo.BorderSize = 1;
            this.cbxVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxVehiculo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbxVehiculo.ForeColor = System.Drawing.Color.DimGray;
            this.cbxVehiculo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxVehiculo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxVehiculo.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxVehiculo.Location = new System.Drawing.Point(447, 279);
            this.cbxVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxVehiculo.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbxVehiculo.Name = "cbxVehiculo";
            this.cbxVehiculo.Padding = new System.Windows.Forms.Padding(1);
            this.cbxVehiculo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxVehiculo.Size = new System.Drawing.Size(287, 43);
            this.cbxVehiculo.TabIndex = 24;
            this.cbxVehiculo.Texts = "";
            // 
            // pbxImgCarros
            // 
            this.pbxImgCarros.Image = global::ProyectoBasesII.Properties.Resources.modificarEjemplarImg;
            this.pbxImgCarros.Location = new System.Drawing.Point(70, 130);
            this.pbxImgCarros.Margin = new System.Windows.Forms.Padding(4);
            this.pbxImgCarros.Name = "pbxImgCarros";
            this.pbxImgCarros.Size = new System.Drawing.Size(335, 384);
            this.pbxImgCarros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImgCarros.TabIndex = 23;
            this.pbxImgCarros.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(413, 130);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 384);
            this.panel2.TabIndex = 22;
            // 
            // btnModificarEjem
            // 
            this.btnModificarEjem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnModificarEjem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnModificarEjem.BorderColor = System.Drawing.Color.Red;
            this.btnModificarEjem.BorderRadius = 20;
            this.btnModificarEjem.BorderSize = 0;
            this.btnModificarEjem.FlatAppearance.BorderSize = 0;
            this.btnModificarEjem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEjem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnModificarEjem.ForeColor = System.Drawing.Color.White;
            this.btnModificarEjem.Location = new System.Drawing.Point(499, 395);
            this.btnModificarEjem.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarEjem.Name = "btnModificarEjem";
            this.btnModificarEjem.Size = new System.Drawing.Size(200, 49);
            this.btnModificarEjem.TabIndex = 18;
            this.btnModificarEjem.Text = "Modificar";
            this.btnModificarEjem.TextColor = System.Drawing.Color.White;
            this.btnModificarEjem.UseVisualStyleBackColor = false;
            this.btnModificarEjem.Click += new System.EventHandler(this.btnModificarEjem_Click);
            // 
            // lblModificarEjemplar
            // 
            this.lblModificarEjemplar.AutoSize = true;
            this.lblModificarEjemplar.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblModificarEjemplar.Location = new System.Drawing.Point(277, 44);
            this.lblModificarEjemplar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModificarEjemplar.Name = "lblModificarEjemplar";
            this.lblModificarEjemplar.Size = new System.Drawing.Size(235, 32);
            this.lblModificarEjemplar.TabIndex = 17;
            this.lblModificarEjemplar.Text = "Modificar Ejemplar";
            // 
            // cbxProovedor
            // 
            this.cbxProovedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxProovedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxProovedor.BorderSize = 1;
            this.cbxProovedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxProovedor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbxProovedor.ForeColor = System.Drawing.Color.DimGray;
            this.cbxProovedor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxProovedor.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxProovedor.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxProovedor.Location = new System.Drawing.Point(447, 176);
            this.cbxProovedor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxProovedor.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbxProovedor.Name = "cbxProovedor";
            this.cbxProovedor.Padding = new System.Windows.Forms.Padding(1);
            this.cbxProovedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxProovedor.Size = new System.Drawing.Size(287, 43);
            this.cbxProovedor.TabIndex = 16;
            this.cbxProovedor.Texts = "";
            // 
            // lblSelecVehiculo
            // 
            this.lblSelecVehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelecVehiculo.AutoSize = true;
            this.lblSelecVehiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecVehiculo.Location = new System.Drawing.Point(441, 239);
            this.lblSelecVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecVehiculo.Name = "lblSelecVehiculo";
            this.lblSelecVehiculo.Size = new System.Drawing.Size(285, 28);
            this.lblSelecVehiculo.TabIndex = 15;
            this.lblSelecVehiculo.Text = "Seleccione el nuevo vehículo";
            // 
            // lblEjemplarProv
            // 
            this.lblEjemplarProv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjemplarProv.AutoSize = true;
            this.lblEjemplarProv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemplarProv.Location = new System.Drawing.Point(437, 130);
            this.lblEjemplarProv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEjemplarProv.Name = "lblEjemplarProv";
            this.lblEjemplarProv.Size = new System.Drawing.Size(302, 28);
            this.lblEjemplarProv.TabIndex = 14;
            this.lblEjemplarProv.Text = "Seleccione el nuevo proveedor";
            // 
            // ModificarInventarioEjemplaresControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxVehiculo);
            this.Controls.Add(this.pbxImgCarros);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnModificarEjem);
            this.Controls.Add(this.lblModificarEjemplar);
            this.Controls.Add(this.cbxProovedor);
            this.Controls.Add(this.lblSelecVehiculo);
            this.Controls.Add(this.lblEjemplarProv);
            this.Name = "ModificarInventarioEjemplaresControl";
            this.Size = new System.Drawing.Size(804, 558);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomBox.RJControls.RJComboBox cbxVehiculo;
        private System.Windows.Forms.PictureBox pbxImgCarros;
        private System.Windows.Forms.Panel panel2;
        private CustomBox.RJControls.RJButton btnModificarEjem;
        private System.Windows.Forms.Label lblModificarEjemplar;
        private CustomBox.RJControls.RJComboBox cbxProovedor;
        private System.Windows.Forms.Label lblSelecVehiculo;
        private System.Windows.Forms.Label lblEjemplarProv;
    }
}
