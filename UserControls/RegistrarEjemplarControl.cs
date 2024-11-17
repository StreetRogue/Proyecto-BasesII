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
        }

       assetEjemplar objEjemplar = new assetEjemplar();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

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
    }
}

