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
        public event Action<string> SolicitarModificarClienteControl;

        public ClienteControl()
        {
            InitializeComponent();
        }

        assetCliente objCliente = new assetCliente();

        private void MostrarClientes()
        {
            DataTable clientes = objCliente.ObtenerClientes();

            if (clientes.Rows.Count > 0)
            {
                dtgClientes.DataSource = clientes; // Enlazar al control DataGridView
            }
            else
            {
                MessageBox.Show("No se encontraron clientes en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClienteControl_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            if (dtgClientes.SelectedCells.Count > 0)
            {
                // Obtener la celda seleccionada
                DataGridViewCell celdaSeleccionada = dtgClientes.SelectedCells[0];
                int filaSeleccionada = celdaSeleccionada.RowIndex;

                // Obtener el valor del ID Proveedor
                var idProveedor = dtgClientes.Rows[filaSeleccionada].Cells["Cédula del Cliente"].Value;

                if (idProveedor != null)
                {
                    SolicitarModificarClienteControl?.Invoke(idProveedor.ToString());
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la cédula del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un ejemplar en la grilla antes de modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void MostrarDatosEnGrillaCliente(int cedulaCliente)
        {
            // Obtener los datos del procedimiento almacenado
            DataSet ds = objCliente.buscarCliente(cedulaCliente);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Crear una tabla para mostrar información del proveedor
                DataTable cliente = new DataTable();
                cliente.Columns.Add("Cédula del Cliente", typeof(string));
                cliente.Columns.Add("Nombre del Cliente", typeof(string));
                cliente.Columns.Add("Apellido del Cliente", typeof(string));
                cliente.Columns.Add("Teléfono del Cliente", typeof(string));
                cliente.Columns.Add("Correo Electrónico", typeof(string));
                cliente.Columns.Add("Dirección del Cliente", typeof(string));

                // Iterar sobre las filas de la tabla para llenar los datos
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DataRow newRow = cliente.NewRow();
                    newRow["Cédula del Cliente"] = row["Cédula del Cliente"].ToString();
                    newRow["Nombre del Cliente"] = row["Nombre del Cliente"].ToString();
                    newRow["Apellido del Cliente"] = row["Apellido del Cliente"].ToString();
                    newRow["Teléfono del Cliente"] = row["Teléfono del Cliente"].ToString();
                    newRow["Correo Electrónico"] = row["Correo Electrónico"].ToString();
                    newRow["Dirección del Cliente"] = row["Dirección del Cliente"].ToString();
                    cliente.Rows.Add(newRow);
                }

                // Vincular los datos a la grilla
                dtgClientes.DataSource = cliente;
            }
            else
            {
                // Manejo de caso: No se encontraron datos
                MessageBox.Show("No se encontró información para el cliente especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgClientes.DataSource = null;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBusqueda.Texts))
            {
                MostrarClientes();
            }
            else if (int.TryParse(txtBusqueda.Texts, out int cedulaCliente))
            {
                // Si se ingresa un ID válido, buscar por ese ID
                MostrarDatosEnGrillaCliente(cedulaCliente);
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
 }

