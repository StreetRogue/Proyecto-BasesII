namespace ProyectoBasesII.UserControls
{
    partial class ClienteControl
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
            this.lblTituloClientes = new System.Windows.Forms.Label();
            this.lblTextBusqueda = new System.Windows.Forms.Label();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new CustomBox.RJControls.RJTextBox();
            this.btnModificarProveedor = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloClientes
            // 
            this.lblTituloClientes.AutoSize = true;
            this.lblTituloClientes.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloClientes.Location = new System.Drawing.Point(396, 28);
            this.lblTituloClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloClientes.Name = "lblTituloClientes";
            this.lblTituloClientes.Size = new System.Drawing.Size(106, 32);
            this.lblTituloClientes.TabIndex = 22;
            this.lblTituloClientes.Text = "Clientes";
            // 
            // lblTextBusqueda
            // 
            this.lblTextBusqueda.AutoSize = true;
            this.lblTextBusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.lblTextBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTextBusqueda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextBusqueda.Location = new System.Drawing.Point(84, 69);
            this.lblTextBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextBusqueda.Name = "lblTextBusqueda";
            this.lblTextBusqueda.Size = new System.Drawing.Size(77, 28);
            this.lblTextBusqueda.TabIndex = 21;
            this.lblTextBusqueda.Text = "Buscar:";
            // 
            // dtgClientes
            // 
            this.dtgClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.dtgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(89)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgClientes.ColumnHeadersHeight = 45;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgClientes.EnableHeadersVisualStyles = false;
            this.dtgClientes.Location = new System.Drawing.Point(89, 179);
            this.dtgClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(89)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClientes.Size = new System.Drawing.Size(648, 401);
            this.dtgClientes.TabIndex = 19;
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
            this.txtBusqueda.Location = new System.Drawing.Point(89, 99);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(5);
            this.txtBusqueda.Multiline = false;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtBusqueda.PasswordChar = false;
            this.txtBusqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBusqueda.PlaceholderText = "";
            this.txtBusqueda.Size = new System.Drawing.Size(543, 39);
            this.txtBusqueda.TabIndex = 17;
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
            this.btnModificarProveedor.Location = new System.Drawing.Point(762, 179);
            this.btnModificarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(53, 38);
            this.btnModificarProveedor.TabIndex = 23;
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
            this.btnBuscar.Location = new System.Drawing.Point(641, 99);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 38);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ClienteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModificarProveedor);
            this.Controls.Add(this.lblTituloClientes);
            this.Controls.Add(this.lblTextBusqueda);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Name = "ClienteControl";
            this.Size = new System.Drawing.Size(899, 608);
            this.Load += new System.EventHandler(this.ClienteControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnModificarProveedor;
        private System.Windows.Forms.Label lblTituloClientes;
        private System.Windows.Forms.Label lblTextBusqueda;
        private System.Windows.Forms.DataGridView dtgClientes;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private CustomBox.RJControls.RJTextBox txtBusqueda;
    }
}
