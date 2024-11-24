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
    public partial class VentaInventarioControl : UserControl
    {
        public VentaInventarioControl()
        {
            InitializeComponent();
        }

        assetVenta objVenta = new assetVenta();


        public void MostrarDatosEnGrillaVentaPorID(int idVenta)
        {
            try
            {
                // Obtener los datos de la vista a través del método buscarVentaPorID
                DataSet ds = objVenta.buscarVenta(idVenta);

                // Verificar si el DataSet tiene datos
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    // Crear una nueva tabla para mostrar datos en la grilla
                    DataTable datosVenta = new DataTable();
                    datosVenta.Columns.Add("ID Venta", typeof(string));
                    datosVenta.Columns.Add("Fecha Venta", typeof(string));
                    datosVenta.Columns.Add("Ejemplar Vendido", typeof(string));
                    datosVenta.Columns.Add("Total", typeof(decimal));
                    datosVenta.Columns.Add("Vendedor", typeof(string));
                    datosVenta.Columns.Add("Comision Venta", typeof(decimal));
                    datosVenta.Columns.Add("Cedula Cliente", typeof(string));
                    datosVenta.Columns.Add("Nombre Cliente", typeof(string));

                    // Llenar la tabla con los datos del DataSet
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        DataRow newRow = datosVenta.NewRow();
                        newRow["ID Venta"] = row["ID Venta"]; // Campo de la vista
                        newRow["Fecha Venta"] = row["Fecha Venta"];
                        newRow["Ejemplar Vendido"] = row["Ejemplar Vendido"];
                        newRow["Total"] = row["Total"];
                        newRow["Vendedor"] = row["Vendedor"];
                        newRow["Comision Venta"] = row["Comision Venta"];
                        newRow["Cedula Cliente"] = row["Cedula Cliente"];
                        newRow["Nombre Cliente"] = row["Nombre Cliente"];
                        datosVenta.Rows.Add(newRow);
                    }

                    // Vincular la tabla a la grilla
                    dtgVentas.DataSource = datosVenta;
                }
                else
                {
                    // Manejo de caso: No se encontraron datos
                    MessageBox.Show("No se encontró información para la venta especificada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgVentas.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos de la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void CargarVentas()
        {
            try
            {
                // Obtener los datos de la vista a través del método buscarVentasGeneral
                DataSet ds = objVenta.buscarVentasGeneral();

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    // Crear una tabla combinada para mostrar datos de ventas
                    DataTable ventasTable = new DataTable();
                    ventasTable.Columns.Add("ID Venta", typeof(string));
                    ventasTable.Columns.Add("Fecha Venta", typeof(string));
                    ventasTable.Columns.Add("Ejemplar Vendido", typeof(string));
                    ventasTable.Columns.Add("Total", typeof(decimal));
                    ventasTable.Columns.Add("Vendedor", typeof(string));
                    ventasTable.Columns.Add("Comision Venta", typeof(decimal));
                    ventasTable.Columns.Add("Cedula Cliente", typeof(string));
                    ventasTable.Columns.Add("Nombre Cliente", typeof(string));

                    // Agregar datos a la tabla combinada
                    foreach (DataRow ventaRow in ds.Tables[0].Rows)
                    {
                        DataRow newRow = ventasTable.NewRow();
                        newRow["ID Venta"] = ventaRow["ID Venta"]; // Campo de la vista
                        newRow["Fecha Venta"] = ventaRow["Fecha Venta"];
                        newRow["Ejemplar Vendido"] = ventaRow["Ejemplar Vendido"];
                        newRow["Total"] = ventaRow["Total"];
                        newRow["Vendedor"] = ventaRow["Vendedor"];
                        newRow["Comision Venta"] = ventaRow["Comision Venta"];
                        newRow["Cedula Cliente"] = ventaRow["Cedula Cliente"];
                        newRow["Nombre Cliente"] = ventaRow["Nombre Cliente"];
                        ventasTable.Rows.Add(newRow);
                    }

                    // Asignar la tabla combinada a la grilla
                    dtgVentas.DataSource = ventasTable;
                }
                else
                {
                    // Manejo de caso: No se encontraron datos
                    MessageBox.Show("No hay ventas para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgVentas.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VentaInventarioControl_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBusqueda.Texts))
            {
                CargarVentas();
            }
            else if (int.TryParse(txtBusqueda.Texts, out int idVenta))
            {
                // Si se ingresa un ID válido, buscar por ese ID
                MostrarDatosEnGrillaVentaPorID(idVenta);
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
