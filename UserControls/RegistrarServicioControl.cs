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
    public partial class RegistrarServicioControl : UserControl
    {
        public RegistrarServicioControl()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.RegistrarServicioControl_Load);
        }

        assetServicio objServicio = new assetServicio();
        assetEmpleado objEmpleado = new assetEmpleado();
        assetVenta objVenta = new assetVenta();



        private void RegistrarServicioControl_Load(object sender, EventArgs e)
        {
            CargarTecnicos();
            CargarServicios();
            CargarVentas();
        }


        private void CargarVentas()
        {
            try
            {
                List<int> idVentas = objVenta.ObtenerIdVentas(); // Llamar al método

                if (idVentas.Count > 0)
                {
                    cbxVenta.DataSource = idVentas; // Llenar el ComboBox
                }
                else
                {
                    MessageBox.Show("No se encontraron ventas en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTecnicos()
        {
            try
            {
                List<string> nombresTecnicos = objEmpleado.ObtenerNombresTecnicos(); // Llamar al método

                if (nombresTecnicos.Count > 0)
                {
                    cbxTecnico.DataSource = nombresTecnicos; // Llenar el ComboBox
                }
                else
                {
                    MessageBox.Show("No se encontraron tecnicos en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tecnicos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CargarServicios()
        {
            try
            {
                List<string> nombresServicios = objServicio.ObtenerNombresServicios(); // Llamar al método

                if (nombresServicios.Count > 0)
                {
                    cbxServicio.DataSource = nombresServicios; // Llenar el ComboBox
                }
                else
                {
                    MessageBox.Show("No se encontraron servicios en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar servicios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarServicio_Click(object sender, EventArgs e)
        {
            //Variables 

            int resultado = 0;
            int idVenta= 2;
            string nombreServicio = "", nombreTecnico = "";
            DateTime fechaInicio;


            //Variables Auxiliares

            int idTecnico, idServicio;
            string auxFechaInicio;

            //PASO 1

            if (string.IsNullOrEmpty(cbxServicio.Texts) || string.IsNullOrEmpty(cbxTecnico.Texts))

            {
                MessageBox.Show("Debe llenar todos los campos.", "Ingrese todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                nombreServicio = cbxServicio.SelectedItem.ToString();
                nombreTecnico = cbxTecnico.SelectedItem.ToString();
                fechaInicio = dtpFechaServicio.Value;

                //Casteo de la fecha a un string

                auxFechaInicio = fechaInicio.ToString("yyyy-MM-dd HH:mm:ss");
            }

            //PASO 2

            try
            {
                idServicio = objServicio.consultarServicio(nombreServicio);
                idTecnico = objServicio.consultarTecnico(nombreTecnico);


                if (idServicio == 0)
                {
                    MessageBox.Show("No existe un Servicio registrado con ese ID ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (idTecnico == 0)
                {
                    MessageBox.Show("No existe un Tecnico registrado con ese ID ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                resultado = objServicio.agregarServicio(idServicio,idTecnico,fechaInicio,idVenta);

                if (resultado > 0)
                {
                    MessageBox.Show("Servicio Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbxServicio.SelectedIndex = -1;
                    cbxTecnico.SelectedIndex = -1;
                    dtpFechaServicio.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Servicio No Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
