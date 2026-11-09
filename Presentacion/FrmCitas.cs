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
        private Label lblIntervalo;
        private ComboBox cboIntervalo;

        public FrmCitas()
        {
            InitializeComponent();

            CrearIndicadorHorario();
            CrearSelectorIntervalo();

            // La fecha se selecciona aquí y la hora mediante el combo.
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = "dd/MM/yyyy";
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
            lblHorarioMedico.Size = new Size(990, 35);
            lblHorarioMedico.AutoSize = false;
            lblHorarioMedico.Font = new Font(Font, FontStyle.Bold);

            pnlCampos.Controls.Add(lblHorarioMedico);
        }

        private void CrearSelectorIntervalo()
        {
            lblIntervalo = new Label();
            lblIntervalo.Name = "lblIntervalo";
            lblIntervalo.Text = "Intervalo disponible *";
            lblIntervalo.Location = new Point(28, 190);
            lblIntervalo.Size = new Size(290, 40);

            cboIntervalo = new ComboBox();
            cboIntervalo.Name = "cboIntervalo";
            cboIntervalo.Location = new Point(328, 190);
            cboIntervalo.Size = new Size(690, 30);
            cboIntervalo.DropDownStyle = ComboBoxStyle.DropDownList;

            pnlCampos.Controls.Add(lblIntervalo);
            pnlCampos.Controls.Add(cboIntervalo);
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            if (sesion == null)
            {
                return;
            }

            Ui.Intentar(() =>
            {
                campos = new VinculadorCampos(
                    this,
                    Procesos.Obtener("cita").Campos);

                campos.Inicializar(sesion);

                cboMedicoId.SelectedIndexChanged +=
                    cboMedicoId_SelectedIndexChanged;

                dtpInicio.ValueChanged +=
                    dtpInicio_ValueChanged;

                cboIntervalo.SelectedIndexChanged +=
                    cboIntervalo_SelectedIndexChanged;

                CargarIntervalosDisponibles();
            });
        }

        private void cboMedicoId_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (sesion != null)
            {
                Ui.Intentar(CargarIntervalosDisponibles);
            }
        }

        private void dtpInicio_ValueChanged(
            object sender,
            EventArgs e)
        {
            if (sesion != null)
            {
                Ui.Intentar(CargarIntervalosDisponibles);
            }
        }

        private void cboIntervalo_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cboIntervalo.SelectedIndex < 0)
            {
                return;
            }

            DataRowView fila =
                cboIntervalo.SelectedItem as DataRowView;

            if (fila == null)
            {
                return;
            }

            DateTime inicio =
                Convert.ToDateTime(fila["Inicio"]);

            dtpInicio.Value = dtpInicio.Value.Date.Add(
                inicio.TimeOfDay);
        }

        private void CargarIntervalosDisponibles()
        {
            cboIntervalo.DataSource = null;
            cboIntervalo.Items.Clear();

            if (cboMedicoId.SelectedValue == null)
            {
                lblHorarioMedico.Text =
                    "Disponibilidad: seleccione un médico para consultar sus horarios.";

                return;
            }

            int medicoId;

            if (!int.TryParse(
                Convert.ToString(cboMedicoId.SelectedValue),
                out medicoId))
            {
                lblHorarioMedico.Text =
                    "Disponibilidad: no se pudo identificar el médico seleccionado.";

                return;
            }

            DataTable horarios =
                Procesos.ObtenerHorarios(
                    sesion,
                    medicoId,
                    dtpInicio.Value.Date);

            if (horarios.Rows.Count == 0)
            {
                lblHorarioMedico.Text =
                    "Sin disponibilidad: el médico no tiene horario configurado para este día.";

                return;
            }

            string textoHorario =
                "Horario del médico: ";

            for (int i = 0; i < horarios.Rows.Count; i++)
            {
                if (i > 0)
                {
                    textoHorario += " | ";
                }

                textoHorario +=
                    Convert.ToDateTime(
                        horarios.Rows[i]["Inicio"])
                        .ToString("HH:mm");

                textoHorario += " - ";

                textoHorario +=
                    Convert.ToDateTime(
                        horarios.Rows[i]["Fin"])
                        .ToString("HH:mm");
            }

            lblHorarioMedico.Text = textoHorario;

            DataTable disponibles =
                Procesos.ObtenerHorariosDisponibles(
                    sesion,
                    medicoId,
                    dtpInicio.Value.Date);

            cboIntervalo.DisplayMember = "Intervalo";
            cboIntervalo.ValueMember = "Inicio";
            cboIntervalo.DataSource = disponibles;

            if (disponibles.Rows.Count > 0)
            {
                lblHorarioMedico.Text +=
        " | Hay " + disponibles.Rows.Count +
        " intervalo(s) disponible(s).";

    cboIntervalo.SelectedIndex = 0;
}
else
{
    lblHorarioMedico.Text =
        "Sin disponibilidad: todos los intervalos del médico " +
        "están ocupados para esta fecha.";

    cboIntervalo.DataSource = null;
    cboIntervalo.Items.Clear();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (campos == null)
            {
                return;
            }

            if (cboIntervalo.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Seleccione un intervalo disponible.",
                    "Citas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Ui.Intentar(() =>
            {
                int id = Procesos.Ejecutar(
                    sesion,
                    "cita",
                    campos.Leer());

                MessageBox.Show(
                    "Registro guardado. Identificador: " + id);

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