using ProyectoBasesII.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBasesII.UserControls
{
    public partial class ModificarClienteControl : UserControl
    {
        private string cedulaCliente;

        public ModificarClienteControl()
        {
            InitializeComponent();
        }

        assetCliente objCliente = new assetCliente();


        public void CargarCliente(string cedulaClienteSeleccionado)
        {
            cedulaCliente = cedulaClienteSeleccionado;

            // Cargar los datos del ejemplar
            DataSet ds = objCliente.buscarCliente(int.Parse(cedulaCliente));

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Mostrar los datos en los controles del formulario
                DataRow row = ds.Tables[0].Rows[0];
                txtCedulaCli.Texts = row["Cédula del Cliente"].ToString();
                txtNombreCli.Texts = row["Nombre del Cliente"].ToString();
                txtApellidoCli.Texts = row["Apellido del Cliente"].ToString();
                txtTelefonoCli.Texts = row["Teléfono del Cliente"].ToString();
                txtEmailCli.Texts = row["Correo Electrónico"].ToString();
                txtDireccionCli.Texts = row["Dirección del Cliente"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró información para el ejemplar seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            string cedulaCliente = "", nombreCliente = "", apellidoCliente = "", telefonoCliente = "", emailCliente = "", direccionCliente = "";

            // Expresiones regulares para validaciones
            Regex regexEmail = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            Regex regexTelefono = new Regex(@"^\+?\d{7,15}$");


            // Validar que todos los campos estén llenos
            if (string.IsNullOrEmpty(txtNombreCli.Texts) ||
                string.IsNullOrEmpty(txtApellidoCli.Texts) ||
                string.IsNullOrEmpty(txtTelefonoCli.Texts) ||
                string.IsNullOrEmpty(txtEmailCli.Texts) ||
                string.IsNullOrEmpty(txtDireccionCli.Texts) ||
                string.IsNullOrEmpty(txtCedulaCli.Texts))
            {
                MessageBox.Show("Debe llenar todos los campos.",
                                "Ingrese todos los campos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            cedulaCliente = txtCedulaCli.Texts;
            nombreCliente = txtNombreCli.Texts;
            apellidoCliente = txtApellidoCli.Texts;
            telefonoCliente = txtTelefonoCli.Texts;
            emailCliente = txtEmailCli.Texts;
            direccionCliente = txtDireccionCli.Texts;

            

            // Validar el formato del teléfono
            if (!regexTelefono.IsMatch(telefonoCliente))
            {
                MessageBox.Show("El número telefónico debe contener entre 7 y 15 dígitos y puede incluir el prefijo '+'.", "Teléfono inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!regexEmail.IsMatch(emailCliente))
            {
                MessageBox.Show("El formato del correo electrónico es inválido.",
                                "Error en el correo electrónico",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }


            try
            {
                if (string.IsNullOrEmpty(cedulaCliente))
                {
                    MessageBox.Show("No se ha cargado un proveedor para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                resultado = objCliente.modificarCliente(int.Parse(cedulaCliente), nombreCliente, apellidoCliente, telefonoCliente, emailCliente, direccionCliente);

                Debug.WriteLine(resultado);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente Modificado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCedulaCli.Texts = string.Empty;
                    txtNombreCli.Texts = string.Empty;
                    txtApellidoCli.Texts = string.Empty;
                    txtTelefonoCli.Texts = string.Empty;
                    txtEmailCli.Texts = string.Empty;
                    txtDireccionCli.Texts = string.Empty;
                }
                else
                {
                    MessageBox.Show("Cliente NO Modificado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                if (ex.Message.Contains("Error: La cédula no puede ser nula."))
                {
                    MessageBox.Show("La cédula no puede ser nula", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (ex.Message.Contains("Error: No existe ningún cliente con la cédula proporcionada."))
                {
                    MessageBox.Show("No existe ningún cliente con la cédula proporcionada.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
