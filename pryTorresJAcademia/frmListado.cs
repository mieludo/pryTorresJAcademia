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
            lstPlan.DataSource = arrPlanesRecibido.Where(plan => !string.IsNullOrWhiteSpace(plan)).ToArray();
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
                MessageBox.Show("Seleccione su búsqueda", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rbTodo.Checked)
            {
                for (int i = 0; i < arrMateriasListado.GetLength(0); i++)
                {
                    AgregarMateria(i);
                }
            }

            if (rbCodigo.Checked)
            {
                if (string.IsNullOrWhiteSpace(tbCodigo.Text))
                {
                    MessageBox.Show("Ingrese un código para buscar.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 0; i < arrMateriasListado.GetLength(0); i++)
                {
                    if (arrMateriasListado[i, 0] == tbCodigo.Text)
                    {
                        AgregarMateria(i);
                    }
                }
            }

            if (rbNombre.Checked)
            {
                if (string.IsNullOrWhiteSpace(tbNombre.Text))
                {
                    MessageBox.Show("Ingrese un nombre para buscar.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 0; i < arrMateriasListado.GetLength(0); i++)
                {
                    if (string.Equals(arrMateriasListado[i, 1], tbNombre.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        AgregarMateria(i);
                    }
                }
            }

            if (rbPlan.Checked)
            {
                if (lstPlan.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un plan para buscar.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 0; i < arrMateriasListado.GetLength(0); i++)
                {
                    if (arrMateriasListado[i, 2] == lstPlan.SelectedItem.ToString())
                    {
                        AgregarMateria(i);
                    }
                }
            }

            if (dgvMaterias.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron materias.", "Listado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
    }
}



