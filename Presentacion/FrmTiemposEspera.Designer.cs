namespace Hospital.Presentacion
{
    partial class FrmTiemposEspera
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
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.cboPaciente = new System.Windows.Forms.ComboBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.cboMedico = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Size = new System.Drawing.Size(1000, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Atenciones y tiempos de espera";
            // lblDesde
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Location = new System.Drawing.Point(28, 75);
            this.lblDesde.Size = new System.Drawing.Size(290, 40);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "Desde *";
            // dtpDesde
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Location = new System.Drawing.Point(328, 75);
            this.dtpDesde.Size = new System.Drawing.Size(690, 30);
            this.dtpDesde.TabIndex = 2;
            this.dtpDesde.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.CustomFormat = "dd/MM/yyyy";
            // lblHasta
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Location = new System.Drawing.Point(28, 121);
            this.lblHasta.Size = new System.Drawing.Size(290, 40);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta *";
            // dtpHasta
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Location = new System.Drawing.Point(328, 121);
            this.dtpHasta.Size = new System.Drawing.Size(690, 30);
            this.dtpHasta.TabIndex = 4;
            this.dtpHasta.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.CustomFormat = "dd/MM/yyyy";
            // lblPaciente
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Location = new System.Drawing.Point(28, 167);
            this.lblPaciente.Size = new System.Drawing.Size(290, 40);
            this.lblPaciente.TabIndex = 5;
            this.lblPaciente.Text = "Paciente";
            // cboPaciente
            this.cboPaciente.Name = "cboPaciente";
            this.cboPaciente.Location = new System.Drawing.Point(328, 167);
            this.cboPaciente.Size = new System.Drawing.Size(690, 30);
            this.cboPaciente.TabIndex = 6;
            this.cboPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaciente.DropDownWidth = 800;
            // lblMedico
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Location = new System.Drawing.Point(28, 213);
            this.lblMedico.Size = new System.Drawing.Size(290, 40);
            this.lblMedico.TabIndex = 7;
            this.lblMedico.Text = "Médico";
            // cboMedico
            this.cboMedico.Name = "cboMedico";
            this.cboMedico.Location = new System.Drawing.Point(328, 213);
            this.cboMedico.Size = new System.Drawing.Size(690, 30);
            this.cboMedico.TabIndex = 8;
            this.cboMedico.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedico.DropDownWidth = 800;
            // btnConsultar
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Location = new System.Drawing.Point(28, 263);
            this.btnConsultar.Size = new System.Drawing.Size(170, 34);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // dgvListado
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Location = new System.Drawing.Point(28, 313);
            this.dgvListado.Size = new System.Drawing.Size(1020, 421);
            this.dgvListado.TabIndex = 10;
            this.dgvListado.ReadOnly = true;
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.MultiSelect = false;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListado.RowHeadersVisible = false;
            this.dgvListado.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.cboPaciente);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.cboMedico);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvListado);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 760);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmTiemposEspera";
            this.Text = "Sistema Hospital · Atenciones y tiempos de espera";
            this.Load += new System.EventHandler(this.Formulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.ComboBox cboPaciente;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox cboMedico;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvListado;
    }
}
