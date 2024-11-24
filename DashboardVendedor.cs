﻿using ProyectoBasesII.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBasesII
{
    public partial class DashboardVendedor : Form
    {
        public DashboardVendedor()
        {
            InitializeComponent();
            InicializarReloj();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void LoadUserControl(UserControl userControl)
        {
            // Limpiar el panel para evitar superposición de controles
            panelDesktopVendedor.Controls.Clear();

            // Configurar el UserControl para que se ajuste al tamaño del panel
            userControl.Dock = DockStyle.Fill;

            // Agregar el UserControl al panel
            panelDesktopVendedor.Controls.Add(userControl);
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) //Contraer menu
            {
                panelMenu.Width = 100;
                Logo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(30);
                    menuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 250;
                Logo.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                    menuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void InicializarReloj()
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // Actualiza cada segundo
            timer.Tick += new EventHandler(ActualizarHora);
            timer.Start();
        }

        private void ActualizarHora(object sender, EventArgs e)
        {
            // Muestra la hora actual en un Label o TextBox
            lblHoraActual.Text = DateTime.Now.ToString("h:mm:ss");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra Formulario2
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            LoadUserControl(new RegistrarClienteControl());
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            /*DashboardVendedor vendedor = new DashboardVendedor();
            vendedor.Show();*/
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            LoadUserControl(new RegistrarVentaControl());
        }

        private void btnGestionarEjem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new InventarioEjemplarControl());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            LoadUserControl(new VentaInventarioControl());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ClienteControl());
        }
    }
}
