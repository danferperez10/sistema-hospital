-- =====================================================
-- verificaciones.sql
-- Comprobaciones de HospitalAcademico (SQL Server)
-- Solo lectura: no modifica datos.
-- Requisito: haber ejecutado antes BaseDatos/01_Crear.sql
-- Resultado: "OK" = bien, "REVISAR" = hay problemas.
-- =====================================================
USE HospitalAcademico;
GO

-- 1. Las 16 tablas existen
SELECT t.Nombre AS Tabla,
       CASE WHEN o.object_id IS NULL THEN 'FALTA' ELSE 'OK' END AS Resultado
FROM (VALUES ('Especialidad'),('Personal'),('Paciente'),('Horario'),
             ('Examen'),('MedicamentoProcedimiento'),('Admision'),('Cita'),
             ('Triaje'),('Atencion'),('Orden'),('Muestra'),('Resultado'),
             ('Indicacion'),('Administracion'),('Auditoria')) t(Nombre)
LEFT JOIN sys.tables o ON o.name = t.Nombre AND o.schema_id = SCHEMA_ID('dbo');
GO

-- 2. Todas las tablas tienen clave primaria (0 filas = OK)
SELECT name AS TablaSinClavePrimaria
FROM sys.tables
WHERE OBJECTPROPERTY(object_id, 'TableHasPrimaryKey') = 0;
GO

-- 3. Claves foraneas: deben ser 24
SELECT COUNT(*) AS TotalFK, 24 AS Esperado,
       CASE WHEN COUNT(*) = 24 THEN 'OK' ELSE 'REVISAR' END AS Resultado
FROM sys.foreign_keys;
GO

-- 4. Claves foraneas deshabilitadas o no confiables (0 filas = OK)
SELECT name AS ForaneaConProblema, is_disabled, is_not_trusted
FROM sys.foreign_keys
WHERE is_disabled = 1 OR is_not_trusted = 1;
GO

-- 5. Registros huerfanos (hijo apunta a un padre que no existe)
SELECT Comprobacion, Problemas,
       CASE WHEN Problemas = 0 THEN 'OK' ELSE 'REVISAR' END AS Resultado
FROM (
 SELECT 'Personal.EspecialidadId' AS Comprobacion, COUNT(*) AS Problemas FROM Personal h WHERE h.EspecialidadId IS NOT NULL AND NOT EXISTS (SELECT 1 FROM Especialidad p WHERE p.Id = h.EspecialidadId)
 UNION ALL SELECT 'Horario.MedicoId', COUNT(*) FROM Horario h WHERE NOT EXISTS (SELECT 1 FROM Personal p WHERE p.Id = h.MedicoId)
 UNION ALL SELECT 'Admision.PacienteId', COUNT(*) FROM Admision h WHERE NOT EXISTS (SELECT 1 FROM Paciente p WHERE p.Id = h.PacienteId)
 UNION ALL SELECT 'Admision.ResponsableId', COUNT(*) FROM Admision h WHERE NOT EXISTS (SELECT 1 FROM Personal p WHERE p.Id = h.ResponsableId)
 UNION ALL SELECT 'Cita.PacienteId', COUNT(*) FROM Cita h WHERE NOT EXISTS (SELECT 1 FROM Paciente p WHERE p.Id = h.PacienteId)
 UNION ALL SELECT 'Cita.MedicoId', COUNT(*) FROM Cita h WHERE NOT EXISTS (SELECT 1 FROM Personal p WHERE p.Id = h.MedicoId)
 UNION ALL SELECT 'Cita.ResponsableId', COUNT(*) FROM Cita h WHERE NOT EXISTS (SELECT 1 FROM Personal p WHERE p.Id = h.ResponsableId)
 UNION ALL SELECT 'Triaje.AdmisionId', COUNT(*) FROM Triaje h WHERE NOT EXISTS (SELECT 1 FROM Admision p WHERE p.Id = h.AdmisionId)
 UNION ALL SELECT 'Triaje.ResponsableId', COUNT(*) FROM Triaje h WHERE NOT EXISTS (SELECT 1 FROM Personal p WHERE p.Id = h.ResponsableId)
 UNION ALL SELECT 'Atencion.TriajeId', COUNT(*) FROM Atencion h WHERE NOT EXISTS (SELECT 1 FROM Triaje p WHERE p.Id = h.TriajeId)
 UNION ALL SELECT 'Atencion.MedicoId', COUNT(*) FROM Atencion h WHERE NOT EXISTS (SELECT 1 FROM Personal p WHERE p.Id = h.MedicoId)
 UNION ALL SELECT 'Orden.AtencionId', COUNT(*) FROM Orden h WHERE NOT EXISTS (SELECT 1 FROM Atencion p WHERE p.Id = h.AtencionId)
 UNION ALL SELECT 'Orden.ExamenId', COUNT(*) FROM Orden h WHERE NOT EXISTS (SELECT 1 FROM Examen p WHERE p.Id = h.ExamenId)
 UNION ALL SELECT 'Muestra.OrdenId', COUNT(*) FROM Muestra h WHERE NOT EXISTS (SELECT 1 FROM Orden p WHERE p.Id = h.OrdenId)
 UNION ALL SELECT 'Muestra.TecnicoId', COUNT(*) FROM Muestra h WHERE NOT EXISTS (SELECT 1 FROM Personal p WHERE p.Id = h.TecnicoId)
 UNION ALL SELECT 'Muestra.ProcesadorId', COUNT(*) FROM Muestra h WHERE h.ProcesadorId IS NOT NULL AND NOT EXISTS (SELECT 1 FROM Personal p WHERE p.Id = h.ProcesadorId)
 UNION ALL SELECT 'Resultado.OrdenId', COUNT(*) FROM Resultado h WHERE NOT EXISTS (SELECT 1 FROM Orden p WHERE p.Id = h.OrdenId)
 UNION ALL SELECT 'Resultado.ProfesionalId', COUNT(*) FROM Resultado h WHERE NOT EXISTS (SELECT 1 FROM Personal p WHERE p.Id = h.ProfesionalId)
 UNION ALL SELECT 'Indicacion.AtencionId', COUNT(*) FROM Indicacion h WHERE NOT EXISTS (SELECT 1 FROM Atencion p WHERE p.Id = h.AtencionId)
 UNION ALL SELECT 'Indicacion.ProductoId', COUNT(*) FROM Indicacion h WHERE NOT EXISTS (SELECT 1 FROM MedicamentoProcedimiento p WHERE p.Id = h.ProductoId)
 UNION ALL SELECT 'Indicacion.MedicoId', COUNT(*) FROM Indicacion h WHERE NOT EXISTS (SELECT 1 FROM Personal p WHERE p.Id = h.MedicoId)
 UNION ALL SELECT 'Administracion.IndicacionId', COUNT(*) FROM Administracion h WHERE NOT EXISTS (SELECT 1 FROM Indicacion p WHERE p.Id = h.IndicacionId)
 UNION ALL SELECT 'Administracion.EnfermeroId', COUNT(*) FROM Administracion h WHERE NOT EXISTS (SELECT 1 FROM Personal p WHERE p.Id = h.EnfermeroId)
 UNION ALL SELECT 'Auditoria.UsuarioId', COUNT(*) FROM Auditoria h WHERE h.UsuarioId IS NOT NULL AND NOT EXISTS (SELECT 1 FROM Personal p WHERE p.Id = h.UsuarioId)
) x;
GO

