-- Ejecutar una sola vez. Todo el script es un único lote.
USE master;
IF DB_ID(N'HospitalAcademico') IS NOT NULL
    THROW 50001, 'HospitalAcademico ya existe. No se modificó.', 1;
EXEC(N'CREATE DATABASE HospitalAcademico');
EXEC(N'USE HospitalAcademico;
CREATE TABLE Especialidad(Id int IDENTITY PRIMARY KEY, Nombre nvarchar(100) NOT NULL UNIQUE, Activo bit NOT NULL DEFAULT 1);
CREATE TABLE Personal(Id int IDENTITY PRIMARY KEY, Documento nvarchar(20) NOT NULL UNIQUE, Nombres nvarchar(150) NOT NULL,
 Cargo nvarchar(50) NOT NULL, EspecialidadId int NULL REFERENCES Especialidad(Id), Usuario nvarchar(50) NOT NULL UNIQUE,
 Rol nvarchar(30) NOT NULL CHECK(Rol IN (''Administrador'',''Recepcionista'',''Enfermero'',''Medico'',''Tecnico'',''Profesional'')),
 ClaveHash varbinary(32) NOT NULL, Salt varbinary(16) NOT NULL, Iteraciones int NOT NULL, Activo bit NOT NULL DEFAULT 1);
CREATE TABLE Paciente(Id int IDENTITY PRIMARY KEY, Documento nvarchar(20) NULL, Nombres nvarchar(150) NOT NULL,
 FechaNacimiento date NULL, Sexo nvarchar(20) NOT NULL, Direccion nvarchar(200) NULL, Telefono nvarchar(30) NULL,
 Temporal bit NOT NULL DEFAULT 0, Historia AS (''HC-''+RIGHT(''00000000''+CONVERT(varchar(10),Id),8)), Activo bit NOT NULL DEFAULT 1,
 CHECK(Temporal=1 OR (Documento IS NOT NULL AND FechaNacimiento IS NOT NULL)));
CREATE UNIQUE INDEX UX_Paciente_Documento ON Paciente(Documento) WHERE Documento IS NOT NULL;
CREATE TABLE Horario(Id int IDENTITY PRIMARY KEY, MedicoId int NOT NULL REFERENCES Personal(Id), Dia int NOT NULL CHECK(Dia BETWEEN 0 AND 6),
 Inicio time(0) NOT NULL, Fin time(0) NOT NULL, Duracion int NOT NULL CHECK(Duracion BETWEEN 5 AND 120), Activo bit NOT NULL DEFAULT 1, CHECK(Fin>Inicio));
CREATE TABLE Examen(Id int IDENTITY PRIMARY KEY, Codigo nvarchar(20) NOT NULL UNIQUE, Nombre nvarchar(100) NOT NULL,
 TipoMuestra nvarchar(80) NOT NULL, Unidad nvarchar(30) NULL, Referencia nvarchar(100) NULL, Activo bit NOT NULL DEFAULT 1);
CREATE TABLE MedicamentoProcedimiento(Id int IDENTITY PRIMARY KEY, Codigo nvarchar(20) NOT NULL UNIQUE,
 Nombre nvarchar(100) NOT NULL, Tipo nvarchar(20) NOT NULL CHECK(Tipo IN (''Medicamento'',''Procedimiento'')), Presentacion nvarchar(100) NOT NULL, Activo bit NOT NULL DEFAULT 1);
CREATE TABLE Admision(Id int IDENTITY PRIMARY KEY, PacienteId int NOT NULL REFERENCES Paciente(Id), Fecha datetime2 NOT NULL DEFAULT SYSDATETIME(),
 Tipo nvarchar(20) NOT NULL CHECK(Tipo IN (''Consulta'',''Emergencia'')), ResponsableId int NOT NULL REFERENCES Personal(Id));
CREATE TABLE Cita(Id int IDENTITY PRIMARY KEY, PacienteId int NOT NULL REFERENCES Paciente(Id), MedicoId int NOT NULL REFERENCES Personal(Id),
 Inicio datetime2 NOT NULL, Fin datetime2 NOT NULL, Estado nvarchar(20) NOT NULL DEFAULT ''Programada'' CHECK(Estado IN (''Programada'',''Anulada'',''Atendida'')),
 MotivoAnulacion nvarchar(250) NULL, ResponsableId int NOT NULL REFERENCES Personal(Id), CHECK(Fin>Inicio));
CREATE INDEX IX_Cita_MedicoFecha ON Cita(MedicoId,Inicio,Fin);
CREATE TABLE Triaje(Id int IDENTITY PRIMARY KEY, AdmisionId int NOT NULL UNIQUE REFERENCES Admision(Id), Motivo nvarchar(500) NOT NULL,
 Presion nvarchar(20) NOT NULL, FC int NOT NULL, FR int NOT NULL, Temperatura decimal(5,2) NOT NULL, Saturacion decimal(5,2) NOT NULL,
 Prioridad int NOT NULL CHECK(Prioridad BETWEEN 1 AND 4), Fecha datetime2 NOT NULL DEFAULT SYSDATETIME(), ResponsableId int NOT NULL REFERENCES Personal(Id),
 Estado nvarchar(20) NOT NULL DEFAULT ''Espera'' CHECK(Estado IN (''Espera'',''Atendido'')));
CREATE TABLE Atencion(Id int IDENTITY PRIMARY KEY, TriajeId int NOT NULL UNIQUE REFERENCES Triaje(Id), Evaluacion nvarchar(2000) NOT NULL,
 Diagnosticos nvarchar(1500) NOT NULL, Evolucion nvarchar(2000) NOT NULL, Conducta nvarchar(30) NOT NULL,
 Destino nvarchar(200) NULL, Fecha datetime2 NOT NULL DEFAULT SYSDATETIME(), MedicoId int NOT NULL REFERENCES Personal(Id));
CREATE TABLE Orden(Id int IDENTITY PRIMARY KEY, AtencionId int NOT NULL REFERENCES Atencion(Id), ExamenId int NOT NULL REFERENCES Examen(Id),
 Fecha datetime2 NOT NULL DEFAULT SYSDATETIME(), Estado nvarchar(20) NOT NULL DEFAULT ''Pendiente''
 CHECK(Estado IN (''Pendiente'',''Muestra tomada'',''En proceso'',''Con resultado'',''Rechazada'')));
CREATE TABLE Muestra(Id int IDENTITY PRIMARY KEY, OrdenId int NOT NULL UNIQUE REFERENCES Orden(Id), Codigo uniqueidentifier NOT NULL DEFAULT NEWID() UNIQUE,
 Fecha datetime2 NOT NULL DEFAULT SYSDATETIME(), TecnicoId int NOT NULL REFERENCES Personal(Id), Rotulada bit NOT NULL CHECK(Rotulada=1),
 Trasladada bit NOT NULL CHECK(Trasladada=1), Recepcion datetime2 NULL, ProcesadorId int NULL REFERENCES Personal(Id), MotivoRechazo nvarchar(500) NULL);
CREATE TABLE Resultado(Id int IDENTITY PRIMARY KEY, OrdenId int NOT NULL UNIQUE REFERENCES Orden(Id), Valor nvarchar(500) NOT NULL,
 Observacion nvarchar(500) NULL, FueraRango bit NOT NULL, Fecha datetime2 NOT NULL DEFAULT SYSDATETIME(), ProfesionalId int NOT NULL REFERENCES Personal(Id));
CREATE TABLE Indicacion(Id int IDENTITY PRIMARY KEY, AtencionId int NOT NULL REFERENCES Atencion(Id), ProductoId int NOT NULL REFERENCES MedicamentoProcedimiento(Id),
 Instruccion nvarchar(500) NOT NULL, MedicoId int NOT NULL REFERENCES Personal(Id));
CREATE TABLE Administracion(Id int IDENTITY PRIMARY KEY, IndicacionId int NOT NULL REFERENCES Indicacion(Id), Detalle nvarchar(500) NOT NULL,
 Fecha datetime2 NOT NULL DEFAULT SYSDATETIME(), EnfermeroId int NOT NULL REFERENCES Personal(Id));
CREATE TABLE Auditoria(Id bigint IDENTITY PRIMARY KEY, UsuarioId int NULL REFERENCES Personal(Id), Fecha datetime2 NOT NULL DEFAULT SYSDATETIME(),
 Accion nvarchar(100) NOT NULL, Entidad nvarchar(80) NOT NULL, RegistroId int NULL);
INSERT Especialidad(Nombre) VALUES(N''Medicina general'');
');
