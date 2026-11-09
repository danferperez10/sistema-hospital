using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Hospital.Entidades;
using Hospital.Logica;

namespace Hospital.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private Sesion sesion;
        public bool CerrarSesion { get; private set; }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public FrmPrincipal(Sesion sesion) : this()
        {
            this.sesion = sesion;
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            if (sesion == null)
            {
                return;
            }

            lblUsuario.Text = sesion.Nombre + " · " + sesion.Rol;
            this.btnPacientes.Enabled = Seguridad.Puede(sesion, "Administrador", "Recepcionista");
            this.btnPersonal.Enabled = Seguridad.Puede(sesion, "Administrador");
            this.btnEspecialidades.Enabled = Seguridad.Puede(sesion, "Administrador");
            this.btnHorarios.Enabled = Seguridad.Puede(sesion, "Administrador");
            this.btnExamenes.Enabled = Seguridad.Puede(sesion, "Administrador");
            this.btnMedicamentos.Enabled = Seguridad.Puede(sesion, "Administrador");
            this.btnAdmision.Enabled = Seguridad.Puede(sesion, "Recepcionista");
            this.btnCitas.Enabled = Seguridad.Puede(sesion, "Recepcionista");
            this.btnAnularCita.Enabled = Seguridad.Puede(sesion, "Recepcionista");
            this.btnPacienteTemporal.Enabled = Seguridad.Puede(sesion, "Enfermero");
            this.btnTriaje.Enabled = Seguridad.Puede(sesion, "Enfermero");
            this.btnAtencion.Enabled = Seguridad.Puede(sesion, "Medico");
            this.btnOrdenExamen.Enabled = Seguridad.Puede(sesion, "Medico");
            this.btnIndicacion.Enabled = Seguridad.Puede(sesion, "Medico");
            this.btnAdministracion.Enabled = Seguridad.Puede(sesion, "Enfermero");
            this.btnTomaMuestra.Enabled = Seguridad.Puede(sesion, "Tecnico");
            this.btnProcesamiento.Enabled = Seguridad.Puede(sesion, "Tecnico");
            this.btnResultados.Enabled = Seguridad.Puede(sesion, "Profesional");
            this.btnRechazoMuestra.Enabled = Seguridad.Puede(sesion, "Tecnico", "Profesional");
            this.btnHistoriaClinica.Enabled = Seguridad.Puede(sesion, "Medico", "Enfermero");
            this.btnAgendaCitas.Enabled = Seguridad.Puede(sesion, "Recepcionista", "Medico");
            this.btnColaEmergencia.Enabled = Seguridad.Puede(sesion, "Medico", "Enfermero");
            this.btnConsultaResultados.Enabled = Seguridad.Puede(sesion, "Medico", "Tecnico", "Profesional");
            this.btnTiemposEspera.Enabled = Seguridad.Puede(sesion, "Administrador");
        }

        private void AbrirModulo_Click(object sender, EventArgs e)
        {
            if (sesion == null)
            {
                return;
            }

            Ui.Intentar(() =>
            {
                Form formulario;
                switch (Convert.ToString(((Button)sender).Tag))
                {
                    case "FrmPacientes":
                        formulario = new FrmPacientes(sesion);
                        break;
                    case "FrmPersonal":
                        formulario = new FrmPersonal(sesion);
                        break;
                    case "FrmEspecialidades":
                        formulario = new FrmEspecialidades(sesion);
                        break;
                    case "FrmHorarios":
                        formulario = new FrmHorarios(sesion);
                        break;
                    case "FrmExamenes":
                        formulario = new FrmExamenes(sesion);
                        break;
                    case "FrmMedicamentos":
                        formulario = new FrmMedicamentos(sesion);
                        break;
                    case "FrmAdmision":
                        formulario = new FrmAdmision(sesion);
                        break;
                    case "FrmCitas":
                        formulario = new FrmCitas(sesion);
                        break;
                    case "FrmAnularCita":
                        formulario = new FrmAnularCita(sesion);
                        break;
                    case "FrmPacienteTemporal":
                        formulario = new FrmPacienteTemporal(sesion);
                        break;
                    case "FrmTriaje":
                        formulario = new FrmTriaje(sesion);
                        break;
                    case "FrmAtencion":
                        formulario = new FrmAtencion(sesion);
                        break;
                    case "FrmOrdenExamen":
                        formulario = new FrmOrdenExamen(sesion);
                        break;
                    case "FrmIndicacion":
                        formulario = new FrmIndicacion(sesion);
                        break;
                    case "FrmAdministracion":
                        formulario = new FrmAdministracion(sesion);
                        break;
                    case "FrmTomaMuestra":
                        formulario = new FrmTomaMuestra(sesion);
                        break;
                    case "FrmProcesamiento":
                        formulario = new FrmProcesamiento(sesion);
                        break;
                    case "FrmResultados":
                        formulario = new FrmResultados(sesion);
                        break;
                    case "FrmRechazoMuestra":
                        formulario = new FrmRechazoMuestra(sesion);
                        break;
                    case "FrmHistoriaClinica":
                        formulario = new FrmHistoriaClinica(sesion);
                        break;
                    case "FrmAgendaCitas":
                        formulario = new FrmAgendaCitas(sesion);
                        break;
                    case "FrmColaEmergencia":
                        formulario = new FrmColaEmergencia(sesion);
                        break;
                    case "FrmConsultaResultados":
                        formulario = new FrmConsultaResultados(sesion);
                        break;
                    case "FrmTiemposEspera":
                        formulario = new FrmTiemposEspera(sesion);
                        break;
                    default:
                        throw new Exception("Módulo no definido.");
                }

                using (formulario)
                {
                    formulario.ShowDialog(this);
                }
            });
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion = true;
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
