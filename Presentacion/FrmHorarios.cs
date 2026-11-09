using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Hospital.Entidades;
using Hospital.Logica;

namespace Hospital.Presentacion
{
    public partial class FrmHorarios : Form
    {
        private Sesion sesion;
        private VinculadorCampos campos;
        private int idActual;

        public FrmHorarios()
        {
            InitializeComponent();
        }

        public FrmHorarios(Sesion sesion) : this()
        {
            this.sesion = sesion;
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            if (sesion == null)
            {
                return; // El diseñador nunca abre una conexión.
            }

            Ui.Intentar(() =>
            {
                campos = new VinculadorCampos(this, Catalogos.Obtener("Horario").Campos);
                campos.Inicializar(sesion);
                CargarListado();
            });
        }

        private void CargarListado()
        {
            dgvListado.DataSource = Catalogos.Listar(sesion, "Horario", txtBuscar.Text.Trim());
        }

        private DataRow Seleccion()
        {
            if (dgvListado.CurrentRow == null)
            {
                throw new Exception("Seleccione un registro.");
            }

            return ((DataRowView)dgvListado.CurrentRow.DataBoundItem).Row;
        }

        private void EditarSeleccion()
        {
            var fila = Seleccion();
            campos.Cargar(fila);
            idActual = (int)fila["Id"];
            lblRegistro.Text = "Editando registro " + idActual;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (sesion != null)
            {
                Ui.Intentar(CargarListado);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (campos == null)
            {
                return;
            }

            campos.Limpiar();
            idActual = 0;
            lblRegistro.Text = "Nuevo registro";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (campos != null)
            {
                Ui.Intentar(EditarSeleccion);
            }
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && campos != null)
            {
                Ui.Intentar(EditarSeleccion);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (campos == null)
            {
                return;
            }

            Ui.Intentar(() =>
            {
                idActual = Catalogos.Guardar(sesion, "Horario", idActual, campos.Leer());
                lblRegistro.Text = "Guardado registro " + idActual;
                CargarListado();
            });
        }

        private void CambiarEstado(bool activo)
        {
            if (sesion == null)
            {
                return;
            }

            Ui.Intentar(() =>
            {
                var fila = Seleccion();
                if (MessageBox.Show(
                    (activo ? "¿Reactivar" : "¿Inhabilitar") + " el registro seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }

                Catalogos.Estado(sesion, "Horario", (int)fila["Id"], activo);
                CargarListado();
            });
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            CambiarEstado(false);
        }

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            CambiarEstado(true);
        }
    }
}
