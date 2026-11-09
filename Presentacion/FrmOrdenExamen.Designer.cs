namespace Hospital.Presentacion
{
    partial class FrmOrdenExamen
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
            this.lblAtencionId = new System.Windows.Forms.Label();
            this.cboAtencionId = new System.Windows.Forms.ComboBox();
            this.lblExamenId = new System.Windows.Forms.Label();
            this.cboExamenId = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Size = new System.Drawing.Size(1020, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Solicitar examen";
            // pnlCampos
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Location = new System.Drawing.Point(0, 72);
            this.pnlCampos.Size = new System.Drawing.Size(1070, 610);
            this.pnlCampos.TabIndex = 1;
            this.pnlCampos.AutoScroll = true;
            this.pnlCampos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // lblAtencionId
            this.lblAtencionId.Name = "lblAtencionId";
            this.lblAtencionId.Location = new System.Drawing.Point(28, 12);
            this.lblAtencionId.Size = new System.Drawing.Size(290, 40);
            this.lblAtencionId.TabIndex = 2;
            this.lblAtencionId.Text = "Atención propia *";
            // cboAtencionId
            this.cboAtencionId.Name = "cboAtencionId";
            this.cboAtencionId.Location = new System.Drawing.Point(328, 12);
            this.cboAtencionId.Size = new System.Drawing.Size(690, 30);
            this.cboAtencionId.TabIndex = 3;
            this.cboAtencionId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboAtencionId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAtencionId.DropDownWidth = 800;
            // lblExamenId
            this.lblExamenId.Name = "lblExamenId";
            this.lblExamenId.Location = new System.Drawing.Point(28, 58);
            this.lblExamenId.Size = new System.Drawing.Size(290, 40);
            this.lblExamenId.TabIndex = 4;
            this.lblExamenId.Text = "Examen *";
            // cboExamenId
            this.cboExamenId.Name = "cboExamenId";
            this.cboExamenId.Location = new System.Drawing.Point(328, 58);
            this.cboExamenId.Size = new System.Drawing.Size(690, 30);
            this.cboExamenId.TabIndex = 5;
            this.cboExamenId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboExamenId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExamenId.DropDownWidth = 800;
            // btnGuardar
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Location = new System.Drawing.Point(28, 706);
            this.btnGuardar.Size = new System.Drawing.Size(170, 34);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // btnCancelar
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Location = new System.Drawing.Point(215, 706);
            this.btnCancelar.Size = new System.Drawing.Size(150, 34);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlCampos);
            this.pnlCampos.Controls.Add(this.lblAtencionId);
            this.pnlCampos.Controls.Add(this.cboAtencionId);
            this.pnlCampos.Controls.Add(this.lblExamenId);
            this.pnlCampos.Controls.Add(this.cboExamenId);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 760);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmOrdenExamen";
            this.Text = "Sistema Hospital · Solicitar examen";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Label lblAtencionId;
        private System.Windows.Forms.ComboBox cboAtencionId;
        private System.Windows.Forms.Label lblExamenId;
        private System.Windows.Forms.ComboBox cboExamenId;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
