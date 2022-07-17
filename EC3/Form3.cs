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
    public partial class frmAreas : Form
    {
        public frmAreas()
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
            txtCodarea.Focus();
        }
        private void visualizar()
        {
            using (bdEC3Entities bd = new bdEC3Entities())
            {
                var lst = from datos in bd.AREATRABAJO select datos;
                dgvAreat.DataSource = lst.ToList();
            }
        }
        private void guardar()
        {
            using (bdEC3Entities bd = new bdEC3Entities())
            {
                AREATRABAJO estructura = new AREATRABAJO();

                estructura.CODA = txtCodarea.Text;
                estructura.NOMA = txtNoma.Text;

                bd.AREATRABAJO.Add(estructura);
                bd.SaveChanges();
            }
        }
        private void modificar()
        {
            using (bdEC3Entities bd = new bdEC3Entities())
            {
                AREATRABAJO estructura = new AREATRABAJO();

                estructura.CODA = txtCodarea.Text;
                estructura.NOMA = txtNoma.Text;

                bd.Entry(estructura).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
            }
        }
        private void eliminar()
        {
            using (bdEC3Entities bd = new bdEC3Entities())
            {
                AREATRABAJO area = bd.AREATRABAJO.Find(txtCodarea.Text);
                bd.AREATRABAJO.Remove(area);
                bd.SaveChanges();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAreas_Load(object sender, EventArgs e)
        {
            visualizar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
            MessageBox.Show("Registro Guardado");
            visualizar();
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
        private void dgvAreat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvAreat.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtCodarea.Text = dgvAreat.Rows[e.RowIndex].Cells["CODA"].FormattedValue.ToString();
                txtNoma.Text = dgvAreat.Rows[e.RowIndex].Cells["NOMA"].FormattedValue.ToString();
            }

        }
    }
}
