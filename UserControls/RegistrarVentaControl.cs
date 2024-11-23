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
    public partial class RegistrarVentaControl : UserControl
    {
        public RegistrarVentaControl()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.RegistrarVentaControl_Load);
            cbxVehiculoEjemplar.OnSelectedIndexChanged += new EventHandler(cbxVehiculoEjemplar_OnSelectedIndexChanged);
            cbxCedulaClienteVenta.OnSelectedIndexChanged += new EventHandler(cbxCedulaClienteVenta_OnSelectedIndexChanged);
        }

        assetVenta objVenta = new assetVenta();
        assetVehiculo objVehiculo = new assetVehiculo();
        assetEmpleado objEmpleado = new assetEmpleado();
        assetCliente objCliente = new assetCliente();
        private bool cargandoVehiculos = true;


        

        private void RegistrarVentaControl_Load(object sender, EventArgs e)
        {
            CargarVendores();
            CargarVehiculos(); 
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                List<int> cedulasCliente = objCliente.ObtenerCedulaCliente(); // Llamar al método

                if (cedulasCliente.Count > 0)
                {
                    cbxCedulaClienteVenta.DataSource = cedulasCliente; // Llenar el ComboBox
                }
                else
                {
                    MessageBox.Show("No se encontraron clientes en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarVendores()
        {
            try
            {
                List<string> nombresVendedores = objEmpleado.ObtenerNombresVendedores(); // Llamar al método

                if (nombresVendedores.Count > 0)
                {
                    cbxVendedor.DataSource = nombresVendedores; // Llenar el ComboBox
                }
                else
                {
                    MessageBox.Show("No se encontraron vendedores en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vendedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarVehiculos()
        {
            try
            {
                cargandoVehiculos = true;
                List<string> modelosVehiculos = objVehiculo.ObtenerModelosVehiculos(); // Llamar al método

                if (modelosVehiculos.Count > 0)
                {
                    cbxVehiculoEjemplar.DataSource = modelosVehiculos; // Llenar el ComboBox
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
                cargandoVehiculos = false; // Finaliza el estado de carga
            }
        }

        private void CargarEjemplaresPorVehiculo(string modeloVehiculo)
        {
            try
            {
                // Obtener el ID del proveedor por el nombre
                int idVehiculo = objVenta.consultarVehiculo(modeloVehiculo);

                if (idVehiculo > 0)
                {
                    // Obtener los vehículos del proveedor
                    List<string> nombresVehiculos = objVenta.ObtenerEjemplaresPorVehiculo(idVehiculo);

                    if (nombresVehiculos.Count > 0)
                    {
                        cbxEjemplarVenta.DataSource = nombresVehiculos; // Llenar el ComboBox de ejemplares
                    }
                    else
                    {

                        cbxEjemplarVenta.DataSource = null; // Limpiar ComboBox si no hay datos
                        if (!cargandoVehiculos)
                        {
                            MessageBox.Show("No se encontraron ejemplares para el vehiculo seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró un vehiculo con ese modelo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ejemplares: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxVehiculoEjemplar_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxVehiculoEjemplar.Texts))
            {
                // Obtener el nombre del proveedor seleccionado
                string modeloVehiculo = cbxVehiculoEjemplar.SelectedItem.ToString();
                int precioVehiculo = objVenta.consultarPrecioVehiculo(modeloVehiculo);
                string precioEjemplar = precioVehiculo.ToString();
                lblPrecioEjemplar.Text = precioEjemplar;
                // Cargar los vehículos asociados al proveedor
                CargarEjemplaresPorVehiculo(modeloVehiculo);

            }
        }

        private void cbxCedulaClienteVenta_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxCedulaClienteVenta.Texts))
            {

                // Obtener el nombre del cliente seleccionado
                string cedulaCliente = cbxCedulaClienteVenta.SelectedItem.ToString();
                int cedulaClienteInt = int.Parse(cedulaCliente);
                string nombreClienteVenta = objVenta.consultarCliente(cedulaClienteInt);


                // Cargar los vehículos asociados al proveedor
                lblNombreClienteVenta.Text = nombreClienteVenta;
            }
        }


        

        private void btnRegistrarEjem_Click(object sender, EventArgs e)
        {

        }
    }
}
