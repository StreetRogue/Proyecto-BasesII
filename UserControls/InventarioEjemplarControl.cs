﻿using ProyectoBasesII.Logica;
using System;
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
    public partial class InventarioEjemplarControl : UserControl
    {
        public InventarioEjemplarControl()
        {
            InitializeComponent();
        }

        assetEjemplar objEjemplar = new assetEjemplar();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Paso 1: Creo un dataset Vacio

            DataSet dss = new DataSet();

            int varidEjemplar;


            if (string.IsNullOrEmpty(txtBusqueda.Texts))
            {
                varidEjemplar = -1;
            }
            else
            {
                varidEjemplar = int.Parse(txtBusqueda.Texts);
            }

            dss = objEjemplar.inventarioEjemplares(varidEjemplar);
            dtgEjemplares.DataSource = dss;
            dtgEjemplares.DataMember = "ResultadoDatos";
            dtgEjemplares.RowHeadersVisible = false;
        }
    }
}
