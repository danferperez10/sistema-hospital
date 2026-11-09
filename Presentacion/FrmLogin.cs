using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Hospital.Entidades;
using Hospital.Logica;

namespace Hospital.Presentacion
{
    public partial class FrmLogin : Form
    {
        int fallos;
        DateTime bloqueadoHasta;
        public Sesion Sesion { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void chkMostrarClave_CheckedChanged(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = !chkMostrarClave.Checked;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInicial_Click(object sender, EventArgs e)
        {
            Ui.Intentar(() =>
            {
                if (!Seguridad.SinUsuarios())
                {
                    throw new Exception("Ya existe un usuario. Solicite acceso al administrador.");
                }

                using (var f = new FrmInicial())
                {
                    f.ShowDialog(this);
                }
            });
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            if (DateTime.Now < bloqueadoHasta)
            {
                lblEstado.Text = "Espere 30 segundos antes de intentar nuevamente.";
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || txtClave.Text.Length == 0)
            {
                lblEstado.Text = "Ingrese usuario y contraseña.";
                return;
            }

            btnIngresar.Enabled = false;
            string usuario = txtUsuario.Text.Trim(), clave = txtClave.Text;
            try
            {
                var sesion = await System.Threading.Tasks.Task.Run(() => Seguridad.Entrar(usuario, clave));
                if (sesion == null)
                {
                    lblEstado.Text = "Usuario o contraseña incorrectos.";
                    txtClave.Clear();
                    if (++fallos >= 5)
                    {
                        bloqueadoHasta = DateTime.Now.AddSeconds(30);
                        fallos = 0;
                    }

                    return;
                }

                Sesion = sesion;
                txtClave.Clear();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception)
            {
                lblEstado.Text = "No se pudo iniciar sesión. Revise la base y la conexión.";
            }
            finally
            {
                if (!IsDisposed)
                {
                    btnIngresar.Enabled = true;
                }
            }
        }
    }
}
