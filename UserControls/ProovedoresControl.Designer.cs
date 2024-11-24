namespace ProyectoBasesII.UserControls
{
    partial class ProovedoresControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBusqueda = new CustomBox.RJControls.RJTextBox();
            this.dtgProovedores = new System.Windows.Forms.DataGridView();
            this.lblTextBusqueda = new System.Windows.Forms.Label();
            this.lblTituloProovedores = new System.Windows.Forms.Label();
            this.btnModificarProveedor = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProovedores)).BeginInit();
            this.SuspendLayout();
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
            this.txtBusqueda.Location = new System.Drawing.Point(56, 87);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(5);
            this.txtBusqueda.Multiline = false;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtBusqueda.PasswordChar = false;
            this.txtBusqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBusqueda.PlaceholderText = "";
            this.txtBusqueda.Size = new System.Drawing.Size(543, 39);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.Texts = "";
            this.txtBusqueda.UnderlinedStyle = false;
            // 
            // dtgProovedores
            // 
            this.dtgProovedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgProovedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProovedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgProovedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.dtgProovedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgProovedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(89)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProovedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProovedores.ColumnHeadersHeight = 45;
            this.dtgProovedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProovedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProovedores.EnableHeadersVisualStyles = false;
            this.dtgProovedores.Location = new System.Drawing.Point(56, 167);
            this.dtgProovedores.Margin = new System.Windows.Forms.Padding(4);
            this.dtgProovedores.Name = "dtgProovedores";
            this.dtgProovedores.ReadOnly = true;
            this.dtgProovedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(89)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProovedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProovedores.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgProovedores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgProovedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProovedores.Size = new System.Drawing.Size(648, 401);
            this.dtgProovedores.TabIndex = 2;
            // 
            // lblTextBusqueda
            // 
            this.lblTextBusqueda.AutoSize = true;
            this.lblTextBusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.lblTextBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTextBusqueda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextBusqueda.Location = new System.Drawing.Point(51, 57);
            this.lblTextBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextBusqueda.Name = "lblTextBusqueda";
            this.lblTextBusqueda.Size = new System.Drawing.Size(77, 28);
            this.lblTextBusqueda.TabIndex = 6;
            this.lblTextBusqueda.Text = "Buscar:";
            // 
            // lblTituloProovedores
            // 
            this.lblTituloProovedores.AutoSize = true;
            this.lblTituloProovedores.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProovedores.Location = new System.Drawing.Point(331, 16);
            this.lblTituloProovedores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloProovedores.Name = "lblTituloProovedores";
            this.lblTituloProovedores.Size = new System.Drawing.Size(162, 32);
            this.lblTituloProovedores.TabIndex = 7;
            this.lblTituloProovedores.Text = "Proovedores";
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
            this.btnModificarProveedor.Location = new System.Drawing.Point(731, 213);
            this.btnModificarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(53, 38);
            this.btnModificarProveedor.TabIndex = 8;
            this.btnModificarProveedor.UseVisualStyleBackColor = false;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 28;
            this.btnAgregar.Location = new System.Drawing.Point(731, 167);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(53, 38);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(608, 87);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 38);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ProovedoresControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModificarProveedor);
            this.Controls.Add(this.lblTituloProovedores);
            this.Controls.Add(this.lblTextBusqueda);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgProovedores);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProovedoresControl";
            this.Size = new System.Drawing.Size(899, 608);
            this.Load += new System.EventHandler(this.ProovedoresControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProovedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomBox.RJControls.RJTextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.DataGridView dtgProovedores;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Label lblTextBusqueda;
        private System.Windows.Forms.Label lblTituloProovedores;
        private FontAwesome.Sharp.IconButton btnModificarProveedor;
    }
}
