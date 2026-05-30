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
        string[] arrPlanes = new string[3];
        public string[,] arrMateriasListado = new string[2, 4];
        public frmListado(string[] arrPlanesRecibido)
        {
            InitializeComponent();
            lstPlan.DataSource = arrPlanesRecibido;
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
            }

            if (rbTodo.Checked)
            {
                for (int i = 0; i < arrMateriasListado.GetLength(0); i++)
                {
                    dgvMaterias.Rows.Add(arrMateriasListado[i, 0], arrMateriasListado[i, 1], arrMateriasListado[i, 2], arrMateriasListado[i, 3]);
                }
            }
            if (rbCodigo.Checked)
            {
                for (int i = 0; i < arrMateriasListado.GetLength(0); i++)
                {
                    if (arrMateriasListado[i, 0] == tbCodigo.Text)
                    {
                        dgvMaterias.Rows.Add(arrMateriasListado[i, 0], arrMateriasListado[i, 1], arrMateriasListado[i, 2], arrMateriasListado[i, 3]);
                    }
                }
            }
            if (rbNombre.Checked)
            {
                for (int i = 0; i < arrMateriasListado.GetLength(0); i++)
                {
                    if (arrMateriasListado[i, 1] == tbNombre.Text)
                    {
                        dgvMaterias.Rows.Add(arrMateriasListado[i, 0], arrMateriasListado[i, 1], arrMateriasListado[i, 2], arrMateriasListado[i, 3]);
                    }
                }
            }
            if (rbPlan.Checked)
            {
                for (int i = 0; i < arrMateriasListado.GetLength(0); i++)
                {
                    if (arrMateriasListado[i, 2] == lstPlan.SelectedItem.ToString())
                    {
                        dgvMaterias.Rows.Add(arrMateriasListado[i, 0], arrMateriasListado[i, 1], arrMateriasListado[i, 2], arrMateriasListado[i, 3]);
                    }
                }
            }
        }
    }
}
        
    

