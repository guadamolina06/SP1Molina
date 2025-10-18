using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP1Molina
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int intentos = 0;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            string userAdmin = "Administrador";
            string passAdmin = "adm135$";

            string userOperador = "Operador";
            string passOperador = "ope246$";

            if ((usuario == userAdmin && contraseña == passAdmin) ||
                (usuario == userOperador && contraseña == passOperador))
            {
                frmIniciodineño iniciodineño = new frmIniciodineño();
                iniciodineño.ShowDialog();

            }
            else
            {
                intentos++;
                MessageBox.Show("Usuario o contraseña incorrectos ", MessageBoxButtons.OK.ToString());
               
                if (intentos >= 3)
                {
                    MessageBox.Show("Ha excedido el número de intentos permitidos. La aplicación se cerrará.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            lstMódulo.SelectedIndex = -1;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtContraseña.Enabled = false;
            }
            else
            {
                txtContraseña.Enabled = true;
            }
        }

        private void lstMódulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMódulo.SelectedIndex != -1)
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lstMódulo.Items.Add("ADM");
            lstMódulo.Items.Add("SIST");
            lstMódulo.Items.Add("COM");
            lstMódulo.Items.Add("VTA");
            txtUsuario.MaxLength=20;
            txtContraseña.MaxLength=20;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                lstMódulo.Enabled = false;
            }
            else
            {
                lstMódulo.Enabled = true;
            }
        }
    }
}