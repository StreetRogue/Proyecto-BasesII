namespace ProyectoBasesII.UserControls
{
    partial class RegistrarServicioControl
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
            this.cbxTecnico = new CustomBox.RJControls.RJComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFechaIniServicio = new System.Windows.Forms.Label();
            this.btnRegistrarServicio = new CustomBox.RJControls.RJButton();
            this.lblRegServicios = new System.Windows.Forms.Label();
            this.cbxServicio = new CustomBox.RJControls.RJComboBox();
            this.lblSelecTecnico = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.pbxImgCarros = new System.Windows.Forms.PictureBox();
            this.dtpFechaServicio = new RJCodeAdvance.RJControls.RJDatePicker();
            this.lblVenta = new System.Windows.Forms.Label();
            this.cbxVenta = new CustomBox.RJControls.RJComboBox();
            this.pnTecnico = new System.Windows.Forms.Panel();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.lblNombreTecnico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTecnico
            // 
            this.cbxTecnico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxTecnico.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxTecnico.BorderSize = 1;
            this.cbxTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxTecnico.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbxTecnico.ForeColor = System.Drawing.Color.DimGray;
            this.cbxTecnico.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxTecnico.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxTecnico.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxTecnico.Location = new System.Drawing.Point(465, 325);
            this.cbxTecnico.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTecnico.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbxTecnico.Name = "cbxTecnico";
            this.cbxTecnico.Padding = new System.Windows.Forms.Padding(1);
            this.cbxTecnico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxTecnico.Size = new System.Drawing.Size(287, 43);
            this.cbxTecnico.TabIndex = 24;
            this.cbxTecnico.Texts = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(429, 118);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 384);
            this.panel2.TabIndex = 22;
            // 
            // lblFechaIniServicio
            // 
            this.lblFechaIniServicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaIniServicio.AutoSize = true;
            this.lblFechaIniServicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIniServicio.Location = new System.Drawing.Point(460, 454);
            this.lblFechaIniServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaIniServicio.Name = "lblFechaIniServicio";
            this.lblFechaIniServicio.Size = new System.Drawing.Size(308, 28);
            this.lblFechaIniServicio.TabIndex = 19;
            this.lblFechaIniServicio.Text = "Seleccione la fecha del servicio";
            // 
            // btnRegistrarServicio
            // 
            this.btnRegistrarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnRegistrarServicio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnRegistrarServicio.BorderColor = System.Drawing.Color.Red;
            this.btnRegistrarServicio.BorderRadius = 20;
            this.btnRegistrarServicio.BorderSize = 0;
            this.btnRegistrarServicio.FlatAppearance.BorderSize = 0;
            this.btnRegistrarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarServicio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarServicio.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarServicio.Location = new System.Drawing.Point(500, 568);
            this.btnRegistrarServicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarServicio.Name = "btnRegistrarServicio";
            this.btnRegistrarServicio.Size = new System.Drawing.Size(200, 49);
            this.btnRegistrarServicio.TabIndex = 18;
            this.btnRegistrarServicio.Text = "Registrar";
            this.btnRegistrarServicio.TextColor = System.Drawing.Color.White;
            this.btnRegistrarServicio.UseVisualStyleBackColor = false;
            this.btnRegistrarServicio.Click += new System.EventHandler(this.btnRegistrarServicio_Click);
            // 
            // lblRegServicios
            // 
            this.lblRegServicios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegServicios.AutoSize = true;
            this.lblRegServicios.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRegServicios.Location = new System.Drawing.Point(293, 32);
            this.lblRegServicios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegServicios.Name = "lblRegServicios";
            this.lblRegServicios.Size = new System.Drawing.Size(219, 32);
            this.lblRegServicios.TabIndex = 17;
            this.lblRegServicios.Text = "Registrar Servicio";
            // 
            // cbxServicio
            // 
            this.cbxServicio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxServicio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxServicio.BorderSize = 1;
            this.cbxServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxServicio.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbxServicio.ForeColor = System.Drawing.Color.DimGray;
            this.cbxServicio.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxServicio.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxServicio.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxServicio.Location = new System.Drawing.Point(465, 227);
            this.cbxServicio.Margin = new System.Windows.Forms.Padding(4);
            this.cbxServicio.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbxServicio.Name = "cbxServicio";
            this.cbxServicio.Padding = new System.Windows.Forms.Padding(1);
            this.cbxServicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxServicio.Size = new System.Drawing.Size(287, 43);
            this.cbxServicio.TabIndex = 16;
            this.cbxServicio.Texts = "";
            // 
            // lblSelecTecnico
            // 
            this.lblSelecTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelecTecnico.AutoSize = true;
            this.lblSelecTecnico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecTecnico.Location = new System.Drawing.Point(465, 284);
            this.lblSelecTecnico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecTecnico.Name = "lblSelecTecnico";
            this.lblSelecTecnico.Size = new System.Drawing.Size(210, 28);
            this.lblSelecTecnico.TabIndex = 15;
            this.lblSelecTecnico.Text = "Seleccione el técnico";
            // 
            // lblServicio
            // 
            this.lblServicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.Location = new System.Drawing.Point(460, 184);
            this.lblServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(215, 28);
            this.lblServicio.TabIndex = 14;
            this.lblServicio.Text = "Seleccione el servicio";
            // 
            // pbxImgCarros
            // 
            this.pbxImgCarros.Image = global::ProyectoBasesII.Properties.Resources.servicioTecnico;
            this.pbxImgCarros.Location = new System.Drawing.Point(86, 118);
            this.pbxImgCarros.Margin = new System.Windows.Forms.Padding(4);
            this.pbxImgCarros.Name = "pbxImgCarros";
            this.pbxImgCarros.Size = new System.Drawing.Size(335, 384);
            this.pbxImgCarros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImgCarros.TabIndex = 23;
            this.pbxImgCarros.TabStop = false;
            // 
            // dtpFechaServicio
            // 
            this.dtpFechaServicio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.dtpFechaServicio.BorderSize = 0;
            this.dtpFechaServicio.CustomFormat = "";
            this.dtpFechaServicio.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpFechaServicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaServicio.Location = new System.Drawing.Point(470, 494);
            this.dtpFechaServicio.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaServicio.Name = "dtpFechaServicio";
            this.dtpFechaServicio.Size = new System.Drawing.Size(287, 35);
            this.dtpFechaServicio.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.dtpFechaServicio.TabIndex = 31;
            this.dtpFechaServicio.TextColor = System.Drawing.Color.White;
            // 
            // lblVenta
            // 
            this.lblVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVenta.AutoSize = true;
            this.lblVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenta.Location = new System.Drawing.Point(460, 103);
            this.lblVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(194, 28);
            this.lblVenta.TabIndex = 32;
            this.lblVenta.Text = "Seleccione la venta";
            // 
            // cbxVenta
            // 
            this.cbxVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxVenta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxVenta.BorderSize = 1;
            this.cbxVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbxVenta.ForeColor = System.Drawing.Color.DimGray;
            this.cbxVenta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxVenta.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxVenta.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxVenta.Location = new System.Drawing.Point(465, 135);
            this.cbxVenta.Margin = new System.Windows.Forms.Padding(4);
            this.cbxVenta.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbxVenta.Name = "cbxVenta";
            this.cbxVenta.Padding = new System.Windows.Forms.Padding(1);
            this.cbxVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxVenta.Size = new System.Drawing.Size(287, 43);
            this.cbxVenta.TabIndex = 33;
            this.cbxVenta.Texts = "";
            // 
            // pnTecnico
            // 
            this.pnTecnico.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnTecnico.Location = new System.Drawing.Point(552, 427);
            this.pnTecnico.Margin = new System.Windows.Forms.Padding(4);
            this.pnTecnico.Name = "pnTecnico";
            this.pnTecnico.Size = new System.Drawing.Size(204, 1);
            this.pnTecnico.TabIndex = 35;
            // 
            // lblTecnico
            // 
            this.lblTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnico.Location = new System.Drawing.Point(456, 399);
            this.lblTecnico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(88, 28);
            this.lblTecnico.TabIndex = 34;
            this.lblTecnico.Text = "Técnico:";
            // 
            // lblNombreTecnico
            // 
            this.lblNombreTecnico.AutoSize = true;
            this.lblNombreTecnico.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTecnico.Location = new System.Drawing.Point(560, 402);
            this.lblNombreTecnico.Name = "lblNombreTecnico";
            this.lblNombreTecnico.Size = new System.Drawing.Size(26, 25);
            this.lblNombreTecnico.TabIndex = 36;
            this.lblNombreTecnico.Text = "--";
            // 
            // RegistrarServicioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNombreTecnico);
            this.Controls.Add(this.pnTecnico);
            this.Controls.Add(this.lblTecnico);
            this.Controls.Add(this.cbxVenta);
            this.Controls.Add(this.lblVenta);
            this.Controls.Add(this.dtpFechaServicio);
            this.Controls.Add(this.cbxTecnico);
            this.Controls.Add(this.pbxImgCarros);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblFechaIniServicio);
            this.Controls.Add(this.btnRegistrarServicio);
            this.Controls.Add(this.lblRegServicios);
            this.Controls.Add(this.cbxServicio);
            this.Controls.Add(this.lblSelecTecnico);
            this.Controls.Add(this.lblServicio);
            this.Name = "RegistrarServicioControl";
            this.Size = new System.Drawing.Size(817, 670);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomBox.RJControls.RJComboBox cbxTecnico;
        private System.Windows.Forms.PictureBox pbxImgCarros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFechaIniServicio;
        private CustomBox.RJControls.RJButton btnRegistrarServicio;
        private System.Windows.Forms.Label lblRegServicios;
        private CustomBox.RJControls.RJComboBox cbxServicio;
        private System.Windows.Forms.Label lblSelecTecnico;
        private System.Windows.Forms.Label lblServicio;
        private RJCodeAdvance.RJControls.RJDatePicker dtpFechaServicio;
        private System.Windows.Forms.Label lblVenta;
        private CustomBox.RJControls.RJComboBox cbxVenta;
        private System.Windows.Forms.Panel pnTecnico;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.Label lblNombreTecnico;
    }
}
