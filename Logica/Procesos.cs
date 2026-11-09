using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Hospital.Datos;
using Hospital.Entidades;

namespace Hospital.Logica
{
    public sealed class Proceso
    {
        public string Codigo, Titulo;
        public string[] Roles;
        public Campo[] Campos;
        public Proceso(string cod, string titulo, string roles, params Campo[] campos)
        {
            Codigo = cod;
            Titulo = titulo;
            Roles = roles.Split('|');
            Campos = campos;
        }
    }

    public static class Procesos
    {
        public static readonly Proceso[] Todos =
        {
            new Proceso(
                "admision",
                "Admisión del paciente",
                "Recepcionista",
                new Campo("PacienteId", "Paciente", "paciente"),
                new Campo("Tipo", "Tipo de admisión", "lista", true, "Consulta|Emergencia")),
            new Proceso(
                "cita",
                "Programar cita",
                "Recepcionista",
                new Campo("PacienteId", "Paciente", "paciente"),
                new Campo("MedicoId", "Médico", "medico"),
                new Campo("Inicio", "Fecha y hora de cita", "fechahora")),
            new Proceso(
                "anular",
                "Anular cita",
                "Recepcionista",
                new Campo("CitaId", "Cita programada", "cita"),
                new Campo("Motivo", "Motivo")),
            new Proceso(
                "temporal",
                "Paciente temporal de emergencia",
                "Enfermero",
                new Campo("Nombres", "Identificación provisional"),
                new Campo("Sexo", "Sexo", "lista", true, "No registrado|Femenino|Masculino")),
            new Proceso(
                "triaje",
                "Registrar triaje",
                "Enfermero",
                new Campo("AdmisionId", "Admisión de emergencia", "admision"),
                new Campo("Motivo", "Motivo, signos y síntomas", "multilinea"),
                new Campo("Presion", "Presión arterial (ej. 120/80)"),
                new Campo("FC", "Frecuencia cardiaca", "entero"),
                new Campo("FR", "Frecuencia respiratoria", "entero"),
                new Campo("Temperatura", "Temperatura °C", "decimal"),
                new Campo("Saturacion", "Saturación %", "decimal"),
                new Campo("Prioridad", "Prioridad I a IV (1 a 4)", "entero")),
            new Proceso(
                "atencion",
                "Registrar atención médica",
                "Medico",
                new Campo("TriajeId", "Paciente en cola", "cola"),
                new Campo("Evaluacion", "Evaluación", "multilinea"),
                new Campo("Diagnosticos", "Diagnósticos (uno por línea)", "multilinea"),
                new Campo("Evolucion", "Evolución", "multilinea"),
                new Campo("Conducta", "Conducta", "lista", true, "Alta|Observacion|Hospitalizacion|Derivacion"),
                new Campo("Destino", "Destino", "texto", false)),
            new Proceso(
                "orden",
                "Solicitar examen",
                "Medico",
                new Campo("AtencionId", "Atención propia", "atencion"),
                new Campo("ExamenId", "Examen", "examen")),
            new Proceso(
                "indicacion",
                "Indicar medicamento o procedimiento",
                "Medico",
                new Campo("AtencionId", "Atención propia", "atencion"),
                new Campo("ProductoId", "Medicamento o procedimiento", "producto"),
                new Campo("Instruccion", "Dosis, vía, frecuencia o procedimiento", "multilinea")),
            new Proceso(
                "administracion",
                "Registrar administración indicada",
                "Enfermero",
                new Campo("IndicacionId", "Indicación médica", "indicacion"),
                new Campo("Detalle", "Detalle de lo administrado o realizado", "multilinea")),
            new Proceso(
                "muestra",
                "Registrar toma y traslado de muestra",
                "Tecnico",
                new Campo("OrdenId", "Orden pendiente", "orden"),
                new Campo("Codigo", "Código para rotular (copiar antes de confirmar)"),
                new Campo("Identidad", "Identidad confirmada", "bool"),
                new Campo("Rotulada", "Recipiente rotulado", "bool"),
                new Campo("Trasladada", "Traslado realizado", "bool")),
            new Proceso(
                "recepcion",
                "Recibir e iniciar procesamiento",
                "Tecnico",
                new Campo("OrdenId", "Muestra tomada", "muestra"),
                new Campo("Conforme", "Identificación y condiciones conformes", "bool")),
            new Proceso(
                "resultado",
                "Registrar resultado",
                "Profesional",
                new Campo("OrdenId", "Orden en proceso", "proceso"),
                new Campo("Valor", "Resultado", "multilinea"),
                new Campo("Observacion", "Observaciones", "multilinea", false),
                new Campo("FueraRango", "Fuera del rango de referencia", "bool")),
            new Proceso(
                "rechazo",
                "Rechazar muestra",
                "Tecnico|Profesional",
                new Campo("OrdenId", "Muestra sin resultado", "rechazable"),
                new Campo("Motivo", "Motivo de rechazo", "multilinea"))
        };
        public static Proceso Obtener(string codigo)
        {
            return Todos.Single(x => x.Codigo == codigo);
        }
public static DataTable ObtenerHorarios(
    Sesion s,
    int medicoId,
    DateTime fecha)
{
    Seguridad.Exigir(s, "Recepcionista");

    using (var db = new Db())
    {
        string sql = @"
            SELECT Inicio, Fin, Duracion
            FROM Horario
            WHERE Activo=1
              AND MedicoId=@m
              AND Dia=@dia
            ORDER BY Inicio";

        return db.Tabla(
            sql,
            Db.P("@m", medicoId),
            Db.P("@dia", (int)fecha.DayOfWeek));
    }
}

