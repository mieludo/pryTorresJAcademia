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
        public DateTime VarInicioSesion;

        //int varCodigo;
        //string varNombre;
        //string varPlan;
        //bool varEstado;


        string[,] arrMaterias = new string[2, 4];
        string[] arrPlanes = new string[5];
        int indiceFila = 0;

        public frmRegistro()
        {
            InitializeComponent();
        }
            private void ActualizarPlanes()
        {
            cbxPlan.DataSource = null;
            cbxPlan.DataSource = arrPlanes.Where(plan => !string.IsNullOrWhiteSpace(plan)).ToArray();
            cbxPlan.SelectedIndex = -1;
        }
    
        

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtbCodigo.Text) ||
        string.IsNullOrWhiteSpace(tbNombre.Text) ||
        cbxPlan.SelectedIndex == -1 ||
        cbxPlan.SelectedItem == null)
            {
                MessageBox.Show("Complete todos los campos y seleccione un plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (indiceFila >= arrMaterias.GetLength(0))
            {
                MessageBox.Show("Límite de materias alcanzado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            arrMaterias[indiceFila, 0] = mtbCodigo.Text;
            arrMaterias[indiceFila, 1] = tbNombre.Text.Trim();
            arrMaterias[indiceFila, 2] = cbxPlan.SelectedItem.ToString();

            if (chbActivo.Checked)
            {
                arrMaterias[indiceFila, 3] = "Activo";
            }
            else
            {
                arrMaterias[indiceFila, 3] = "Inactivo";
            }

            mtbCodigo.Clear();
            tbNombre.Clear();
            cbxPlan.SelectedIndex = -1;
            chbActivo.Checked = false;

            indiceFila++;

            MessageBox.Show("Materia registrada con éxito.", "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
        

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListado frmListado = new frmListado(arrPlanes);
            frmListado.arrMateriasListado = arrMaterias;

            frmListado.ShowDialog();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            frmCargaPlan frmCargaPlan = new frmCargaPlan();
            frmCargaPlan.arrPlanes = arrPlanes;
            frmCargaPlan.ShowDialog();

            ActualizarPlanes();


        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

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
