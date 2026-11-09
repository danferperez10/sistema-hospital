using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Hospital.Entidades;
using Hospital.Logica;

namespace Hospital.Presentacion
{
    public partial class FrmHistoriaClinica : Form
    {
        private Sesion sesion;
        private VinculadorCampos campos;

        public FrmHistoriaClinica()
        {
            InitializeComponent();
        }

        public FrmHistoriaClinica(Sesion sesion) : this()
        {
            this.sesion = sesion;
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            if (sesion == null)
            {
                return;
            }

            Ui.Intentar(() =>
            {
                campos = new VinculadorCampos(this, new Campo[] { new Campo("Paciente", "Paciente", "paciente", true) });
                campos.Inicializar(sesion);
            });
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (campos == null)
            {
                return;
            }

            Ui.Intentar(() =>
            {
                var v = campos.Leer();
                if (!v.ContainsKey("Desde"))
                {
                    v["Desde"] = DateTime.Today;
                    v["Hasta"] = DateTime.Today;
                }

                if (!v.ContainsKey("Medico"))
                {
                    v["Medico"] = null;
                }

                var tabla = Consultas.Ejecutar(
                    sesion,
                    0,
                    (DateTime)v["Desde"],
                    (DateTime)v["Hasta"],
                    v["Paciente"] == null ? (int? )null : Convert.ToInt32(v["Paciente"]),
                    v["Medico"] == null ? (int? )null : Convert.ToInt32(v["Medico"]));
                dgvListado.DataSource = tabla;
                //TareaConsulta1
                dgvListado.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvListado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //FinTarea1

                //TareaConsula2
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros para los filtros seleccionados.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //FinTarea2

                if (tabla.Columns.Contains("FueraRango"))
                {
                    foreach (DataGridViewRow fila in dgvListado.Rows)
                    {
                        if (fila.Cells["FueraRango"].Value != DBNull.Value && Convert.ToBoolean(fila.Cells["FueraRango"].Value))
                        {
                            fila.DefaultCellStyle.BackColor = Color.MistyRose;
                        }
                    }
                }
            });
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Tarea 3
            Ui.Intentar(() =>
            {
                // Vaciamos la tabla de resultados
                dgvListado.DataSource = null;

                // Reiniciamos los campos vinculados a su estado original
                if (campos != null)
                {
                    campos.Inicializar(sesion);
                }
            });
        }
    }
}
