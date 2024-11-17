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
    public partial class RegistrarEmpleadoControl : UserControl
    {
        public RegistrarEmpleadoControl()
        {
            InitializeComponent();
        }

        int resultado;
        assetEmpleado empleado = new assetEmpleado();

        private void btnRegistrarEmp_Click(object sender, EventArgs e)
        {
            string varNombreEmpleado, varApellidoEmpleado, varCargoEmpleado = "";

            //PASO 1
            if (string.IsNullOrEmpty(txtNombreEmp.Texts)||string.IsNullOrEmpty(txtApellidoEmp.Texts)||string.IsNullOrEmpty(cbxCargoEmp.Texts)){
                MessageBox.Show("Debe llenar todos los campos.", "Ingrese todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                varNombreEmpleado = txtNombreEmp.Texts;
                varApellidoEmpleado = txtApellidoEmp.Texts;
                varCargoEmpleado = cbxCargoEmp.SelectedItem.ToString();
            }

            //PASO 2

            try
            {
                resultado = empleado.registrarEmpleado(varNombreEmpleado,varApellidoEmpleado,varCargoEmpleado);

                if (resultado > 0  )
                {
                    MessageBox.Show("Empleado Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreEmp.Texts = "";
                    txtApellidoEmp.Texts = "";
                    cbxCargoEmp.SelectedItem = -1;
                }
                else
                {
                    MessageBox.Show("Empleado No Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
