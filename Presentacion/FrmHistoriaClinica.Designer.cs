namespace Hospital.Presentacion
{
    partial class FrmHistoriaClinica
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

#region Código generado para el diseñador de Windows Forms
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.cboPaciente = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Size = new System.Drawing.Size(1000, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Historia clínica";
            // lblPaciente
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Location = new System.Drawing.Point(28, 75);
            this.lblPaciente.Size = new System.Drawing.Size(290, 40);
            this.lblPaciente.TabIndex = 1;
            this.lblPaciente.Text = "Paciente *";
            // cboPaciente
            this.cboPaciente.Name = "cboPaciente";
            this.cboPaciente.Location = new System.Drawing.Point(328, 75);
            this.cboPaciente.Size = new System.Drawing.Size(690, 30);
            this.cboPaciente.TabIndex = 2;
            this.cboPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaciente.DropDownWidth = 800;
            // btnConsultar
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Location = new System.Drawing.Point(28, 125);
            this.btnConsultar.Size = new System.Drawing.Size(170, 34);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // dgvListado
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Location = new System.Drawing.Point(28, 175);
            this.dgvListado.Size = new System.Drawing.Size(1020, 559);
            this.dgvListado.TabIndex = 4;
            this.dgvListado.ReadOnly = true;
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.MultiSelect = false;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListado.RowHeadersVisible = false;
            this.dgvListado.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.cboPaciente);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvListado);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 760);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmHistoriaClinica";
            this.Text = "Sistema Hospital · Historia clínica";
            this.Load += new System.EventHandler(this.Formulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.ComboBox cboPaciente;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvListado;
    }
}
