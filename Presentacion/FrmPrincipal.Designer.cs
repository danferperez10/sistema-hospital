namespace Hospital.Presentacion
{
    partial class FrmPrincipal
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabModulos = new System.Windows.Forms.TabControl();
            this.tabMantenimientos = new System.Windows.Forms.TabPage();
            this.tabProcesos = new System.Windows.Forms.TabPage();
            this.tabConsultas = new System.Windows.Forms.TabPage();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnEspecialidades = new System.Windows.Forms.Button();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnExamenes = new System.Windows.Forms.Button();
            this.btnMedicamentos = new System.Windows.Forms.Button();
            this.btnAdmision = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnAnularCita = new System.Windows.Forms.Button();
            this.btnPacienteTemporal = new System.Windows.Forms.Button();
            this.btnTriaje = new System.Windows.Forms.Button();
            this.btnAtencion = new System.Windows.Forms.Button();
            this.btnOrdenExamen = new System.Windows.Forms.Button();
            this.btnIndicacion = new System.Windows.Forms.Button();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.btnTomaMuestra = new System.Windows.Forms.Button();
            this.btnProcesamiento = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.btnRechazoMuestra = new System.Windows.Forms.Button();
            this.btnHistoriaClinica = new System.Windows.Forms.Button();
            this.btnAgendaCitas = new System.Windows.Forms.Button();
            this.btnColaEmergencia = new System.Windows.Forms.Button();
            this.btnConsultaResultados = new System.Windows.Forms.Button();
            this.btnTiemposEspera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblUsuario
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Location = new System.Drawing.Point(28, 20);
            this.lblUsuario.Size = new System.Drawing.Size(700, 36);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario · Rol";
            // btnCerrarSesion
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Location = new System.Drawing.Point(740, 20);
            this.btnCerrarSesion.Size = new System.Drawing.Size(170, 34);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // btnSalir
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Location = new System.Drawing.Point(930, 20);
            this.btnSalir.Size = new System.Drawing.Size(120, 34);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // tabModulos
            this.tabModulos.Name = "tabModulos";
            this.tabModulos.Location = new System.Drawing.Point(24, 80);
            this.tabModulos.Size = new System.Drawing.Size(1030, 690);
            this.tabModulos.TabIndex = 3;
            this.tabModulos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // tabMantenimientos
            this.tabMantenimientos.Name = "tabMantenimientos";
            this.tabMantenimientos.Location = new System.Drawing.Point(4, 26);
            this.tabMantenimientos.Size = new System.Drawing.Size(1022, 660);
            this.tabMantenimientos.TabIndex = 4;
            this.tabMantenimientos.Text = "Mantenimientos";
            this.tabMantenimientos.AutoScroll = true;
            // tabProcesos
            this.tabProcesos.Name = "tabProcesos";
            this.tabProcesos.Location = new System.Drawing.Point(4, 26);
            this.tabProcesos.Size = new System.Drawing.Size(1022, 660);
            this.tabProcesos.TabIndex = 5;
            this.tabProcesos.Text = "Procesos";
            this.tabProcesos.AutoScroll = true;
            // tabConsultas
            this.tabConsultas.Name = "tabConsultas";
            this.tabConsultas.Location = new System.Drawing.Point(4, 26);
            this.tabConsultas.Size = new System.Drawing.Size(1022, 660);
            this.tabConsultas.TabIndex = 6;
            this.tabConsultas.Text = "Consultas";
            this.tabConsultas.AutoScroll = true;
            // btnPacientes
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Location = new System.Drawing.Point(24, 20);
            this.btnPacientes.Size = new System.Drawing.Size(730, 34);
            this.btnPacientes.TabIndex = 7;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.Tag = "FrmPacientes";
            this.btnPacientes.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnPersonal
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Location = new System.Drawing.Point(24, 66);
            this.btnPersonal.Size = new System.Drawing.Size(730, 34);
            this.btnPersonal.TabIndex = 8;
            this.btnPersonal.Text = "Personal y usuarios";
            this.btnPersonal.Tag = "FrmPersonal";
            this.btnPersonal.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnEspecialidades
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Location = new System.Drawing.Point(24, 112);
            this.btnEspecialidades.Size = new System.Drawing.Size(730, 34);
            this.btnEspecialidades.TabIndex = 9;
            this.btnEspecialidades.Text = "Especialidades";
            this.btnEspecialidades.Tag = "FrmEspecialidades";
            this.btnEspecialidades.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnHorarios
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Location = new System.Drawing.Point(24, 158);
            this.btnHorarios.Size = new System.Drawing.Size(730, 34);
            this.btnHorarios.TabIndex = 10;
            this.btnHorarios.Text = "Horarios";
            this.btnHorarios.Tag = "FrmHorarios";
            this.btnHorarios.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnExamenes
            this.btnExamenes.Name = "btnExamenes";
            this.btnExamenes.Location = new System.Drawing.Point(24, 204);
            this.btnExamenes.Size = new System.Drawing.Size(730, 34);
            this.btnExamenes.TabIndex = 11;
            this.btnExamenes.Text = "Exámenes de laboratorio";
            this.btnExamenes.Tag = "FrmExamenes";
            this.btnExamenes.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnMedicamentos
            this.btnMedicamentos.Name = "btnMedicamentos";
            this.btnMedicamentos.Location = new System.Drawing.Point(24, 250);
            this.btnMedicamentos.Size = new System.Drawing.Size(730, 34);
            this.btnMedicamentos.TabIndex = 12;
            this.btnMedicamentos.Text = "Medicamentos y procedimientos";
            this.btnMedicamentos.Tag = "FrmMedicamentos";
            this.btnMedicamentos.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnAdmision
            this.btnAdmision.Name = "btnAdmision";
            this.btnAdmision.Location = new System.Drawing.Point(24, 20);
            this.btnAdmision.Size = new System.Drawing.Size(730, 34);
            this.btnAdmision.TabIndex = 13;
            this.btnAdmision.Text = "Admisión del paciente";
            this.btnAdmision.Tag = "FrmAdmision";
            this.btnAdmision.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnCitas
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Location = new System.Drawing.Point(24, 66);
            this.btnCitas.Size = new System.Drawing.Size(730, 34);
            this.btnCitas.TabIndex = 14;
            this.btnCitas.Text = "Programar cita";
            this.btnCitas.Tag = "FrmCitas";
            this.btnCitas.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnAnularCita
            this.btnAnularCita.Name = "btnAnularCita";
            this.btnAnularCita.Location = new System.Drawing.Point(24, 112);
            this.btnAnularCita.Size = new System.Drawing.Size(730, 34);
            this.btnAnularCita.TabIndex = 15;
            this.btnAnularCita.Text = "Anular cita";
            this.btnAnularCita.Tag = "FrmAnularCita";
            this.btnAnularCita.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnPacienteTemporal
            this.btnPacienteTemporal.Name = "btnPacienteTemporal";
            this.btnPacienteTemporal.Location = new System.Drawing.Point(24, 158);
            this.btnPacienteTemporal.Size = new System.Drawing.Size(730, 34);
            this.btnPacienteTemporal.TabIndex = 16;
            this.btnPacienteTemporal.Text = "Paciente temporal de emergencia";
            this.btnPacienteTemporal.Tag = "FrmPacienteTemporal";
            this.btnPacienteTemporal.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnTriaje
            this.btnTriaje.Name = "btnTriaje";
            this.btnTriaje.Location = new System.Drawing.Point(24, 204);
            this.btnTriaje.Size = new System.Drawing.Size(730, 34);
            this.btnTriaje.TabIndex = 17;
            this.btnTriaje.Text = "Registrar triaje";
            this.btnTriaje.Tag = "FrmTriaje";
            this.btnTriaje.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnAtencion
            this.btnAtencion.Name = "btnAtencion";
            this.btnAtencion.Location = new System.Drawing.Point(24, 250);
            this.btnAtencion.Size = new System.Drawing.Size(730, 34);
            this.btnAtencion.TabIndex = 18;
            this.btnAtencion.Text = "Registrar atención médica";
            this.btnAtencion.Tag = "FrmAtencion";
            this.btnAtencion.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnOrdenExamen
            this.btnOrdenExamen.Name = "btnOrdenExamen";
            this.btnOrdenExamen.Location = new System.Drawing.Point(24, 296);
            this.btnOrdenExamen.Size = new System.Drawing.Size(730, 34);
            this.btnOrdenExamen.TabIndex = 19;
            this.btnOrdenExamen.Text = "Solicitar examen";
            this.btnOrdenExamen.Tag = "FrmOrdenExamen";
            this.btnOrdenExamen.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnIndicacion
            this.btnIndicacion.Name = "btnIndicacion";
            this.btnIndicacion.Location = new System.Drawing.Point(24, 342);
            this.btnIndicacion.Size = new System.Drawing.Size(730, 34);
            this.btnIndicacion.TabIndex = 20;
            this.btnIndicacion.Text = "Indicar medicamento o procedimiento";
            this.btnIndicacion.Tag = "FrmIndicacion";
            this.btnIndicacion.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnAdministracion
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Location = new System.Drawing.Point(24, 388);
            this.btnAdministracion.Size = new System.Drawing.Size(730, 34);
            this.btnAdministracion.TabIndex = 21;
            this.btnAdministracion.Text = "Registrar administración indicada";
            this.btnAdministracion.Tag = "FrmAdministracion";
            this.btnAdministracion.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnTomaMuestra
            this.btnTomaMuestra.Name = "btnTomaMuestra";
            this.btnTomaMuestra.Location = new System.Drawing.Point(24, 434);
            this.btnTomaMuestra.Size = new System.Drawing.Size(730, 34);
            this.btnTomaMuestra.TabIndex = 22;
            this.btnTomaMuestra.Text = "Registrar toma y traslado de muestra";
            this.btnTomaMuestra.Tag = "FrmTomaMuestra";
            this.btnTomaMuestra.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnProcesamiento
            this.btnProcesamiento.Name = "btnProcesamiento";
            this.btnProcesamiento.Location = new System.Drawing.Point(24, 480);
            this.btnProcesamiento.Size = new System.Drawing.Size(730, 34);
            this.btnProcesamiento.TabIndex = 23;
            this.btnProcesamiento.Text = "Recibir e iniciar procesamiento";
            this.btnProcesamiento.Tag = "FrmProcesamiento";
            this.btnProcesamiento.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnResultados
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Location = new System.Drawing.Point(24, 526);
            this.btnResultados.Size = new System.Drawing.Size(730, 34);
            this.btnResultados.TabIndex = 24;
            this.btnResultados.Text = "Registrar resultado";
            this.btnResultados.Tag = "FrmResultados";
            this.btnResultados.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnRechazoMuestra
            this.btnRechazoMuestra.Name = "btnRechazoMuestra";
            this.btnRechazoMuestra.Location = new System.Drawing.Point(24, 572);
            this.btnRechazoMuestra.Size = new System.Drawing.Size(730, 34);
            this.btnRechazoMuestra.TabIndex = 25;
            this.btnRechazoMuestra.Text = "Rechazar muestra";
            this.btnRechazoMuestra.Tag = "FrmRechazoMuestra";
            this.btnRechazoMuestra.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnHistoriaClinica
            this.btnHistoriaClinica.Name = "btnHistoriaClinica";
            this.btnHistoriaClinica.Location = new System.Drawing.Point(24, 20);
            this.btnHistoriaClinica.Size = new System.Drawing.Size(730, 34);
            this.btnHistoriaClinica.TabIndex = 26;
            this.btnHistoriaClinica.Text = "Historia clínica";
            this.btnHistoriaClinica.Tag = "FrmHistoriaClinica";
            this.btnHistoriaClinica.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnAgendaCitas
            this.btnAgendaCitas.Name = "btnAgendaCitas";
            this.btnAgendaCitas.Location = new System.Drawing.Point(24, 66);
            this.btnAgendaCitas.Size = new System.Drawing.Size(730, 34);
            this.btnAgendaCitas.TabIndex = 27;
            this.btnAgendaCitas.Text = "Agenda de citas";
            this.btnAgendaCitas.Tag = "FrmAgendaCitas";
            this.btnAgendaCitas.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnColaEmergencia
            this.btnColaEmergencia.Name = "btnColaEmergencia";
            this.btnColaEmergencia.Location = new System.Drawing.Point(24, 112);
            this.btnColaEmergencia.Size = new System.Drawing.Size(730, 34);
            this.btnColaEmergencia.TabIndex = 28;
            this.btnColaEmergencia.Text = "Cola de emergencia";
            this.btnColaEmergencia.Tag = "FrmColaEmergencia";
            this.btnColaEmergencia.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnConsultaResultados
            this.btnConsultaResultados.Name = "btnConsultaResultados";
            this.btnConsultaResultados.Location = new System.Drawing.Point(24, 158);
            this.btnConsultaResultados.Size = new System.Drawing.Size(730, 34);
            this.btnConsultaResultados.TabIndex = 29;
            this.btnConsultaResultados.Text = "Estado y resultados de laboratorio";
            this.btnConsultaResultados.Tag = "FrmConsultaResultados";
            this.btnConsultaResultados.Click += new System.EventHandler(this.AbrirModulo_Click);
            // btnTiemposEspera
            this.btnTiemposEspera.Name = "btnTiemposEspera";
            this.btnTiemposEspera.Location = new System.Drawing.Point(24, 204);
            this.btnTiemposEspera.Size = new System.Drawing.Size(730, 34);
            this.btnTiemposEspera.TabIndex = 30;
            this.btnTiemposEspera.Text = "Atenciones y tiempos de espera";
            this.btnTiemposEspera.Tag = "FrmTiemposEspera";
            this.btnTiemposEspera.Click += new System.EventHandler(this.AbrirModulo_Click);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabModulos);
            this.tabModulos.Controls.Add(this.tabMantenimientos);
            this.tabModulos.Controls.Add(this.tabProcesos);
            this.tabModulos.Controls.Add(this.tabConsultas);
            this.tabMantenimientos.Controls.Add(this.btnPacientes);
            this.tabMantenimientos.Controls.Add(this.btnPersonal);
            this.tabMantenimientos.Controls.Add(this.btnEspecialidades);
            this.tabMantenimientos.Controls.Add(this.btnHorarios);
            this.tabMantenimientos.Controls.Add(this.btnExamenes);
            this.tabMantenimientos.Controls.Add(this.btnMedicamentos);
            this.tabProcesos.Controls.Add(this.btnAdmision);
            this.tabProcesos.Controls.Add(this.btnCitas);
            this.tabProcesos.Controls.Add(this.btnAnularCita);
            this.tabProcesos.Controls.Add(this.btnPacienteTemporal);
            this.tabProcesos.Controls.Add(this.btnTriaje);
            this.tabProcesos.Controls.Add(this.btnAtencion);
            this.tabProcesos.Controls.Add(this.btnOrdenExamen);
            this.tabProcesos.Controls.Add(this.btnIndicacion);
            this.tabProcesos.Controls.Add(this.btnAdministracion);
            this.tabProcesos.Controls.Add(this.btnTomaMuestra);
            this.tabProcesos.Controls.Add(this.btnProcesamiento);
            this.tabProcesos.Controls.Add(this.btnResultados);
            this.tabProcesos.Controls.Add(this.btnRechazoMuestra);
            this.tabConsultas.Controls.Add(this.btnHistoriaClinica);
            this.tabConsultas.Controls.Add(this.btnAgendaCitas);
            this.tabConsultas.Controls.Add(this.btnColaEmergencia);
            this.tabConsultas.Controls.Add(this.btnConsultaResultados);
            this.tabConsultas.Controls.Add(this.btnTiemposEspera);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 800);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmPrincipal";
            this.Text = "Sistema Hospital · Menú principal";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TabControl tabModulos;
        private System.Windows.Forms.TabPage tabMantenimientos;
        private System.Windows.Forms.TabPage tabProcesos;
        private System.Windows.Forms.TabPage tabConsultas;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Button btnExamenes;
        private System.Windows.Forms.Button btnMedicamentos;
        private System.Windows.Forms.Button btnAdmision;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnAnularCita;
        private System.Windows.Forms.Button btnPacienteTemporal;
        private System.Windows.Forms.Button btnTriaje;
        private System.Windows.Forms.Button btnAtencion;
        private System.Windows.Forms.Button btnOrdenExamen;
        private System.Windows.Forms.Button btnIndicacion;
        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Button btnTomaMuestra;
        private System.Windows.Forms.Button btnProcesamiento;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Button btnRechazoMuestra;
        private System.Windows.Forms.Button btnHistoriaClinica;
        private System.Windows.Forms.Button btnAgendaCitas;
        private System.Windows.Forms.Button btnColaEmergencia;
        private System.Windows.Forms.Button btnConsultaResultados;
        private System.Windows.Forms.Button btnTiemposEspera;
    }
}
