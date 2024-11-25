using ProyectoBasesII.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBasesII.UserControls
{
    public partial class ModificarProveedorControl : UserControl
    {
        public ModificarProveedorControl()
        {
            InitializeComponent();
        }

        private string idProveedor;
        assetProveedor objProveedor = new assetProveedor();


        public void CargarProveedor(string idProveedorSeleccionado)
        {
            idProveedor = idProveedorSeleccionado;

            // Cargar los datos del ejemplar
            DataSet ds = objProveedor.buscarProveedor(int.Parse(idProveedor));

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Mostrar los datos en los controles del formulario
                DataRow row = ds.Tables[0].Rows[0];
                txtNombreProovedor.Texts = row["nombreProveedor"].ToString();
                txtTelefonoProovedor.Texts = row["telefonoProveedor"].ToString();
                txtDireccionProovedor.Texts = row["direccionProveedor"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró información para el proveedor seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificarProv_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            string nombreProveedor = "", telefonoProveedor = "", direccionProveedor = "";

            if (string.IsNullOrEmpty(txtNombreProovedor.Texts) || string.IsNullOrEmpty(txtTelefonoProovedor.Texts) || string.IsNullOrEmpty(txtDireccionProovedor.Texts))
            {
                MessageBox.Show("Debe llenar todos los campos.", "Ingrese todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nombreProveedor = txtNombreProovedor.Texts;
            telefonoProveedor = txtTelefonoProovedor.Texts;
            direccionProveedor = txtDireccionProovedor.Texts;

            try
            {
                if (string.IsNullOrEmpty(idProveedor))
                {
                    MessageBox.Show("No se ha cargado un proveedor para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                resultado = objProveedor.modificarProveedores(int.Parse(idProveedor), nombreProveedor, telefonoProveedor, direccionProveedor);

                

                if (resultado > 0)
                {
                    MessageBox.Show("Proveedor Modificado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNombreProovedor.Texts = string.Empty;
                    txtTelefonoProovedor.Texts = string.Empty;
                    txtDireccionProovedor.Texts = string.Empty;
                }
                else
                {
                    MessageBox.Show("Proveedor NO Modificado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            catch (Exception ex)
            {
                if (ex.Message.Contains("Error: El proveedor especificado no existe."))
                {
                    MessageBox.Show("El proveedor especificado no existe.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }else if (ex.Message.Contains("Error: Ya existe otro proveedor con el mismo nombre."))
                {
                    MessageBox.Show("Ya existe otro proveedor con el mismo nombre.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
