using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Hospital.Entidades;
using Hospital.Logica;

namespace Hospital.Presentacion
{
    public partial class FrmCitas : Form
    {
        private Sesion sesion;
        private VinculadorCampos campos;

        private Label lblHorarioMedico;

        public FrmCitas()
        {
            InitializeComponent();
            CrearIndicadorHorario();
        }

        public FrmCitas(Sesion sesion) : this()
        {
            this.sesion = sesion;
        }

        private void CrearIndicadorHorario()
        {
            lblHorarioMedico = new Label();
            lblHorarioMedico.Name = "lblHorarioMedico";
            lblHorarioMedico.Text = "Horario del médico: seleccione médico y fecha.";
            lblHorarioMedico.Location = new Point(28, 150);
            lblHorarioMedico.Size = new Size(990, 40);
            lblHorarioMedico.AutoSize = false;
            lblHorarioMedico.Font = new Font(Font, FontStyle.Bold);

            pnlCampos.Controls.Add(lblHorarioMedico);
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            if (sesion == null)
            {
                return;
            }

            Ui.Intentar(() =>
            {
                campos = new VinculadorCampos(this, Procesos.Obtener("cita").Campos);
                campos.Inicializar(sesion);

                cboMedicoId.SelectedIndexChanged += cboMedicoId_SelectedIndexChanged;
                dtpInicio.ValueChanged += dtpInicio_ValueChanged;

                MostrarHorarioMedico();
            });
        }

        private void cboMedicoId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sesion != null)
            {
                Ui.Intentar(MostrarHorarioMedico);
            }
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            if (sesion != null)
            {
                Ui.Intentar(MostrarHorarioMedico);
            }
        }

        private void MostrarHorarioMedico()
        {
            if (cboMedicoId.SelectedValue == null)
            {
                lblHorarioMedico.Text =
                    "Horario del médico: seleccione un médico.";
                return;
            }

            int medicoId;

            if (!int.TryParse(
                Convert.ToString(cboMedicoId.SelectedValue),
                out medicoId))
            {
                lblHorarioMedico.Text =
                    "Horario del médico: seleccione un médico.";
                return;
            }

            DataTable horarios = Procesos.ObtenerHorarios(
                sesion,
                medicoId,
                dtpInicio.Value.Date);

            if (horarios.Rows.Count == 0)
            {
                lblHorarioMedico.Text =
                    "Horario del médico: no tiene horario configurado para este día.";
                return;
            }

            string texto = "Horario del médico: ";

            for (int i = 0; i < horarios.Rows.Count; i++)
            {
                if (i > 0)
                {
                    texto += " | ";
                }

                texto += Convert.ToDateTime(
                    horarios.Rows[i]["Inicio"]).ToString("HH:mm");

                texto += " - ";

                texto += Convert.ToDateTime(
                    horarios.Rows[i]["Fin"]).ToString("HH:mm");
            }

            lblHorarioMedico.Text = texto;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (campos == null)
            {
                return;
            }

            Ui.Intentar(() =>
            {
                int id = Procesos.Ejecutar(sesion, "cita", campos.Leer());
                MessageBox.Show("Registro guardado. Identificador: " + id);
                DialogResult = DialogResult.OK;
                Close();
            });
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}