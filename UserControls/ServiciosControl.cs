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
    public partial class ServiciosControl : UserControl
    {
        public ServiciosControl()
        {
            InitializeComponent();
        }

        assetServicio objServicios = new assetServicio();
        public void MostrarDatosEnGrillaServicios(int idVenta)
        {
            // Obtener los datos de la vista a través del método buscarServicios (deberías implementar este método en tu clase)
            DataSet ds = objServicios.buscarServicio(idVenta);

            // Verificar si el DataSet tiene datos
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Crear una nueva tabla para mostrar datos en la grilla
                DataTable datosServicios = new DataTable();
                datosServicios.Columns.Add("ID Venta", typeof(string));
                datosServicios.Columns.Add("Fecha Inicio Servicio", typeof(DateTime));
                datosServicios.Columns.Add("Fecha Fin Servicio", typeof(DateTime));
                datosServicios.Columns.Add("Tipo Servicio", typeof(string));
                datosServicios.Columns.Add("Costo Servicio", typeof(decimal));
                datosServicios.Columns.Add("Cédula Cliente", typeof(string));
                datosServicios.Columns.Add("Nombre Cliente", typeof(string));

                // Llenar la tabla con los datos del DataSet
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DataRow newRow = datosServicios.NewRow();
                    newRow["ID Venta"] = row["idVenta"];
                    newRow["Fecha Inicio Servicio"] = row["fechaInicioServicio"];
                    newRow["Fecha Fin Servicio"] = row["fechaFinServicio"];
                    newRow["Tipo Servicio"] = row["tipoServicio"];
                    newRow["Costo Servicio"] = row["costoServicio"];
                    newRow["Cédula Cliente"] = row["cedulaCliente"];
                    newRow["Nombre Cliente"] = row["nombreCliente"];
                    datosServicios.Rows.Add(newRow);
                }

                // Vincular la tabla a la grilla
                dtgServicios.DataSource = datosServicios;
            }
            else
            {
                // Manejo de caso: No se encontraron datos
                MessageBox.Show("No se encontró información para la venta especificada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgServicios.DataSource = null;
            }
        }


        public void CargarTodosLosServicios()
        {
            // Obtener los datos de la vista a través del método buscarServiciosGeneral (deberías implementar este método en tu clase)
            DataSet ds = objServicios.buscarServiciosGeneral();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Crear una tabla combinada para mostrar los datos de los servicios
                DataTable servicios = new DataTable();
                servicios.Columns.Add("ID Venta", typeof(string));
                servicios.Columns.Add("Fecha Inicio Servicio", typeof(DateTime));
                servicios.Columns.Add("Fecha Fin Servicio", typeof(DateTime));
                servicios.Columns.Add("Tipo Servicio", typeof(string));
                servicios.Columns.Add("Costo Servicio", typeof(decimal));
                servicios.Columns.Add("Cédula Cliente", typeof(string));
                servicios.Columns.Add("Nombre Cliente", typeof(string));

                // Agregar datos a la tabla combinada
                foreach (DataRow servicioRow in ds.Tables[0].Rows)
                {
                    DataRow newRow = servicios.NewRow();
                    newRow["ID Venta"] = servicioRow["idVenta"];
                    newRow["Fecha Inicio Servicio"] = servicioRow["fechaInicioServicio"];
                    newRow["Fecha Fin Servicio"] = servicioRow["fechaFinServicio"];
                    newRow["Tipo Servicio"] = servicioRow["tipoServicio"];
                    newRow["Costo Servicio"] = servicioRow["costoServicio"];
                    newRow["Cédula Cliente"] = servicioRow["cedulaCliente"];
                    newRow["Nombre Cliente"] = servicioRow["nombreCliente"];
                    servicios.Rows.Add(newRow);
                }   

                // Asignar la tabla combinada a la grilla
                dtgServicios.DataSource = servicios;
            }
            else
            {
                // Manejo de caso: No se encontraron datos
                MessageBox.Show("No hay servicios para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgServicios.DataSource = null;
            }
        }


        private void InventarioServiciosControl_Load(object sender, EventArgs e)
        {
            CargarTodosLosServicios();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtBusqueda.Texts))
            {
                CargarTodosLosServicios();
            }
            else if (int.TryParse(txtBusqueda.Texts, out int idVenta))
            {
                // Si se ingresa un ID válido, buscar por ese ID
                MostrarDatosEnGrillaServicios(idVenta);
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {

        }
    }
}
