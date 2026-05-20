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
    public partial class frmCargaPlan : Form
    {
        //Declaración --> string[] arrayPlan --- array de una
        //Dimensión - vector
        string[] arrayPlan = new string[4];
        //crea memoria y declara los espacios --> = new string[4];

        int varIndice = 0;
        public frmCargaPlan()
        {
            InitializeComponent();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void frmCargaPlan_Load(object sender, EventArgs e)
        {
            if (tbNombre.Text != "")
                arrayPlan[varIndice] = tbNombre.Text;
            varIndice++;
            {
                MessageBox.Show("Nombre registrado con éxito", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
