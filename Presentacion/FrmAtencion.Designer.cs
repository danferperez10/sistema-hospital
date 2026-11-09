namespace Hospital.Presentacion
{
    partial class FrmAtencion
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
            this.lblTriajeId = new System.Windows.Forms.Label();
            this.cboTriajeId = new System.Windows.Forms.ComboBox();
            this.lblEvaluacion = new System.Windows.Forms.Label();
            this.txtEvaluacion = new System.Windows.Forms.TextBox();
            this.lblDiagnosticos = new System.Windows.Forms.Label();
            this.txtDiagnosticos = new System.Windows.Forms.TextBox();
            this.lblEvolucion = new System.Windows.Forms.Label();
            this.txtEvolucion = new System.Windows.Forms.TextBox();
            this.lblConducta = new System.Windows.Forms.Label();
            this.cboConducta = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Size = new System.Drawing.Size(1020, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar atención médica";
            // pnlCampos
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Location = new System.Drawing.Point(0, 72);
            this.pnlCampos.Size = new System.Drawing.Size(1070, 610);
            this.pnlCampos.TabIndex = 1;
            this.pnlCampos.AutoScroll = true;
            this.pnlCampos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // lblTriajeId
            this.lblTriajeId.Name = "lblTriajeId";
            this.lblTriajeId.Location = new System.Drawing.Point(28, 12);
            this.lblTriajeId.Size = new System.Drawing.Size(290, 40);
            this.lblTriajeId.TabIndex = 2;
            this.lblTriajeId.Text = "Paciente en cola *";
            // cboTriajeId
            this.cboTriajeId.Name = "cboTriajeId";
            this.cboTriajeId.Location = new System.Drawing.Point(328, 12);
            this.cboTriajeId.Size = new System.Drawing.Size(690, 30);
            this.cboTriajeId.TabIndex = 3;
            this.cboTriajeId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboTriajeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTriajeId.DropDownWidth = 800;
            // lblEvaluacion
            this.lblEvaluacion.Name = "lblEvaluacion";
            this.lblEvaluacion.Location = new System.Drawing.Point(28, 58);
            this.lblEvaluacion.Size = new System.Drawing.Size(290, 40);
            this.lblEvaluacion.TabIndex = 4;
            this.lblEvaluacion.Text = "Evaluación *";
            // txtEvaluacion
            this.txtEvaluacion.Name = "txtEvaluacion";
            this.txtEvaluacion.Location = new System.Drawing.Point(328, 58);
            this.txtEvaluacion.Size = new System.Drawing.Size(690, 66);
            this.txtEvaluacion.TabIndex = 5;
            this.txtEvaluacion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtEvaluacion.MaxLength = 1500;
            this.txtEvaluacion.Multiline = true;
            this.txtEvaluacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // lblDiagnosticos
            this.lblDiagnosticos.Name = "lblDiagnosticos";
            this.lblDiagnosticos.Location = new System.Drawing.Point(28, 140);
            this.lblDiagnosticos.Size = new System.Drawing.Size(290, 40);
            this.lblDiagnosticos.TabIndex = 6;
            this.lblDiagnosticos.Text = "Diagnósticos (uno por línea) *";
            // txtDiagnosticos
            this.txtDiagnosticos.Name = "txtDiagnosticos";
            this.txtDiagnosticos.Location = new System.Drawing.Point(328, 140);
            this.txtDiagnosticos.Size = new System.Drawing.Size(690, 66);
            this.txtDiagnosticos.TabIndex = 7;
            this.txtDiagnosticos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtDiagnosticos.MaxLength = 1500;
            this.txtDiagnosticos.Multiline = true;
            this.txtDiagnosticos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // lblEvolucion
            this.lblEvolucion.Name = "lblEvolucion";
            this.lblEvolucion.Location = new System.Drawing.Point(28, 222);
            this.lblEvolucion.Size = new System.Drawing.Size(290, 40);
            this.lblEvolucion.TabIndex = 8;
            this.lblEvolucion.Text = "Evolución *";
            // txtEvolucion
            this.txtEvolucion.Name = "txtEvolucion";
            this.txtEvolucion.Location = new System.Drawing.Point(328, 222);
            this.txtEvolucion.Size = new System.Drawing.Size(690, 66);
            this.txtEvolucion.TabIndex = 9;
            this.txtEvolucion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtEvolucion.MaxLength = 1500;
            this.txtEvolucion.Multiline = true;
            this.txtEvolucion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // lblConducta
            this.lblConducta.Name = "lblConducta";
            this.lblConducta.Location = new System.Drawing.Point(28, 304);
            this.lblConducta.Size = new System.Drawing.Size(290, 40);
            this.lblConducta.TabIndex = 10;
            this.lblConducta.Text = "Conducta *";
            // cboConducta
            this.cboConducta.Name = "cboConducta";
            this.cboConducta.Location = new System.Drawing.Point(328, 304);
            this.cboConducta.Size = new System.Drawing.Size(690, 30);
            this.cboConducta.TabIndex = 11;
            this.cboConducta.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboConducta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConducta.DropDownWidth = 800;
            // lblDestino
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Location = new System.Drawing.Point(28, 350);
            this.lblDestino.Size = new System.Drawing.Size(290, 40);
            this.lblDestino.TabIndex = 12;
            this.lblDestino.Text = "Destino";
            // txtDestino
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Location = new System.Drawing.Point(328, 350);
            this.txtDestino.Size = new System.Drawing.Size(690, 30);
            this.txtDestino.TabIndex = 13;
            this.txtDestino.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtDestino.MaxLength = 200;
            // btnGuardar
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Location = new System.Drawing.Point(28, 706);
            this.btnGuardar.Size = new System.Drawing.Size(170, 34);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // btnCancelar
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Location = new System.Drawing.Point(215, 706);
            this.btnCancelar.Size = new System.Drawing.Size(150, 34);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.cboConducta.Items.AddRange(new object[] { "Alta", "Observacion", "Hospitalizacion", "Derivacion" });
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlCampos);
            this.pnlCampos.Controls.Add(this.lblTriajeId);
            this.pnlCampos.Controls.Add(this.cboTriajeId);
            this.pnlCampos.Controls.Add(this.lblEvaluacion);
            this.pnlCampos.Controls.Add(this.txtEvaluacion);
            this.pnlCampos.Controls.Add(this.lblDiagnosticos);
            this.pnlCampos.Controls.Add(this.txtDiagnosticos);
            this.pnlCampos.Controls.Add(this.lblEvolucion);
            this.pnlCampos.Controls.Add(this.txtEvolucion);
            this.pnlCampos.Controls.Add(this.lblConducta);
            this.pnlCampos.Controls.Add(this.cboConducta);
            this.pnlCampos.Controls.Add(this.lblDestino);
            this.pnlCampos.Controls.Add(this.txtDestino);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 760);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmAtencion";
            this.Text = "Sistema Hospital · Registrar atención médica";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Label lblTriajeId;
        private System.Windows.Forms.ComboBox cboTriajeId;
        private System.Windows.Forms.Label lblEvaluacion;
        private System.Windows.Forms.TextBox txtEvaluacion;
        private System.Windows.Forms.Label lblDiagnosticos;
        private System.Windows.Forms.TextBox txtDiagnosticos;
        private System.Windows.Forms.Label lblEvolucion;
        private System.Windows.Forms.TextBox txtEvolucion;
        private System.Windows.Forms.Label lblConducta;
        private System.Windows.Forms.ComboBox cboConducta;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
