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
            float varPrecioVehiculo;
            int varIdProveedor,  varAnioVehiculoEntero; ;

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
                varPrecioVehiculo = float.Parse(txtPrecioVehiculo.Texts);
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
                MessageBox.Show("Error: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
