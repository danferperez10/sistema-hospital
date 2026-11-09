namespace Hospital.Presentacion
{
    partial class FrmEspecialidades
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
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
            this.lblTitulo.Text = "Especialidades";
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
            // lblNombre
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Location = new System.Drawing.Point(28, 10);
            this.lblNombre.Size = new System.Drawing.Size(290, 40);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre *";
            // txtNombre
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Location = new System.Drawing.Point(328, 10);
            this.txtNombre.Size = new System.Drawing.Size(690, 30);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtNombre.MaxLength = 200;
            // btnGuardar
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Location = new System.Drawing.Point(28, 770);
            this.btnGuardar.Size = new System.Drawing.Size(140, 34);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // btnInhabilitar
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Location = new System.Drawing.Point(185, 770);
            this.btnInhabilitar.Size = new System.Drawing.Size(140, 34);
            this.btnInhabilitar.TabIndex = 10;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // btnReactivar
            this.btnReactivar.Name = "btnReactivar";
            this.btnReactivar.Location = new System.Drawing.Point(342, 770);
            this.btnReactivar.Size = new System.Drawing.Size(140, 34);
            this.btnReactivar.TabIndex = 11;
            this.btnReactivar.Text = "Reactivar";
            this.btnReactivar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnReactivar.Click += new System.EventHandler(this.btnReactivar_Click);
            // lblRegistro
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Location = new System.Drawing.Point(510, 775);
            this.lblRegistro.Size = new System.Drawing.Size(530, 30);
            this.lblRegistro.TabIndex = 12;
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
            this.pnlEdicion.Controls.Add(this.lblNombre);
            this.pnlEdicion.Controls.Add(this.txtNombre);
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
            this.Name = "FrmEspecialidades";
            this.Text = "Sistema Hospital · Especialidades";
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
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnReactivar;
        private System.Windows.Forms.Label lblRegistro;
    }
}
