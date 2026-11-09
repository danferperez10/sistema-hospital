using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Hospital.Entidades;
using Hospital.Logica;

namespace Hospital.Presentacion
{
    public partial class FrmAnularCita : Form
    {
        private Sesion sesion;
        private VinculadorCampos campos;

        public FrmAnularCita()
        {
            InitializeComponent();
        }

        public FrmAnularCita(Sesion sesion) : this()
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
                campos = new VinculadorCampos(this, Procesos.Obtener("anular").Campos);
                campos.Inicializar(sesion);
            });
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (campos == null)
            {
                return;
            }

            Ui.Intentar(() =>
            {
                int id = Procesos.Ejecutar(sesion, "anular", campos.Leer());
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
