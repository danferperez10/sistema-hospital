using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Hospital.Entidades;
using Hospital.Logica;

namespace Hospital.Presentacion
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Ui.Intentar(() =>
            {
                if (txtClave.Text != txtConfirmacion.Text)
                {
                    throw new Exception("Las contraseñas no coinciden.");
                }

                Seguridad.CrearInicial(txtUsuario.Text.Trim(), txtClave.Text);
                MessageBox.Show("Administrador creado. Ya puede iniciar sesión.");
                Close();
            });
        }
    }
}
