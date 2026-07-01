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
    public partial class frmAlumno : Form
    {
        string[,] arrAlumnos = new string[2, 8];
        int indiceFila = 0;
        int filaSeleccionada = -1;

        public frmAlumno()
        {
            InitializeComponent();
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (indiceFila >= arrAlumnos.GetLength(0))
            {
                MessageBox.Show("Límite de alumnos alcanzado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbDocumento.Clear();
                tbNombre.Clear();
                tbApellido.Clear();
                tbDireccion.Clear();
                tbContacto.Clear();
                mtbDocumento.Focus();
                return;
            }

            if (mtbDocumento.Text == "")
            {
                MessageBox.Show("Ingrese un documento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                mtbDocumento.Focus();
                return;
            }

            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tbNombre.Focus();
                return;
            }

            if (tbApellido.Text == "")
            {
                MessageBox.Show("Ingrese un apellido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tbApellido.Focus();
                return;
            }

            if (tbDireccion.Text == "")
            {
                MessageBox.Show("Ingrese una dirección", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tbDireccion.Focus();
                return;
            }

            if (tbContacto.Text == "")
            {
                MessageBox.Show("Ingrese un contacto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tbContacto.Focus();
                return;
            }

            dgvAlumnos.Rows.Clear();

            arrAlumnos[indiceFila, 0] = mtbDocumento.Text;
            arrAlumnos[indiceFila, 1] = tbNombre.Text;
            arrAlumnos[indiceFila, 2] = tbApellido.Text;
            arrAlumnos[indiceFila, 3] = tbDireccion.Text;
            arrAlumnos[indiceFila, 4] = tbContacto.Text;
            arrAlumnos[indiceFila, 5] = dtpNacimiento.Value.ToString("dd/MM/yyyy");
            arrAlumnos[indiceFila, 6] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            arrAlumnos[indiceFila, 7] = "";

            for (int i = 0; i < arrAlumnos.GetLength(0); i++)
            {
                if (arrAlumnos[i, 0] != null)
                {
                    dgvAlumnos.Rows.Add(
                        arrAlumnos[i, 0],
                        arrAlumnos[i, 1],
                        arrAlumnos[i, 2],
                        arrAlumnos[i, 3],
                        arrAlumnos[i, 4],
                        arrAlumnos[i, 5]
                    );
                }
            }

            indiceFila++;

            MessageBox.Show("Alumno registrado exitosamente.", "Registro Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mtbDocumento.Clear();
            tbNombre.Clear();
            tbApellido.Clear();
            tbDireccion.Clear();
            tbContacto.Clear();
            mtbDocumento.Focus();
        }

        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            if (indiceFila == 0)
            {
                MessageBox.Show("No hay alumnos registrados.", "Listado Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = 0; i < indiceFila; i++)
            {
                string texto =
                "DATOS DEL ALUMNO\n\n" +
                "DNI: " + arrAlumnos[i, 0] + "\n" +
                "Nombre: " + arrAlumnos[i, 1] + "\n" +
                "Apellido: " + arrAlumnos[i, 2] + "\n" +
                "Dirección: " + arrAlumnos[i, 3] + "\n" +
                "Contacto: " + arrAlumnos[i, 4] + "\n" +
                "Fecha nacimiento: " + arrAlumnos[i, 5] + "\n" +
                "Fecha registro: " + arrAlumnos[i, 6] + "\n" +
                "Última actualización: " + arrAlumnos[i, 7];

                MessageBox.Show(texto, "Alumno registrado");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada == -1)
            {
                MessageBox.Show("Seleccione un alumno para editar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            dgvAlumnos.Rows.Clear();

            arrAlumnos[filaSeleccionada, 0] = mtbDocumento.Text;
            arrAlumnos[filaSeleccionada, 1] = tbNombre.Text;
            arrAlumnos[filaSeleccionada, 2] = tbApellido.Text;
            arrAlumnos[filaSeleccionada, 3] = tbDireccion.Text;
            arrAlumnos[filaSeleccionada, 4] = tbContacto.Text;
            arrAlumnos[filaSeleccionada, 5] = dtpNacimiento.Value.ToString("dd/MM/yyyy");
            arrAlumnos[filaSeleccionada, 7] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            for (int i = 0; i < arrAlumnos.GetLength(0); i++)
            {
                if (arrAlumnos[i, 0] != null)
                {
                    dgvAlumnos.Rows.Add(
                        arrAlumnos[i, 0],
                        arrAlumnos[i, 1],
                        arrAlumnos[i, 2],
                        arrAlumnos[i, 3],
                        arrAlumnos[i, 4],
                        arrAlumnos[i, 5]
                    );
                }
            }

            mtbDocumento.Clear();
            tbNombre.Clear();
            tbApellido.Clear();
            tbDireccion.Clear();
            tbContacto.Clear();
            mtbDocumento.Focus();

            filaSeleccionada = -1;

            MessageBox.Show("Alumno editado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada == -1)
            {
                MessageBox.Show("Seleccione un alumno para eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            for (int i = filaSeleccionada; i < indiceFila - 1; i++)
            {
                arrAlumnos[i, 0] = arrAlumnos[i + 1, 0];
                arrAlumnos[i, 1] = arrAlumnos[i + 1, 1];
                arrAlumnos[i, 2] = arrAlumnos[i + 1, 2];
                arrAlumnos[i, 3] = arrAlumnos[i + 1, 3];
                arrAlumnos[i, 4] = arrAlumnos[i + 1, 4];
                arrAlumnos[i, 5] = arrAlumnos[i + 1, 5];
                arrAlumnos[i, 6] = arrAlumnos[i + 1, 6];
                arrAlumnos[i, 7] = arrAlumnos[i + 1, 7];
            }

            indiceFila--;

            arrAlumnos[indiceFila, 0] = null;
            arrAlumnos[indiceFila, 1] = null;
            arrAlumnos[indiceFila, 2] = null;
            arrAlumnos[indiceFila, 3] = null;
            arrAlumnos[indiceFila, 4] = null;
            arrAlumnos[indiceFila, 5] = null;
            arrAlumnos[indiceFila, 6] = null;
            arrAlumnos[indiceFila, 7] = null;

            dgvAlumnos.Rows.Clear();

            for (int i = 0; i < arrAlumnos.GetLength(0); i++)
            {
                if (arrAlumnos[i, 0] != null)
                {
                    dgvAlumnos.Rows.Add(
                        arrAlumnos[i, 0],
                        arrAlumnos[i, 1],
                        arrAlumnos[i, 2],
                        arrAlumnos[i, 3],
                        arrAlumnos[i, 4],
                        arrAlumnos[i, 5]
                    );
                }
            }

            mtbDocumento.Clear();
            tbNombre.Clear();
            tbApellido.Clear();
            tbDireccion.Clear();
            tbContacto.Clear();
            mtbDocumento.Focus();

            filaSeleccionada = -1;

            MessageBox.Show("Alumno eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            filaSeleccionada = e.RowIndex;

            if (filaSeleccionada >= indiceFila || filaSeleccionada >= arrAlumnos.GetLength(0))
            {
                return;
            }

            mtbDocumento.Text = arrAlumnos[filaSeleccionada, 0];
            tbNombre.Text = arrAlumnos[filaSeleccionada, 1];
            tbApellido.Text = arrAlumnos[filaSeleccionada, 2];
            tbDireccion.Text = arrAlumnos[filaSeleccionada, 3];
            tbContacto.Text = arrAlumnos[filaSeleccionada, 4];
            dtpNacimiento.Value = DateTime.Parse(arrAlumnos[filaSeleccionada, 5]);
        }
    }
}
