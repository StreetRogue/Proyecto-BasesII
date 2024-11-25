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

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtProovedorID.Texts) ||string.IsNullOrEmpty(txtNombreProovedor.Texts) ||
                string.IsNullOrEmpty(txtTelefonoProovedor.Texts) || string.IsNullOrEmpty(txtDireccionProovedor.Texts))
            {
                MessageBox.Show("Debe llenar todos los campos.", "Ingrese todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Asignar valores a las variables restantes
            varIdProveedor = int.Parse(txtProovedorID.Texts);
            varNombreProveedor = txtNombreProovedor.Texts;
            varTelefonoProveedor = txtTelefonoProovedor.Texts;
            varDireccionProveedor = txtDireccionProovedor.Texts;

            try
            {
                // Llamar al método para registrar el proveedor
                int resultado = objProveedor.registrarProveedor(varIdProveedor, varNombreProveedor, varTelefonoProveedor, varDireccionProveedor);

                if (resultado > 0)
                {
                    MessageBox.Show("Proveedor Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpiar los campos
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
            catch (OracleException ex)
            {
                // Manejar errores específicos del procedimiento
                if (ex.Message.Contains("Error: El ID de proveedor ya existe"))
                {
                    MessageBox.Show("El ID del proveedor ya existe. Intente con un ID diferente.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("Error: El nombre del proveedor ya existe."))
                {
                    MessageBox.Show("Ya existe un proveedor con el mismo nombre. Verifique el nombre ingresado.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de datos incorrecto. Verifique la cédula y los demás campos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
