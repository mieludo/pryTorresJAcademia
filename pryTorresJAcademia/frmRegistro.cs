using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTorresJAcademia
{
    public partial class frmRegistro : Form
    {
        string estado;
        public static int indiceFila = 0;
        public static string[,] arrMaterias = new string[2, 4];

        public static string[,] DevolverMaterias()
        {
            return arrMaterias;
        }

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void ActualizarPlanes()
        {
            cbxPlan.DataSource = null;
            cbxPlan.DataSource = frmCargaPlan.DevolverPlanes();
            cbxPlan.SelectedIndex = -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (mtbCodigo.Text == "")
            {
                MessageBox.Show("Debe ingresar el código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCodigo.Focus();
                return;
            }

            if (tbNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNombre.Focus();
                return;
            }

            if (cbxPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxPlan.Focus();
                return;
            }

            if (chbActivo.Checked == true)
            {
                estado = "Activo";
            }
            else
            {
                estado = "Inactivo";
            }

            if (indiceFila >= arrMaterias.GetLength(0))
            {
                MessageBox.Show("Límite de materias alcanzado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCodigo.Clear();
                tbNombre.Clear();
                cbxPlan.SelectedIndex = -1;
                chbActivo.Checked = false;
                mtbCodigo.Focus();
                return;
            }

            arrMaterias[indiceFila, 0] = mtbCodigo.Text;
            arrMaterias[indiceFila, 1] = tbNombre.Text;
            arrMaterias[indiceFila, 2] = cbxPlan.Text;
            arrMaterias[indiceFila, 3] = estado;

            indiceFila++;

            MessageBox.Show("Materia registrada con éxito", "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mtbCodigo.Clear();
            tbNombre.Clear();
            cbxPlan.SelectedIndex = -1;
            chbActivo.Checked = false;
            mtbCodigo.Focus();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListado listado = new frmListado(frmCargaPlan.DevolverPlanes());
            listado.ShowDialog();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            frmCargaPlan cargaPlan = new frmCargaPlan();
            cargaPlan.ShowDialog();

            cbxPlan.DataSource = null;
            cbxPlan.DataSource = frmCargaPlan.DevolverPlanes();
            cbxPlan.SelectedIndex = -1;
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            cbxPlan.DataSource = null;
            cbxPlan.DataSource = frmCargaPlan.DevolverPlanes();
            cbxPlan.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }
    }
}
