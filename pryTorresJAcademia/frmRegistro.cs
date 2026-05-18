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
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string estado;
            if (chbActivo.Checked)
            {
                estado = "Activo";
            }
            else
            {
                estado = "Inactivo";
            }
            MessageBox.Show(
                "Registro completo\n\n" +
                "Código: " + mtbCodigo.Text +
                "\nNombre: " + tbNombre.Text +
                "\nPlan: " + cbxPlan.Text +
                "\nEstado: " + estado);
        



            if (tbNombre.Text == "" || cbxPlan.Text == "" || mtbCodigo.Text == "")
            {
                MessageBox.Show("Debe completar todos los casilleros", "Registro academico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
            else
            {
                MessageBox.Show("Registro con éxito");
                this.Close();

                
            }
        }
        

        private void btnListado_Click(object sender, EventArgs e)
        {

        }
    }
}
