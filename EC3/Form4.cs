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
    public partial class frmMenu : Form
    {
        private frmTrabajadores trab;
        private frmAreas areat;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarTrab(object sender, FormClosedEventArgs e)
        {
            trab = null;
        }

        private void cerrarAreat(object sender, FormClosedEventArgs e)
        {
            areat = null;
        }

        private void controlarVentanaTrab()
        {
            if (trab == null)
            {
                trab = new frmTrabajadores();// cambia el nombre de frmTrabajadores por trab
                trab.MdiParent = this;
                trab.FormClosed += new FormClosedEventHandler(cerrarTrab);//se ejecuta cuando el objeto 'trab' se cierra
                trab.Show();// se muestra el formulario trabajadores
            }
            else
            {
                trab.Activate();
            }
        }
        private void controlarVentanaAreat()
        {
            if (areat == null)
            {
                areat = new frmAreas();
                areat.MdiParent = this;
                areat.FormClosed += new FormClosedEventHandler(cerrarAreat);
                areat.Show();
            }
            else
            {
                areat.Activate();
            }
        }


        private void tsTrabajadores_Click(object sender, EventArgs e)
        {
            controlarVentanaTrab();
        }

        private void tsArea_Click(object sender, EventArgs e)
        {
            controlarVentanaAreat();
        }

        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            controlarVentanaTrab();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            controlarVentanaAreat();
        }
    }
}
