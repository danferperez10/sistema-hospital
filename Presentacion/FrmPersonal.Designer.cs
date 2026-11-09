namespace Hospital.Presentacion
{
    partial class FrmPersonal
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.pnlEdicion = new System.Windows.Forms.Panel();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblEspecialidadId = new System.Windows.Forms.Label();
            this.cboEspecialidadId = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnReactivar = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Size = new System.Drawing.Size(800, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Personal y usuarios";
            // txtBuscar
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Location = new System.Drawing.Point(28, 65);
            this.txtBuscar.Size = new System.Drawing.Size(330, 30);
            this.txtBuscar.TabIndex = 1;
            // btnBuscar
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Location = new System.Drawing.Point(375, 63);
            this.btnBuscar.Size = new System.Drawing.Size(140, 34);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // btnNuevo
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Location = new System.Drawing.Point(525, 63);
            this.btnNuevo.Size = new System.Drawing.Size(140, 34);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // btnEditar
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Location = new System.Drawing.Point(675, 63);
            this.btnEditar.Size = new System.Drawing.Size(140, 34);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar fila";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // dgvListado
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Location = new System.Drawing.Point(28, 110);
            this.dgvListado.Size = new System.Drawing.Size(1020, 215);
            this.dgvListado.TabIndex = 5;
            this.dgvListado.ReadOnly = true;
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.MultiSelect = false;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListado.RowHeadersVisible = false;
            this.dgvListado.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // pnlEdicion
            this.pnlEdicion.Name = "pnlEdicion";
            this.pnlEdicion.Location = new System.Drawing.Point(0, 345);
            this.pnlEdicion.Size = new System.Drawing.Size(1070, 405);
            this.pnlEdicion.TabIndex = 6;
            this.pnlEdicion.AutoScroll = true;
            this.pnlEdicion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // lblDocumento
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Location = new System.Drawing.Point(28, 10);
            this.lblDocumento.Size = new System.Drawing.Size(290, 40);
            this.lblDocumento.TabIndex = 7;
            this.lblDocumento.Text = "Documento *";
            // txtDocumento
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Location = new System.Drawing.Point(328, 10);
            this.txtDocumento.Size = new System.Drawing.Size(690, 30);
            this.txtDocumento.TabIndex = 8;
            this.txtDocumento.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtDocumento.MaxLength = 200;
            // lblNombres
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Location = new System.Drawing.Point(28, 56);
            this.lblNombres.Size = new System.Drawing.Size(290, 40);
            this.lblNombres.TabIndex = 9;
            this.lblNombres.Text = "Nombres completos *";
            // txtNombres
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Location = new System.Drawing.Point(328, 56);
            this.txtNombres.Size = new System.Drawing.Size(690, 30);
            this.txtNombres.TabIndex = 10;
            this.txtNombres.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtNombres.MaxLength = 200;
            // lblCargo
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Location = new System.Drawing.Point(28, 102);
            this.lblCargo.Size = new System.Drawing.Size(290, 40);
            this.lblCargo.TabIndex = 11;
            this.lblCargo.Text = "Cargo *";
            // txtCargo
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Location = new System.Drawing.Point(328, 102);
            this.txtCargo.Size = new System.Drawing.Size(690, 30);
            this.txtCargo.TabIndex = 12;
            this.txtCargo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtCargo.MaxLength = 200;
            // lblEspecialidadId
            this.lblEspecialidadId.Name = "lblEspecialidadId";
            this.lblEspecialidadId.Location = new System.Drawing.Point(28, 148);
            this.lblEspecialidadId.Size = new System.Drawing.Size(290, 40);
            this.lblEspecialidadId.TabIndex = 13;
            this.lblEspecialidadId.Text = "Especialidad";
            // cboEspecialidadId
            this.cboEspecialidadId.Name = "cboEspecialidadId";
            this.cboEspecialidadId.Location = new System.Drawing.Point(328, 148);
            this.cboEspecialidadId.Size = new System.Drawing.Size(690, 30);
            this.cboEspecialidadId.TabIndex = 14;
            this.cboEspecialidadId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboEspecialidadId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidadId.DropDownWidth = 800;
            // lblUsuario
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Location = new System.Drawing.Point(28, 194);
            this.lblUsuario.Size = new System.Drawing.Size(290, 40);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "Usuario *";
            // txtUsuario
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Location = new System.Drawing.Point(328, 194);
            this.txtUsuario.Size = new System.Drawing.Size(690, 30);
            this.txtUsuario.TabIndex = 16;
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtUsuario.MaxLength = 200;
            // lblRol
            this.lblRol.Name = "lblRol";
            this.lblRol.Location = new System.Drawing.Point(28, 240);
            this.lblRol.Size = new System.Drawing.Size(290, 40);
            this.lblRol.TabIndex = 17;
            this.lblRol.Text = "Rol *";
            // cboRol
            this.cboRol.Name = "cboRol";
            this.cboRol.Location = new System.Drawing.Point(328, 240);
            this.cboRol.Size = new System.Drawing.Size(690, 30);
            this.cboRol.TabIndex = 18;
            this.cboRol.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.DropDownWidth = 800;
            // lblClave
            this.lblClave.Name = "lblClave";
            this.lblClave.Location = new System.Drawing.Point(28, 286);
            this.lblClave.Size = new System.Drawing.Size(290, 40);
            this.lblClave.TabIndex = 19;
            this.lblClave.Text = "Contraseña nueva (12 caracteres)";
            // txtClave
            this.txtClave.Name = "txtClave";
            this.txtClave.Location = new System.Drawing.Point(328, 286);
            this.txtClave.Size = new System.Drawing.Size(690, 30);
            this.txtClave.TabIndex = 20;
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtClave.MaxLength = 200;
            this.txtClave.UseSystemPasswordChar = true;
            // btnGuardar
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Location = new System.Drawing.Point(28, 770);
            this.btnGuardar.Size = new System.Drawing.Size(140, 34);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // btnInhabilitar
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Location = new System.Drawing.Point(185, 770);
            this.btnInhabilitar.Size = new System.Drawing.Size(140, 34);
            this.btnInhabilitar.TabIndex = 22;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // btnReactivar
            this.btnReactivar.Name = "btnReactivar";
            this.btnReactivar.Location = new System.Drawing.Point(342, 770);
            this.btnReactivar.Size = new System.Drawing.Size(140, 34);
            this.btnReactivar.TabIndex = 23;
            this.btnReactivar.Text = "Reactivar";
            this.btnReactivar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnReactivar.Click += new System.EventHandler(this.btnReactivar_Click);
            // lblRegistro
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Location = new System.Drawing.Point(510, 775);
            this.lblRegistro.Size = new System.Drawing.Size(530, 30);
            this.lblRegistro.TabIndex = 24;
            this.lblRegistro.Text = "Nuevo registro";
            this.lblRegistro.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.cboRol.Items.AddRange(new object[] { "Administrador", "Recepcionista", "Enfermero", "Medico", "Tecnico", "Profesional" });
            this.dgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellDoubleClick);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.pnlEdicion);
            this.pnlEdicion.Controls.Add(this.lblDocumento);
            this.pnlEdicion.Controls.Add(this.txtDocumento);
            this.pnlEdicion.Controls.Add(this.lblNombres);
            this.pnlEdicion.Controls.Add(this.txtNombres);
            this.pnlEdicion.Controls.Add(this.lblCargo);
            this.pnlEdicion.Controls.Add(this.txtCargo);
            this.pnlEdicion.Controls.Add(this.lblEspecialidadId);
            this.pnlEdicion.Controls.Add(this.cboEspecialidadId);
            this.pnlEdicion.Controls.Add(this.lblUsuario);
            this.pnlEdicion.Controls.Add(this.txtUsuario);
            this.pnlEdicion.Controls.Add(this.lblRol);
            this.pnlEdicion.Controls.Add(this.cboRol);
            this.pnlEdicion.Controls.Add(this.lblClave);
            this.pnlEdicion.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnReactivar);
            this.Controls.Add(this.lblRegistro);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 820);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmPersonal";
            this.Text = "Sistema Hospital · Personal y usuarios";
            this.Load += new System.EventHandler(this.Formulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Panel pnlEdicion;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblEspecialidadId;
        private System.Windows.Forms.ComboBox cboEspecialidadId;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnReactivar;
        private System.Windows.Forms.Label lblRegistro;
    }
}
