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
        string[] arrPlanes = new string[3];
        int indiceFila = 0;

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            if (tbNombre.Text == "" || cbxPlan.Text == "" || mtbCodigo.Text == "")
            {
                MessageBox.Show("Debe completar todos los casilleros", "Registro académico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (
              string.IsNullOrWhiteSpace(mtbCodigo.Text) ||
              string.IsNullOrWhiteSpace(tbNombre.Text) ||
              cbxPlan.SelectedIndex == -1
           )
                {
                    MessageBox.Show("Complete todos los campos y seleccione un plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (indiceFila >= arrMaterias.GetLength(0))
                {
                    MessageBox.Show("Límite de materias alcanzado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                arrMaterias[indiceFila, 0] = mtbCodigo.Text;
                arrMaterias[indiceFila, 1] = tbNombre.Text;
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
        }
        

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListado frmListado = new frmListado(arrPlanes);
            frmListado.arrMateriasListado = arrMaterias;

            frmListado.ShowDialog();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            frmCargaPlan frmCargaPlan = new frmCargaPlan(arrPlanes);
            frmCargaPlan.arrPlanes = arrPlanes;
            frmCargaPlan.ShowDialog();

            cbxPlan.DataSource = null;
            cbxPlan.DataSource = arrPlanes;


        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
