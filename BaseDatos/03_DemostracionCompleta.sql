-- DATOS FICTICIOS PARA EL SISTEMA HOSPITAL
-- Ejecutar completo en localhost, una vez creada HospitalAcademico.
-- No borra registros, no cambia contraseñas existentes y no recrea la base.
-- Catálogo de demostración: sin dosis, concentraciones ni indicaciones terapéuticas.
USE [HospitalAcademico];
SET NOCOUNT ON;
SET XACT_ABORT ON;
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
BEGIN TRY
    BEGIN TRANSACTION;
    IF OBJECT_ID(N'dbo.Personal', N'U') IS NULL
        THROW 51000, 'Faltan las tablas del proyecto. Ejecute 01_Crear.sql solo si la base todavía no existe.', 1;
    IF NOT EXISTS(SELECT 1 FROM dbo.Personal WHERE Rol=N'Administrador' AND Activo=1)
        THROW 51001, 'Cree primero el administrador inicial desde el login. Luego ejecute este script.', 1;

    DECLARE @Resumen TABLE(Entidad nvarchar(70), Insertados int);
    DECLARE @Especialidades TABLE(Nombre nvarchar(100));
    INSERT INTO @Especialidades VALUES
    (N'Medicina general'),
    (N'Pediatría'),
    (N'Cardiología'),
    (N'Dermatología'),
    (N'Traumatología'),
    (N'Ginecología'),
    (N'Neurología'),
    (N'Endocrinología');
    INSERT dbo.Especialidad(Nombre, Activo)
    SELECT e.Nombre,1 FROM @Especialidades e
    WHERE NOT EXISTS(SELECT 1 FROM dbo.Especialidad x WITH(UPDLOCK,HOLDLOCK) WHERE x.Nombre=e.Nombre);
    INSERT @Resumen VALUES(N'Especialidades',@@ROWCOUNT);

    DECLARE @Productos TABLE(Codigo nvarchar(20),Nombre nvarchar(100),Tipo nvarchar(20),Presentacion nvarchar(100));
    INSERT @Productos VALUES
    (N'DEMO-M001', N'Vitamina A', N'Medicamento', N'Vitaminas | Presentación por completar'),
    (N'DEMO-M002', N'Vitamina B1 (tiamina)', N'Medicamento', N'Vitaminas | Presentación por completar'),
    (N'DEMO-M003', N'Vitamina B2 (riboflavina)', N'Medicamento', N'Vitaminas | Presentación por completar'),
    (N'DEMO-M004', N'Vitamina B3 (niacina)', N'Medicamento', N'Vitaminas | Presentación por completar'),
    (N'DEMO-M005', N'Vitamina B5', N'Medicamento', N'Vitaminas | Presentación por completar'),
    (N'DEMO-M006', N'Vitamina B6 (piridoxina)', N'Medicamento', N'Vitaminas | Presentación por completar'),
    (N'DEMO-M007', N'Vitamina B7 (biotina)', N'Medicamento', N'Vitaminas | Presentación por completar'),
    (N'DEMO-M008', N'Vitamina B9 (ácido fólico)', N'Medicamento', N'Vitaminas | Presentación por completar'),
    (N'DEMO-M009', N'Vitamina B12', N'Medicamento', N'Vitaminas | Presentación por completar'),
    (N'DEMO-M010', N'Vitamina C', N'Medicamento', N'Vitaminas | Presentación por completar'),
    (N'DEMO-M011', N'Vitamina D3', N'Medicamento', N'Vitaminas | Presentación por completar'),
    (N'DEMO-M012', N'Vitamina E', N'Medicamento', N'Vitaminas | Presentación por completar'),
    (N'DEMO-M013', N'Paracetamol', N'Medicamento', N'Analgésicos y antiinflamatorios | Presentación por completar'),
    (N'DEMO-M014', N'Ibuprofeno', N'Medicamento', N'Analgésicos y antiinflamatorios | Presentación por completar'),
    (N'DEMO-M015', N'Naproxeno', N'Medicamento', N'Analgésicos y antiinflamatorios | Presentación por completar'),
    (N'DEMO-M016', N'Diclofenaco', N'Medicamento', N'Analgésicos y antiinflamatorios | Presentación por completar'),
    (N'DEMO-M017', N'Ketoprofeno', N'Medicamento', N'Analgésicos y antiinflamatorios | Presentación por completar'),
    (N'DEMO-M018', N'Dexketoprofeno', N'Medicamento', N'Analgésicos y antiinflamatorios | Presentación por completar'),
    (N'DEMO-M019', N'Meloxicam', N'Medicamento', N'Analgésicos y antiinflamatorios | Presentación por completar'),
    (N'DEMO-M020', N'Celecoxib', N'Medicamento', N'Analgésicos y antiinflamatorios | Presentación por completar'),
    (N'DEMO-M021', N'Loratadina', N'Medicamento', N'Antihistamínicos | Presentación por completar'),
    (N'DEMO-M022', N'Cetirizina', N'Medicamento', N'Antihistamínicos | Presentación por completar'),
    (N'DEMO-M023', N'Desloratadina', N'Medicamento', N'Antihistamínicos | Presentación por completar'),
    (N'DEMO-M024', N'Fexofenadina', N'Medicamento', N'Antihistamínicos | Presentación por completar'),
    (N'DEMO-M025', N'Clorfenamina', N'Medicamento', N'Antihistamínicos | Presentación por completar'),
    (N'DEMO-M026', N'Omeprazol', N'Medicamento', N'Digestivos | Presentación por completar'),
    (N'DEMO-M027', N'Pantoprazol', N'Medicamento', N'Digestivos | Presentación por completar'),
    (N'DEMO-M028', N'Esomeprazol', N'Medicamento', N'Digestivos | Presentación por completar'),
    (N'DEMO-M029', N'Famotidina', N'Medicamento', N'Digestivos | Presentación por completar'),
    (N'DEMO-M030', N'Hidróxido de magnesio', N'Medicamento', N'Digestivos | Presentación por completar'),
    (N'DEMO-M031', N'Simeticona', N'Medicamento', N'Digestivos | Presentación por completar'),
    (N'DEMO-M032', N'Lactulosa', N'Medicamento', N'Digestivos | Presentación por completar'),
    (N'DEMO-M033', N'Amoxicilina', N'Medicamento', N'Antibacterianos | Presentación por completar'),
    (N'DEMO-M034', N'Amoxicilina con ácido clavulánico', N'Medicamento', N'Antibacterianos | Presentación por completar'),
    (N'DEMO-M035', N'Cefalexina', N'Medicamento', N'Antibacterianos | Presentación por completar'),
    (N'DEMO-M036', N'Azitromicina', N'Medicamento', N'Antibacterianos | Presentación por completar'),
    (N'DEMO-M037', N'Claritromicina', N'Medicamento', N'Antibacterianos | Presentación por completar'),
    (N'DEMO-M038', N'Doxiciclina', N'Medicamento', N'Antibacterianos | Presentación por completar'),
    (N'DEMO-M039', N'Metronidazol', N'Medicamento', N'Antibacterianos | Presentación por completar'),
    (N'DEMO-M040', N'Clindamicina', N'Medicamento', N'Antibacterianos | Presentación por completar'),
    (N'DEMO-M041', N'Losartán', N'Medicamento', N'Cardiovasculares y diuréticos | Presentación por completar'),
    (N'DEMO-M042', N'Valsartán', N'Medicamento', N'Cardiovasculares y diuréticos | Presentación por completar'),
    (N'DEMO-M043', N'Enalapril', N'Medicamento', N'Cardiovasculares y diuréticos | Presentación por completar'),
    (N'DEMO-M044', N'Amlodipino', N'Medicamento', N'Cardiovasculares y diuréticos | Presentación por completar'),
    (N'DEMO-M045', N'Atenolol', N'Medicamento', N'Cardiovasculares y diuréticos | Presentación por completar'),
    (N'DEMO-M046', N'Hidroclorotiazida', N'Medicamento', N'Cardiovasculares y diuréticos | Presentación por completar'),
    (N'DEMO-M047', N'Furosemida', N'Medicamento', N'Cardiovasculares y diuréticos | Presentación por completar'),
    (N'DEMO-M048', N'Metformina', N'Medicamento', N'Endocrinos | Presentación por completar'),
    (N'DEMO-M049', N'Levotiroxina', N'Medicamento', N'Endocrinos | Presentación por completar'),
    (N'DEMO-M050', N'Glibenclamida', N'Medicamento', N'Endocrinos | Presentación por completar'),
    (N'DEMO-PR01', N'Curación simple', N'Procedimiento', N'Procedimiento de demostración'),
    (N'DEMO-PR02', N'Control de signos vitales', N'Procedimiento', N'Procedimiento de demostración'),
    (N'DEMO-PR03', N'Electrocardiograma', N'Procedimiento', N'Procedimiento de demostración'),
    (N'DEMO-PR04', N'Retiro de puntos', N'Procedimiento', N'Procedimiento de demostración'),
    (N'DEMO-PR05', N'Nebulización', N'Procedimiento', N'Procedimiento de demostración');
    IF EXISTS(SELECT 1 FROM @Productos p JOIN dbo.MedicamentoProcedimiento x ON x.Codigo=p.Codigo WHERE x.Tipo<>p.Tipo)
        THROW 51002, 'Un código DEMO de producto está ocupado por otro tipo. No se aplicaron cambios.', 1;
    INSERT dbo.MedicamentoProcedimiento(Codigo,Nombre,Tipo,Presentacion,Activo)
    SELECT p.Codigo,p.Nombre,p.Tipo,p.Presentacion,1 FROM @Productos p
    WHERE NOT EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento x WITH(UPDLOCK,HOLDLOCK) WHERE x.Codigo=p.Codigo);
    INSERT @Resumen VALUES(N'Medicamentos y procedimientos',@@ROWCOUNT);

    DECLARE @Pacientes TABLE(Documento nvarchar(20),Nombres nvarchar(150),Nacimiento date,Sexo nvarchar(20),Direccion nvarchar(200),Telefono nvarchar(30));
    INSERT @Pacientes VALUES
    (N'DEMO-P001', N'Valeria Soto [DEMO]', N'1976-02-02', N'Femenino', N'Dirección ficticia 01', NULL),
    (N'DEMO-P002', N'Mateo Rivas [DEMO]', N'1977-03-03', N'Masculino', N'Dirección ficticia 02', NULL),
    (N'DEMO-P003', N'Camila Flores [DEMO]', N'1978-04-04', N'Femenino', N'Dirección ficticia 03', NULL),
    (N'DEMO-P004', N'Sebastián Ruiz [DEMO]', N'1979-05-05', N'Masculino', N'Dirección ficticia 04', NULL),
    (N'DEMO-P005', N'Daniela Campos [DEMO]', N'1980-06-06', N'Femenino', N'Dirección ficticia 05', NULL),
    (N'DEMO-P006', N'Gabriel Vega [DEMO]', N'1981-07-07', N'Masculino', N'Dirección ficticia 06', NULL),
    (N'DEMO-P007', N'Isabella Ramos [DEMO]', N'1982-08-08', N'Femenino', N'Dirección ficticia 07', NULL),
    (N'DEMO-P008', N'Nicolás Díaz [DEMO]', N'1983-09-09', N'Masculino', N'Dirección ficticia 08', NULL),
    (N'DEMO-P009', N'Mariana Romero [DEMO]', N'1984-10-10', N'Femenino', N'Dirección ficticia 09', NULL),
    (N'DEMO-P010', N'Adrián Cruz [DEMO]', N'1985-11-11', N'Masculino', N'Dirección ficticia 10', NULL),
    (N'DEMO-P011', N'Paula Herrera [DEMO]', N'1986-12-12', N'Femenino', N'Dirección ficticia 11', NULL),
    (N'DEMO-P012', N'Samuel Ortiz [DEMO]', N'1987-01-13', N'Masculino', N'Dirección ficticia 12', NULL),
    (N'DEMO-P013', N'Renata Medina [DEMO]', N'1988-02-14', N'Femenino', N'Dirección ficticia 13', NULL),
    (N'DEMO-P014', N'Bruno Aguilar [DEMO]', N'1989-03-15', N'Masculino', N'Dirección ficticia 14', NULL),
    (N'DEMO-P015', N'Natalia Fuentes [DEMO]', N'1990-04-16', N'Femenino', N'Dirección ficticia 15', NULL),
    (N'DEMO-P016', N'Emilio Navarro [DEMO]', N'1991-05-17', N'Masculino', N'Dirección ficticia 16', NULL),
    (N'DEMO-P017', N'Julia Cárdenas [DEMO]', N'1992-06-18', N'Femenino', N'Dirección ficticia 17', NULL),
    (N'DEMO-P018', N'Tomás Lozano [DEMO]', N'1993-07-19', N'Masculino', N'Dirección ficticia 18', NULL),
    (N'DEMO-P019', N'Andrea Benítez [DEMO]', N'1994-08-20', N'Femenino', N'Dirección ficticia 19', NULL),
    (N'DEMO-P020', N'David Ponce [DEMO]', N'1995-09-21', N'Masculino', N'Dirección ficticia 20', NULL);
    INSERT dbo.Paciente(Documento,Nombres,FechaNacimiento,Sexo,Direccion,Telefono,Temporal,Activo)
    SELECT p.Documento,p.Nombres,p.Nacimiento,p.Sexo,p.Direccion,p.Telefono,0,1 FROM @Pacientes p
    WHERE NOT EXISTS(SELECT 1 FROM dbo.Paciente x WITH(UPDLOCK,HOLDLOCK) WHERE x.Documento=p.Documento);
    INSERT @Resumen VALUES(N'Pacientes ficticios',@@ROWCOUNT);

    DECLARE @Examenes TABLE(Codigo nvarchar(20),Nombre nvarchar(100),TipoMuestra nvarchar(80));
    INSERT @Examenes VALUES
    (N'DEMO-E001', N'Hemograma', N'Sangre'),
    (N'DEMO-E002', N'Glucosa', N'Sangre'),
    (N'DEMO-E003', N'Colesterol total', N'Sangre'),
    (N'DEMO-E004', N'Triglicéridos', N'Sangre'),
    (N'DEMO-E005', N'Creatinina', N'Sangre'),
    (N'DEMO-E006', N'Urea', N'Sangre'),
    (N'DEMO-E007', N'Examen completo de orina', N'Orina'),
    (N'DEMO-E008', N'Urocultivo', N'Orina'),
    (N'DEMO-E009', N'Examen parasitológico', N'Heces'),
    (N'DEMO-E010', N'Hemoglobina glicosilada', N'Sangre'),
    (N'DEMO-E011', N'TSH', N'Sangre'),
    (N'DEMO-E012', N'Proteína C reactiva', N'Sangre'),
    (N'DEMO-E013', N'Perfil hepático', N'Sangre'),
    (N'DEMO-E014', N'Grupo sanguíneo y Rh', N'Sangre'),
    (N'DEMO-E015', N'Electrolitos', N'Sangre');
    INSERT dbo.Examen(Codigo,Nombre,TipoMuestra,Unidad,Referencia,Activo)
    SELECT e.Codigo,e.Nombre,e.TipoMuestra,NULL,N'DEMO: pendiente de validación',1 FROM @Examenes e
    WHERE NOT EXISTS(SELECT 1 FROM dbo.Examen x WITH(UPDLOCK,HOLDLOCK) WHERE x.Codigo=e.Codigo);
    INSERT @Resumen VALUES(N'Exámenes de laboratorio',@@ROWCOUNT);

    DECLARE @Personal TABLE(Documento nvarchar(20),Nombres nvarchar(150),Cargo nvarchar(50),Especialidad nvarchar(100),Usuario nvarchar(50),Rol nvarchar(30),ClaveHash varbinary(32),Salt varbinary(16));
    INSERT @Personal VALUES

    (N'DEMO-D001', N'Ana Torres [DEMO]', N'Médico', N'Medicina general', N'demo.medico01', N'Medico', 0x8980bfe65302cd6225433b9e2401ea7ee69b0cb6c37171a6a0f11284303c9ac4, 0xcf51d9d688d7c8745b99102bc3a84f1b),
    (N'DEMO-D002', N'Luis Mendoza [DEMO]', N'Médico', N'Pediatría', N'demo.medico02', N'Medico', 0x544b7f9bf50e6385b30620a30da7aeacf9bf5b7c0ad7d4b6c142cebaba38f840, 0xe49d603cb30f0c2fbcd1bae075837429),
    (N'DEMO-D003', N'Carla Rojas [DEMO]', N'Médico', N'Cardiología', N'demo.medico03', N'Medico', 0x663d51d5e39f3e3d13e1c47239799a57adf29890b55a363707618f068d0b1c37, 0x7fda8e4f6a87396d4f7299d86dbe04d9),
    (N'DEMO-D004', N'Diego Salazar [DEMO]', N'Médico', N'Dermatología', N'demo.medico04', N'Medico', 0xb38099b72812f8e91ce49a35433c8ade43a0bc28c489c5652ef7c75cb65d2466, 0x56f1bfce8a569bc9497bcf360f03d9e0),
    (N'DEMO-D005', N'Elena Vargas [DEMO]', N'Médico', N'Traumatología', N'demo.medico05', N'Medico', 0x769321909620961dc50e37c314268dd6dce08da5aaeecf27366bbb4cfdf05fbf, 0x484514c35e8c30174fddf4115306ba93),
    (N'DEMO-D006', N'Mario Castro [DEMO]', N'Médico', N'Ginecología', N'demo.medico06', N'Medico', 0x57f7436e9993149fde28d3ae9809cd22caa39d2c9dece67d419af1e5d6bc316b, 0xae87c7727900607865d218dec49e2b24),
    (N'DEMO-D007', N'Lucía Paredes [DEMO]', N'Médico', N'Neurología', N'demo.medico07', N'Medico', 0xda491ac316ec55a1329bb214d1524102d5442ba3566b69ae91cfac16603fa038, 0x0e653faae7132b874987261e1f6701a3),
    (N'DEMO-D008', N'Jorge Molina [DEMO]', N'Médico', N'Endocrinología', N'demo.medico08', N'Medico', 0x63a13bc2ea3893781a5bc53e6c000285c7d9a132313daeb0b89608643e02a45f, 0xedc7d0fb0f3ab7cde6f5d9143da86a45),
    (N'DEMO-T001', N'Rosa Silva [DEMO]', N'Recepción', NULL, N'demo.recepcion', N'Recepcionista', 0x76d42080f54d0a90af59065a3b076e659f475f5c13b5cb737e191551f86808c7, 0x14fc24df55dde28a0a0e911d2f767909),
    (N'DEMO-T002', N'Pedro León [DEMO]', N'Enfermería', NULL, N'demo.enfermeria', N'Enfermero', 0x85078e8aa65140c858e204a28db462142f4699779a18723e120ebc7844f1199b, 0x120d9866a299020a804cb2c02ae2aed7),
    (N'DEMO-T003', N'Sofía Peña [DEMO]', N'Técnico de laboratorio', NULL, N'demo.tecnico', N'Tecnico', 0x13e9c494db417e8d407c2c9e55191361926b2b22d4d0880b6ca2e11f7c24f208, 0x8881b769c34e3287eb9248a522e04d91),
    (N'DEMO-T004', N'Andrés Luna [DEMO]', N'Profesional de laboratorio', NULL, N'demo.laboratorio', N'Profesional', 0x437c14cb39c8e76631189dc926cfdbb88b5b4519b184253d925c3f4c05dd2b5d, 0xb2e9bb5c52783eb2b4957e43dad6f7e4);
    -- No vincular un usuario DEMO con un documento o rol de otra persona.
    IF EXISTS(SELECT 1 FROM @Personal p JOIN dbo.Personal x ON x.Usuario=p.Usuario OR x.Documento=p.Documento
              WHERE x.Usuario<>p.Usuario OR x.Documento<>p.Documento OR x.Rol<>p.Rol)
        THROW 51003, 'Existe una colisión de usuario/documento/rol DEMO. No se aplicaron cambios.', 1;
    INSERT dbo.Personal(Documento,Nombres,Cargo,EspecialidadId,Usuario,Rol,ClaveHash,Salt,Iteraciones,Activo)
    SELECT p.Documento,p.Nombres,p.Cargo,e.Id,p.Usuario,p.Rol,p.ClaveHash,p.Salt,600000,1
    FROM @Personal p LEFT JOIN dbo.Especialidad e ON e.Nombre=p.Especialidad
    WHERE NOT EXISTS(SELECT 1 FROM dbo.Personal x WITH(UPDLOCK,HOLDLOCK) WHERE x.Usuario=p.Usuario);
    INSERT @Resumen VALUES(N'Personal ficticio (8 médicos y 4 usuarios)',@@ROWCOUNT);

    -- Dos turnos semanales por médico: lunes y miércoles, 08:00 a 12:00.
    -- Se omite cualquier turno que se cruce con un horario existente.
    INSERT dbo.Horario(MedicoId,Dia,Inicio,Fin,Duracion,Activo)
    SELECT m.Id,d.Dia,CONVERT(time,'08:00'),CONVERT(time,'12:00'),20,1
    FROM dbo.Personal m JOIN @Personal p ON m.Usuario=p.Usuario AND m.Documento=p.Documento
    CROSS JOIN (VALUES(1),(3)) d(Dia)
    WHERE m.Rol=N'Medico' AND m.Activo=1
      AND NOT EXISTS(SELECT 1 FROM dbo.Horario h WITH(UPDLOCK,HOLDLOCK)
                     WHERE h.MedicoId=m.Id AND h.Dia=d.Dia
                     AND ((h.Activo=1 AND h.Inicio<CONVERT(time,'12:00') AND h.Fin>CONVERT(time,'08:00'))
                          OR (h.Inicio=CONVERT(time,'08:00') AND h.Fin=CONVERT(time,'12:00'))));
    INSERT @Resumen VALUES(N'Horarios de médicos (hasta 16)',@@ROWCOUNT);

    COMMIT TRANSACTION;
    SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
    SELECT Entidad,Insertados FROM @Resumen;
    SELECT Tipo,COUNT(*) AS ProductosDemo FROM dbo.MedicamentoProcedimiento
    WHERE Codigo IN(SELECT Codigo FROM @Productos) GROUP BY Tipo;
