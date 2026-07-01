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
    public partial class frmListado : Form
    {

        public string[,] arrMateriasListado = new string[2, 4];
        public frmListado(string[] arrPlanesRecibido)
        {
            InitializeComponent();

            lstPlan.DataSource = null;
            lstPlan.DataSource = frmCargaPlan.DevolverPlanes();
            lstPlan.SelectedIndex = -1;
        }

        private void frmListado_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvMaterias.Rows.Clear();

            if (!rbTodo.Checked && !rbCodigo.Checked && !rbNombre.Checked && !rbPlan.Checked)
            {
                MessageBox.Show("Seleccione su búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rbTodo.Checked)
            {
                for (int i = 0; i < frmRegistro.DevolverMaterias().GetLength(0); i++)
                {
                    if (frmRegistro.DevolverMaterias()[i, 0] != null)
                    {
                        dgvMaterias.Rows.Add(
                            frmRegistro.DevolverMaterias()[i, 0],
                            frmRegistro.DevolverMaterias()[i, 1],
                            frmRegistro.DevolverMaterias()[i, 2],
                            frmRegistro.DevolverMaterias()[i, 3]
                        );
                    }
                }
            }

            if (rbCodigo.Checked)
            {
                bool encontrado = false;

                for (int i = 0; i < frmRegistro.DevolverMaterias().GetLength(0); i++)
                {
                    if (frmRegistro.DevolverMaterias()[i, 0] != null && frmRegistro.DevolverMaterias()[i, 0] == tbCodigo.Text)
                    {
                        dgvMaterias.Rows.Add(
                            frmRegistro.DevolverMaterias()[i, 0],
                            frmRegistro.DevolverMaterias()[i, 1],
                            frmRegistro.DevolverMaterias()[i, 2],
                            frmRegistro.DevolverMaterias()[i, 3]
                        );

                        encontrado = true;
                    }
                }

                if (encontrado == false)
                {
                    MessageBox.Show("No se encontró el código ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCodigo.Focus();
                }
            }

            if (rbNombre.Checked)
            {
                bool encontrado = false;

                for (int i = 0; i < frmRegistro.DevolverMaterias().GetLength(0); i++)
                {
                    if (frmRegistro.DevolverMaterias()[i, 1] != null && frmRegistro.DevolverMaterias()[i, 1].ToLower() == tbNombre.Text.ToLower())
                    {
                        dgvMaterias.Rows.Add(
                            frmRegistro.DevolverMaterias()[i, 0],
                            frmRegistro.DevolverMaterias()[i, 1],
                            frmRegistro.DevolverMaterias()[i, 2],
                            frmRegistro.DevolverMaterias()[i, 3]
                        );

                        encontrado = true;
                    }
                }

                if (encontrado == false)
                {
                    MessageBox.Show("No se encontró el nombre ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbNombre.Focus();
                }
            }

            if (rbPlan.Checked)
            {
                bool encontrado = false;

                for (int i = 0; i < frmRegistro.DevolverMaterias().GetLength(0); i++)
                {
                    if (frmRegistro.DevolverMaterias()[i, 2] != null && frmRegistro.DevolverMaterias()[i, 2] == lstPlan.Text)
                    {
                        dgvMaterias.Rows.Add(
                            frmRegistro.DevolverMaterias()[i, 0],
                            frmRegistro.DevolverMaterias()[i, 1],
                            frmRegistro.DevolverMaterias()[i, 2],
                            frmRegistro.DevolverMaterias()[i, 3]
                        );

                        encontrado = true;
                    }
                }

                if (encontrado == false)
                {
                    MessageBox.Show("No se encontró el plan seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lstPlan.Focus();
                }
            }

            tbCodigo.Clear();
            tbNombre.Clear();
            lstPlan.SelectedIndex = -1;
        }
        private void AgregarMateria(int indice)
        {
            if (!string.IsNullOrWhiteSpace(arrMateriasListado[indice, 0]))
            {
                dgvMaterias.Rows.Add(
                    arrMateriasListado[indice, 0],
                    arrMateriasListado[indice, 1],
                    arrMateriasListado[indice, 2],
                    arrMateriasListado[indice, 3]);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}



