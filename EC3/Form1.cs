using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC3
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text.ToUpper() == "IDAT") && (txtPassword.Text == "123"))//si coincide:
            {
                this.Visible = false;//se oculta el frm de  login
                frmMenu md = new frmMenu(); 
                md.Show(); //muestra en fromulario menu

            }
            else//sino
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
