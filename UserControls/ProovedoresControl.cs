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

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Crear una tabla para mostrar información del proveedor
                DataTable proveedor = new DataTable();
                proveedor.Columns.Add("ID Proveedor", typeof(string));
                proveedor.Columns.Add("Nombre Proveedor", typeof(string));
                proveedor.Columns.Add("Teléfono", typeof(string));
                proveedor.Columns.Add("Dirección", typeof(string));

                // Iterar sobre las filas de la tabla para llenar los datos
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DataRow newRow = proveedor.NewRow();
                    newRow["ID Proveedor"] = row["idProveedor"].ToString();
                    newRow["Nombre Proveedor"] = row["nombreProveedor"].ToString();
                    newRow["Teléfono"] = row["telefonoProveedor"].ToString();
                    newRow["Dirección"] = row["direccionProveedor"].ToString();
                    proveedor.Rows.Add(newRow);
                }

                // Vincular los datos a la grilla
                dtgProovedores.DataSource = proveedor;
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
            DataSet ds = objProveedor.buscarProveedorGeneral();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Crear una tabla para mostrar datos de proveedores
                DataTable proveedores = new DataTable();
                proveedores.Columns.Add("ID Proveedor", typeof(string));
                proveedores.Columns.Add("Nombre Proveedor", typeof(string));
                proveedores.Columns.Add("Teléfono", typeof(string));
                proveedores.Columns.Add("Dirección", typeof(string));

                // Agregar datos a la tabla
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DataRow newRow = proveedores.NewRow();
                    newRow["ID Proveedor"] = row["idProveedor"];
                    newRow["Nombre Proveedor"] = row["nombreProveedor"];
                    newRow["Teléfono"] = row["telefonoProveedor"];
                    newRow["Dirección"] = row["direccionProveedor"];
                    proveedores.Rows.Add(newRow);
                }

                // Asignar la tabla a la grilla
                dtgProovedores.DataSource = proveedores;
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
