namespace Hospital.Presentacion
{
    partial class FrmProcesamiento
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
            this.lblOrdenId = new System.Windows.Forms.Label();
            this.cboOrdenId = new System.Windows.Forms.ComboBox();
            this.lblConforme = new System.Windows.Forms.Label();
            this.chkConforme = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Size = new System.Drawing.Size(1020, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Recibir e iniciar procesamiento";
            // pnlCampos
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Location = new System.Drawing.Point(0, 72);
            this.pnlCampos.Size = new System.Drawing.Size(1070, 610);
            this.pnlCampos.TabIndex = 1;
            this.pnlCampos.AutoScroll = true;
            this.pnlCampos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // lblOrdenId
            this.lblOrdenId.Name = "lblOrdenId";
            this.lblOrdenId.Location = new System.Drawing.Point(28, 12);
            this.lblOrdenId.Size = new System.Drawing.Size(290, 40);
            this.lblOrdenId.TabIndex = 2;
            this.lblOrdenId.Text = "Muestra tomada *";
            // cboOrdenId
            this.cboOrdenId.Name = "cboOrdenId";
            this.cboOrdenId.Location = new System.Drawing.Point(328, 12);
            this.cboOrdenId.Size = new System.Drawing.Size(690, 30);
            this.cboOrdenId.TabIndex = 3;
            this.cboOrdenId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboOrdenId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenId.DropDownWidth = 800;
            // lblConforme
            this.lblConforme.Name = "lblConforme";
            this.lblConforme.Location = new System.Drawing.Point(28, 58);
            this.lblConforme.Size = new System.Drawing.Size(290, 40);
            this.lblConforme.TabIndex = 4;
            this.lblConforme.Text = "Identificación y condiciones conformes";
            // chkConforme
            this.chkConforme.Name = "chkConforme";
            this.chkConforme.Location = new System.Drawing.Point(328, 58);
            this.chkConforme.Size = new System.Drawing.Size(690, 30);
            this.chkConforme.TabIndex = 5;
            this.chkConforme.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
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
            this.pnlCampos.Controls.Add(this.lblOrdenId);
            this.pnlCampos.Controls.Add(this.cboOrdenId);
            this.pnlCampos.Controls.Add(this.lblConforme);
            this.pnlCampos.Controls.Add(this.chkConforme);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 760);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmProcesamiento";
            this.Text = "Sistema Hospital · Recibir e iniciar procesamiento";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Label lblOrdenId;
        private System.Windows.Forms.ComboBox cboOrdenId;
        private System.Windows.Forms.Label lblConforme;
        private System.Windows.Forms.CheckBox chkConforme;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
