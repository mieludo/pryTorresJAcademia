namespace pryTorresJAcademia
{
    partial class frmAcademia
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcademia));
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.White;
            this.lblBienvenido.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBienvenido.Location = new System.Drawing.Point(201, 337);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(172, 32);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "¡ Bienvenido !";
            this.lblBienvenido.Click += new System.EventHandler(this.lblBienvenido_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(58, 486);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(227, 43);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Registro ";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.Location = new System.Drawing.Point(291, 486);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(227, 43);
            this.btnAlumnos.TabIndex = 2;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.InitialImage")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(572, 500);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // frmAcademia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 558);
            this.Controls.Add(this.btnAlumnos);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.pbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAcademia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmAcademia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

