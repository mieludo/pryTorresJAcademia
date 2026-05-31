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
            this.gbAlumnos = new System.Windows.Forms.GroupBox();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.mtbDocumento = new System.Windows.Forms.MaskedTextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbContacto = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.gbAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAlumnos
            // 
            this.gbAlumnos.Controls.Add(this.btnListado);
            this.gbAlumnos.Controls.Add(this.btnRegistrar);
            this.gbAlumnos.Controls.Add(this.dtpNacimiento);
            this.gbAlumnos.Controls.Add(this.tbContacto);
            this.gbAlumnos.Controls.Add(this.tbDireccion);
            this.gbAlumnos.Controls.Add(this.tbApellido);
            this.gbAlumnos.Controls.Add(this.tbNombre);
            this.gbAlumnos.Controls.Add(this.mtbDocumento);
            this.gbAlumnos.Controls.Add(this.lblRegistro);
            this.gbAlumnos.Location = new System.Drawing.Point(13, 13);
            this.gbAlumnos.Name = "gbAlumnos";
            this.gbAlumnos.Size = new System.Drawing.Size(281, 240);
            this.gbAlumnos.TabIndex = 0;
            this.gbAlumnos.TabStop = false;
            this.gbAlumnos.Text = "Registro";
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
            // mtbDocumento
            // 
            this.mtbDocumento.Location = new System.Drawing.Point(139, 17);
            this.mtbDocumento.Mask = "99999999";
            this.mtbDocumento.Name = "mtbDocumento";
            this.mtbDocumento.Size = new System.Drawing.Size(132, 20);
            this.mtbDocumento.TabIndex = 1;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(139, 43);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(132, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(139, 69);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(132, 20);
            this.tbApellido.TabIndex = 3;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(139, 95);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(132, 20);
            this.tbDireccion.TabIndex = 4;
            // 
            // tbContacto
            // 
            this.tbContacto.Location = new System.Drawing.Point(139, 121);
            this.tbContacto.Name = "tbContacto";
            this.tbContacto.Size = new System.Drawing.Size(132, 20);
            this.tbContacto.TabIndex = 5;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNacimiento.Location = new System.Drawing.Point(139, 148);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(132, 20);
            this.dtpNacimiento.TabIndex = 6;
            this.dtpNacimiento.ValueChanged += new System.EventHandler(this.dtpNacimiento_ValueChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(10, 176);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(261, 23);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnListado
            // 
            this.btnListado.Location = new System.Drawing.Point(10, 205);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(261, 23);
            this.btnListado.TabIndex = 8;
            this.btnListado.Text = "Listado";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(313, 268);
            this.Controls.Add(this.gbAlumnos);
            this.Name = "frmAlumno";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.frmAlumno_Load);
            this.gbAlumnos.ResumeLayout(false);
            this.gbAlumnos.PerformLayout();
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
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnRegistrar;
    }
}