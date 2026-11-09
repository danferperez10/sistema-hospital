namespace Hospital.Presentacion
{
    partial class FrmTomaMuestra
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblIdentidad = new System.Windows.Forms.Label();
            this.chkIdentidad = new System.Windows.Forms.CheckBox();
            this.lblRotulada = new System.Windows.Forms.Label();
            this.chkRotulada = new System.Windows.Forms.CheckBox();
            this.lblTrasladada = new System.Windows.Forms.Label();
            this.chkTrasladada = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Size = new System.Drawing.Size(1020, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar toma y traslado de muestra";
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
            this.lblOrdenId.Text = "Orden pendiente *";
            // cboOrdenId
            this.cboOrdenId.Name = "cboOrdenId";
            this.cboOrdenId.Location = new System.Drawing.Point(328, 12);
            this.cboOrdenId.Size = new System.Drawing.Size(690, 30);
            this.cboOrdenId.TabIndex = 3;
            this.cboOrdenId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboOrdenId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenId.DropDownWidth = 800;
            // lblCodigo
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Location = new System.Drawing.Point(28, 58);
            this.lblCodigo.Size = new System.Drawing.Size(290, 40);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Código para rotular (copiar antes de confirmar) *";
            // txtCodigo
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Location = new System.Drawing.Point(328, 58);
            this.txtCodigo.Size = new System.Drawing.Size(690, 30);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtCodigo.MaxLength = 200;
            this.txtCodigo.ReadOnly = true;
            // lblIdentidad
            this.lblIdentidad.Name = "lblIdentidad";
            this.lblIdentidad.Location = new System.Drawing.Point(28, 104);
            this.lblIdentidad.Size = new System.Drawing.Size(290, 40);
            this.lblIdentidad.TabIndex = 6;
            this.lblIdentidad.Text = "Identidad confirmada";
            // chkIdentidad
            this.chkIdentidad.Name = "chkIdentidad";
            this.chkIdentidad.Location = new System.Drawing.Point(328, 104);
            this.chkIdentidad.Size = new System.Drawing.Size(690, 30);
            this.chkIdentidad.TabIndex = 7;
            this.chkIdentidad.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // lblRotulada
            this.lblRotulada.Name = "lblRotulada";
            this.lblRotulada.Location = new System.Drawing.Point(28, 150);
            this.lblRotulada.Size = new System.Drawing.Size(290, 40);
            this.lblRotulada.TabIndex = 8;
            this.lblRotulada.Text = "Recipiente rotulado";
            // chkRotulada
            this.chkRotulada.Name = "chkRotulada";
            this.chkRotulada.Location = new System.Drawing.Point(328, 150);
            this.chkRotulada.Size = new System.Drawing.Size(690, 30);
            this.chkRotulada.TabIndex = 9;
            this.chkRotulada.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // lblTrasladada
            this.lblTrasladada.Name = "lblTrasladada";
            this.lblTrasladada.Location = new System.Drawing.Point(28, 196);
            this.lblTrasladada.Size = new System.Drawing.Size(290, 40);
            this.lblTrasladada.TabIndex = 10;
            this.lblTrasladada.Text = "Traslado realizado";
            // chkTrasladada
            this.chkTrasladada.Name = "chkTrasladada";
            this.chkTrasladada.Location = new System.Drawing.Point(328, 196);
            this.chkTrasladada.Size = new System.Drawing.Size(690, 30);
            this.chkTrasladada.TabIndex = 11;
            this.chkTrasladada.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // btnGuardar
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Location = new System.Drawing.Point(28, 706);
            this.btnGuardar.Size = new System.Drawing.Size(170, 34);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // btnCancelar
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Location = new System.Drawing.Point(215, 706);
            this.btnCancelar.Size = new System.Drawing.Size(150, 34);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlCampos);
            this.pnlCampos.Controls.Add(this.lblOrdenId);
            this.pnlCampos.Controls.Add(this.cboOrdenId);
            this.pnlCampos.Controls.Add(this.lblCodigo);
            this.pnlCampos.Controls.Add(this.txtCodigo);
            this.pnlCampos.Controls.Add(this.lblIdentidad);
            this.pnlCampos.Controls.Add(this.chkIdentidad);
            this.pnlCampos.Controls.Add(this.lblRotulada);
            this.pnlCampos.Controls.Add(this.chkRotulada);
            this.pnlCampos.Controls.Add(this.lblTrasladada);
            this.pnlCampos.Controls.Add(this.chkTrasladada);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 760);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmTomaMuestra";
            this.Text = "Sistema Hospital · Registrar toma y traslado de muestra";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Label lblOrdenId;
        private System.Windows.Forms.ComboBox cboOrdenId;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblIdentidad;
        private System.Windows.Forms.CheckBox chkIdentidad;
        private System.Windows.Forms.Label lblRotulada;
        private System.Windows.Forms.CheckBox chkRotulada;
        private System.Windows.Forms.Label lblTrasladada;
        private System.Windows.Forms.CheckBox chkTrasladada;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
