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
    public partial class frmAcademia : Form
    {
        public frmAcademia()
        {
            InitializeComponent();
        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();

            this.Hide();
            
            frmRegistro.ShowDialog();
        }

        private void frmAcademia_Load(object sender, EventArgs e)
        {
            //Almacenar la fecha y hora de inicio de sesión
            //Variables
            //VarInicioSesion == DateTime.Now; //Inicio de variables
        }
    }
}
