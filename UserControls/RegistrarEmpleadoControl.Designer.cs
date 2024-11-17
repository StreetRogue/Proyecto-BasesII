namespace ProyectoBasesII.UserControls
{
    partial class RegistrarEmpleadoControl
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
            this.lblRegEmpleado = new System.Windows.Forms.Label();
            this.txtApellidoEmp = new CustomBox.RJControls.RJTextBox();
            this.lblApellidoEmp = new System.Windows.Forms.Label();
            this.txtNombreEmp = new CustomBox.RJControls.RJTextBox();
            this.lblNombreEmp = new System.Windows.Forms.Label();
            this.btnRegistrarEmp = new CustomBox.RJControls.RJButton();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cbxCargoEmp = new CustomBox.RJControls.RJComboBox();
            this.pnlVertical = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegEmpleado
            // 
            this.lblRegEmpleado.AutoSize = true;
            this.lblRegEmpleado.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRegEmpleado.Location = new System.Drawing.Point(234, 34);
            this.lblRegEmpleado.Name = "lblRegEmpleado";
            this.lblRegEmpleado.Size = new System.Drawing.Size(195, 25);
            this.lblRegEmpleado.TabIndex = 7;
            this.lblRegEmpleado.Text = "Registrar Empleado";
            // 
            // txtApellidoEmp
            // 
            this.txtApellidoEmp.BackColor = System.Drawing.SystemColors.Control;
            this.txtApellidoEmp.BorderColor = System.Drawing.Color.Transparent;
            this.txtApellidoEmp.BorderFocusColor = System.Drawing.SystemColors.ControlLight;
            this.txtApellidoEmp.BorderRadius = 0;
            this.txtApellidoEmp.BorderSize = 2;
            this.txtApellidoEmp.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtApellidoEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidoEmp.Location = new System.Drawing.Point(348, 210);
            this.txtApellidoEmp.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoEmp.Multiline = false;
            this.txtApellidoEmp.Name = "txtApellidoEmp";
            this.txtApellidoEmp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellidoEmp.PasswordChar = false;
            this.txtApellidoEmp.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtApellidoEmp.PlaceholderText = "";
            this.txtApellidoEmp.Size = new System.Drawing.Size(200, 35);
            this.txtApellidoEmp.TabIndex = 11;
            this.txtApellidoEmp.Texts = "";
            this.txtApellidoEmp.UnderlinedStyle = false;
            // 
            // lblApellidoEmp
            // 
            this.lblApellidoEmp.AutoSize = true;
            this.lblApellidoEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEmp.Location = new System.Drawing.Point(344, 185);
            this.lblApellidoEmp.Name = "lblApellidoEmp";
            this.lblApellidoEmp.Size = new System.Drawing.Size(241, 21);
            this.lblApellidoEmp.TabIndex = 10;
            this.lblApellidoEmp.Text = "Ingrese el  apellido del Cliente";
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreEmp.BorderColor = System.Drawing.Color.Transparent;
            this.txtNombreEmp.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombreEmp.BorderRadius = 0;
            this.txtNombreEmp.BorderSize = 2;
            this.txtNombreEmp.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNombreEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreEmp.Location = new System.Drawing.Point(348, 135);
            this.txtNombreEmp.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreEmp.Multiline = false;
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreEmp.PasswordChar = false;
            this.txtNombreEmp.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreEmp.PlaceholderText = "";
            this.txtNombreEmp.Size = new System.Drawing.Size(199, 35);
            this.txtNombreEmp.TabIndex = 9;
            this.txtNombreEmp.Texts = "";
            this.txtNombreEmp.UnderlinedStyle = false;
            // 
            // lblNombreEmp
            // 
            this.lblNombreEmp.AutoSize = true;
            this.lblNombreEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmp.Location = new System.Drawing.Point(344, 114);
            this.lblNombreEmp.Name = "lblNombreEmp";
            this.lblNombreEmp.Size = new System.Drawing.Size(234, 21);
            this.lblNombreEmp.TabIndex = 8;
            this.lblNombreEmp.Text = "Ingrese el nombre del Cliente";
            // 
            // btnRegistrarEmp
            // 
            this.btnRegistrarEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnRegistrarEmp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnRegistrarEmp.BorderColor = System.Drawing.Color.Red;
            this.btnRegistrarEmp.BorderRadius = 20;
            this.btnRegistrarEmp.BorderSize = 0;
            this.btnRegistrarEmp.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEmp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarEmp.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarEmp.Location = new System.Drawing.Point(397, 349);
            this.btnRegistrarEmp.Name = "btnRegistrarEmp";
            this.btnRegistrarEmp.Size = new System.Drawing.Size(181, 40);
            this.btnRegistrarEmp.TabIndex = 12;
            this.btnRegistrarEmp.Text = "Registrar";
            this.btnRegistrarEmp.TextColor = System.Drawing.Color.White;
            this.btnRegistrarEmp.UseVisualStyleBackColor = false;
            this.btnRegistrarEmp.Click += new System.EventHandler(this.btnRegistrarEmp_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(344, 267);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(215, 21);
            this.lblCargo.TabIndex = 13;
            this.lblCargo.Text = "Seleccione el tipo de cargo";
            // 
            // cbxCargoEmp
            // 
            this.cbxCargoEmp.BackColor = System.Drawing.SystemColors.Control;
            this.cbxCargoEmp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxCargoEmp.BorderSize = 1;
            this.cbxCargoEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxCargoEmp.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbxCargoEmp.ForeColor = System.Drawing.Color.DimGray;
            this.cbxCargoEmp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.cbxCargoEmp.Items.AddRange(new object[] {
            "Técnico",
            "Vendedor"});
            this.cbxCargoEmp.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxCargoEmp.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxCargoEmp.Location = new System.Drawing.Point(348, 302);
            this.cbxCargoEmp.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxCargoEmp.Name = "cbxCargoEmp";
            this.cbxCargoEmp.Padding = new System.Windows.Forms.Padding(1);
            this.cbxCargoEmp.Size = new System.Drawing.Size(211, 35);
            this.cbxCargoEmp.TabIndex = 14;
            this.cbxCargoEmp.Texts = "";
            // 
            // pnlVertical
            // 
            this.pnlVertical.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlVertical.Location = new System.Drawing.Point(337, 114);
            this.pnlVertical.Name = "pnlVertical";
            this.pnlVertical.Size = new System.Drawing.Size(1, 275);
            this.pnlVertical.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoBasesII.Properties.Resources.ImgEmpleados;
            this.pictureBox1.Location = new System.Drawing.Point(20, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(348, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(348, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 18;
            // 
            // RegistrarEmpleadoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlVertical);
            this.Controls.Add(this.cbxCargoEmp);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.btnRegistrarEmp);
            this.Controls.Add(this.txtApellidoEmp);
            this.Controls.Add(this.lblApellidoEmp);
            this.Controls.Add(this.txtNombreEmp);
            this.Controls.Add(this.lblNombreEmp);
            this.Controls.Add(this.lblRegEmpleado);
            this.Name = "RegistrarEmpleadoControl";
            this.Size = new System.Drawing.Size(674, 494);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegEmpleado;
        private CustomBox.RJControls.RJTextBox txtApellidoEmp;
        private System.Windows.Forms.Label lblApellidoEmp;
        private CustomBox.RJControls.RJTextBox txtNombreEmp;
        private System.Windows.Forms.Label lblNombreEmp;
        private CustomBox.RJControls.RJButton btnRegistrarEmp;
        private System.Windows.Forms.Label lblCargo;
        private CustomBox.RJControls.RJComboBox cbxCargoEmp;
        private System.Windows.Forms.Panel pnlVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
