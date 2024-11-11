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
            this.txtIdEjemplar = new CustomBox.RJControls.RJTextBox();
            this.lblEjemplarId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rjTextBox1 = new CustomBox.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdEjemplar
            // 
            this.txtIdEjemplar.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdEjemplar.BorderColor = System.Drawing.Color.Transparent;
            this.txtIdEjemplar.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtIdEjemplar.BorderRadius = 0;
            this.txtIdEjemplar.BorderSize = 2;
            this.txtIdEjemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtIdEjemplar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdEjemplar.Location = new System.Drawing.Point(64, 124);
            this.txtIdEjemplar.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEjemplar.Multiline = false;
            this.txtIdEjemplar.Name = "txtIdEjemplar";
            this.txtIdEjemplar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIdEjemplar.PasswordChar = false;
            this.txtIdEjemplar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdEjemplar.PlaceholderText = "";
            this.txtIdEjemplar.Size = new System.Drawing.Size(80, 31);
            this.txtIdEjemplar.TabIndex = 0;
            this.txtIdEjemplar.Texts = "";
            this.txtIdEjemplar.UnderlinedStyle = false;
            // 
            // lblEjemplarId
            // 
            this.lblEjemplarId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjemplarId.AutoSize = true;
            this.lblEjemplarId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblEjemplarId.Location = new System.Drawing.Point(59, 93);
            this.lblEjemplarId.Name = "lblEjemplarId";
            this.lblEjemplarId.Size = new System.Drawing.Size(217, 25);
            this.lblEjemplarId.TabIndex = 1;
            this.lblEjemplarId.Text = "Ingrese ID del ejemplar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rjTextBox1);
            this.panel1.Location = new System.Drawing.Point(64, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(3, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(-2, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese ID del ejemplar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.rjTextBox1.BorderColor = System.Drawing.Color.Transparent;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.Transparent;
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(3, 65);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(250, 31);
            this.rjTextBox1.TabIndex = 3;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            this.rjTextBox1._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(62, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese ID del ejemplar";
            // 
            // RegistrarEjemplarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEjemplarId);
            this.Controls.Add(this.txtIdEjemplar);
            this.Name = "RegistrarEjemplarControl";
            this.Size = new System.Drawing.Size(495, 513);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomBox.RJControls.RJTextBox txtIdEjemplar;
        private System.Windows.Forms.Label lblEjemplarId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private CustomBox.RJControls.RJTextBox rjTextBox1;
        private System.Windows.Forms.Label label2;
    }
}
