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

        public frmAlumno()
        {
            InitializeComponent();
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtbDocumento.Text) ||
               string.IsNullOrWhiteSpace(tbNombre.Text) ||
               string.IsNullOrWhiteSpace(tbApellido.Text) ||
               string.IsNullOrWhiteSpace(tbDireccion.Text) ||
               string.IsNullOrWhiteSpace(dtpNacimiento.Text) ||
               string.IsNullOrWhiteSpace(tbContacto.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (indiceFila >= arrAlumnos.GetLength(0))
            {
                MessageBox.Show("Límite de alumnos alcanzado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            arrAlumnos[indiceFila, 0] = mtbDocumento.Text;
            arrAlumnos[indiceFila, 1] = tbNombre.Text;
            arrAlumnos[indiceFila, 2] = tbApellido.Text;
            arrAlumnos[indiceFila, 3] = tbDireccion.Text;
            arrAlumnos[indiceFila, 4] = tbContacto.Text;
            arrAlumnos[indiceFila, 5] = dtpNacimiento.Value.ToString("dd/MM/yyyy");
            arrAlumnos[indiceFila, 6] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            arrAlumnos[indiceFila, 7] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            indiceFila++;

            MessageBox.Show("Alumno registrado exitosamente.", "Registro Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tbNombre.Clear();
            tbApellido.Clear();
            tbDireccion.Clear();
            mtbDocumento.Clear();
            tbContacto.Clear();
            dtpNacimiento.Format = DateTimePickerFormat.Custom;
            dtpNacimiento.CustomFormat = " ";
        }

        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {
            dtpNacimiento.CustomFormat = "dd/MM/yyyy";
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            if (indiceFila == 0)
            {
                MessageBox.Show("No hay alumnos registrados.", "Listado Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = 0; i < arrAlumnos.GetLength(0); i++)
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
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
        }
    }
}
