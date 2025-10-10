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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmIniciodineño iniciodineño = new frmIniciodineño();
            iniciodineño.ShowDialog();
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