-- 6. Duplicados en campos que deben ser unicos
SELECT Comprobacion, Problemas,
       CASE WHEN Problemas = 0 THEN 'OK' ELSE 'REVISAR' END AS Resultado
FROM (
 SELECT 'Personal.Documento repetido' AS Comprobacion, COUNT(*) AS Problemas FROM (SELECT Documento FROM Personal GROUP BY Documento HAVING COUNT(*) > 1) d
 UNION ALL SELECT 'Personal.Usuario repetido', COUNT(*) FROM (SELECT Usuario FROM Personal GROUP BY Usuario HAVING COUNT(*) > 1) d
 UNION ALL SELECT 'Paciente.Documento repetido', COUNT(*) FROM (SELECT Documento FROM Paciente WHERE Documento IS NOT NULL GROUP BY Documento HAVING COUNT(*) > 1) d
 UNION ALL SELECT 'Especialidad.Nombre repetido', COUNT(*) FROM (SELECT Nombre FROM Especialidad GROUP BY Nombre HAVING COUNT(*) > 1) d
 UNION ALL SELECT 'Examen.Codigo repetido', COUNT(*) FROM (SELECT Codigo FROM Examen GROUP BY Codigo HAVING COUNT(*) > 1) d
 UNION ALL SELECT 'MedicamentoProcedimiento.Codigo repetido', COUNT(*) FROM (SELECT Codigo FROM MedicamentoProcedimiento GROUP BY Codigo HAVING COUNT(*) > 1) d
) x;
GO

-- 7. Reglas de negocio (basadas en los CHECK y estados del esquema)
SELECT Comprobacion, Problemas,
       CASE WHEN Problemas = 0 THEN 'OK' ELSE 'REVISAR' END AS Resultado
FROM (
 SELECT 'Cita con Fin <= Inicio' AS Comprobacion, COUNT(*) AS Problemas FROM Cita WHERE Fin <= Inicio
 UNION ALL SELECT 'Horario con Fin <= Inicio', COUNT(*) FROM Horario WHERE Fin <= Inicio
 UNION ALL SELECT 'Citas programadas solapadas (mismo medico)', COUNT(*)
   FROM Cita a JOIN Cita b ON a.MedicoId = b.MedicoId AND a.Id < b.Id
   WHERE a.Estado = 'Programada' AND b.Estado = 'Programada'
     AND a.Inicio < b.Fin AND b.Inicio < a.Fin
 UNION ALL SELECT 'Cita asignada a alguien que no es Medico', COUNT(*)
   FROM Cita c JOIN Personal p ON p.Id = c.MedicoId WHERE p.Rol <> 'Medico'
 UNION ALL SELECT 'Horario asignado a alguien que no es Medico', COUNT(*)
   FROM Horario h JOIN Personal p ON p.Id = h.MedicoId WHERE p.Rol <> 'Medico'
 UNION ALL SELECT 'Cita anulada sin motivo', COUNT(*)
   FROM Cita WHERE Estado = 'Anulada' AND (MotivoAnulacion IS NULL OR LTRIM(RTRIM(MotivoAnulacion)) = '')
 UNION ALL SELECT 'Paciente no temporal sin documento o fecha de nacimiento', COUNT(*)
   FROM Paciente WHERE Temporal = 0 AND (Documento IS NULL OR FechaNacimiento IS NULL)
 UNION ALL SELECT 'Triaje