END TRY
BEGIN CATCH
    IF @@TRANCOUNT>0 ROLLBACK TRANSACTION;
    SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
    THROW;
END CATCH;


-- ETAPA 2: casos ficticios para todas las listas de procesos.
-- Para otra ronda de práctica, cambie DEMO-01 por DEMO-02, etc.
DECLARE @Lote nvarchar(30)=N'DEMO-01';
DECLARE @Ahora datetime2=SYSDATETIME();
DECLARE @Base datetime2=DATEADD(minute,-180,@Ahora);
SET XACT_ABORT ON;
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
BEGIN TRY
    BEGIN TRANSACTION;
    IF OBJECT_ID(N'dbo.DemoHospitalRegistro',N'U') IS NULL
        CREATE TABLE dbo.DemoHospitalRegistro(
            Clave nvarchar(100) NOT NULL PRIMARY KEY,
            Entidad nvarchar(30) NOT NULL,
            RegistroId int NOT NULL,
            Creado datetime2 NOT NULL DEFAULT SYSDATETIME()
        );

    DECLARE @Recepcion int=(SELECT Id FROM dbo.Personal WHERE Usuario=N'demo.recepcion' AND Activo=1);
    DECLARE @Enfermero int=(SELECT Id FROM dbo.Personal WHERE Usuario=N'demo.enfermeria' AND Activo=1);
    DECLARE @Tecnico int=(SELECT Id FROM dbo.Personal WHERE Usuario=N'demo.tecnico' AND Activo=1);
    DECLARE @Profesional int=(SELECT Id FROM dbo.Personal WHERE Usuario=N'demo.laboratorio' AND Activo=1);
    IF @Recepcion IS NULL OR @Enfermero IS NULL OR @Tecnico IS NULL OR @Profesional IS NULL
        THROW 51101,'Faltan cuentas DEMO activas. Revise la carga inicial.',1;
    IF (SELECT COUNT(*) FROM dbo.Personal WHERE Usuario BETWEEN N'demo.medico01' AND N'demo.medico08' AND Rol=N'Medico' AND Activo=1)<>8
        THROW 51102,'Se necesitan los ocho médicos DEMO activos.',1;
    IF (SELECT COUNT(*) FROM dbo.Paciente WHERE Documento BETWEEN N'DEMO-P001' AND N'DEMO-P020' AND Activo=1)<>20
        THROW 51103,'Se necesitan los veinte pacientes DEMO activos.',1;

    DECLARE @i int=1,@Paciente int,@Medico int,@Admision int,@Triaje int,@Atencion int;
    DECLARE @Clave nvarchar(100),@Codigo nvarchar(20),@Fecha datetime2;
    WHILE @i<=20
    BEGIN
        SET @Codigo=N'DEMO-P'+RIGHT(N'000'+CONVERT(nvarchar(3),@i),3);
        SELECT @Paciente=Id FROM dbo.Paciente WHERE Documento=@Codigo;
        SET @Fecha=DATEADD(minute,@i*3,@Base);
        SET @Clave=@Lote+N'/Admision/'+CONVERT(nvarchar(3),@i);
        IF NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WITH(UPDLOCK,HOLDLOCK) WHERE Clave=@Clave)
        BEGIN
            INSERT dbo.Admision(PacienteId,Fecha,Tipo,ResponsableId)
            VALUES(@Paciente,@Fecha,N'Emergencia',@Recepcion);
            SET @Admision=CONVERT(int,SCOPE_IDENTITY());
            INSERT dbo.DemoHospitalRegistro VALUES(@Clave,N'Admision',@Admision,@Ahora);
        END
        ELSE SELECT @Admision=RegistroId FROM dbo.DemoHospitalRegistro WHERE Clave=@Clave;

        -- 1..6: admisiones listas para registrar triaje.
        -- 7..12: triajes en espera; 13..20: atenciones ya registradas.
        IF @i>=7
        BEGIN
            SET @Clave=@Lote+N'/Triaje/'+CONVERT(nvarchar(3),@i);
            IF NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=@Clave)
            BEGIN
                INSERT dbo.Triaje(AdmisionId,Motivo,Presion,FC,FR,Temperatura,Saturacion,Prioridad,Fecha,ResponsableId,Estado)
                VALUES(@Admision,N'[DEMO] Caso ficticio para practicar el flujo; no representa una evaluación real.',N'120/80',80,18,36.5,98,
                       1+(@i%4),DATEADD(minute,10,@Fecha),@Enfermero,CASE WHEN @i<=12 THEN N'Espera' ELSE N'Atendido' END);
                SET @Triaje=CONVERT(int,SCOPE_IDENTITY());
                INSERT dbo.DemoHospitalRegistro VALUES(@Clave,N'Triaje',@Triaje,@Ahora);
            END
            ELSE SELECT @Triaje=RegistroId FROM dbo.DemoHospitalRegistro WHERE Clave=@Clave;
        END
        IF @i>=13
        BEGIN
            SELECT @Medico=Id FROM dbo.Personal WHERE Usuario=N'demo.medico'+RIGHT(N'00'+CONVERT(nvarchar(2),@i-12),2);
            SET @Clave=@Lote+N'/Atencion/'+CONVERT(nvarchar(3),@i);
            IF NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=@Clave)
            BEGIN
                INSERT dbo.Atencion(TriajeId,Evaluacion,Diagnosticos,Evolucion,Conducta,Destino,Fecha,MedicoId)
                VALUES(@Triaje,N'[DEMO] Evaluación ficticia para capacitación.',N'[DEMO] Sin diagnóstico clínico real.',
                       N'[DEMO] Evolución simulada.',N'Observacion',NULL,DATEADD(minute,20,@Fecha),@Medico);
                SET @Atencion=CONVERT(int,SCOPE_IDENTITY());
                INSERT dbo.DemoHospitalRegistro VALUES(@Clave,N'Atencion',@Atencion,@Ahora);
            END
        END
        SET @i+=1;
    END

    -- Indicaciones y administraciones de procedimientos, sin pautas farmacológicas.
    DECLARE @Producto int,@Indicacion int,@Administracion int;
    SET @i=13;
    WHILE @i<=20
    BEGIN
        SELECT @Atencion=RegistroId FROM dbo.DemoHospitalRegistro WHERE Clave=@Lote+N'/Atencion/'+CONVERT(nvarchar(3),@i);
        SELECT @Medico=MedicoId FROM dbo.Atencion WHERE Id=@Atencion;
        SELECT @Producto=Id FROM dbo.MedicamentoProcedimiento WHERE Codigo=N'DEMO-PR02';
        SET @Clave=@Lote+N'/Indicacion/'+CONVERT(nvarchar(3),@i);
        IF NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=@Clave)
        BEGIN
            INSERT dbo.Indicacion(AtencionId,ProductoId,Instruccion,MedicoId)
            VALUES(@Atencion,@Producto,N'[DEMO] Simulación de registro de procedimiento; no realizar sobre una persona.',@Medico);
            SET @Indicacion=CONVERT(int,SCOPE_IDENTITY());
            INSERT dbo.DemoHospitalRegistro VALUES(@Clave,N'Indicacion',@Indicacion,@Ahora);
        END
        ELSE SELECT @Indicacion=RegistroId FROM dbo.DemoHospitalRegistro WHERE Clave=@Clave;
        IF @i<=16
        BEGIN
            SET @Clave=@Lote+N'/Administracion/'+CONVERT(nvarchar(3),@i);
            IF NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=@Clave)
            BEGIN
                INSERT dbo.Administracion(IndicacionId,Detalle,Fecha,EnfermeroId)
                VALUES(@Indicacion,N'[DEMO] Registro simulado de procedimiento.',DATEADD(minute,-30,@Ahora),@Enfermero);
                SET @Administracion=CONVERT(int,SCOPE_IDENTITY());
                INSERT dbo.DemoHospitalRegistro VALUES(@Clave,N'Administracion',@Administracion,@Ahora);
            END
        END
        SET @i+=1;
    END

    -- 16 órdenes: 4 pendientes y 3 por cada estado restante.
    DECLARE @Orden int,@Examen int,@Muestra int,@Resultado int,@Estado nvarchar(20),@NumeroAtencion int;
    SET @i=1;
    WHILE @i<=16
    BEGIN
        SET @NumeroAtencion=13+((@i-1)%8);
        SELECT @Atencion=RegistroId FROM dbo.DemoHospitalRegistro WHERE Clave=@Lote+N'/Atencion/'+CONVERT(nvarchar(3),@NumeroAtencion);
        SELECT @Examen=Id FROM dbo.Examen WHERE Codigo=N'DEMO-E'+RIGHT(N'000'+CONVERT(nvarchar(3),1+((@i-1)%15)),3);
        SET @Estado=CASE (@i-1)%5 WHEN 0 THEN N'Pendiente' WHEN 1 THEN N'Muestra tomada' WHEN 2 THEN N'En proceso' WHEN 3 THEN N'Con resultado' ELSE N'Rechazada' END;
        SET @Clave=@Lote+N'/Orden/'+CONVERT(nvarchar(3),@i);
        IF NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=@Clave)
        BEGIN
            INSERT dbo.Orden(AtencionId,ExamenId,Fecha,Estado)
            VALUES(@Atencion,@Examen,DATEADD(minute,-60,@Ahora),@Estado);
            SET @Orden=CONVERT(int,SCOPE_IDENTITY());
            INSERT dbo.DemoHospitalRegistro VALUES(@Clave,N'Orden',@Orden,@Ahora);
            -- Toda la cadena se crea en una transacción y solo para una orden nueva.
            IF @Estado<>N'Pendiente'
            BEGIN
                INSERT dbo.Muestra(OrdenId,Fecha,TecnicoId,Rotulada,Trasladada,Recepcion,ProcesadorId,MotivoRechazo)
                VALUES(@Orden,DATEADD(minute,-50,@Ahora),@Tecnico,1,1,
                       CASE WHEN @Estado=N'Muestra tomada' THEN NULL ELSE DATEADD(minute,-40,@Ahora) END,
                       CASE WHEN @Estado=N'Muestra tomada' THEN NULL ELSE @Tecnico END,
                       CASE WHEN @Estado=N'Rechazada' THEN N'[DEMO] Rechazo simulado para probar la consulta.' ELSE NULL END);
                SET @Muestra=CONVERT(int,SCOPE_IDENTITY());
                INSERT dbo.DemoHospitalRegistro VALUES(@Lote+N'/Muestra/'+CONVERT(nvarchar(3),@i),N'Muestra',@Muestra,@Ahora);
            END
            IF @Estado=N'Con resultado'
            BEGIN
                INSERT dbo.Resultado(OrdenId,Valor,Observacion,FueraRango,Fecha,ProfesionalId)
                VALUES(@Orden,N'[DEMO] Resultado simulado sin valor clínico.',N'Datos ficticios para la presentación del sistema.',
                       CASE WHEN @i=9 THEN 1 ELSE 0 END,DATEADD(minute,-20,@Ahora),@Profesional);
                SET @Resultado=CONVERT(int,SCOPE_IDENTITY());
                INSERT dbo.DemoHospitalRegistro VALUES(@Lote+N'/Resultado/'+CONVERT(nvarchar(3),@i),N'Resultado',@Resultado,@Ahora);
            END
        END
        SET @i+=1;
    END

    -- Citas futuras: lunes/miércoles próximos, respetando horarios y cruces.
    DECLARE @Lunes date=DATEADD(day,7-(DATEDIFF(day,CONVERT(date,'19000101',112),CONVERT(date,@Ahora))%7),CONVERT(date,@Ahora));
    DECLARE @Slot int,@Inicio datetime2,@Fin datetime2,@Dia int,@Cita int,@Encontrado bit;
    SET @i=1;
    WHILE @i<=8
    BEGIN
        SET @Clave=@Lote+N'/Cita/'+CONVERT(nvarchar(3),@i);
        IF NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=@Clave)
        BEGIN
            SELECT @Medico=Id FROM dbo.Personal WHERE Usuario=N'demo.medico'+RIGHT(N'00'+CONVERT(nvarchar(2),@i),2);
            SELECT @Paciente=Id FROM dbo.Paciente WHERE Documento=N'DEMO-P'+RIGHT(N'000'+CONVERT(nvarchar(3),@i),3);
            SET @Slot=0;SET @Encontrado=0;
            WHILE @Slot<24 AND @Encontrado=0
            BEGIN
                SET @Dia=CASE WHEN @Slot<12 THEN 1 ELSE 3 END;
                SET @Inicio=DATEADD(minute,480+(@Slot%12)*20,CONVERT(datetime2,DATEADD(day,CASE WHEN @Slot<12 THEN 0 ELSE 2 END,@Lunes)));
                SET @Fin=DATEADD(minute,20,@Inicio);
                IF EXISTS(SELECT 1 FROM dbo.Horario WHERE MedicoId=@Medico AND Activo=1 AND Dia=@Dia AND Inicio<=CONVERT(time,@Inicio) AND Fin>=CONVERT(time,@Fin) AND Duracion=20 AND DATEDIFF(minute,Inicio,CONVERT(time,@Inicio))%20=0)
                   AND NOT EXISTS(SELECT 1 FROM dbo.Cita WITH(UPDLOCK,HOLDLOCK) WHERE Estado=N'Programada' AND (MedicoId=@Medico OR PacienteId=@Paciente) AND Inicio<@Fin AND Fin>@Inicio)
                BEGIN
                    INSERT dbo.Cita(PacienteId,MedicoId,Inicio,Fin,ResponsableId) VALUES(@Paciente,@Medico,@Inicio,@Fin,@Recepcion);
                    SET @Cita=CONVERT(int,SCOPE_IDENTITY());
                    INSERT dbo.DemoHospitalRegistro VALUES(@Clave,N'Cita',@Cita,@Ahora);
                    SET @Encontrado=1;
                END
                SET @Slot+=1;
            END
        END
        SET @i+=1;
    END

    COMMIT TRANSACTION;
    SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
    SELECT Entidad,COUNT(*) AS RegistrosDelLote FROM dbo.DemoHospitalRegistro WHERE LEFT(Clave,LEN(@Lote)+1)=@Lote+N'/' GROUP BY Entidad;
    SELECT N'Registrar triaje' AS Pantalla,COUNT(*) AS OpcionesDisponibles
    FROM dbo.Admision a JOIN dbo.DemoHospitalRegistro r ON r.Entidad=N'Admision' AND r.RegistroId=a.Id
    WHERE LEFT(r.Clave,LEN(@Lote)+1)=@Lote+N'/' AND NOT EXISTS(SELECT 1 FROM dbo.Triaje t WHERE t.AdmisionId=a.Id)
    UNION ALL SELECT N'Registrar atención / cola',COUNT(*) FROM dbo.Triaje t JOIN dbo.DemoHospitalRegistro r ON r.Entidad=N'Triaje' AND r.RegistroId=t.Id WHERE LEFT(r.Clave,LEN(@Lote)+1)=@Lote+N'/' AND t.Estado=N'Espera'
    UNION ALL SELECT N'Toma de muestra',COUNT(*) FROM dbo.Orden o JOIN dbo.DemoHospitalRegistro r ON r.Entidad=N'Orden' AND r.RegistroId=o.Id WHERE LEFT(r.Clave,LEN(@Lote)+1)=@Lote+N'/' AND o.Estado=N'Pendiente'
    UNION ALL SELECT N'Recibir y procesar',COUNT(*) FROM dbo.Orden o JOIN dbo.DemoHospitalRegistro r ON r.Entidad=N'Orden' AND r.RegistroId=o.Id WHERE LEFT(r.Clave,LEN(@Lote)+1)=@Lote+N'/' AND o.Estado=N'Muestra tomada'
    UNION ALL SELECT N'Registrar resultados',COUNT(*) FROM dbo.Orden o JOIN dbo.DemoHospitalRegistro r ON r.Entidad=N'Orden' AND r.RegistroId=o.Id WHERE LEFT(r.Clave,LEN(@Lote)+1)=@Lote+N'/' AND o.Estado=N'En proceso';
    SELECT c.Id,p.Nombres AS Paciente,m.Nombres AS Medico,c.Inicio,c.Fin,c.Estado
    FROM dbo.Cita c JOIN dbo.DemoHospitalRegistro r ON r.Entidad=N'Cita' AND r.RegistroId=c.Id
    JOIN dbo.Paciente p ON p.Id=c.PacienteId JOIN dbo.Personal m ON m.Id=c.MedicoId
    WHERE LEFT(r.Clave,LEN(@Lote)+1)=@Lote+N'/' ORDER BY c.Inicio;
END TRY
BEGIN CATCH
    IF @@TRANCOUNT>0 ROLLBACK TRANSACTION;
    SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
    THROW;
END CATCH;
