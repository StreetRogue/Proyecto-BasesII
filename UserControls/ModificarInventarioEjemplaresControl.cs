using Oracle.ManagedDataAccess.Client;
using ProyectoBasesII.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBasesII.UserControls
{
    public partial class ModificarInventarioEjemplaresControl : UserControl
    {
        private string idEjemplar;

        

        public ModificarInventarioEjemplaresControl()
        {
            InitializeComponent();
            this.Load += new EventHandler(ModificarInventarioEjemplaresControl_Load);
            cbxProovedor.OnSelectedIndexChanged += new EventHandler(cbxProovedor_OnSelectedIndexChanged);
        }

        assetEjemplar objEjemplar = new assetEjemplar();
        assetProveedor objProveedores = new assetProveedor();
        assetVehiculo objVehiculo = new assetVehiculo();
        private bool cargandoProveedores = true;


        private void ModificarInventarioEjemplaresControl_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            try
            {
                cargandoProveedores = true;
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
            finally
            {
                cargandoProveedores = false; // Finaliza el estado de carga
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

                        cbxVehiculo.DataSource = null; // Limpiar ComboBox si no hay datos
                        if (!cargandoProveedores)
                        {
                            MessageBox.Show("No se encontraron vehículos para el proveedor seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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

        private void btnModificarEjem_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            string modeloVehiculo = "", nombreProveedor = "";

            int auxIdEjemplar;


            if (string.IsNullOrEmpty(cbxProovedor.Texts) || string.IsNullOrEmpty(cbxVehiculo.Texts))
            {
                MessageBox.Show("Debe llenar todos los campos.", "Ingrese todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

             modeloVehiculo = cbxVehiculo.SelectedItem.ToString();
             nombreProveedor = cbxProovedor.SelectedItem.ToString();

            try
            {
                if (string.IsNullOrEmpty(idEjemplar))
                {
                    MessageBox.Show("No se ha cargado un ejemplar para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                

                resultado = objEjemplar.modificarEjemplaresInventario(int.Parse(idEjemplar), modeloVehiculo, nombreProveedor);

                if (resultado > 0)
                {
                    MessageBox.Show("Ejemplar Modificado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ejemplar NO Modificado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void CargarEjemplar(string idEjemplarSeleccionado)
        {
            idEjemplar = idEjemplarSeleccionado;

            // Cargar los datos del ejemplar
            DataSet ds = objEjemplar.buscarEjemplar(int.Parse(idEjemplar));

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Mostrar los datos en los controles del formulario
                DataRow row = ds.Tables[0].Rows[0];
                cbxVehiculo.Texts = row["modeloVehiculo"].ToString();
                cbxProovedor.Texts = row["nombreProveedor"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró información para el ejemplar seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
