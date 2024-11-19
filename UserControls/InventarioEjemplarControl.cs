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
    public partial class InventarioEjemplarControl : UserControl
    {
        public InventarioEjemplarControl()
        {
            InitializeComponent();
        }

        assetEjemplar objEjemplar = new assetEjemplar();


        public void MostrarDatosEnGrillaEjemplar(int idEjemplar)
        {
            // Obtener los datos del procedimiento almacenado
            DataSet ds = objEjemplar.buscarEjemplar(idEjemplar);

            // Verificar si el DataSet tiene datos
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Crear una nueva tabla para mostrar datos en la grilla
                DataTable datosEjemplar = new DataTable();
                datosEjemplar.Columns.Add("ID Ejemplar", typeof(string));
                datosEjemplar.Columns.Add("Modelo Vehículo", typeof(string));
                datosEjemplar.Columns.Add("Estado Ejemplar", typeof(string));
                datosEjemplar.Columns.Add("Nombre Proveedor", typeof(string));

                // Llenar la tabla con los datos del DataSet
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DataRow newRow = datosEjemplar.NewRow();
                    newRow["ID Ejemplar"] = row["idEjemplar"];
                    newRow["Modelo Vehículo"] = row["modeloVehiculo"];
                    newRow["Estado Ejemplar"] = row["estadoEjemplar"];
                    newRow["Nombre Proveedor"] = row["nombreProveedor"];
                    datosEjemplar.Rows.Add(newRow);
                }

                // Vincular la tabla a la grilla
                dtgEjemplares.DataSource = datosEjemplar;
            }
            else
            {
                // Manejo de caso: No se encontraron datos
                MessageBox.Show("No se encontró información para el ejemplar especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgEjemplares.DataSource = null;
            }
        }


        public void CargarTodosLosEjemplares()
        {
            // Obtener los datos del procedimiento almacenado
            DataSet ds = objEjemplar.buscarEjemplarGeneral();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Crear una tabla combinada para mostrar datos de ejemplares, vehículos y proveedores
                DataTable ejemplaresYVehiculos = new DataTable();
                ejemplaresYVehiculos.Columns.Add("ID Ejemplar", typeof(string));
                ejemplaresYVehiculos.Columns.Add("Modelo Vehículo", typeof(string));
                ejemplaresYVehiculos.Columns.Add("Estado Ejemplar", typeof(string));
                ejemplaresYVehiculos.Columns.Add("Nombre Proveedor", typeof(string));

                // Agregar datos a la tabla combinada
                foreach (DataRow ejemplarRow in ds.Tables[0].Rows)
                {
                    DataRow newRow = ejemplaresYVehiculos.NewRow();
                    newRow["ID Ejemplar"] = ejemplarRow["idEjemplar"];
                    newRow["Modelo Vehículo"] = ejemplarRow["modeloVehiculo"];
                    newRow["Estado Ejemplar"] = ejemplarRow["estadoEjemplar"];
                    newRow["Nombre Proveedor"] = ejemplarRow["nombreProveedor"];
                    ejemplaresYVehiculos.Rows.Add(newRow);
                }

                // Asignar la tabla combinada a la grilla
                dtgEjemplares.DataSource = ejemplaresYVehiculos;
            }
            else
            {
                // Manejo de caso: No se encontraron datos
                MessageBox.Show("No hay ejemplares para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgEjemplares.DataSource = null;
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtBusqueda.Texts, out int idEjemplar))
            {
                MostrarDatosEnGrillaEjemplar(idEjemplar);
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InventarioEjemplarControl_Load(object sender, EventArgs e)
        {
            CargarTodosLosEjemplares();
        }
    }
}
