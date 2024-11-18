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
    public partial class RegistrarEjemplarControl : UserControl
    {
        public RegistrarEjemplarControl()
        {
            InitializeComponent();
            this.Load += new EventHandler(RegistrarEjemplarControl_Load);
            cbxProovedor.OnSelectedIndexChanged += new EventHandler(cbxProovedor_OnSelectedIndexChanged);
        }

       assetEjemplar objEjemplar = new assetEjemplar();
       assetProveedor objProveedores = new assetProveedor();
       assetVehiculo objVehiculo = new assetVehiculo();



        private void RegistrarEjemplarControl_Load(object sender, EventArgs e)
        {
            CargarProveedores(); // Llama al método para cargar los proveedores al iniciar el formulario
        }

        private void CargarProveedores()
        {
            try
            {
                List<string> nombresProveedores = objProveedores.ObtenerNombresProveedores(); // Llamar al método

                if (nombresProveedores.Count > 0)
                {
                    cbxProovedor.DataSource = nombresProveedores; // Llenar el ComboBox
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

        private void CargarVehiculosPorProveedor(string nombreProveedor)
        {
            try
            {
                // Obtener el ID del proveedor por el nombre
                int idProveedor = objVehiculo.consultarProveedor(nombreProveedor);

                if (idProveedor > 0)
                {
                    // Obtener los vehículos del proveedor
                    List<string> nombresVehiculos = objVehiculo.ObtenerVehiculosPorProveedor(idProveedor);

                    if (nombresVehiculos.Count > 0)
                    {
                        cbxVehiculo.DataSource = nombresVehiculos; // Llenar el ComboBox de vehículos
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron vehículos para el proveedor seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbxVehiculo.DataSource = null; // Limpiar ComboBox si no hay datos
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró un proveedor con ese nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los vehículos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarEjem_Click(object sender, EventArgs e)
        {
            int resultado = 0;
             string modeloVehiculo = "", nombreProveedor = "";
             int idVehiculo, idProveedor, cantidad;

            //PASO 1
            
            if (string.IsNullOrEmpty(cbxVehiculo.Texts) || string.IsNullOrEmpty(cbxProovedor.Texts) || string.IsNullOrEmpty(txtStockEjemplar.Texts))
            {
                MessageBox.Show("Debe llenar todos los campos.", "Ingrese todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                modeloVehiculo = cbxVehiculo.SelectedItem.ToString();
                nombreProveedor = cbxProovedor.SelectedItem.ToString();
                cantidad = int.Parse(txtStockEjemplar.Texts);
            }
            
            //PASO 2


            try
            {
                
                idVehiculo = objEjemplar.consultarVehiculo(modeloVehiculo);
                idProveedor = objEjemplar.consultarProveedor(nombreProveedor);
                
                //VALIDACIONES AUXILIARES

                if (idVehiculo == 0)
                {
                    MessageBox.Show("No existe un Vehicilo registrado con ese ID ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (idProveedor == 0)
                {
                    MessageBox.Show("No existe un Proveedor registrado con ese ID ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                resultado = objEjemplar.agregarEjemplar(idVehiculo, idProveedor, cantidad);

                if (resultado > 0)
                {
                    MessageBox.Show("Ejemplar/es Registrado/s", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbxVehiculo.SelectedItem = -1;
                    cbxProovedor.SelectedItem = -1;
                    txtStockEjemplar.Texts = "";
                }
                else
                {
                    MessageBox.Show("Ejemplar/es NO Registrado/s", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbxProovedor_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxProovedor.Texts))
            {
                // Obtener el nombre del proveedor seleccionado
                string nombreProveedor = cbxProovedor.SelectedItem.ToString();

                // Cargar los vehículos asociados al proveedor
                CargarVehiculosPorProveedor(nombreProveedor);
            }
        }


    }
}

