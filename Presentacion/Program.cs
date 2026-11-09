using System;
using System.Windows.Forms;

namespace Hospital.Presentacion
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                using (var login = new FrmLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                    {
                        break;
                    }

                    using (var principal = new FrmPrincipal(login.Sesion))
                    {
                        Application.Run(principal);
                        if (!principal.CerrarSesion)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
