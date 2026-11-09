namespace Hospital.Presentacion
{
    partial class FrmHorarios
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
            this.lblMedicoId = new System.Windows.Forms.Label();
            this.cboMedicoId = new System.Windows.Forms.ComboBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.nudDia = new System.Windows.Forms.NumericUpDown();
            this.lblInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFin = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.nudDuracion = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnReactivar = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).BeginInit();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Size = new System.Drawing.Size(800, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Horarios";
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
            // lblMedicoId
            this.lblMedicoId.Name = "lblMedicoId";
            this.lblMedicoId.Location = new System.Drawing.Point(28, 10);
            this.lblMedicoId.Size = new System.Drawing.Size(290, 40);
            this.lblMedicoId.TabIndex = 7;
            this.lblMedicoId.Text = "Médico *";
            // cboMedicoId
            this.cboMedicoId.Name = "cboMedicoId";
            this.cboMedicoId.Location = new System.Drawing.Point(328, 10);
            this.cboMedicoId.Size = new System.Drawing.Size(690, 30);
            this.cboMedicoId.TabIndex = 8;
            this.cboMedicoId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboMedicoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedicoId.DropDownWidth = 800;
            // lblDia
            this.lblDia.Name = "lblDia";
            this.lblDia.Location = new System.Drawing.Point(28, 56);
            this.lblDia.Size = new System.Drawing.Size(290, 40);
            this.lblDia.TabIndex = 9;
            this.lblDia.Text = "Día (0 domingo a 6 sábado) *";
            // nudDia
            this.nudDia.Name = "nudDia";
            this.nudDia.Location = new System.Drawing.Point(328, 56);
            this.nudDia.Size = new System.Drawing.Size(690, 30);
            this.nudDia.TabIndex = 10;
            this.nudDia.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.nudDia.Maximum = new decimal (new int[] { 100000, 0, 0, 0 });
            this.nudDia.DecimalPlaces = 0;
            // lblInicio
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Location = new System.Drawing.Point(28, 102);
            this.lblInicio.Size = new System.Drawing.Size(290, 40);
            this.lblInicio.TabIndex = 11;
            this.lblInicio.Text = "Inicio HH:mm *";
            // dtpInicio
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Location = new System.Drawing.Point(328, 102);
            this.dtpInicio.Size = new System.Drawing.Size(690, 30);
            this.dtpInicio.TabIndex = 12;
            this.dtpInicio.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.CustomFormat = "HH:mm";
            this.dtpInicio.ShowUpDown = true;
            // lblFin
            this.lblFin.Name = "lblFin";
            this.lblFin.Location = new System.Drawing.Point(28, 148);
            this.lblFin.Size = new System.Drawing.Size(290, 40);
            this.lblFin.TabIndex = 13;
            this.lblFin.Text = "Fin HH:mm *";
            // dtpFin
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Location = new System.Drawing.Point(328, 148);
            this.dtpFin.Size = new System.Drawing.Size(690, 30);
            this.dtpFin.TabIndex = 14;
            this.dtpFin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFin.CustomFormat = "HH:mm";
            this.dtpFin.ShowUpDown = true;
            // lblDuracion
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Location = new System.Drawing.Point(28, 194);
            this.lblDuracion.Size = new System.Drawing.Size(290, 40);
            this.lblDuracion.TabIndex = 15;
            this.lblDuracion.Text = "Minutos por cita *";
            // nudDuracion
            this.nudDuracion.Name = "nudDuracion";
            this.nudDuracion.Location = new System.Drawing.Point(328, 194);
            this.nudDuracion.Size = new System.Drawing.Size(690, 30);
            this.nudDuracion.TabIndex = 16;
            this.nudDuracion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.nudDuracion.Maximum = new decimal (new int[] { 100000, 0, 0, 0 });
            this.nudDuracion.DecimalPlaces = 0;
            // btnGuardar
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Location = new System.Drawing.Point(28, 770);
            this.btnGuardar.Size = new System.Drawing.Size(140, 34);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // btnInhabilitar
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Location = new System.Drawing.Point(185, 770);
            this.btnInhabilitar.Size = new System.Drawing.Size(140, 34);
            this.btnInhabilitar.TabIndex = 18;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // btnReactivar
            this.btnReactivar.Name = "btnReactivar";
            this.btnReactivar.Location = new System.Drawing.Point(342, 770);
            this.btnReactivar.Size = new System.Drawing.Size(140, 34);
            this.btnReactivar.TabIndex = 19;
            this.btnReactivar.Text = "Reactivar";
            this.btnReactivar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnReactivar.Click += new System.EventHandler(this.btnReactivar_Click);
            // lblRegistro
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Location = new System.Drawing.Point(510, 775);
            this.lblRegistro.Size = new System.Drawing.Size(530, 30);
            this.lblRegistro.TabIndex = 20;
            this.lblRegistro.Text = "Nuevo registro";
            this.lblRegistro.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.dgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellDoubleClick);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.pnlEdicion);
            this.pnlEdicion.Controls.Add(this.lblMedicoId);
            this.pnlEdicion.Controls.Add(this.cboMedicoId);
            this.pnlEdicion.Controls.Add(this.lblDia);
            this.pnlEdicion.Controls.Add(this.nudDia);
            this.pnlEdicion.Controls.Add(this.lblInicio);
            this.pnlEdicion.Controls.Add(this.dtpInicio);
            this.pnlEdicion.Controls.Add(this.lblFin);
            this.pnlEdicion.Controls.Add(this.dtpFin);
            this.pnlEdicion.Controls.Add(this.lblDuracion);
            this.pnlEdicion.Controls.Add(this.nudDuracion);
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
            this.Name = "FrmHorarios";
            this.Text = "Sistema Hospital · Horarios";
            this.Load += new System.EventHandler(this.Formulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).EndInit();
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
        private System.Windows.Forms.Label lblMedicoId;
        private System.Windows.Forms.ComboBox cboMedicoId;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.NumericUpDown nudDia;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.NumericUpDown nudDuracion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnReactivar;
        private System.Windows.Forms.Label lblRegistro;
    }
}
