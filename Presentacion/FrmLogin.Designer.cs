namespace Hospital.Presentacion
{
    partial class FrmLogin
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
            this.chkMostrarClave = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInicial = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Location = new System.Drawing.Point(60, 30);
            this.lblTitulo.Size = new System.Drawing.Size(550, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SISTEMA HOSPITAL";
            // lblUsuario
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Location = new System.Drawing.Point(60, 100);
            this.lblUsuario.Size = new System.Drawing.Size(280, 30);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // txtUsuario
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Location = new System.Drawing.Point(60, 135);
            this.txtUsuario.Size = new System.Drawing.Size(550, 30);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.MaxLength = 50;
            // lblClave
            this.lblClave.Name = "lblClave";
            this.lblClave.Location = new System.Drawing.Point(60, 180);
            this.lblClave.Size = new System.Drawing.Size(280, 30);
            this.lblClave.TabIndex = 3;
            this.lblClave.Text = "Contraseña";
            // txtClave
            this.txtClave.Name = "txtClave";
            this.txtClave.Location = new System.Drawing.Point(60, 215);
            this.txtClave.Size = new System.Drawing.Size(550, 30);
            this.txtClave.TabIndex = 4;
            this.txtClave.MaxLength = 200;
            this.txtClave.UseSystemPasswordChar = true;
            // chkMostrarClave
            this.chkMostrarClave.Name = "chkMostrarClave";
            this.chkMostrarClave.Location = new System.Drawing.Point(60, 260);
            this.chkMostrarClave.Size = new System.Drawing.Size(250, 28);
            this.chkMostrarClave.TabIndex = 5;
            this.chkMostrarClave.Text = "Mostrar contraseña";
            // btnIngresar
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Location = new System.Drawing.Point(60, 307);
            this.btnIngresar.Size = new System.Drawing.Size(160, 34);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // btnSalir
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Location = new System.Drawing.Point(235, 307);
            this.btnSalir.Size = new System.Drawing.Size(140, 34);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // btnInicial
            this.btnInicial.Name = "btnInicial";
            this.btnInicial.Location = new System.Drawing.Point(60, 355);
            this.btnInicial.Size = new System.Drawing.Size(300, 34);
            this.btnInicial.TabIndex = 8;
            this.btnInicial.Text = "Crear administrador inicial";
            this.btnInicial.Click += new System.EventHandler(this.btnInicial_Click);
            // lblEstado
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Location = new System.Drawing.Point(60, 403);
            this.lblEstado.Size = new System.Drawing.Size(550, 45);
            this.lblEstado.TabIndex = 9;
            this.chkMostrarClave.CheckedChanged += new System.EventHandler(this.chkMostrarClave_CheckedChanged);
            this.AcceptButton = this.btnIngresar;
            this.CancelButton = this.btnSalir;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.chkMostrarClave);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInicial);
            this.Controls.Add(this.lblEstado);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 470);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(680, 470);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmLogin";
            this.Text = "Sistema Hospital · Inicio de sesión";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.CheckBox chkMostrarClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInicial;
        private System.Windows.Forms.Label lblEstado;
    }
}
