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
        //Declaración --> string[] arrayPlan --- array de una
        //Dimensión - vector
        string[] arrPlan = new string[4];
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
                arrPlan[varIndice] = tbNombre.Text;
            varIndice++;
            {
                MessageBox.Show("Nombre registrado con éxito", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != "")

                arrPlan[varIndice] = tbNombre.Text;
            varIndice++;

            tbNombre.Clear();


            {
                MessageBox.Show("Nombre registrado con éxito", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (varIndice >= arrPlan.Length)
            {
                MessageBox.Show("No se pueden cargar más planes", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnRegistrar.Enabled = false;
                return;
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //int indiceRecorrido = 0;
            lstPlanes.Items.Clear();
            string planesRegistrados = "Planes registrados:\n";

            for (int i = 0; i < arrPlan.Length; i++)
            {
                if (string.IsNullOrEmpty(arrPlan[i]))


                    planesRegistrados += $"{i + 1}. {arrPlan[i]}\n";
                lstPlanes.Items.Add(arrPlan[i]);

                MessageBox.Show(planesRegistrados, "Listado de Planes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

