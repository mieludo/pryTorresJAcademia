namespace pryTorresJAcademia
{
    partial class frmAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumno));
            this.gbAlumnos = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tbContacto = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.mtbDocumento = new System.Windows.Forms.MaskedTextBox();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.colDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAlumnos
            // 
            this.gbAlumnos.Controls.Add(this.btnEditar);
            this.gbAlumnos.Controls.Add(this.btnEliminar);
            this.gbAlumnos.Controls.Add(this.btnRegistrar);
            this.gbAlumnos.Controls.Add(this.dtpNacimiento);
            this.gbAlumnos.Controls.Add(this.tbContacto);
            this.gbAlumnos.Controls.Add(this.tbDireccion);
            this.gbAlumnos.Controls.Add(this.tbApellido);
            this.gbAlumnos.Controls.Add(this.tbNombre);
            this.gbAlumnos.Controls.Add(this.mtbDocumento);
            this.gbAlumnos.Controls.Add(this.lblRegistro);
            this.gbAlumnos.Location = new System.Drawing.Point(12, 32);
            this.gbAlumnos.Name = "gbAlumnos";
            this.gbAlumnos.Size = new System.Drawing.Size(281, 240);
            this.gbAlumnos.TabIndex = 0;
            this.gbAlumnos.TabStop = false;
            this.gbAlumnos.Text = "Registro";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(14, 193);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(81, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNacimiento.Location = new System.Drawing.Point(139, 148);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(132, 20);
            this.dtpNacimiento.TabIndex = 5;
            this.dtpNacimiento.ValueChanged += new System.EventHandler(this.dtpNacimiento_ValueChanged);
            // 
            // tbContacto
            // 
            this.tbContacto.Location = new System.Drawing.Point(139, 121);
            this.tbContacto.Name = "tbContacto";
            this.tbContacto.Size = new System.Drawing.Size(132, 20);
            this.tbContacto.TabIndex = 4;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(139, 95);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(132, 20);
            this.tbDireccion.TabIndex = 3;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(139, 69);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(132, 20);
            this.tbApellido.TabIndex = 2;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(139, 43);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(132, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // mtbDocumento
            // 
            this.mtbDocumento.Location = new System.Drawing.Point(139, 17);
            this.mtbDocumento.Mask = "99999999";
            this.mtbDocumento.Name = "mtbDocumento";
            this.mtbDocumento.Size = new System.Drawing.Size(132, 20);
            this.mtbDocumento.TabIndex = 0;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(7, 20);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(109, 143);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "DNI:\r\n\r\nNombre:\r\n\r\nApellido:\r\n\r\nDirección:\r\n\r\nContacto:\r\n\r\nFecha de nacimiento:";
            // 
            // btnVolver
            // 
            this.btnVolver.ForeColor = System.Drawing.Color.Red;
            this.btnVolver.Location = new System.Drawing.Point(12, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDocumento,
            this.colNombre,
            this.colApellido,
            this.colDireccion,
            this.colContacto,
            this.colFechaNacimiento});
            this.dgvAlumnos.Location = new System.Drawing.Point(315, 32);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(644, 238);
            this.dgvAlumnos.TabIndex = 2;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellClick);
            // 
            // colDocumento
            // 
            this.colDocumento.HeaderText = "Documento";
            this.colDocumento.Name = "colDocumento";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            // 
            // colDireccion
            // 
            this.colDireccion.HeaderText = "Dirección";
            this.colDireccion.Name = "colDireccion";
            // 
            // colContacto
            // 
            this.colContacto.HeaderText = "Contacto";
            this.colContacto.Name = "colContacto";
            // 
            // colFechaNacimiento
            // 
            this.colFechaNacimiento.HeaderText = "Fecha de nacimiento";
            this.colFechaNacimiento.Name = "colFechaNacimiento";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(188, 193);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(101, 193);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(966, 282);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbAlumnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAlumno";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.frmAlumno_Load);
            this.gbAlumnos.ResumeLayout(false);
            this.gbAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAlumnos;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.TextBox tbContacto;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.MaskedTextBox mtbDocumento;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNacimiento;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}