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
    public partial class frmTrabajadores : Form
    {
        public frmTrabajadores()
        {
            InitializeComponent();
        }
        private void limpiar()
        {
            foreach(Control caja in this.Controls)
            {
                if(caja is TextBox)
                {
                    caja.Text = "";
                }
            }
            txtDni.Focus();
        }
        private void guardar()
        {
            using (bdEC3Entities bd = new bdEC3Entities())
            {
                TRABAJADORES estructura = new TRABAJADORES();

                estructura.DNI = Convert.ToInt32(txtDni.Text);
                estructura.APATERNO = txtAp.Text;
                estructura.AMATERNO = txtAm.Text;
                estructura.NOMBRES = txtNombres.Text;
                estructura.SUELDO = Convert.ToInt32(txtSueldo.Text);
                estructura.CODA = cmbCoda.SelectedValue.ToString();

                bd.TRABAJADORES.Add(estructura);
                bd.SaveChanges();
            }
        }
        
        private void visualizar()
        {
            using (bdEC3Entities bd = new bdEC3Entities())
            {
                var lst = from datos in bd.TRABAJADORES select datos;
                dgvTrab.DataSource = lst.ToList();

                cmbCoda.DataSource = bd.AREATRABAJO.ToList();//agrega todos las filas de la tabla AREATRABAJO 
                cmbCoda.DisplayMember = "CODA";//muestra el campo CODA de la tabla AREATRABAJO ojo: se puede traer cualquier otro campo
                cmbCoda.ValueMember = "CODA";//captura el PK del valor que se seleccione del combo
            } 
        }
        private void modificar()
        {
            using (bdEC3Entities bd = new bdEC3Entities())
            {
                TRABAJADORES estructura = new TRABAJADORES();

                estructura.DNI = Convert.ToInt32(txtDni.Text);
                estructura.APATERNO = txtAp.Text;
                estructura.AMATERNO = txtAm.Text;
                estructura.NOMBRES = txtNombres.Text;
                estructura.SUELDO = Convert.ToInt32(txtSueldo.Text);
                estructura.CODA = cmbCoda.SelectedValue.ToString();

                bd.Entry(estructura).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
            }
        }
        private void eliminar()
        {
            using (bdEC3Entities bd = new bdEC3Entities())
            {
                TRABAJADORES trabajador = bd.TRABAJADORES.Find(Convert.ToInt32(txtDni.Text));
                bd.TRABAJADORES.Remove(trabajador);
                bd.SaveChanges();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTrabajadores_Load(object sender, EventArgs e)
        {
            visualizar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
            MessageBox.Show("Registro Guardado");
            visualizar();
        }

        private void dgvTrab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvTrab.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtDni.Text = dgvTrab.Rows[e.RowIndex].Cells["DNI"].FormattedValue.ToString();
                txtAp.Text = dgvTrab.Rows[e.RowIndex].Cells["APATERNO"].FormattedValue.ToString();
                txtAm.Text = dgvTrab.Rows[e.RowIndex].Cells["AMATERNO"].FormattedValue.ToString();
                txtNombres.Text = dgvTrab.Rows[e.RowIndex].Cells["NOMBRES"].FormattedValue.ToString();
                txtSueldo.Text = dgvTrab.Rows[e.RowIndex].Cells["SUELDO"].FormattedValue.ToString();
                cmbCoda.Text = dgvTrab.Rows[e.RowIndex].Cells["CODA"].FormattedValue.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
            MessageBox.Show("Registro modificado");
            visualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            limpiar();
            MessageBox.Show("Registro eliminado");
            visualizar();
        }
    }
}
