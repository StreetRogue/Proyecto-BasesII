using Oracle.ManagedDataAccess.Client;
using ProyectoBasesII.Logica;
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
    public partial class RegistrarProovedorControl : UserControl
    {
        public RegistrarProovedorControl()
        {
            InitializeComponent();
        }

        int resultado = 0;
        assetProveedor objProveedor = new assetProveedor();

        private void btnRegistrarProv_Click(object sender, EventArgs e)
        {
            int varIdProveedor;
            string varNombreProveedor, varTelefonoProveedor, varDireccionProveedor;

            // PASO 1
            if (string.IsNullOrEmpty(txtProovedorID.Texts) || string.IsNullOrEmpty(txtNombreProovedor.Texts) || string.IsNullOrEmpty(txtTelefonoProovedor.Texts) || string.IsNullOrEmpty(txtTelefonoProovedor.Texts) || string.IsNullOrEmpty(txtDireccionProovedor.Texts))
            {
                MessageBox.Show("Debe llenar todos los campos.", "Ingrese todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                varIdProveedor = int.Parse(txtProovedorID.Texts);
                varNombreProveedor = txtNombreProovedor.Texts;
                varTelefonoProveedor = txtTelefonoProovedor.Texts;
                varDireccionProveedor = txtDireccionProovedor.Texts;
                
            }

            // PASO 2

            try
            {
            
               resultado = objProveedor.registrarProveedor(varIdProveedor,varNombreProveedor,varTelefonoProveedor,varDireccionProveedor);
                if (resultado > 0)
                {
                    MessageBox.Show("Proveedor Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProovedorID.Texts = "";
                    txtNombreProovedor.Texts = "";
                    txtTelefonoProovedor.Texts = "";
                    txtDireccionProovedor.Texts = "";
                }
                else
                {
                    MessageBox.Show("Proveedor No Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(OracleException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
