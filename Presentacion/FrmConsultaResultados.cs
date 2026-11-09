using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Hospital.Entidades;
using Hospital.Logica;

namespace Hospital.Presentacion
{
    public partial class FrmConsultaResultados : Form
    {
        private Sesion sesion;
        private VinculadorCampos campos;

        public FrmConsultaResultados()
        {
            InitializeComponent();
        }

        public FrmConsultaResultados(Sesion sesion) : this()
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
                campos = new VinculadorCampos(
                    this,
                    new Campo[] { new Campo("Desde", "Desde", "fecha", true), new Campo("Hasta", "Hasta", "fecha", true), new Campo("Paciente", "Paciente", "paciente", false) });
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
                    3,
                    (DateTime)v["Desde"],
                    (DateTime)v["Hasta"],
                    v["Paciente"] == null ? (int? )null : Convert.ToInt32(v["Paciente"]),
                    v["Medico"] == null ? (int? )null : Convert.ToInt32(v["Medico"]));
                dgvListado.DataSource = tabla;
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
    }
}
