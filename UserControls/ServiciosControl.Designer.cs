namespace ProyectoBasesII.UserControls
{
    partial class ServiciosControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloServicios = new System.Windows.Forms.Label();
            this.lblTextBusqueda = new System.Windows.Forms.Label();
            this.dtgServicios = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new CustomBox.RJControls.RJTextBox();
            this.btnModificarProveedor = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloServicios
            // 
            this.lblTituloServicios.AutoSize = true;
            this.lblTituloServicios.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloServicios.Location = new System.Drawing.Point(395, 28);
            this.lblTituloServicios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloServicios.Name = "lblTituloServicios";
            this.lblTituloServicios.Size = new System.Drawing.Size(118, 32);
            this.lblTituloServicios.TabIndex = 15;
            this.lblTituloServicios.Text = "Servicios";
            // 
            // lblTextBusqueda
            // 
            this.lblTextBusqueda.AutoSize = true;
            this.lblTextBusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.lblTextBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTextBusqueda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextBusqueda.Location = new System.Drawing.Point(83, 69);
            this.lblTextBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextBusqueda.Name = "lblTextBusqueda";
            this.lblTextBusqueda.Size = new System.Drawing.Size(77, 28);
            this.lblTextBusqueda.TabIndex = 14;
            this.lblTextBusqueda.Text = "Buscar:";
            // 
            // dtgServicios
            // 
            this.dtgServicios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgServicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgServicios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.dtgServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(89)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgServicios.ColumnHeadersHeight = 45;
            this.dtgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgServicios.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtgServicios.EnableHeadersVisualStyles = false;
            this.dtgServicios.Location = new System.Drawing.Point(88, 179);
            this.dtgServicios.Margin = new System.Windows.Forms.Padding(4);
            this.dtgServicios.Name = "dtgServicios";
            this.dtgServicios.ReadOnly = true;
            this.dtgServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(89)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgServicios.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgServicios.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgServicios.Size = new System.Drawing.Size(648, 401);
            this.dtgServicios.TabIndex = 11;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.txtBusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.txtBusqueda.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.txtBusqueda.BorderRadius = 0;
            this.txtBusqueda.BorderSize = 2;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBusqueda.Location = new System.Drawing.Point(88, 99);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(5);
            this.txtBusqueda.Multiline = false;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtBusqueda.PasswordChar = false;
            this.txtBusqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBusqueda.PlaceholderText = "";
            this.txtBusqueda.Size = new System.Drawing.Size(543, 39);
            this.txtBusqueda.TabIndex = 9;
            this.txtBusqueda.Texts = "";
            this.txtBusqueda.UnderlinedStyle = false;
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnModificarProveedor.FlatAppearance.BorderSize = 0;
            this.btnModificarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProveedor.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.btnModificarProveedor.IconColor = System.Drawing.Color.Black;
            this.btnModificarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarProveedor.IconSize = 30;
            this.btnModificarProveedor.Location = new System.Drawing.Point(761, 179);
            this.btnModificarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(53, 38);
            this.btnModificarProveedor.TabIndex = 16;
            this.btnModificarProveedor.UseVisualStyleBackColor = false;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 30;
            this.btnBuscar.Location = new System.Drawing.Point(640, 99);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 38);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ServiciosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModificarProveedor);
            this.Controls.Add(this.lblTituloServicios);
            this.Controls.Add(this.lblTextBusqueda);
            this.Controls.Add(this.dtgServicios);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Name = "ServiciosControl";
            this.Size = new System.Drawing.Size(899, 608);
            this.Load += new System.EventHandler(this.InventarioServiciosControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnModificarProveedor;
        private System.Windows.Forms.Label lblTituloServicios;
        private System.Windows.Forms.Label lblTextBusqueda;
        private System.Windows.Forms.DataGridView dtgServicios;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private CustomBox.RJControls.RJTextBox txtBusqueda;
    }
}
