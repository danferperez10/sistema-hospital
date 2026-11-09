using System;
using System.Data;
using Hospital.Datos;
using Hospital.Entidades;

namespace Hospital.Logica
{
    public static class Consultas
    {
        public static readonly string[] Nombres =
        {
            "Historia clínica",
            "Agenda de citas",
            "Cola de emergencia",
            "Estado y resultados de laboratorio",
            "Atenciones y tiempos de espera"
        };
        public static string[] Roles(int i)
        {
            switch (i)
            {
                case 0:
                    return new[]
                    {
                        "Medico",
                        "Enfermero"
                    };
                case 1:
                    return new[]
                    {
                        "Recepcionista",
                        "Medico"
                    };
                case 2:
                    return new[]
                    {
                        "Medico",
                        "Enfermero"
                    };
                case 3:
                    return new[]
                    {
                        "Medico",
                        "Tecnico",
                        "Profesional"
                    };
                case 4:
                    return new[]
                    {
                        "Administrador"
                    };
                default:
                    throw new Exception("Consulta no definida.");
            }
        }

        public static DataTable Ejecutar(Sesion s, int i, DateTime desde, DateTime hasta, int? paciente, int? medico)
        {
            Seguridad.Exigir(s, Roles(i));
            if (hasta.Date < desde.Date)
            {
                throw new Exception("Revise el intervalo de fechas.");
            }

            string sql = "";
            switch (i)
            {
                case 0:
                    if (!paciente.HasValue)
                    {
                        throw new Exception("Seleccione un paciente para consultar su historia.");
                    }

                    sql = @"SELECT a.Fecha,'Atención' Tipo,CONCAT('Evaluación: ',a.Evaluacion,' | Diagnósticos: ',a.Diagnosticos,' | Evolución: ',a.Evolucion,' | Conducta: ',a.Conducta,' | Destino: ',a.Destino) Detalle,per.Nombres Responsable
                    FROM Atencion a JOIN Personal per ON per.Id=a.MedicoId JOIN Triaje t ON t.Id=a.TriajeId JOIN Admision ad ON ad.Id=t.AdmisionId WHERE ad.PacienteId=@p
                    UNION ALL SELECT o.Fecha,'Orden',CONCAT(e.Nombre,' | Estado: ',o.Estado,' | Resultado: ',r.Valor,' | Observación: ',r.Observacion),'Laboratorio'
                    FROM Orden o JOIN Examen e ON e.Id=o.ExamenId LEFT JOIN Resultado r ON r.OrdenId=o.Id JOIN Atencion a ON a.Id=o.AtencionId JOIN Triaje t ON t.Id=a.TriajeId JOIN Admision ad ON ad.Id=t.AdmisionId WHERE ad.PacienteId=@p
                    UNION ALL SELECT a.Fecha,'Indicación',CONCAT(mp.Nombre,' | ',ind.Instruccion),per.Nombres FROM Indicacion ind JOIN Personal per ON per.Id=ind.MedicoId JOIN MedicamentoProcedimiento mp ON mp.Id=ind.ProductoId JOIN Atencion a ON a.Id=ind.AtencionId JOIN Triaje t ON t.Id=a.TriajeId JOIN Admision ad ON ad.Id=t.AdmisionId WHERE ad.PacienteId=@p
                    UNION ALL SELECT adm.Fecha,'Administración',adm.Detalle,per.Nombres FROM Administracion adm JOIN Personal per ON per.Id=adm.EnfermeroId JOIN Indicacion ind ON ind.Id=adm.IndicacionId JOIN Atencion a ON a.Id=ind.AtencionId JOIN Triaje t ON t.Id=a.TriajeId JOIN Admision ad ON ad.Id=t.AdmisionId WHERE ad.PacienteId=@p ORDER BY Fecha";
                    break;
                case 1:
                    sql = @"SELECT c.Id,p.Historia,p.Nombres Paciente,m.Nombres Medico,e.Nombre Especialidad,c.Inicio,c.Fin,c.Estado,c.MotivoAnulacion FROM Cita c JOIN Paciente p ON p.Id=c.PacienteId JOIN Personal m ON m.Id=c.MedicoId LEFT JOIN Especialidad e ON e.Id=m.EspecialidadId WHERE c.Inicio>=@d AND c.Inicio<@h AND (@p IS NULL OR c.PacienteId=@p) AND (@m IS NULL OR c.MedicoId=@m) ORDER BY c.Inicio";
                    break;
                case 2:
                    sql = @"SELECT t.Id,p.Historia,p.Nombres,t.Prioridad,ad.Fecha Llegada,t.Fecha Triaje,DATEDIFF(minute,ad.Fecha,SYSDATETIME()) MinutosDesdeLlegada,t.Motivo FROM Triaje t JOIN Admision ad ON ad.Id=t.AdmisionId JOIN Paciente p ON p.Id=ad.PacienteId WHERE t.Estado='Espera' AND (@p IS NULL OR p.Id=@p) ORDER BY t.Prioridad,ad.Fecha,t.Id";
                    break;
                case 3:
                    sql = @"SELECT o.Id Orden,p.Historia,p.Nombres Paciente,e.Nombre Examen,e.TipoMuestra,o.Estado,m.Codigo,m.Fecha Toma,m.Recepcion,m.MotivoRechazo,r.Valor,e.Unidad,e.Referencia,r.FueraRango,r.Observacion,r.Fecha FechaResultado FROM Orden o JOIN Examen e ON e.Id=o.ExamenId JOIN Atencion a ON a.Id=o.AtencionId JOIN Triaje t ON t.Id=a.TriajeId JOIN Admision ad ON ad.Id=t.AdmisionId JOIN Paciente p ON p.Id=ad.PacienteId LEFT JOIN Muestra m ON m.OrdenId=o.Id LEFT JOIN Resultado r ON r.OrdenId=o.Id WHERE o.Fecha>=@d AND o.Fecha<@h AND (@p IS NULL OR p.Id=@p) ORDER BY o.Fecha DESC";
                    break;
                case 4:
                    sql = @"SELECT a.Id,p.Historia,p.Nombres Paciente,per.Nombres Medico,t.Prioridad,ad.Fecha Llegada,t.Fecha Triaje,a.Fecha RegistroAtencion,DATEDIFF(minute,ad.Fecha,t.Fecha) MinLlegadaTriaje,DATEDIFF(minute,t.Fecha,a.Fecha) MinTriajeRegistro,a.Conducta FROM Atencion a JOIN Personal per ON per.Id=a.MedicoId JOIN Triaje t ON t.Id=a.TriajeId JOIN Admision ad ON ad.Id=t.AdmisionId JOIN Paciente p ON p.Id=ad.PacienteId WHERE a.Fecha>=@d AND a.Fecha<@h AND (@p IS NULL OR p.Id=@p) AND (@m IS NULL OR a.MedicoId=@m) ORDER BY a.Fecha DESC";
                    break;
            }

            using (var db = new Db())
            {
                var t = db.Tabla(
                    sql,
                    Db.P("@d", desde.Date),
                    Db.P("@h", hasta.Date.AddDays(1)),
                    new System.Data.SqlClient.SqlParameter("@p", SqlDbType.Int) { Value = (object)paciente ?? DBNull.Value },
                    new System.Data.SqlClient.SqlParameter("@m", SqlDbType.Int) { Value = (object)medico ?? DBNull.Value });
                Catalogos.Auditar(db, s, "Consultar " + Nombres[i], "Consulta", paciente);
                return t;
            }
        }
    }
}
