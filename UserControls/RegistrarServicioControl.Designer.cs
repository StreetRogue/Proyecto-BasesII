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
            this.cbxVehiculo = new CustomBox.RJControls.RJComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFechaIniServicio = new System.Windows.Forms.Label();
            this.btnRegistrarEjem = new CustomBox.RJControls.RJButton();
            this.lblRegServicios = new System.Windows.Forms.Label();
            this.cbxProovedor = new CustomBox.RJControls.RJComboBox();
            this.lblSelecTecnico = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.pbxImgCarros = new System.Windows.Forms.PictureBox();
            this.dtpFechaServicio = new RJCodeAdvance.RJControls.RJDatePicker();
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
            this.cbxVehiculo.Location = new System.Drawing.Point(463, 267);
            this.cbxVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxVehiculo.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbxVehiculo.Name = "cbxVehiculo";
            this.cbxVehiculo.Padding = new System.Windows.Forms.Padding(1);
            this.cbxVehiculo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxVehiculo.Size = new System.Drawing.Size(287, 43);
            this.cbxVehiculo.TabIndex = 24;
            this.cbxVehiculo.Texts = "";
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
            this.lblFechaIniServicio.Location = new System.Drawing.Point(457, 334);
            this.lblFechaIniServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaIniServicio.Name = "lblFechaIniServicio";
            this.lblFechaIniServicio.Size = new System.Drawing.Size(308, 28);
            this.lblFechaIniServicio.TabIndex = 19;
            this.lblFechaIniServicio.Text = "Seleccione la fecha del servicio";
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
            this.btnRegistrarEjem.Location = new System.Drawing.Point(513, 453);
            this.btnRegistrarEjem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarEjem.Name = "btnRegistrarEjem";
            this.btnRegistrarEjem.Size = new System.Drawing.Size(200, 49);
            this.btnRegistrarEjem.TabIndex = 18;
            this.btnRegistrarEjem.Text = "Registrar";
            this.btnRegistrarEjem.TextColor = System.Drawing.Color.White;
            this.btnRegistrarEjem.UseVisualStyleBackColor = false;
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
            this.cbxProovedor.Location = new System.Drawing.Point(458, 163);
            this.cbxProovedor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxProovedor.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbxProovedor.Name = "cbxProovedor";
            this.cbxProovedor.Padding = new System.Windows.Forms.Padding(1);
            this.cbxProovedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxProovedor.Size = new System.Drawing.Size(287, 43);
            this.cbxProovedor.TabIndex = 16;
            this.cbxProovedor.Texts = "";
            // 
            // lblSelecTecnico
            // 
            this.lblSelecTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelecTecnico.AutoSize = true;
            this.lblSelecTecnico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecTecnico.Location = new System.Drawing.Point(457, 227);
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
            this.lblServicio.Location = new System.Drawing.Point(453, 118);
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
            this.dtpFechaServicio.Location = new System.Drawing.Point(463, 376);
            this.dtpFechaServicio.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaServicio.Name = "dtpFechaServicio";
            this.dtpFechaServicio.Size = new System.Drawing.Size(287, 35);
            this.dtpFechaServicio.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.dtpFechaServicio.TabIndex = 31;
            this.dtpFechaServicio.TextColor = System.Drawing.Color.White;
            // 
            // RegistrarServicioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpFechaServicio);
            this.Controls.Add(this.cbxVehiculo);
            this.Controls.Add(this.pbxImgCarros);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblFechaIniServicio);
            this.Controls.Add(this.btnRegistrarEjem);
            this.Controls.Add(this.lblRegServicios);
            this.Controls.Add(this.cbxProovedor);
            this.Controls.Add(this.lblSelecTecnico);
            this.Controls.Add(this.lblServicio);
            this.Name = "RegistrarServicioControl";
            this.Size = new System.Drawing.Size(817, 568);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomBox.RJControls.RJComboBox cbxVehiculo;
        private System.Windows.Forms.PictureBox pbxImgCarros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFechaIniServicio;
        private CustomBox.RJControls.RJButton btnRegistrarEjem;
        private System.Windows.Forms.Label lblRegServicios;
        private CustomBox.RJControls.RJComboBox cbxProovedor;
        private System.Windows.Forms.Label lblSelecTecnico;
        private System.Windows.Forms.Label lblServicio;
        private RJCodeAdvance.RJControls.RJDatePicker dtpFechaServicio;
    }
}
