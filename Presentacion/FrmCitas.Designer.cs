namespace Hospital.Presentacion
{
    partial class FrmCitas
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
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.lblPacienteId = new System.Windows.Forms.Label();
            this.cboPacienteId = new System.Windows.Forms.ComboBox();
            this.lblMedicoId = new System.Windows.Forms.Label();
            this.cboMedicoId = new System.Windows.Forms.ComboBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Size = new System.Drawing.Size(1020, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Programar cita";
            // pnlCampos
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Location = new System.Drawing.Point(0, 72);
            this.pnlCampos.Size = new System.Drawing.Size(1070, 610);
            this.pnlCampos.TabIndex = 1;
            this.pnlCampos.AutoScroll = true;
            this.pnlCampos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // lblPacienteId
            this.lblPacienteId.Name = "lblPacienteId";
            this.lblPacienteId.Location = new System.Drawing.Point(28, 12);
            this.lblPacienteId.Size = new System.Drawing.Size(290, 40);
            this.lblPacienteId.TabIndex = 2;
            this.lblPacienteId.Text = "Paciente *";
            // cboPacienteId
            this.cboPacienteId.Name = "cboPacienteId";
            this.cboPacienteId.Location = new System.Drawing.Point(328, 12);
            this.cboPacienteId.Size = new System.Drawing.Size(690, 30);
            this.cboPacienteId.TabIndex = 3;
            this.cboPacienteId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboPacienteId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPacienteId.DropDownWidth = 800;
            // lblMedicoId
            this.lblMedicoId.Name = "lblMedicoId";
            this.lblMedicoId.Location = new System.Drawing.Point(28, 58);
            this.lblMedicoId.Size = new System.Drawing.Size(290, 40);
            this.lblMedicoId.TabIndex = 4;
            this.lblMedicoId.Text = "Médico *";
            // cboMedicoId
            this.cboMedicoId.Name = "cboMedicoId";
            this.cboMedicoId.Location = new System.Drawing.Point(328, 58);
            this.cboMedicoId.Size = new System.Drawing.Size(690, 30);
            this.cboMedicoId.TabIndex = 5;
            this.cboMedicoId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboMedicoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedicoId.DropDownWidth = 800;
            // lblInicio
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Location = new System.Drawing.Point(28, 104);
            this.lblInicio.Size = new System.Drawing.Size(290, 40);
            this.lblInicio.TabIndex = 6;
            this.lblInicio.Text = "Fecha y hora de cita *";
            // dtpInicio
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Location = new System.Drawing.Point(328, 104);
            this.dtpInicio.Size = new System.Drawing.Size(690, 30);
            this.dtpInicio.TabIndex = 7;
            this.dtpInicio.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            // btnGuardar
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Location = new System.Drawing.Point(28, 706);
            this.btnGuardar.Size = new System.Drawing.Size(170, 34);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // btnCancelar
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Location = new System.Drawing.Point(215, 706);
            this.btnCancelar.Size = new System.Drawing.Size(150, 34);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlCampos);
            this.pnlCampos.Controls.Add(this.lblPacienteId);
            this.pnlCampos.Controls.Add(this.cboPacienteId);
            this.pnlCampos.Controls.Add(this.lblMedicoId);
            this.pnlCampos.Controls.Add(this.cboMedicoId);
            this.pnlCampos.Controls.Add(this.lblInicio);
            this.pnlCampos.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 760);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmCitas";
            this.Text = "Sistema Hospital · Programar cita";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Label lblPacienteId;
        private System.Windows.Forms.ComboBox cboPacienteId;
        private System.Windows.Forms.Label lblMedicoId;
        private System.Windows.Forms.ComboBox cboMedicoId;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
