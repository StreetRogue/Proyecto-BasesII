﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoBasesII.UserControls
{
    public partial class ProovedoresControl : UserControl
    
    {

        public event EventHandler SolicitarRegistrarProovedores;

        public ProovedoresControl()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SolicitarRegistrarProovedores?.Invoke(this, EventArgs.Empty);
        }
    }
}