        static void Uno(Db db, string sql, params SqlParameter[] ps)
        {
            if (Convert.ToInt32(db.Valor(sql, ps)) != 1)
            {
                throw new Exception("El registro no está disponible o cambió de estado. Actualice la pantalla.");
            }
        }

        public static int Ejecutar(Sesion s, string codigo, Dictionary<string, object> v)
        {
            var p = Obtener(codigo);
            Seguridad.Exigir(s, p.Roles);
            foreach (var f in p.Campos)
            {
                if (f.Requerido && (!v.ContainsKey(f.Nombre) || v[f.Nombre] == null || string.IsNullOrWhiteSpace(Convert.ToString(v[f.Nombre]))))
                {
                    throw new Exception("Complete: " + f.Etiqueta);
                }
            }

            var ps = v.Select(x => Db.P("@" + x.Key, x.Value)).ToList();
            ps.Add(Db.P("@u", s.Id));
            int id = 0;
            using (var db = new Db(true))
            {
                string sql = "";
                if (codigo == "admision" || codigo == "cita")
                {
                    Uno(db, "SELECT COUNT(*) FROM Paciente WHERE Id=@id AND Activo=1", Db.P("@id", v["PacienteId"]));
                }

                switch (codigo)
                {
                    case "admision":
                        sql = "INSERT Admision(PacienteId,Tipo,ResponsableId) OUTPUT INSERTED.Id VALUES(@PacienteId,@Tipo,@u)";
                        break;
                    case "temporal":
                        id = Convert.ToInt32(db.Valor(
                            "INSERT Paciente(Nombres,Sexo,Temporal) OUTPUT INSERTED.Id VALUES(@Nombres,@Sexo,1)",
                            ps.ToArray()));
                        db.Ejecutar(
                            "INSERT Admision(PacienteId,Tipo,ResponsableId) VALUES(@id,'Emergencia',@u)",
                            Db.P("@id", id),
                            Db.P("@u", s.Id));
                        break;
                    case "cita":
                        DateTime inicio = (DateTime)v["Inicio"];
                        if (inicio <= DateTime.Now)
                        {
                            throw new Exception("Seleccione una fecha futura.");
                        }

                        Uno(
                            db,
                            "SELECT COUNT(*) FROM Personal WHERE Id=@id AND Rol='Medico' AND Activo=1",
                            Db.P("@id", v["MedicoId"]));
                        var horarios = db.Tabla(
                            "SELECT Inicio,Fin,Duracion FROM Horario WITH(UPDLOCK,HOLDLOCK) WHERE Activo=1 AND MedicoId=@m AND Dia=@dia AND Inicio<=@hora AND Fin>@hora",
                            Db.P("@m", v["MedicoId"]),
                            Db.P("@dia", (int)inicio.DayOfWeek),
                            Db.P("@hora", inicio.TimeOfDay));
                        if (horarios.Rows.Count != 1)
                        {
                            throw new Exception("La fecha no pertenece a un horario activo del médico.");
                        }

                        var h = horarios.Rows[0];
                        int dur = (int)h["Duracion"];
                        DateTime fin = inicio.AddMinutes(dur);
                        if (fin.Date != inicio.Date || fin.TimeOfDay > (TimeSpan)h["Fin"] || (inicio.TimeOfDay - (TimeSpan)h["Inicio"]).TotalMinutes % dur != 0 || inicio.Second != 0)
                        {
                            throw new Exception("La hora debe coincidir con un cupo completo del horario.");
                        }

                        if (Convert.ToInt32(db.Valor(
                            "SELECT COUNT(*) FROM Cita WITH(UPDLOCK,HOLDLOCK) WHERE Estado='Programada' AND (MedicoId=@m OR PacienteId=@p) AND Inicio<@fin AND Fin>@ini",
                            Db.P("@m", v["MedicoId"]),
                            Db.P("@p", v["PacienteId"]),
                            Db.P("@ini", inicio),
                            Db.P("@fin", fin))) > 0)
                        {
                            throw new Exception("El médico o paciente ya tiene una cita en ese intervalo.");
                        }

                        ps.Add(Db.P("@Fin", fin));
                        sql = "INSERT Cita(PacienteId,MedicoId,Inicio,Fin,ResponsableId) OUTPUT INSERTED.Id VALUES(@PacienteId,@MedicoId,@Inicio,@Fin,@u)";
                        break;
                    case "anular":
                        if (db.Ejecutar(
                            "UPDATE Cita SET Estado='Anulada',MotivoAnulacion=@Motivo WHERE Id=@CitaId AND Estado='Programada' AND Inicio>SYSDATETIME()",
                            ps.ToArray()) != 1)
                        {
                            throw new Exception("Solo se anulan citas futuras programadas.");
                        }

                        id = Convert.ToInt32(v["CitaId"]);
                        break;
                    case "triaje":
                        Uno(
                            db,
                            "SELECT COUNT(*) FROM Admision WHERE Id=@id AND Tipo='Emergencia'",
                            Db.P("@id", v["AdmisionId"]));
                        int prioridad = Convert.ToInt32(v["Prioridad"]);
                        if (prioridad < 1 || prioridad > 4)
                        {
                            throw new Exception("La prioridad debe estar entre 1 y 4; la decide el enfermero.");
                        }

                        if (Convert.ToInt32(v["FC"]) < 0 || Convert.ToInt32(v["FR"]) < 0 || Convert.ToDecimal(v["Saturacion"]) < 0 || Convert.ToDecimal(v["Saturacion"]) > 100)
                        {
                            throw new Exception("Revise los valores de signos vitales.");
                        }

                        sql = "INSERT Triaje(AdmisionId,Motivo,Presion,FC,FR,Temperatura,Saturacion,Prioridad,ResponsableId) OUTPUT INSERTED.Id VALUES(@AdmisionId,@Motivo,@Presion,@FC,@FR,@Temperatura,@Saturacion,@Prioridad,@u)";
                        break;
                    case "atencion":
                        Uno(
                            db,
                            "SELECT COUNT(*) FROM Triaje WITH(UPDLOCK,HOLDLOCK) WHERE Id=@id AND Estado='Espera'",
                            Db.P("@id", v["TriajeId"]));
                        string conducta = Convert.ToString(v["Conducta"]);
                        if ((conducta == "Derivacion" || conducta == "Hospitalizacion") && string.IsNullOrWhiteSpace(Convert.ToString(v["Destino"])))
                        {
                            throw new Exception("Indique el destino.");
                        }

                        db.Ejecutar("UPDATE Triaje SET Estado='Atendido' WHERE Id=@id", Db.P("@id", v["TriajeId"]));
                        sql = "INSERT Atencion(TriajeId,Evaluacion,Diagnosticos,Evolucion,Conducta,Destino,MedicoId) OUTPUT INSERTED.Id VALUES(@TriajeId,@Evaluacion,@Diagnosticos,@Evolucion,@Conducta,@Destino,@u)";
                        break;
                    case "orden":
                    case "indicacion":
                        Uno(
                            db,
                            "SELECT COUNT(*) FROM Atencion WHERE Id=@id AND (@admin=1 OR MedicoId=@u)",
                            Db.P("@id", v["AtencionId"]),
                            Db.P("@u", s.Id),
                            Db.P("@admin", s.Rol == "Administrador"));
                        if (codigo == "orden")
                        {
                            Uno(db, "SELECT COUNT(*) FROM Examen WHERE Id=@id AND Activo=1", Db.P("@id", v["ExamenId"]));
                            sql = "INSERT Orden(AtencionId,ExamenId) OUTPUT INSERTED.Id VALUES(@AtencionId,@ExamenId)";
                        }
                        else
                        {
                            Uno(
                                db,
                                "SELECT COUNT(*) FROM MedicamentoProcedimiento WHERE Id=@id AND Activo=1",
                                Db.P("@id", v["ProductoId"]));
                            sql = "INSERT Indicacion(AtencionId,ProductoId,Instruccion,MedicoId) OUTPUT INSERTED.Id VALUES(@AtencionId,@ProductoId,@Instruccion,@u)";
                        }

                        break;
                    case "administracion":
                        Uno(db, "SELECT COUNT(*) FROM Indicacion WHERE Id=@id", Db.P("@id", v["IndicacionId"]));
                        sql = "INSERT Administracion(IndicacionId,Detalle,EnfermeroId) OUTPUT INSERTED.Id VALUES(@IndicacionId,@Detalle,@u)";
                        break;
                    case "muestra":
                        if (!Convert.ToBoolean(v["Identidad"]) || !Convert.ToBoolean(v["Rotulada"]) || !Convert.ToBoolean(v["Trasladada"]))
                        {
                            throw new Exception("Confirme identidad, rotulado y traslado para completar la toma.");
                        }

                        if (db.Ejecutar(
                            "UPDATE Orden SET Estado='Muestra tomada' WHERE Id=@OrdenId AND Estado='Pendiente'",
                            ps.ToArray()) != 1)
                        {
                            throw new Exception("La orden ya no está pendiente.");
                        }

                        Guid codigoMuestra;
                        if (!Guid.TryParse(Convert.ToString(v["Codigo"]), out codigoMuestra))
                        {
                            throw new Exception("Código de muestra inválido.");
                        }

                        sql = "INSERT Muestra(OrdenId,Codigo,TecnicoId,Rotulada,Trasladada) OUTPUT INSERTED.Id VALUES(@OrdenId,@Codigo,@u,1,1)";
                        break;
                    case "recepcion":
                        if (!Convert.ToBoolean(v["Conforme"]))
                        {
                            throw new Exception("Si la muestra no es conforme, use Rechazar muestra.");
                        }

                        if (db.Ejecutar(
                            "UPDATE Orden SET Estado='En proceso' WHERE Id=@OrdenId AND Estado='Muestra tomada'",
                            ps.ToArray()) != 1)
                        {
                            throw new Exception("La muestra cambió de estado.");
                        }

                        db.Ejecutar(
                            "UPDATE Muestra SET Recepcion=SYSDATETIME(),ProcesadorId=@u WHERE OrdenId=@OrdenId",
                            ps.ToArray());
                        id = Convert.ToInt32(v["OrdenId"]);
                        break;
                    case "resultado":
                        if (db.Ejecutar(
                            "UPDATE Orden SET Estado='Con resultado' WHERE Id=@OrdenId AND Estado='En proceso'",
                            ps.ToArray()) != 1)
                        {
                            throw new Exception("La orden no está en proceso.");
                        }

                        sql = "INSERT Resultado(OrdenId,Valor,Observacion,FueraRango,ProfesionalId) OUTPUT INSERTED.Id VALUES(@OrdenId,@Valor,@Observacion,@FueraRango,@u)";
                        break;
                    case "rechazo":
                        if (db.Ejecutar(
                            "UPDATE Orden SET Estado='Rechazada' WHERE Id=@OrdenId AND Estado IN ('Muestra tomada','En proceso')",
                            ps.ToArray()) != 1)
                        {
                            throw new Exception("La muestra no admite rechazo en su estado actual.");
                        }

                        db.Ejecutar("UPDATE Muestra SET MotivoRechazo=@Motivo WHERE OrdenId=@OrdenId", ps.ToArray());
                        id = Convert.ToInt32(v["OrdenId"]);
                        break;
                }

                if (sql != "")
                {
                    id = Convert.ToInt32(db.Valor(sql, ps.ToArray()));
                }

                Catalogos.Auditar(db, s, "Registrar " + codigo, codigo, id);
                db.Confirmar();
                return id;
            }
        }

