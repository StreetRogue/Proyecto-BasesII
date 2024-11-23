using Oracle.ManagedDataAccess.Client;
using ProyectoBasesII.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            // Expresiones regulares para cédula, email y teléfono
            Regex regexCedula = new Regex(@"^\d{8,10}$");
            Regex regexEmail = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            Regex regexTelefono = new Regex(@"^\+?\d{7,15}$");

            // PASO 1: Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtCedulaCli.Texts) || string.IsNullOrEmpty(txtNombreCli.Texts) ||
                string.IsNullOrEmpty(txtApellidoCli.Texts) || string.IsNullOrEmpty(txtTelefonoCli.Texts) ||
                string.IsNullOrEmpty(txtEmailCli.Texts) || string.IsNullOrEmpty(txtDireccionCli.Texts))
            {
                MessageBox.Show("Debe llenar todos los campos.", "Ingrese todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar formato de la cédula
            if (!regexCedula.IsMatch(txtCedulaCli.Texts))
            {
                MessageBox.Show("La cédula debe contener solo números y tener entre 8 y 10 dígitos.", "Cédula inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar formato del email
            if (!regexEmail.IsMatch(txtEmailCli.Texts))
            {
                MessageBox.Show("El correo electrónico no es válido.", "Email inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar formato del teléfono
            if (!regexTelefono.IsMatch(txtTelefonoCli.Texts))
            {
                MessageBox.Show("El número telefónico debe contener entre 7 y 15 dígitos y puede incluir el prefijo '+'.", "Teléfono inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // PASO 2: Asignar valores y registrar cliente
            try
            {
                varCedulaCliente = int.Parse(txtCedulaCli.Texts);
                varNombreCliente = txtNombreCli.Texts;
                varApellidoCliente = txtApellidoCli.Texts;
                varTelefonoCliente = txtTelefonoCli.Texts;
                varEmailCliente = txtEmailCli.Texts;
                varDireccionCliente = txtDireccionCli.Texts;

                // Llamar al procedimiento almacenado
                resultado = objCliente.registrarCliente(varCedulaCliente, varNombreCliente, varApellidoCliente, varTelefonoCliente, varEmailCliente, varDireccionCliente);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos
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
                // Manejar excepciones específicas desde el procedimiento almacenado
                if (ex.Message.Contains("Error: La cédula del cliente ya está registrada en el sistema"))
                {
                    MessageBox.Show("Cliente ya registrado con la cédula ingresada.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("Error: El email ya está registrado en el sistema"))
                {
                    MessageBox.Show("El correo electrónico ya está registrado.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
