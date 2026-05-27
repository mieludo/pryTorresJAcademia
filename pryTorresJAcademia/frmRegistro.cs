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

        int varCodigo;
        string varNombre;
        string varPlan;
        bool varEstado;

        int indiceFila = 0;
        string[,] matMaterias = new string[2,5];

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
                // varcodigo = Convert.ToInt32(mtbCodigo.Text);
                // varNombre = tbNombre.Text;
                // varPlan = cbxPlan.Text;

                matMaterias[indiceFila, 0] = mtbCodigo.Text;
                matMaterias[indiceFila, 1] = tbNombre.Text;
                matMaterias[indiceFila, 2] = cbxPlan.Text;
                

                string estado;

                if (chbActivo.Checked)
                {
                    matMaterias[indiceFila,3] = "Activo";
                    varEstado = true;
                    estado = "Activo";
                }
                else
                {
                    matMaterias[indiceFila,3] = "Inactivo";
                    varEstado = false;
                    estado = "Inactivo";
                }
                
                MessageBox.Show(
                    "Registro completo\n\n" +
                    "Código: " + mtbCodigo.Text +
                    "\nNombre: " + tbNombre.Text +
                    "\nPlan: " + cbxPlan.Text +
                    "\nEstado: " + estado);
        


            }
            indiceFila++;
        }
        

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListado frmListado = new frmListado();
            this.Hide();
            frmListado.ShowDialog();
            this.Show();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            frmCargaPlan frmCargaPlan = new frmCargaPlan();
            this.Hide();
            frmCargaPlan.ShowDialog();
            this.Show();
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
