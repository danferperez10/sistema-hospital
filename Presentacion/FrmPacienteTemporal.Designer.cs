namespace Hospital.Presentacion
{
    partial class FrmPacienteTemporal
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
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Size = new System.Drawing.Size(1020, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Paciente temporal de emergencia";
            // pnlCampos
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Location = new System.Drawing.Point(0, 72);
            this.pnlCampos.Size = new System.Drawing.Size(1070, 610);
            this.pnlCampos.TabIndex = 1;
            this.pnlCampos.AutoScroll = true;
            this.pnlCampos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // lblNombres
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Location = new System.Drawing.Point(28, 12);
            this.lblNombres.Size = new System.Drawing.Size(290, 40);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "Identificación provisional *";
            // txtNombres
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Location = new System.Drawing.Point(328, 12);
            this.txtNombres.Size = new System.Drawing.Size(690, 30);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtNombres.MaxLength = 200;
            // lblSexo
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Location = new System.Drawing.Point(28, 58);
            this.lblSexo.Size = new System.Drawing.Size(290, 40);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo *";
            // cboSexo
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Location = new System.Drawing.Point(328, 58);
            this.cboSexo.Size = new System.Drawing.Size(690, 30);
            this.cboSexo.TabIndex = 5;
            this.cboSexo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.DropDownWidth = 800;
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
            this.cboSexo.Items.AddRange(new object[] { "No registrado", "Femenino", "Masculino" });
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlCampos);
            this.pnlCampos.Controls.Add(this.lblNombres);
            this.pnlCampos.Controls.Add(this.txtNombres);
            this.pnlCampos.Controls.Add(this.lblSexo);
            this.pnlCampos.Controls.Add(this.cboSexo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 760);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmPacienteTemporal";
            this.Text = "Sistema Hospital · Paciente temporal de emergencia";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
