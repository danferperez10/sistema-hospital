namespace Hospital.Presentacion
{
    partial class FrmPacientes
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
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTemporal = new System.Windows.Forms.Label();
            this.chkTemporal = new System.Windows.Forms.CheckBox();
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
            this.lblTitulo.Text = "Pacientes";
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
            this.lblDocumento.Text = "Documento";
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
            // lblFechaNacimiento
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Location = new System.Drawing.Point(28, 102);
            this.lblFechaNacimiento.Size = new System.Drawing.Size(290, 40);
            this.lblFechaNacimiento.TabIndex = 11;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // dtpFechaNacimiento
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(328, 102);
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(690, 30);
            this.dtpFechaNacimiento.TabIndex = 12;
            this.dtpFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimiento.ShowCheckBox = true;
            this.dtpFechaNacimiento.Checked = false;
            // lblSexo
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Location = new System.Drawing.Point(28, 148);
            this.lblSexo.Size = new System.Drawing.Size(290, 40);
            this.lblSexo.TabIndex = 13;
            this.lblSexo.Text = "Sexo *";
            // cboSexo
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Location = new System.Drawing.Point(328, 148);
            this.cboSexo.Size = new System.Drawing.Size(690, 30);
            this.cboSexo.TabIndex = 14;
            this.cboSexo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.DropDownWidth = 800;
            // lblDireccion
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Location = new System.Drawing.Point(28, 194);
            this.lblDireccion.Size = new System.Drawing.Size(290, 40);
            this.lblDireccion.TabIndex = 15;
            this.lblDireccion.Text = "Dirección";
            // txtDireccion
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Location = new System.Drawing.Point(328, 194);
            this.txtDireccion.Size = new System.Drawing.Size(690, 30);
            this.txtDireccion.TabIndex = 16;
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtDireccion.MaxLength = 200;
            // lblTelefono
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Location = new System.Drawing.Point(28, 240);
            this.lblTelefono.Size = new System.Drawing.Size(290, 40);
            this.lblTelefono.TabIndex = 17;
            this.lblTelefono.Text = "Teléfono";
            // txtTelefono
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Location = new System.Drawing.Point(328, 240);
            this.txtTelefono.Size = new System.Drawing.Size(690, 30);
            this.txtTelefono.TabIndex = 18;
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtTelefono.MaxLength = 200;
            // lblTemporal
            this.lblTemporal.Name = "lblTemporal";
            this.lblTemporal.Location = new System.Drawing.Point(28, 286);
            this.lblTemporal.Size = new System.Drawing.Size(290, 40);
            this.lblTemporal.TabIndex = 19;
            this.lblTemporal.Text = "Registro temporal";
            // chkTemporal
            this.chkTemporal.Name = "chkTemporal";
            this.chkTemporal.Location = new System.Drawing.Point(328, 286);
            this.chkTemporal.Size = new System.Drawing.Size(690, 30);
            this.chkTemporal.TabIndex = 20;
            this.chkTemporal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
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
            this.cboSexo.Items.AddRange(new object[] { "Femenino", "Masculino", "No registrado" });
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
            this.pnlEdicion.Controls.Add(this.lblFechaNacimiento);
            this.pnlEdicion.Controls.Add(this.dtpFechaNacimiento);
            this.pnlEdicion.Controls.Add(this.lblSexo);
            this.pnlEdicion.Controls.Add(this.cboSexo);
            this.pnlEdicion.Controls.Add(this.lblDireccion);
            this.pnlEdicion.Controls.Add(this.txtDireccion);
            this.pnlEdicion.Controls.Add(this.lblTelefono);
            this.pnlEdicion.Controls.Add(this.txtTelefono);
            this.pnlEdicion.Controls.Add(this.lblTemporal);
            this.pnlEdicion.Controls.Add(this.chkTemporal);
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
            this.Name = "FrmPacientes";
            this.Text = "Sistema Hospital · Pacientes";
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
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTemporal;
        private System.Windows.Forms.CheckBox chkTemporal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnReactivar;
        private System.Windows.Forms.Label lblRegistro;
    }
}
