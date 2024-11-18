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
    public partial class ProovedoresControl : UserControl
    
    {

        public event EventHandler SolicitarRegistrarProovedores;

        public ProovedoresControl()
        {
            InitializeComponent();
        }

        assetProveedor objProveedor = new assetProveedor();


        public void MostrarDatosEnGrilla(int idProveedor)
        {
            // Obtener los datos del procedimiento almacenado
            DataSet ds = objProveedor.buscarProveedor(idProveedor);

            if (ds.Tables.Count > 1 && ds.Tables[0].Rows.Count > 0)
            {
                // Crear una nueva tabla para combinar datos del proveedor y vehículos
                DataTable proveedorYVehiculos = new DataTable();
                proveedorYVehiculos.Columns.Add("Nombre Proveedor", typeof(string));
                proveedorYVehiculos.Columns.Add("Teléfono", typeof(string));
                proveedorYVehiculos.Columns.Add("Dirección", typeof(string));
                proveedorYVehiculos.Columns.Add("ID Vehículo", typeof(string));
                proveedorYVehiculos.Columns.Add("Modelo Vehículo", typeof(string));
                proveedorYVehiculos.Columns.Add("Marca Vehículo", typeof(string));
                proveedorYVehiculos.Columns.Add("Año Vehículo", typeof(string));

                // Obtener datos del proveedor
                DataRow proveedorRow = ds.Tables[0].Rows[0];
                string nombreProveedor = proveedorRow["nombreProveedor"].ToString();
                string telefonoProveedor = proveedorRow["telefonoProveedor"].ToString();
                string direccionProveedor = proveedorRow["direccionProveedor"].ToString();

                // Agregar información de cada vehículo
                foreach (DataRow vehiculoRow in ds.Tables[1].Rows)
                {
                    DataRow newRow = proveedorYVehiculos.NewRow();
                    newRow["Nombre Proveedor"] = nombreProveedor;
                    newRow["Teléfono"] = telefonoProveedor;
                    newRow["Dirección"] = direccionProveedor;
                    newRow["ID Vehículo"] = vehiculoRow["idVehiculo"];
                    newRow["Modelo Vehículo"] = vehiculoRow["modeloVehiculo"];
                    newRow["Marca Vehículo"] = vehiculoRow["marcaVehiculo"];
                    newRow["Año Vehículo"] = vehiculoRow["añoVehiculo"];
                    proveedorYVehiculos.Rows.Add(newRow);
                }

                // Vincular los datos a la grilla
                dtgProovedores.DataSource = proveedorYVehiculos;
            }
            else
            {
                // Manejo de caso: No se encontraron datos
                MessageBox.Show("No se encontró información para el proveedor especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgProovedores.DataSource = null;
            }
        }

        public void CargarTodosLosProveedores()
        {
            // Obtener los datos del procedimiento almacenado
            DataSet ds = new DataSet();

            ds = objProveedor.buscarProveedorGeneral();

            if (ds.Tables.Count > 1)
            {
                // Crear una tabla combinada para mostrar datos de proveedores y vehículos
                DataTable proveedoresYVehiculos = new DataTable();
                proveedoresYVehiculos.Columns.Add("Nombre Proveedor", typeof(string));
                proveedoresYVehiculos.Columns.Add("Teléfono", typeof(string));
                proveedoresYVehiculos.Columns.Add("Dirección", typeof(string));
                proveedoresYVehiculos.Columns.Add("ID Vehículo", typeof(string));
                proveedoresYVehiculos.Columns.Add("Modelo Vehículo", typeof(string));
                proveedoresYVehiculos.Columns.Add("Marca Vehículo", typeof(string));
                proveedoresYVehiculos.Columns.Add("Año Vehículo", typeof(string));

                // Agregar datos a la tabla combinada
                foreach (DataRow proveedorRow in ds.Tables[0].Rows)
                {
                    string nombreProveedor = proveedorRow["nombreProveedor"].ToString();
                    string telefonoProveedor = proveedorRow["telefonoProveedor"].ToString();
                    string direccionProveedor = proveedorRow["direccionProveedor"].ToString();

                    // Buscar vehículos asociados
                    foreach (DataRow vehiculoRow in ds.Tables[1].Select($"idProveedor = {proveedorRow["idProveedor"]}"))
                    {
                        DataRow newRow = proveedoresYVehiculos.NewRow();
                        newRow["Nombre Proveedor"] = nombreProveedor;
                        newRow["Teléfono"] = telefonoProveedor;
                        newRow["Dirección"] = direccionProveedor;
                        newRow["ID Vehículo"] = vehiculoRow["idVehiculo"];
                        newRow["Modelo Vehículo"] = vehiculoRow["modeloVehiculo"];
                        newRow["Marca Vehículo"] = vehiculoRow["marcaVehiculo"];
                        newRow["Año Vehículo"] = vehiculoRow["añoVehiculo"];
                        proveedoresYVehiculos.Rows.Add(newRow);
                    }
                }

                // Asignar la tabla combinada a la grilla
                dtgProovedores.DataSource = proveedoresYVehiculos;
            }
            else
            {
                // Manejo de caso: No se encontraron datos
                MessageBox.Show("No hay proveedores para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgProovedores.DataSource = null;
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SolicitarRegistrarProovedores?.Invoke(this, EventArgs.Empty);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBusqueda.Texts, out int idProveedor))
            {
                MostrarDatosEnGrilla(idProveedor);
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProovedoresControl_Load(object sender, EventArgs e)
        {
            CargarTodosLosProveedores();
        }
    }
}
