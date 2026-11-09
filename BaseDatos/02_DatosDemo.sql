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

    (N'DEMO-D001', N'Ana Torres [DEMO]', N'Médico', N'Medicina general', N'demo.medico01', N'Medico', 0x1c32fa463d512727a895ff227da523544d5642a2231fbbcda0a7fbb720d24a15, 0x91e1a8118510537a30809e3118abcbc2),
    (N'DEMO-D002', N'Luis Mendoza [DEMO]', N'Médico', N'Pediatría', N'demo.medico02', N'Medico', 0x4195600d9ee1ff59341db29ff0e384e99c4163a0847576264eafb9bd7453e111, 0x7c28a680d96f9da7de41bf433a64aa52),
    (N'DEMO-D003', N'Carla Rojas [DEMO]', N'Médico', N'Cardiología', N'demo.medico03', N'Medico', 0x86fa3d01a02f0e954c4af2d04a935718bc4aee043e395664520d8fee559920a9, 0x457aaab3b1471e46863112e8f033053a),
    (N'DEMO-D004', N'Diego Salazar [DEMO]', N'Médico', N'Dermatología', N'demo.medico04', N'Medico', 0x1e068bae25e784b0e4e59a37c82d4e57ef483b348b46e5214538db444afd1679, 0x0e43a2122a5833328e5a6bf77836dafc),
    (N'DEMO-D005', N'Elena Vargas [DEMO]', N'Médico', N'Traumatología', N'demo.medico05', N'Medico', 0x8932bf2b4ba5a9a02cb30311bf22e92c568f1a17af4e688457da299284048f01, 0x5d92bf422478304008057ac098b98890),
    (N'DEMO-D006', N'Mario Castro [DEMO]', N'Médico', N'Ginecología', N'demo.medico06', N'Medico', 0x5f68c99f130bc97f837935bb008ac93e0d1c39652edb609e7e8adc28e6780f97, 0x1e407a4192606314c9ae72c8b8dc37ee),
    (N'DEMO-D007', N'Lucía Paredes [DEMO]', N'Médico', N'Neurología', N'demo.medico07', N'Medico', 0x594de07685a7031f729b9007a1de7de50b71ea97391b84c709bcb15dc27cc96e, 0x2f1b14b49d5a88c58af866a3dcda2616),
    (N'DEMO-D008', N'Jorge Molina [DEMO]', N'Médico', N'Endocrinología', N'demo.medico08', N'Medico', 0x7bd2e2bbce49e48e09c8c4674c7b4bc1aeb5964d74bd976a911bbae27b24d1b6, 0x8b255e76740b0f6fcfcb64d6c4df28c3),
    (N'DEMO-T001', N'Rosa Silva [DEMO]', N'Recepción', NULL, N'demo.recepcion', N'Recepcionista', 0x0a130bfc787b5e9cd0e51736a6d655c7ba334e7a7ca10a2e1256a1f014fe37ad, 0x784fefe2928224a4a6de63cc5e486424),
    (N'DEMO-T002', N'Pedro León [DEMO]', N'Enfermería', NULL, N'demo.enfermeria', N'Enfermero', 0xaa968c669e80584053d3e607dc46404b6e990002a4d825b758d78f447e14dc6b, 0x7c9b5d4cc136326216f5807a2f9b23ea),
    (N'DEMO-T003', N'Sofía Peña [DEMO]', N'Técnico de laboratorio', NULL, N'demo.tecnico', N'Tecnico', 0x7cde5737770149c432f7afdc94e1144eee5fb49e8c29890f93630c537e249080, 0xa40263c6ba97821f7f635c289a5f7434),
    (N'DEMO-T004', N'Andrés Luna [DEMO]', N'Profesional de laboratorio', NULL, N'demo.laboratorio', N'Profesional', 0xaa54ecfc2d759806dc5db1a0eebcd53e379985498a9b7990a66a6fc96a8cf481, 0x6aed10cfbef1ad23e0c770539fafaabd);
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
