﻿using ProyectoBasesII.Logica;
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

        public event Action<string> SolicitarModificarInventarioEjemplares;

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
            // Obtener los datos de la vista a través del método buscarEjemplarGeneral
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
                    newRow["ID Ejemplar"] = ejemplarRow["ID Ejemplar"]; // Asegúrate de que coincidan con los nombres de la vista
                    newRow["Modelo Vehículo"] = ejemplarRow["Modelo Vehículo"];
                    newRow["Estado Ejemplar"] = ejemplarRow["Estado Ejemplar"];
                    newRow["Nombre Proveedor"] = ejemplarRow["Nombre Proveedor"];
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

            if (string.IsNullOrWhiteSpace(txtBusqueda.Texts))
            {
                CargarTodosLosEjemplares();
            }
            else if (int.TryParse(txtBusqueda.Texts, out int idEjemplar))
            {
                // Si se ingresa un ID válido, buscar por ese ID
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

        private void btnModificarEjemplar_Click(object sender, EventArgs e)
        {
            if (dtgEjemplares.SelectedCells.Count > 0)
            {
                // Obtener la celda seleccionada
                DataGridViewCell celdaSeleccionada = dtgEjemplares.SelectedCells[0];
                int filaSeleccionada = celdaSeleccionada.RowIndex;

                // Obtener el valor del ID Ejemplar
                var idEjemplar = dtgEjemplares.Rows[filaSeleccionada].Cells["ID Ejemplar"].Value;
                var estadoEjemplar = dtgEjemplares.Rows[filaSeleccionada].Cells["Estado Ejemplar"].Value;


                if (idEjemplar != null && estadoEjemplar != null)
                {
                    // Validar si el estado es "disponible"
                    if (estadoEjemplar.ToString().ToLower() == "disponible")
                    {
                        // Disparar el evento con el ID Ejemplar seleccionado
                        SolicitarModificarInventarioEjemplares?.Invoke(idEjemplar.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Solo se pueden modificar ejemplares con estado 'disponible'.","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
