using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Hospital.Datos;
using Hospital.Entidades;

namespace Hospital.Logica
{
    public sealed class Campo
    {
        public string Nombre, Etiqueta, Tipo, Opciones;
        public bool Requerido;
        public Campo(string n, string e, string t = "texto", bool req = true, string opciones = "")
        {
            Nombre = n;
            Etiqueta = e;
            Tipo = t;
            Requerido = req;
            Opciones = opciones;
        }
    }

    public sealed class Catalogo
    {
        public string Tabla, Titulo;
        public Campo[] Campos;
        public Catalogo(string t, string titulo, params Campo[] c)
        {
            Tabla = t;
            Titulo = titulo;
            Campos = c;
        }
    }

    public static class Catalogos
    {
        public static readonly Catalogo[] Todos =
        {
            new Catalogo(
                "Paciente",
                "Pacientes",
                new Campo("Documento", "Documento", "texto", false),
                new Campo("Nombres", "Nombres completos"),
                new Campo("FechaNacimiento", "Fecha de nacimiento", "fecha", false),
                new Campo("Sexo", "Sexo", "lista", true, "Femenino|Masculino|No registrado"),
                new Campo("Direccion", "Dirección", "texto", false),
                new Campo("Telefono", "Teléfono", "texto", false),
                new Campo("Temporal", "Registro temporal", "bool")),
            new Catalogo(
                "Personal",
                "Personal y usuarios",
                new Campo("Documento", "Documento"),
                new Campo("Nombres", "Nombres completos"),
                new Campo("Cargo", "Cargo"),
                new Campo("EspecialidadId", "Especialidad", "especialidad", false),
                new Campo("Usuario", "Usuario"),
                new Campo(
                "Rol",
                "Rol",
                "lista",
                true,
                "Administrador|Recepcionista|Enfermero|Medico|Tecnico|Profesional"),
                new Campo("Clave", "Contraseña nueva (12 caracteres)", "clave", false)),
            new Catalogo("Especialidad", "Especialidades", new Campo("Nombre", "Nombre")),
            new Catalogo(
                "Horario",
                "Horarios",
                new Campo("MedicoId", "Médico", "medico"),
                new Campo("Dia", "Día (0 domingo a 6 sábado)", "entero"),
                new Campo("Inicio", "Inicio HH:mm", "hora"),
                new Campo("Fin", "Fin HH:mm", "hora"),
                new Campo("Duracion", "Minutos por cita", "entero")),
            new Catalogo(
                "Examen",
                "Exámenes de laboratorio",
                new Campo("Codigo", "Código"),
                new Campo("Nombre", "Nombre"),
                new Campo("TipoMuestra", "Tipo de muestra"),
                new Campo("Unidad", "Unidad", "texto", false),
                new Campo("Referencia", "Rango de referencia", "texto", false)),
            new Catalogo(
                "MedicamentoProcedimiento",
                "Medicamentos y procedimientos",
                new Campo("Codigo", "Código"),
                new Campo("Nombre", "Nombre"),
                new Campo("Tipo", "Tipo", "lista", true, "Medicamento|Procedimiento"),
                new Campo("Presentacion", "Presentación o descripción"))
        };
        public static Catalogo Obtener(string tabla)
        {
            return Todos.Single(x => x.Tabla == tabla);
        } // Solo nombres de tabla de esta lista, nunca entrada libre.

        static void Permiso(Sesion s, string tabla)
        {
            if (tabla == "Paciente")
            {
                Seguridad.Exigir(s, "Administrador", "Recepcionista");
            }
            else
            {
                Seguridad.Exigir(s, "Administrador");
            }
        }

        public static void Auditar(Db db, Sesion s, string accion, string entidad, int? id)
        {
            db.Ejecutar(
                "INSERT Auditoria(UsuarioId,Accion,Entidad,RegistroId) VALUES(@u,@a,@e,@id)",
                Db.P("@u", s.Id),
                Db.P("@a", accion),
                Db.P("@e", entidad),
                Db.P("@id", id));
        }

        public static DataTable Listar(Sesion s, string tabla, string buscar)
        {
            var c = Obtener(tabla);
            Permiso(s, tabla);
            string columnas = "Id," + string.Join(",", c.Campos.Where(x => x.Nombre != "Clave").Select(x => "[" + x.Nombre + "]")) + ",Activo";
            if (tabla == "Paciente")
            {
                columnas += ",Historia";
            }

            var texto = c.Campos.Where(x => x.Tipo == "texto").Select(x => "[" + x.Nombre + "] LIKE @q");
            string filtro = texto.Any() ? " WHERE " + string.Join(" OR ", texto) : "";
            using (var db = new Db())
            {
                var t = db.Tabla(
                    "SELECT " + columnas + " FROM [" + tabla + "]" + filtro + " ORDER BY Id DESC",
                    Db.P("@q", "%" + buscar + "%"));
                Auditar(db, s, "Consultar mantenedor", tabla, null);
                return t;
            }
        }