        public static DataTable Opciones(Sesion s, string tipo)
        {
            Seguridad.Exigir(s, "Administrador", "Recepcionista", "Enfermero", "Medico", "Tecnico", "Profesional");
            string[] permitidos;
            switch (tipo)
            {
                case "especialidad":
                    permitidos = new[]
                    {
                        "Administrador"
                    };
                    break;
                case "medico":
                    permitidos = new[]
                    {
                        "Administrador",
                        "Recepcionista",
                        "Medico"
                    };
                    break;
                case "paciente":
                    permitidos = new[]
                    {
                        "Administrador",
                        "Recepcionista",
                        "Enfermero",
                        "Medico",
                        "Tecnico",
                        "Profesional"
                    };
                    break;
                case "examen":
                case "producto":
                case "atencion":
                case "cola":
                    permitidos = new[]
                    {
                        "Medico"
                    };
                    break;
                case "cita":
                    permitidos = new[]
                    {
                        "Recepcionista"
                    };
                    break;
                case "admision":
                case "indicacion":
                    permitidos = new[]
                    {
                        "Enfermero"
                    };
                    break;
                case "orden":
                case "muestra":
                    permitidos = new[]
                    {
                        "Tecnico"
                    };
                    break;
                case "proceso":
                    permitidos = new[]
                    {
                        "Profesional"
                    };
                    break;
                case "rechazable":
                    permitidos = new[]
                    {
                        "Tecnico",
                        "Profesional"
                    };
                    break;
                default:
                    throw new Exception("Lista no definida.");
            }

            Seguridad.Exigir(s, permitidos);
            string sql;
            switch (tipo)
            {
                case "especialidad":
                    sql = "SELECT Id,Nombre Texto FROM Especialidad WHERE Activo=1";
                    break;
                case "medico":
                    sql = "SELECT Id,Nombres Texto FROM Personal WHERE Activo=1 AND Rol='Medico'";
                    break;
                case "paciente":
                    sql = "SELECT Id,CONCAT(Historia,' - ',Nombres,' - ',Documento) Texto FROM Paciente WHERE Activo=1";
                    break;
                case "examen":
                    sql = "SELECT Id,CONCAT(Nombre,' / ',TipoMuestra,' / ',Unidad,' / referencia: ',Referencia) Texto FROM Examen WHERE Activo=1";
                    break;
                case "producto":
                    sql = "SELECT Id,CONCAT(Tipo,': ',Nombre,' - ',Presentacion) Texto FROM MedicamentoProcedimiento WHERE Activo=1";
                    break;
                case "cita":
                    sql = "SELECT c.Id,CONCAT(c.Id,' - ',p.Nombres,' - ',CONVERT(varchar(16),c.Inicio,120)) Texto FROM Cita c JOIN Paciente p ON p.Id=c.PacienteId WHERE c.Estado='Programada' AND c.Inicio>SYSDATETIME()";
                    break;
                case "admision":
                    sql = "SELECT a.Id,CONCAT(a.Id,' - ',p.Nombres) Texto FROM Admision a JOIN Paciente p ON p.Id=a.PacienteId WHERE a.Tipo='Emergencia' AND NOT EXISTS(SELECT 1 FROM Triaje t WHERE t.AdmisionId=a.Id)";
                    break;
                case "cola":
                    sql = "SELECT t.Id,CONCAT('Prioridad ',t.Prioridad,' - ',p.Nombres,' - ',CONVERT(varchar(16),a.Fecha,120)) Texto FROM Triaje t JOIN Admision a ON a.Id=t.AdmisionId JOIN Paciente p ON p.Id=a.PacienteId WHERE t.Estado='Espera' ORDER BY t.Prioridad,a.Fecha,t.Id";
                    break;
                case "atencion":
                    sql = "SELECT a.Id,CONCAT(a.Id,' - ',p.Nombres,' - ',CONVERT(varchar(16),a.Fecha,120)) Texto FROM Atencion a JOIN Triaje t ON t.Id=a.TriajeId JOIN Admision ad ON ad.Id=t.AdmisionId JOIN Paciente p ON p.Id=ad.PacienteId WHERE (@admin=1 OR a.MedicoId=@u)";
                    break;
                case "indicacion":
                    sql = "SELECT i.Id,CONCAT(i.Id,' - ',p.Nombres,' - ',mp.Nombre,' - ',i.Instruccion) Texto FROM Indicacion i JOIN MedicamentoProcedimiento mp ON mp.Id=i.ProductoId JOIN Atencion a ON a.Id=i.AtencionId JOIN Triaje t ON t.Id=a.TriajeId JOIN Admision ad ON ad.Id=t.AdmisionId JOIN Paciente p ON p.Id=ad.PacienteId";
                    break;
                case "orden":
                case "muestra":
                case "proceso":
                case "rechazable":
                    string estado = tipo == "orden" ? "o.Estado='Pendiente'" : tipo == "muestra" ? "o.Estado='Muestra tomada'" : tipo == "proceso" ? "o.Estado='En proceso'" : "o.Estado IN ('Muestra tomada','En proceso')";
                    sql = "SELECT o.Id,CONCAT(o.Id,' - ',p.Nombres,' - ',e.Nombre,' / ',e.TipoMuestra,' / ',e.Unidad,' / ref: ',e.Referencia,' / código: ',m.Codigo) Texto FROM Orden o JOIN Examen e ON e.Id=o.ExamenId JOIN Atencion a ON a.Id=o.AtencionId JOIN Triaje t ON t.Id=a.TriajeId JOIN Admision ad ON ad.Id=t.AdmisionId JOIN Paciente p ON p.Id=ad.PacienteId LEFT JOIN Muestra m ON m.OrdenId=o.Id WHERE " + estado;
                    break;
                default:
                    throw new Exception("Lista no definida.");
            }

            using (var db = new Db())
            {
                var r = db.Tabla(sql, Db.P("@u", s.Id), Db.P("@admin", s.Rol == "Administrador"));
                Catalogos.Auditar(db, s, "Consultar opciones", tipo, null);
                return r;
            }
        }
    }
}
