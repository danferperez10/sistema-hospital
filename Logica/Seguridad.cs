using System;
using System.Data;
using System.Security.Cryptography;
using Hospital.Datos;
using Hospital.Entidades;

namespace Hospital.Logica
{
    public static class Seguridad
    {
        public const int Iteraciones = 600000;
        public static byte[] Salt()
        {
            var b = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(b);
            }

            return b;
        }

        public static byte[] Hash(string clave, byte[] salt, int iter)
        {
            using (var k = new Rfc2898DeriveBytes(clave, salt, iter, HashAlgorithmName.SHA256))
            {
                return k.GetBytes(32);
            }
        }

        public static void ValidarClave(string clave)
        {
            if (string.IsNullOrWhiteSpace(clave) || clave.Length < 12)
            {
                throw new Exception("La contraseña debe tener al menos 12 caracteres.");
            }
        }

        public static Sesion Entrar(string usuario, string clave)
        {
            using (var db = new Db())
            {
                var t = db.Tabla(
                    "SELECT Id,Nombres,Rol,ClaveHash,Salt,Iteraciones FROM Personal WHERE Usuario=@u AND Activo=1",
                    Db.P("@u", usuario));
                if (t.Rows.Count != 1)
                {
                    Hash(clave, new byte[16], Iteraciones);
                    return null;
                }

                var r = t.Rows[0];
                var a = Hash(clave, (byte[])r["Salt"], (int)r["Iteraciones"]);
                var b = (byte[])r["ClaveHash"];
                int dif = a.Length ^ b.Length;
                for (int i = 0; i < a.Length && i < b.Length; i++)
                {
                    dif |= a[i] ^ b[i];
                }

                if (dif != 0)
                {
                    return null;
                }

                var s = new Sesion((int)r["Id"], (string)r["Nombres"], (string)r["Rol"]);
                db.Ejecutar(
                    "INSERT Auditoria(UsuarioId,Accion,Entidad,RegistroId) VALUES(@u,'Inicio de sesión','Personal',@u)",
                    Db.P("@u", s.Id));
                return s;
            }
        }

        public static bool SinUsuarios()
        {
            using (var db = new Db())
            {
                return Convert.ToInt32(db.Valor("SELECT COUNT(*) FROM Personal")) == 0;
            }
        }

        public static void CrearInicial(string usuario, string clave)
        {
            ValidarClave(clave);
            if (string.IsNullOrWhiteSpace(usuario))
            {
                throw new Exception("Ingrese un usuario.");
            }

            using (var db = new Db(true))
            {
                if (Convert.ToInt32(db.Valor("SELECT COUNT(*) FROM Personal WITH(UPDLOCK,HOLDLOCK)")) != 0)
                {
                    throw new Exception("Ya existe un usuario. Inicie sesión.");
                }

                var salt = Salt();
                db.Ejecutar(
                    "INSERT Personal(Documento,Nombres,Cargo,Usuario,Rol,ClaveHash,Salt,Iteraciones) VALUES('ADMIN-INICIAL','Administrador inicial','Administrador',@u,'Administrador',@h,@s,@i)",
                    Db.P("@u", usuario.Trim()),
                    Db.P("@h", Hash(clave, salt, Iteraciones)),
                    Db.P("@s", salt),
                    Db.P("@i", Iteraciones));
                db.Confirmar();
            }
        }

        // Política común al menú y a las operaciones. Exigir también valida la cuenta en SQL.
        public static bool Puede(Sesion s, params string[] roles)
        {
            return s != null && (s.Rol == "Administrador" || (roles != null && Array.IndexOf(roles, s.Rol) >= 0));
        }

        public static void Exigir(Sesion s, params string[] roles)
        {
            if (!Puede(s, roles))
            {
                throw new Exception("Su rol no tiene permiso para esta operación.");
            }

            using (var db = new Db())
            {
                if (Convert.ToInt32(db.Valor(
                    "SELECT COUNT(*) FROM Personal WHERE Id=@id AND Activo=1 AND Rol=@rol",
                    Db.P("@id", s.Id),
                    Db.P("@rol", s.Rol))) != 1)
                {
                    throw new Exception("Su cuenta cambió o fue inhabilitada. Cierre la sesión.");
                }
            }
        }
    }
}
