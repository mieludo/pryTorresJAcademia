namespace pryTorresJAcademia
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.msRegistro = new System.Windows.Forms.MenuStrip();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDePlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // msRegistro
            // 
            this.msRegistro.Dock = System.Windows.Forms.DockStyle.Left;
            this.msRegistro.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.msRegistro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.listadoToolStripMenuItem,
            this.cargaDePlanToolStripMenuItem});
            this.msRegistro.Location = new System.Drawing.Point(0, 0);
            this.msRegistro.Name = "msRegistro";
            this.msRegistro.Size = new System.Drawing.Size(95, 424);
            this.msRegistro.TabIndex = 0;
            this.msRegistro.Text = "menuStrip1";
            // 
            // ssStatus
            // 
            this.ssStatus.Location = new System.Drawing.Point(0, 424);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(552, 22);
            this.ssStatus.TabIndex = 1;
            this.ssStatus.Text = "statusStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(88, 19);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(88, 19);
            this.listadoToolStripMenuItem.Text = "Listado";
            // 
            // cargaDePlanToolStripMenuItem
            // 
            this.cargaDePlanToolStripMenuItem.Name = "cargaDePlanToolStripMenuItem";
            this.cargaDePlanToolStripMenuItem.Size = new System.Drawing.Size(88, 19);
            this.cargaDePlanToolStripMenuItem.Text = "Carga de Plan";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 446);
            this.Controls.Add(this.msRegistro);
            this.Controls.Add(this.ssStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msRegistro;
            this.Name = "frmPrincipal";
            this.Text = "Menú";
            this.msRegistro.ResumeLayout(false);
            this.msRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msRegistro;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripMenuItem cargaDePlanToolStripMenuItem;
    }
}