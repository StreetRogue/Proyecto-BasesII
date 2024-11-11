using ProyectoBasesII.Logica;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCleanCampos_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Obtén las credenciales del usuario
            string nombreUsuario = txtUser.Text;
            string password = txtPassword.Text;

            // Crea una instancia de assetLogin
            assetLogin login = new assetLogin();

            // Verifica las credenciales y obtiene el rol
            string rolUsuario = login.ValidarCredenciales(nombreUsuario, password);

            // Redirige al formulario correspondiente según el rol
            if (rolUsuario == "ADMIN")
            {
                DashboardAdmin adminForm = new DashboardAdmin();
                adminForm.Show();
                this.Hide();
            }
            else if (rolUsuario == "VENDEDOR")
            {
                DashboardVendedor vendedorForm = new DashboardVendedor();
                vendedorForm.Show();
                this.Hide();
            }
            else if (rolUsuario == "TECNICO")
            {
                DashboardTecnico tecnicoForm = new DashboardTecnico();
                tecnicoForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
