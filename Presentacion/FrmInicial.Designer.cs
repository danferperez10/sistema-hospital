namespace Hospital.Presentacion
{
    partial class FrmInicial
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.txtConfirmacion = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Location = new System.Drawing.Point(28, 25);
            this.lblTitulo.Size = new System.Drawing.Size(700, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Crear el primer administrador";
            // lblUsuario
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Location = new System.Drawing.Point(28, 90);
            this.lblUsuario.Size = new System.Drawing.Size(290, 40);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario *";
            // txtUsuario
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Location = new System.Drawing.Point(328, 90);
            this.txtUsuario.Size = new System.Drawing.Size(590, 30);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtUsuario.MaxLength = 200;
            // lblClave
            this.lblClave.Name = "lblClave";
            this.lblClave.Location = new System.Drawing.Point(28, 136);
            this.lblClave.Size = new System.Drawing.Size(290, 40);
            this.lblClave.TabIndex = 3;
            this.lblClave.Text = "Contraseña de al menos 12 caracteres *";
            // txtClave
            this.txtClave.Name = "txtClave";
            this.txtClave.Location = new System.Drawing.Point(328, 136);
            this.txtClave.Size = new System.Drawing.Size(590, 30);
            this.txtClave.TabIndex = 4;
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtClave.MaxLength = 200;
            this.txtClave.UseSystemPasswordChar = true;
            // lblConfirmacion
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Location = new System.Drawing.Point(28, 182);
            this.lblConfirmacion.Size = new System.Drawing.Size(290, 40);
            this.lblConfirmacion.TabIndex = 5;
            this.lblConfirmacion.Text = "Repita la contraseña *";
            // txtConfirmacion
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Location = new System.Drawing.Point(328, 182);
            this.txtConfirmacion.Size = new System.Drawing.Size(590, 30);
            this.txtConfirmacion.TabIndex = 6;
            this.txtConfirmacion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtConfirmacion.MaxLength = 200;
            this.txtConfirmacion.UseSystemPasswordChar = true;
            // btnCrear
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Location = new System.Drawing.Point(28, 248);
            this.btnCrear.Size = new System.Drawing.Size(230, 34);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear administrador";
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblConfirmacion);
            this.Controls.Add(this.txtConfirmacion);
            this.Controls.Add(this.btnCrear);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 430);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(800, 430);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmInicial";
            this.Text = "Sistema Hospital · Crear administrador inicial";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblConfirmacion;
        private System.Windows.Forms.TextBox txtConfirmacion;
        private System.Windows.Forms.Button btnCrear;
    }
}
