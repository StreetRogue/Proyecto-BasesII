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
    public partial class RegistrarVehiculoControl : UserControl
    {
        public RegistrarVehiculoControl()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.RegistrarVehiculoControl_Load);
        }

        int resultado = 0;
        assetVehiculo objVehiculo = new assetVehiculo();
        assetProveedor objProveedores = new assetProveedor();

        private void RegistrarVehiculoControl_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            try
            {
                List<string> nombresProveedores = objProveedores.ObtenerNombresProveedores(); // Llamar al método

                if (nombresProveedores.Count > 0)
                {
                    cbxProveedores.DataSource = nombresProveedores; // Llenar el ComboBox
                }
                else
                {
                    MessageBox.Show("No se encontraron proveedores en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            string varModeloVehiculo, varMarcaVehiculo, varNombreProveedor = "";
            DateTime varAnioVehiculo;
            int varPrecioVehiculo;
            int varIdProveedor,  varAnioVehiculoEntero; ;


            // Expresiones regulares para validar los campos
            Regex regexModelo = new Regex(@"^[A-Za-z0-9\s]{1,100}$"); // Letras, números y espacios, máximo 50 caracteres
            Regex regexMarca = new Regex(@"^[A-Za-z0-9\s]{1,100}$"); // Letras y espacios, máximo 50 caracteres
            Regex regexPrecio = new Regex(@"^\d+$"); // Número entero positivo

            // Validar formato del modelo
            if (!regexModelo.IsMatch(txtModeloVehiculo.Texts))
            {
                MessageBox.Show("El modelo debe contener solo letras, números y espacios, con un máximo de 100 caracteres.", "Modelo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar formato de la marca
            if (!regexMarca.IsMatch(txtMarcaVehiculo.Texts))
            {
                MessageBox.Show("La marca debe contener solo letras y espacios, con un máximo de 100 caracteres.", "Marca Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar formato del precio
            if (!regexPrecio.IsMatch(txtPrecioVehiculo.Texts))
            {
                MessageBox.Show("El precio debe ser un número entero positivo.", "Precio Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //PASO 1
            if (string.IsNullOrEmpty(txtMarcaVehiculo.Texts) || string.IsNullOrEmpty(txtModeloVehiculo.Texts) || string.IsNullOrEmpty(txtPrecioVehiculo.Texts)|| string.IsNullOrEmpty(cbxProveedores.Texts))
            {
                MessageBox.Show("Debe llenar todos los campos.", "Ingrese todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                varModeloVehiculo = txtModeloVehiculo.Texts;
                varMarcaVehiculo = txtMarcaVehiculo.Texts;
                varNombreProveedor = cbxProveedores.SelectedItem.ToString();
                varAnioVehiculo = dtpAnioVehiculo.Value;
                varAnioVehiculoEntero = varAnioVehiculo.Year;
                varPrecioVehiculo = int.Parse(txtPrecioVehiculo.Texts);
            }


            //PASO 2

            try
            {

                varIdProveedor = objVehiculo.consultarProveedor(varNombreProveedor);

                if (varIdProveedor == 0)
                {
                    MessageBox.Show("No existe un Proveedor registrado con ese ID ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                resultado = objVehiculo.registrarVehiculo(varModeloVehiculo, varMarcaVehiculo, varAnioVehiculoEntero, varPrecioVehiculo, varIdProveedor);

                if (resultado > 0)
                {
                    MessageBox.Show("Vehículo Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMarcaVehiculo.Texts = "";
                    txtModeloVehiculo.Texts = "";
                    txtPrecioVehiculo.Texts = "";
                    dtpAnioVehiculo.Value = DateTime.Now;
                    cbxProveedores.SelectedItem = -1;
                }
                else
                {
                    MessageBox.Show("Vehículo No Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (OracleException ex)
            {
                // Manejar excepciones específicas desde el procedimiento almacenado
                if (ex.Message.Contains("Error: El proveedor especificado no existe."))
                {
                    MessageBox.Show("El proveedor especificado no existe.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("Error: Ya existe un vehículo con el mismo modelo."))
                {
                    MessageBox.Show(" Ya existe un vehículo con el mismo modelo.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("Error: El precio del vehículo debe ser un valor positivo."))
                {
                    MessageBox.Show(" El precio del vehículo debe ser un valor positivo.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