        public static int Guardar(Sesion s, string tabla, int id, Dictionary<string, object> valores)
        {
            var c = Obtener(tabla);
            Permiso(s, tabla);
            var v = c.Campos.ToDictionary(x => x.Nombre, x => valores.ContainsKey(x.Nombre) ? valores[x.Nombre] : null);
            foreach (var f in c.Campos)
            {
                if (f.Requerido && (v[f.Nombre] == null || string.IsNullOrWhiteSpace(Convert.ToString(v[f.Nombre]))))
                {
                    throw new Exception("Complete: " + f.Etiqueta);
                }
            }

            if (tabla == "Paciente")
            {
                if (!Convert.ToBoolean(v["Temporal"]) && (v["Documento"] == null || v["FechaNacimiento"] == null))
                {
                    throw new Exception("Un paciente identificado requiere documento y nacimiento.");
                }

                if (v["FechaNacimiento"] != null && (DateTime)v["FechaNacimiento"] > DateTime.Today)
                {
                    throw new Exception("Nacimiento no puede ser futuro.");
                }
            }

            using (var db = new Db(true))
            {
                if (id > 0 && Convert.ToInt32(db.Valor("SELECT COUNT(*) FROM [" + tabla + "] WITH(UPDLOCK,HOLDLOCK) WHERE Id=@id", Db.P("@id", id))) != 1)
                {
                    throw new Exception("El registro ya no existe.");
                }

                if (tabla == "Horario")
                {
                    int dia = Convert.ToInt32(v["Dia"]), dur = Convert.ToInt32(v["Duracion"]);
                    var ini = (TimeSpan)v["Inicio"];
                    var fin = (TimeSpan)v["Fin"];
                    if (dia < 0 || dia > 6 || dur < 5 || dur > 120 || fin <= ini)
                    {
                        throw new Exception("Revise día, duración y horas.");
                    }

                    if (Convert.ToInt32(db.Valor(
                        "SELECT COUNT(*) FROM Personal WHERE Id=@m AND Rol='Medico' AND Activo=1",
                        Db.P("@m", v["MedicoId"]))) != 1)
                    {
                        throw new Exception("Seleccione un médico activo.");
                    }

                    if (Convert.ToInt32(db.Valor(
                        "SELECT COUNT(*) FROM Horario WITH(UPDLOCK,HOLDLOCK) WHERE Activo=1 AND MedicoId=@m AND Dia=@d AND Id<>@id AND Inicio<@fin AND Fin>@ini",
                        Db.P("@m", v["MedicoId"]),
                        Db.P("@d", dia),
                        Db.P("@id", id),
                        Db.P("@ini", ini),
                        Db.P("@fin", fin))) > 0)
                    {
                        throw new Exception("El horario se cruza con otro horario activo.");
                    }
                }

                if (tabla == "Personal")
                {
                    if (id == s.Id && Convert.ToString(v["Rol"]) != "Administrador")
                    {
                        throw new Exception("No puede retirar su propio rol administrador.");
                    }

                    if (Convert.ToString(v["Rol"]) == "Medico" && v["EspecialidadId"] == null)
                    {
                        throw new Exception("El médico requiere especialidad.");
                    }

                    string clave = Convert.ToString(v["Clave"]);
                    v.Remove("Clave");
                    if (id == 0 || !string.IsNullOrEmpty(clave))
                    {
                        Seguridad.ValidarClave(clave);
                        var salt = Seguridad.Salt();
                        v["Salt"] = salt;
                        v["ClaveHash"] = Seguridad.Hash(clave, salt, Seguridad.Iteraciones);
                        v["Iteraciones"] = Seguridad.Iteraciones;
                    }
                }

                var ps = v.Select(x => Db.P("@" + x.Key, x.Value)).ToList();
                if (id == 0)
                {
                    string cols = string.Join(",", v.Keys.Select(x => "[" + x + "]"));
                    string pars = string.Join(",", v.Keys.Select(x => "@" + x));
                    id = Convert.ToInt32(db.Valor("INSERT [" + tabla + "](" + cols + ") OUTPUT INSERTED.Id VALUES(" + pars + ")", ps.ToArray()));
                }
                else
                {
                    ps.Add(Db.P("@id", id));
                    db.Ejecutar("UPDATE [" + tabla + "] SET " + string.Join(",", v.Keys.Select(x => "[" + x + "]=@" + x)) + " WHERE Id=@id", ps.ToArray());
                }

                Auditar(db, s, "Guardar", tabla, id);
                db.Confirmar();
                return id;
            }
        }

        public static void Estado(Sesion s, string tabla, int id, bool activo)
        {
            Obtener(tabla);
            Permiso(s, tabla);
            if (tabla == "Personal" && id == s.Id)
            {
                throw new Exception("No puede inhabilitar su propia cuenta.");
            }

            // Al reactivar horarios se valida el posible cruce mediante Guardar antes de activar.
            using (var db = new Db(true))
            {
                if (tabla == "Horario" && activo && Convert.ToInt32(db.Valor(
                    "SELECT COUNT(*) FROM Horario a JOIN Horario b WITH(UPDLOCK,HOLDLOCK) ON a.MedicoId=b.MedicoId AND a.Dia=b.Dia AND a.Inicio<b.Fin AND a.Fin>b.Inicio AND b.Id<>a.Id WHERE a.Id=@id AND b.Activo=1",
                    Db.P("@id", id))) > 0)
                {
                    throw new Exception("No se puede reactivar: existe un horario cruzado.");
                }

                if (db.Ejecutar("UPDATE [" + tabla + "] SET Activo=@a WHERE Id=@id", Db.P("@a", activo), Db.P("@id", id)) != 1)
                {
                    throw new Exception("Seleccione un registro existente.");
                }

                Auditar(db, s, activo ? "Reactivar" : "Inhabilitar", tabla, id);
                db.Confirmar();
            }
        }
    }
}
