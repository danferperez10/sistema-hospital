namespace Hospital.Presentacion
{
    partial class FrmAdministracion
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
            this.lblIndicacionId = new System.Windows.Forms.Label();
            this.cboIndicacionId = new System.Windows.Forms.ComboBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Size = new System.Drawing.Size(1020, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar administración indicada";
            // pnlCampos
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Location = new System.Drawing.Point(0, 72);
            this.pnlCampos.Size = new System.Drawing.Size(1070, 610);
            this.pnlCampos.TabIndex = 1;
            this.pnlCampos.AutoScroll = true;
            this.pnlCampos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // lblIndicacionId
            this.lblIndicacionId.Name = "lblIndicacionId";
            this.lblIndicacionId.Location = new System.Drawing.Point(28, 12);
            this.lblIndicacionId.Size = new System.Drawing.Size(290, 40);
            this.lblIndicacionId.TabIndex = 2;
            this.lblIndicacionId.Text = "Indicación médica *";
            // cboIndicacionId
            this.cboIndicacionId.Name = "cboIndicacionId";
            this.cboIndicacionId.Location = new System.Drawing.Point(328, 12);
            this.cboIndicacionId.Size = new System.Drawing.Size(690, 30);
            this.cboIndicacionId.TabIndex = 3;
            this.cboIndicacionId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboIndicacionId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIndicacionId.DropDownWidth = 800;
            // lblDetalle
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Location = new System.Drawing.Point(28, 58);
            this.lblDetalle.Size = new System.Drawing.Size(290, 40);
            this.lblDetalle.TabIndex = 4;
            this.lblDetalle.Text = "Detalle de lo administrado o realizado *";
            // txtDetalle
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Location = new System.Drawing.Point(328, 58);
            this.txtDetalle.Size = new System.Drawing.Size(690, 66);
            this.txtDetalle.TabIndex = 5;
            this.txtDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtDetalle.MaxLength = 1500;
            this.txtDetalle.Multiline = true;
            this.txtDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
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
            this.pnlCampos.Controls.Add(this.lblIndicacionId);
            this.pnlCampos.Controls.Add(this.cboIndicacionId);
            this.pnlCampos.Controls.Add(this.lblDetalle);
            this.pnlCampos.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 760);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmAdministracion";
            this.Text = "Sistema Hospital · Registrar administración indicada";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Label lblIndicacionId;
        private System.Windows.Forms.ComboBox cboIndicacionId;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
