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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListado));
            this.gbxBuscar = new System.Windows.Forms.GroupBox();
            this.lstPlan = new System.Windows.Forms.ComboBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.MaskedTextBox();
            this.rbPlan = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbTodo = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxBuscar
            // 
            this.gbxBuscar.Controls.Add(this.lstPlan);
            this.gbxBuscar.Controls.Add(this.tbNombre);
            this.gbxBuscar.Controls.Add(this.tbCodigo);
            this.gbxBuscar.Controls.Add(this.rbPlan);
            this.gbxBuscar.Controls.Add(this.rbNombre);
            this.gbxBuscar.Controls.Add(this.rbCodigo);
            this.gbxBuscar.Controls.Add(this.rbTodo);
            this.gbxBuscar.Controls.Add(this.btnBuscar);
            this.gbxBuscar.Location = new System.Drawing.Point(21, 15);
            this.gbxBuscar.Name = "gbxBuscar";
            this.gbxBuscar.Size = new System.Drawing.Size(269, 203);
            this.gbxBuscar.TabIndex = 0;
            this.gbxBuscar.TabStop = false;
            this.gbxBuscar.Text = "Buscar";
            // 
            // lstPlan
            // 
            this.lstPlan.FormattingEnabled = true;
            this.lstPlan.Items.AddRange(new object[] {
            "Plan Mayor",
            "Plan Medio",
            "Plan Chico"});
            this.lstPlan.Location = new System.Drawing.Point(109, 106);
            this.lstPlan.Name = "lstPlan";
            this.lstPlan.Size = new System.Drawing.Size(144, 21);
            this.lstPlan.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(110, 79);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(143, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(110, 51);
            this.tbCodigo.Mask = "0000";
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(143, 20);
            this.tbCodigo.TabIndex = 1;
            // 
            // rbPlan
            // 
            this.rbPlan.AutoSize = true;
            this.rbPlan.Location = new System.Drawing.Point(24, 106);
            this.rbPlan.Name = "rbPlan";
            this.rbPlan.Size = new System.Drawing.Size(46, 17);
            this.rbPlan.TabIndex = 3;
            this.rbPlan.TabStop = true;
            this.rbPlan.Text = "Plan";
            this.rbPlan.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(24, 80);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(62, 17);
            this.rbNombre.TabIndex = 2;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(24, 54);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(58, 17);
            this.rbCodigo.TabIndex = 1;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // rbTodo
            // 
            this.rbTodo.AutoSize = true;
            this.rbTodo.Location = new System.Drawing.Point(24, 30);
            this.rbTodo.Name = "rbTodo";
            this.rbTodo.Size = new System.Drawing.Size(50, 17);
            this.rbTodo.TabIndex = 0;
            this.rbTodo.TabStop = true;
            this.rbTodo.Text = "Todo";
            this.rbTodo.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(90, 155);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Columna2,
            this.Columna3,
            this.Columna4});
            this.dgvMaterias.Location = new System.Drawing.Point(308, 25);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.Size = new System.Drawing.Size(444, 193);
            this.dgvMaterias.TabIndex = 1;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Columna2
            // 
            this.Columna2.HeaderText = "Nombre";
            this.Columna2.Name = "Columna2";
            // 
            // Columna3
            // 
            this.Columna3.HeaderText = "Plan";
            this.Columna3.Name = "Columna3";
            // 
            // Columna4
            // 
            this.Columna4.HeaderText = "Activo";
            this.Columna4.Name = "Columna4";
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(774, 241);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.gbxBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            this.gbxBuscar.ResumeLayout(false);
            this.gbxBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBuscar;
        private System.Windows.Forms.RadioButton rbPlan;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbTodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna4;
        private System.Windows.Forms.MaskedTextBox tbCodigo;
        private System.Windows.Forms.ComboBox lstPlan;
        private System.Windows.Forms.TextBox tbNombre;
    }
}