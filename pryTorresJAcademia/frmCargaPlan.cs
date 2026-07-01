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
        public static string[] arrPlanes = new string[5];
        public static int indicePlan = 0;

        public static string[] DevolverPlanes()
        {
            string[] resultado = new string[indicePlan];

            for (int i = 0; i < indicePlan; i++)
            {
                resultado[i] = arrPlanes[i];
            }

            return resultado;
        }

        public frmCargaPlan()
        {
            InitializeComponent();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
        }

        private void frmCargaPlan_Load(object sender, EventArgs e)
        {
            lstPlan.Items.Clear();

            for (int i = 0; i < indicePlan; i++)
            {
                lstPlan.Items.Add(arrPlanes[i]);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (indicePlan >= arrPlanes.Length)
            {
                MessageBox.Show("No se pueden cargar más planes", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (tbNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del plan", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbNombre.Focus();
                return;
            }

            arrPlanes[indicePlan] = tbNombre.Text;
            indicePlan++;

            lstPlan.Items.Add(tbNombre.Text);

            tbNombre.Clear();
            tbNombre.Focus();

            MessageBox.Show("Plan registrado con éxito", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lstPlan.Items.Clear();

            for (int i = 0; i < indicePlan; i++)
            {
                lstPlan.Items.Add(arrPlanes[i]);
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

