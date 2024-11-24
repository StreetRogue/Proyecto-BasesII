﻿using Oracle.ManagedDataAccess.Client;
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
        public event Action<string> SolicitarModificarProveedoresControl;
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
            // Obtener los datos de la vista a través del método buscarProveedorGeneral2
            DataSet ds = objProveedor.buscarProveedorGeneral();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Crear una tabla para mostrar datos de proveedores
                DataTable proveedores = new DataTable();
                proveedores.Columns.Add("ID Proveedor", typeof(string));
                proveedores.Columns.Add("Nombre Proveedor", typeof(string));
                proveedores.Columns.Add("Teléfono", typeof(string));
                proveedores.Columns.Add("Dirección", typeof(string));
                proveedores.Columns.Add("Cantidad de Vehículos Asociados", typeof(string)); // Nueva columna

                // Agregar datos a la tabla
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DataRow newRow = proveedores.NewRow();
                    newRow["ID Proveedor"] = row["ID Proveedor"]; // Nombre de columna sensible a mayúsculas/minúsculas
                    newRow["Nombre Proveedor"] = row["Nombre Proveedor"];
                    newRow["Teléfono"] = row["Teléfono Proveedor"];
                    newRow["Dirección"] = row["Dirección Proveedor"];
                    newRow["Cantidad de Vehículos Asociados"] = row["Cantidad de Vehículos Asociados"];
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
            if (string.IsNullOrWhiteSpace(txtBusqueda.Texts))
            {
                CargarTodosLosProveedores();
            }
            else if (int.TryParse(txtBusqueda.Texts, out int idProveedor))
            {
                // Si se ingresa un ID válido, buscar por ese ID
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

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            if (dtgProovedores.SelectedCells.Count > 0)
            {
                // Obtener la celda seleccionada
                DataGridViewCell celdaSeleccionada = dtgProovedores.SelectedCells[0];
                int filaSeleccionada = celdaSeleccionada.RowIndex;

                // Obtener el valor del ID Proveedor
                var idProveedor = dtgProovedores.Rows[filaSeleccionada].Cells["ID Proveedor"].Value;

                if (idProveedor != null)
                {
                    SolicitarModificarProveedoresControl?.Invoke(idProveedor.ToString());
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID del ejemplar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un ejemplar en la grilla antes de modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
