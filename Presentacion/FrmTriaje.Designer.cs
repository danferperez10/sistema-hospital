namespace Hospital.Presentacion
{
    partial class FrmTriaje
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
            this.lblAdmisionId = new System.Windows.Forms.Label();
            this.cboAdmisionId = new System.Windows.Forms.ComboBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblPresion = new System.Windows.Forms.Label();
            this.txtPresion = new System.Windows.Forms.TextBox();
            this.lblFC = new System.Windows.Forms.Label();
            this.nudFC = new System.Windows.Forms.NumericUpDown();
            this.lblFR = new System.Windows.Forms.Label();
            this.nudFR = new System.Windows.Forms.NumericUpDown();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.nudTemperatura = new System.Windows.Forms.NumericUpDown();
            this.lblSaturacion = new System.Windows.Forms.Label();
            this.nudSaturacion = new System.Windows.Forms.NumericUpDown();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.nudPrioridad = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemperatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrioridad)).BeginInit();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Size = new System.Drawing.Size(1020, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar triaje";
            // pnlCampos
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Location = new System.Drawing.Point(0, 72);
            this.pnlCampos.Size = new System.Drawing.Size(1070, 610);
            this.pnlCampos.TabIndex = 1;
            this.pnlCampos.AutoScroll = true;
            this.pnlCampos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // lblAdmisionId
            this.lblAdmisionId.Name = "lblAdmisionId";
            this.lblAdmisionId.Location = new System.Drawing.Point(28, 12);
            this.lblAdmisionId.Size = new System.Drawing.Size(290, 40);
            this.lblAdmisionId.TabIndex = 2;
            this.lblAdmisionId.Text = "Admisión de emergencia *";
            // cboAdmisionId
            this.cboAdmisionId.Name = "cboAdmisionId";
            this.cboAdmisionId.Location = new System.Drawing.Point(328, 12);
            this.cboAdmisionId.Size = new System.Drawing.Size(690, 30);
            this.cboAdmisionId.TabIndex = 3;
            this.cboAdmisionId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboAdmisionId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdmisionId.DropDownWidth = 800;
            // lblMotivo
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Location = new System.Drawing.Point(28, 58);
            this.lblMotivo.Size = new System.Drawing.Size(290, 40);
            this.lblMotivo.TabIndex = 4;
            this.lblMotivo.Text = "Motivo, signos y síntomas *";
            // txtMotivo
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Location = new System.Drawing.Point(328, 58);
            this.txtMotivo.Size = new System.Drawing.Size(690, 66);
            this.txtMotivo.TabIndex = 5;
            this.txtMotivo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtMotivo.MaxLength = 1500;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // lblPresion
            this.lblPresion.Name = "lblPresion";
            this.lblPresion.Location = new System.Drawing.Point(28, 140);
            this.lblPresion.Size = new System.Drawing.Size(290, 40);
            this.lblPresion.TabIndex = 6;
            this.lblPresion.Text = "Presión arterial (ej. 120/80) *";
            // txtPresion
            this.txtPresion.Name = "txtPresion";
            this.txtPresion.Location = new System.Drawing.Point(328, 140);
            this.txtPresion.Size = new System.Drawing.Size(690, 30);
            this.txtPresion.TabIndex = 7;
            this.txtPresion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtPresion.MaxLength = 200;
            // lblFC
            this.lblFC.Name = "lblFC";
            this.lblFC.Location = new System.Drawing.Point(28, 186);
            this.lblFC.Size = new System.Drawing.Size(290, 40);
            this.lblFC.TabIndex = 8;
            this.lblFC.Text = "Frecuencia cardiaca *";
            // nudFC
            this.nudFC.Name = "nudFC";
            this.nudFC.Location = new System.Drawing.Point(328, 186);
            this.nudFC.Size = new System.Drawing.Size(690, 30);
            this.nudFC.TabIndex = 9;
            this.nudFC.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.nudFC.Maximum = new decimal (new int[] { 100000, 0, 0, 0 });
            this.nudFC.DecimalPlaces = 0;
            // lblFR
            this.lblFR.Name = "lblFR";
            this.lblFR.Location = new System.Drawing.Point(28, 232);
            this.lblFR.Size = new System.Drawing.Size(290, 40);
            this.lblFR.TabIndex = 10;
            this.lblFR.Text = "Frecuencia respiratoria *";
            // nudFR
            this.nudFR.Name = "nudFR";
            this.nudFR.Location = new System.Drawing.Point(328, 232);
            this.nudFR.Size = new System.Drawing.Size(690, 30);
            this.nudFR.TabIndex = 11;
            this.nudFR.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.nudFR.Maximum = new decimal (new int[] { 100000, 0, 0, 0 });
            this.nudFR.DecimalPlaces = 0;
            // lblTemperatura
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Location = new System.Drawing.Point(28, 278);
            this.lblTemperatura.Size = new System.Drawing.Size(290, 40);
            this.lblTemperatura.TabIndex = 12;
            this.lblTemperatura.Text = "Temperatura °C *";
            // nudTemperatura
            this.nudTemperatura.Name = "nudTemperatura";
            this.nudTemperatura.Location = new System.Drawing.Point(328, 278);
            this.nudTemperatura.Size = new System.Drawing.Size(690, 30);
            this.nudTemperatura.TabIndex = 13;
            this.nudTemperatura.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.nudTemperatura.Maximum = new decimal (new int[] { 100000, 0, 0, 0 });
            this.nudTemperatura.DecimalPlaces = 2;
            // lblSaturacion
            this.lblSaturacion.Name = "lblSaturacion";
            this.lblSaturacion.Location = new System.Drawing.Point(28, 324);
            this.lblSaturacion.Size = new System.Drawing.Size(290, 40);
            this.lblSaturacion.TabIndex = 14;
            this.lblSaturacion.Text = "Saturación % *";
            // nudSaturacion
            this.nudSaturacion.Name = "nudSaturacion";
            this.nudSaturacion.Location = new System.Drawing.Point(328, 324);
            this.nudSaturacion.Size = new System.Drawing.Size(690, 30);
            this.nudSaturacion.TabIndex = 15;
            this.nudSaturacion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.nudSaturacion.Maximum = new decimal (new int[] { 100000, 0, 0, 0 });
            this.nudSaturacion.DecimalPlaces = 2;
            // lblPrioridad
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Location = new System.Drawing.Point(28, 370);
            this.lblPrioridad.Size = new System.Drawing.Size(290, 40);
            this.lblPrioridad.TabIndex = 16;
            this.lblPrioridad.Text = "Prioridad I a IV (1 a 4) *";
            // nudPrioridad
            this.nudPrioridad.Name = "nudPrioridad";
            this.nudPrioridad.Location = new System.Drawing.Point(328, 370);
            this.nudPrioridad.Size = new System.Drawing.Size(690, 30);
            this.nudPrioridad.TabIndex = 17;
            this.nudPrioridad.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.nudPrioridad.Maximum = new decimal (new int[] { 100000, 0, 0, 0 });
            this.nudPrioridad.DecimalPlaces = 0;
            // btnGuardar
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Location = new System.Drawing.Point(28, 706);
            this.btnGuardar.Size = new System.Drawing.Size(170, 34);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // btnCancelar
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Location = new System.Drawing.Point(215, 706);
            this.btnCancelar.Size = new System.Drawing.Size(150, 34);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlCampos);
            this.pnlCampos.Controls.Add(this.lblAdmisionId);
            this.pnlCampos.Controls.Add(this.cboAdmisionId);
            this.pnlCampos.Controls.Add(this.lblMotivo);
            this.pnlCampos.Controls.Add(this.txtMotivo);
            this.pnlCampos.Controls.Add(this.lblPresion);
            this.pnlCampos.Controls.Add(this.txtPresion);
            this.pnlCampos.Controls.Add(this.lblFC);
            this.pnlCampos.Controls.Add(this.nudFC);
            this.pnlCampos.Controls.Add(this.lblFR);
            this.pnlCampos.Controls.Add(this.nudFR);
            this.pnlCampos.Controls.Add(this.lblTemperatura);
            this.pnlCampos.Controls.Add(this.nudTemperatura);
            this.pnlCampos.Controls.Add(this.lblSaturacion);
            this.pnlCampos.Controls.Add(this.nudSaturacion);
            this.pnlCampos.Controls.Add(this.lblPrioridad);
            this.pnlCampos.Controls.Add(this.nudPrioridad);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 760);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmTriaje";
            this.Text = "Sistema Hospital · Registrar triaje";
            this.Load += new System.EventHandler(this.Formulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemperatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrioridad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Label lblAdmisionId;
        private System.Windows.Forms.ComboBox cboAdmisionId;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblPresion;
        private System.Windows.Forms.TextBox txtPresion;
        private System.Windows.Forms.Label lblFC;
        private System.Windows.Forms.NumericUpDown nudFC;
        private System.Windows.Forms.Label lblFR;
        private System.Windows.Forms.NumericUpDown nudFR;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.NumericUpDown nudTemperatura;
        private System.Windows.Forms.Label lblSaturacion;
        private System.Windows.Forms.NumericUpDown nudSaturacion;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.NumericUpDown nudPrioridad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
