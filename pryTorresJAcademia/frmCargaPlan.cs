using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTorresJAcademia
{
    public partial class frmCargaPlan : Form
    {
        int varIndice = 0;
        public string[] arrPlanes = new string[5];


        public frmCargaPlan()
        {
            InitializeComponent();
            
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void frmCargaPlan_Load(object sender, EventArgs e)
        {
            varIndice = 0;

            while (varIndice < arrPlanes.Length && !string.IsNullOrEmpty(arrPlanes[varIndice]))
            {
                varIndice++;
            }
            btnRegistrar.Enabled = varIndice < arrPlanes.Length;
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (varIndice >= arrPlanes.Length)
            {
                MessageBox.Show("No se pueden cargar más planes", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnRegistrar.Enabled = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del plan", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            arrPlanes[varIndice] = tbNombre.Text.Trim();
            varIndice++;
            tbNombre.Clear();
            ListarPlanes();
            MessageBox.Show("Nombre registrado con éxito", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (varIndice >= arrPlanes.Length)
            {
                MessageBox.Show("No se pueden cargar más planes", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnRegistrar.Enabled = false;
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            
            {
                ListarPlanes();
            }
            }
            private void ListarPlanes()
        {
            lstPlan.Items.Clear();

            for (int count = 0; count < arrPlanes.Length; count++)
            {
                if (!string.IsNullOrWhiteSpace(arrPlanes[count]))
                {
                    lstPlan.Items.Add(arrPlanes[count]);
                }
            }
        }


        

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnListar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRegistrar.PerformClick();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
                frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
        }
    }
}


