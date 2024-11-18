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
    public partial class RegistrarClienteControl : UserControl
    {
        public RegistrarClienteControl()
        {
            InitializeComponent();
        }

        int resultado = 0;
        assetCliente objCliente = new assetCliente();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int varCedulaCliente;
            string varNombreCliente, varApellidoCliente, varTelefonoCliente, varEmailCliente, varDireccionCliente;

            //PASO 1
            if (string.IsNullOrEmpty(txtCedulaCli.Texts) || string.IsNullOrEmpty(txtNombreCli.Texts) || string.IsNullOrEmpty(txtApellidoCli.Texts) || string.IsNullOrEmpty(txtTelefonoCli.Texts) || string.IsNullOrEmpty(txtEmailCli.Texts) || string.IsNullOrEmpty(txtDireccionCli.Texts))
            {
                MessageBox.Show("Debe llenar todos los campos.", "Ingrese todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                varCedulaCliente = int.Parse(txtCedulaCli.Texts);
                varNombreCliente = txtNombreCli.Texts;
                varApellidoCliente = txtApellidoCli.Texts;
                varTelefonoCliente = txtTelefonoCli.Texts;
                varEmailCliente = txtEmailCli.Texts;
                varDireccionCliente = txtDireccionCli.Texts;
            }

            //PASO 2

            try
            {
                resultado = objCliente.registrarCliente(varCedulaCliente, varNombreCliente, varApellidoCliente, varTelefonoCliente, varEmailCliente, varDireccionCliente);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCedulaCli.Texts = "";
                    txtNombreCli.Texts = "";
                    txtApellidoCli.Texts = "";
                    txtTelefonoCli.Texts = "";
                    txtEmailCli.Texts = "";
                    txtDireccionCli.Texts = "";
                }
                else
                {
                    MessageBox.Show("Cliente No Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
