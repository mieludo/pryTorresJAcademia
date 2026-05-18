namespace pryTorresJAcademia
{
    partial class frmListado
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
            this.gbxBuscar = new System.Windows.Forms.GroupBox();
            this.chbTodo = new System.Windows.Forms.CheckBox();
            this.chbCodigo = new System.Windows.Forms.CheckBox();
            this.chbNombre = new System.Windows.Forms.CheckBox();
            this.chbPlan = new System.Windows.Forms.CheckBox();
            this.gbxBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBuscar
            // 
            this.gbxBuscar.Controls.Add(this.chbPlan);
            this.gbxBuscar.Controls.Add(this.chbNombre);
            this.gbxBuscar.Controls.Add(this.chbCodigo);
            this.gbxBuscar.Controls.Add(this.chbTodo);
            this.gbxBuscar.Location = new System.Drawing.Point(21, 15);
            this.gbxBuscar.Name = "gbxBuscar";
            this.gbxBuscar.Size = new System.Drawing.Size(333, 249);
            this.gbxBuscar.TabIndex = 0;
            this.gbxBuscar.TabStop = false;
            this.gbxBuscar.Text = "Buscar";
            // 
            // chbTodo
            // 
            this.chbTodo.AutoSize = true;
            this.chbTodo.Location = new System.Drawing.Point(30, 35);
            this.chbTodo.Name = "chbTodo";
            this.chbTodo.Size = new System.Drawing.Size(51, 17);
            this.chbTodo.TabIndex = 0;
            this.chbTodo.Text = "Todo";
            this.chbTodo.UseVisualStyleBackColor = true;
            // 
            // chbCodigo
            // 
            this.chbCodigo.AutoSize = true;
            this.chbCodigo.Location = new System.Drawing.Point(30, 58);
            this.chbCodigo.Name = "chbCodigo";
            this.chbCodigo.Size = new System.Drawing.Size(59, 17);
            this.chbCodigo.TabIndex = 1;
            this.chbCodigo.Text = "Código";
            this.chbCodigo.UseVisualStyleBackColor = true;
            // 
            // chbNombre
            // 
            this.chbNombre.AutoSize = true;
            this.chbNombre.Location = new System.Drawing.Point(30, 81);
            this.chbNombre.Name = "chbNombre";
            this.chbNombre.Size = new System.Drawing.Size(63, 17);
            this.chbNombre.TabIndex = 2;
            this.chbNombre.Text = "Nombre";
            this.chbNombre.UseVisualStyleBackColor = true;
            // 
            // chbPlan
            // 
            this.chbPlan.AutoSize = true;
            this.chbPlan.Location = new System.Drawing.Point(30, 104);
            this.chbPlan.Name = "chbPlan";
            this.chbPlan.Size = new System.Drawing.Size(47, 17);
            this.chbPlan.TabIndex = 3;
            this.chbPlan.Text = "Plan";
            this.chbPlan.UseVisualStyleBackColor = true;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(377, 291);
            this.Controls.Add(this.gbxBuscar);
            this.MaximizeBox = false;
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.gbxBuscar.ResumeLayout(false);
            this.gbxBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBuscar;
        private System.Windows.Forms.CheckBox chbPlan;
        private System.Windows.Forms.CheckBox chbNombre;
        private System.Windows.Forms.CheckBox chbCodigo;
        private System.Windows.Forms.CheckBox chbTodo;
    }
}