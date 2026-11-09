namespace Hospital.Presentacion
{
    partial class FrmResultados
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
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblFueraRango = new System.Windows.Forms.Label();
            this.chkFueraRango = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Size = new System.Drawing.Size(1020, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar resultado";
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
            this.lblOrdenId.Text = "Orden en proceso *";
            // cboOrdenId
            this.cboOrdenId.Name = "cboOrdenId";
            this.cboOrdenId.Location = new System.Drawing.Point(328, 12);
            this.cboOrdenId.Size = new System.Drawing.Size(690, 30);
            this.cboOrdenId.TabIndex = 3;
            this.cboOrdenId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboOrdenId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenId.DropDownWidth = 800;
            // lblValor
            this.lblValor.Name = "lblValor";
            this.lblValor.Location = new System.Drawing.Point(28, 58);
            this.lblValor.Size = new System.Drawing.Size(290, 40);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Resultado *";
            // txtValor
            this.txtValor.Name = "txtValor";
            this.txtValor.Location = new System.Drawing.Point(328, 58);
            this.txtValor.Size = new System.Drawing.Size(690, 66);
            this.txtValor.TabIndex = 5;
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtValor.MaxLength = 1500;
            this.txtValor.Multiline = true;
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // lblObservacion
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Location = new System.Drawing.Point(28, 140);
            this.lblObservacion.Size = new System.Drawing.Size(290, 40);
            this.lblObservacion.TabIndex = 6;
            this.lblObservacion.Text = "Observaciones";
            // txtObservacion
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Location = new System.Drawing.Point(328, 140);
            this.txtObservacion.Size = new System.Drawing.Size(690, 66);
            this.txtObservacion.TabIndex = 7;
            this.txtObservacion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtObservacion.MaxLength = 1500;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // lblFueraRango
            this.lblFueraRango.Name = "lblFueraRango";
            this.lblFueraRango.Location = new System.Drawing.Point(28, 222);
            this.lblFueraRango.Size = new System.Drawing.Size(290, 40);
            this.lblFueraRango.TabIndex = 8;
            this.lblFueraRango.Text = "Fuera del rango de referencia";
            // chkFueraRango
            this.chkFueraRango.Name = "chkFueraRango";
            this.chkFueraRango.Location = new System.Drawing.Point(328, 222);
            this.chkFueraRango.Size = new System.Drawing.Size(690, 30);
            this.chkFueraRango.TabIndex = 9;
            this.chkFueraRango.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // btnGuardar
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Location = new System.Drawing.Point(28, 706);
            this.btnGuardar.Size = new System.Drawing.Size(170, 34);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // btnCancelar
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Location = new System.Drawing.Point(215, 706);
            this.btnCancelar.Size = new System.Drawing.Size(150, 34);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlCampos);
            this.pnlCampos.Controls.Add(this.lblOrdenId);
            this.pnlCampos.Controls.Add(this.cboOrdenId);
            this.pnlCampos.Controls.Add(this.lblValor);
            this.pnlCampos.Controls.Add(this.txtValor);
            this.pnlCampos.Controls.Add(this.lblObservacion);
            this.pnlCampos.Controls.Add(this.txtObservacion);
            this.pnlCampos.Controls.Add(this.lblFueraRango);
            this.pnlCampos.Controls.Add(this.chkFueraRango);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 760);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmResultados";
            this.Text = "Sistema Hospital · Registrar resultado";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Label lblOrdenId;
        private System.Windows.Forms.ComboBox cboOrdenId;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblFueraRango;
        private System.Windows.Forms.CheckBox chkFueraRango;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
