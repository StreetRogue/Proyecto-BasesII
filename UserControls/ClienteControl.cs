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
    public partial class ClienteControl : UserControl
    {
        public ClienteControl()
        {
            InitializeComponent();
        }

        assetCliente objCliente = new assetCliente();

        /*public void MostrarDatosEnGrillaClientes()
        {
            // Obtener los datos de la colección de clientes usando el procedimiento almacenado
            DataSet ds = objCliente.buscarClientesGeneral();

            // Verificar si el DataSet tiene datos
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Crear una nueva tabla para mostrar datos en la grilla
                DataTable datosClientes = new DataTable();
                datosClientes.Columns.Add("Cédula Cliente", typeof(string));
                datosClientes.Columns.Add("Nombre Cliente", typeof(string));
                datosClientes.Columns.Add("Apellido Cliente", typeof(string));
                datosClientes.Columns.Add("Teléfono Cliente", typeof(string));
                datosClientes.Columns.Add("Email Cliente", typeof(string));
                datosClientes.Columns.Add("Dirección Cliente", typeof(string));

                // Llenar la tabla con los datos del DataSet
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DataRow newRow = datosClientes.NewRow();
                    newRow["Cédula Cliente"] = row["cedulaCliente"];
                    newRow["Nombre Cliente"] = row["nombreCliente"];
                    newRow["Apellido Cliente"] = row["apellidoCliente"];
                    newRow["Teléfono Cliente"] = row["telefonoCliente"];
                    newRow["Email Cliente"] = row["emailCliente"];
                    newRow["Dirección Cliente"] = row["direccionCliente"];
                    datosClientes.Rows.Add(newRow);
                }

                // Vincular la tabla a la grilla
                dtgClientes.DataSource = datosClientes;
            }
            else
            {
                // Manejo de caso: No se encontraron datos
                MessageBox.Show("No se encontraron clientes para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgClientes.DataSource = null;
            }
        }*/

        public void CargarTodosLosClientes()
        {
            // Obtener los datos de la colección de clientes
            DataSet ds = objCliente.buscarClientesGeneral();

            // Verificar si el DataSet tiene datos
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Crear una nueva tabla para mostrar datos en la grilla
                DataTable datosClientes = new DataTable();
                datosClientes.Columns.Add("Cédula Cliente", typeof(string));
                datosClientes.Columns.Add("Nombre Cliente", typeof(string));
                datosClientes.Columns.Add("Apellido Cliente", typeof(string));
                datosClientes.Columns.Add("Teléfono Cliente", typeof(string));
                datosClientes.Columns.Add("Email Cliente", typeof(string));
                datosClientes.Columns.Add("Dirección Cliente", typeof(string));

                // Llenar la tabla con los datos del DataSet
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DataRow newRow = datosClientes.NewRow();
                    newRow["Cédula Cliente"] = row["cedulaCliente"];
                    newRow["Nombre Cliente"] = row["nombreCliente"];
                    newRow["Apellido Cliente"] = row["apellidoCliente"];
                    newRow["Teléfono Cliente"] = row["telefonoCliente"];
                    newRow["Email Cliente"] = row["emailCliente"];
                    newRow["Dirección Cliente"] = row["direccionCliente"];
                    datosClientes.Rows.Add(newRow);
                }

                // Asignar la tabla a la grilla
                dtgClientes.DataSource = datosClientes;
            }
            else
            {
                // Manejo de caso: No se encontraron datos
                MessageBox.Show("No se encontraron clientes para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgClientes.DataSource = null;
            }
        }




        private void ClienteControl_Load(object sender, EventArgs e)
        {
            CargarTodosLosClientes();
        }

    }
}
