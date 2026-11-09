-- Actualización para la base de práctica ya cargada.
USE HospitalAcademico;
SET NOCOUNT ON;
SET XACT_ABORT ON;
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
BEGIN TRY
BEGIN TRANSACTION;
IF OBJECT_ID(N'dbo.DemoHospitalRegistro',N'U') IS NULL
 THROW 51200,'Primero carga los casos del paquete anterior.',1;


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P001',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P001' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P001');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P001' WHERE t.Documento=N'85000001' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000001' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P001';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P002',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P002' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P002');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P002' WHERE t.Documento=N'85000002' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000002' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P002';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P003',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P003' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P003');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P003' WHERE t.Documento=N'85000003' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000003' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P003';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P004',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P004' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P004');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P004' WHERE t.Documento=N'85000004' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000004' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P004';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P005',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P005' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P005');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P005' WHERE t.Documento=N'85000005' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000005' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P005';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P006',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P006' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P006');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P006' WHERE t.Documento=N'85000006' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000006' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P006';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P007',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P007' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P007');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P007' WHERE t.Documento=N'85000007' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000007' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P007';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P008',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P008' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P008');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P008' WHERE t.Documento=N'85000008' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000008' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P008';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P009',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P009' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P009');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P009' WHERE t.Documento=N'85000009' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000009' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P009';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P010',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P010' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P010');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P010' WHERE t.Documento=N'85000010' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000010' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P010';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P011',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P011' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P011');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P011' WHERE t.Documento=N'85000011' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000011' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P011';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P012',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P012' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P012');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P012' WHERE t.Documento=N'85000012' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000012' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P012';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P013',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P013' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P013');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P013' WHERE t.Documento=N'85000013' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000013' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P013';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P014',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P014' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P014');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P014' WHERE t.Documento=N'85000014' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000014' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P014';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P015',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P015' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P015');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P015' WHERE t.Documento=N'85000015' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000015' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P015';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P016',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P016' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P016');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P016' WHERE t.Documento=N'85000016' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000016' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P016';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P017',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P017' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P017');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P017' WHERE t.Documento=N'85000017' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000017' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P017';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P018',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P018' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P018');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P018' WHERE t.Documento=N'85000018' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000018' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P018';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P019',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P019' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P019');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P019' WHERE t.Documento=N'85000019' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000019' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P019';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-P020',N'Paciente',Id FROM dbo.Paciente
WHERE Documento=N'DEMO-P020' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P020');
IF EXISTS(SELECT 1 FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-P020' WHERE t.Documento=N'85000020' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'85000020' FROM dbo.Paciente t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-P020';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-D001',N'Personal',Id FROM dbo.Personal
WHERE Documento=N'DEMO-D001' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-D001');
IF EXISTS(SELECT 1 FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-D001' WHERE t.Documento=N'86000001' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'86000001' FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-D001';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-D002',N'Personal',Id FROM dbo.Personal
WHERE Documento=N'DEMO-D002' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-D002');
IF EXISTS(SELECT 1 FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-D002' WHERE t.Documento=N'86000002' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'86000002' FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-D002';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-D003',N'Personal',Id FROM dbo.Personal
WHERE Documento=N'DEMO-D003' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-D003');
IF EXISTS(SELECT 1 FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-D003' WHERE t.Documento=N'86000003' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'86000003' FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-D003';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-D004',N'Personal',Id FROM dbo.Personal
WHERE Documento=N'DEMO-D004' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-D004');
IF EXISTS(SELECT 1 FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-D004' WHERE t.Documento=N'86000004' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'86000004' FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-D004';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-D005',N'Personal',Id FROM dbo.Personal
WHERE Documento=N'DEMO-D005' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-D005');
IF EXISTS(SELECT 1 FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-D005' WHERE t.Documento=N'86000005' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'86000005' FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-D005';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-D006',N'Personal',Id FROM dbo.Personal
WHERE Documento=N'DEMO-D006' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-D006');
IF EXISTS(SELECT 1 FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-D006' WHERE t.Documento=N'86000006' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'86000006' FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-D006';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-D007',N'Personal',Id FROM dbo.Personal
WHERE Documento=N'DEMO-D007' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-D007');
IF EXISTS(SELECT 1 FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-D007' WHERE t.Documento=N'86000007' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'86000007' FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-D007';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-D008',N'Personal',Id FROM dbo.Personal
WHERE Documento=N'DEMO-D008' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-D008');
IF EXISTS(SELECT 1 FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-D008' WHERE t.Documento=N'86000008' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'86000008' FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-D008';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-T001',N'Personal',Id FROM dbo.Personal
WHERE Documento=N'DEMO-T001' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-T001');
IF EXISTS(SELECT 1 FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-T001' WHERE t.Documento=N'87000001' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'87000001' FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-T001';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-T002',N'Personal',Id FROM dbo.Personal
WHERE Documento=N'DEMO-T002' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-T002');
IF EXISTS(SELECT 1 FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-T002' WHERE t.Documento=N'87000002' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'87000002' FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-T002';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-T003',N'Personal',Id FROM dbo.Personal
WHERE Documento=N'DEMO-T003' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-T003');
IF EXISTS(SELECT 1 FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-T003' WHERE t.Documento=N'87000003' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'87000003' FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-T003';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-T004',N'Personal',Id FROM dbo.Personal
WHERE Documento=N'DEMO-T004' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-T004');
IF EXISTS(SELECT 1 FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-T004' WHERE t.Documento=N'87000004' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Documento=N'87000004' FROM dbo.Personal t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-T004';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-E001',N'Examen',Id FROM dbo.Examen
WHERE Codigo=N'DEMO-E001' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-E001');
IF EXISTS(SELECT 1 FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-E001' WHERE t.Codigo=N'EX-001' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'EX-001' FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-E001';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-E002',N'Examen',Id FROM dbo.Examen
WHERE Codigo=N'DEMO-E002' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-E002');
IF EXISTS(SELECT 1 FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-E002' WHERE t.Codigo=N'EX-002' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'EX-002' FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-E002';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-E003',N'Examen',Id FROM dbo.Examen
WHERE Codigo=N'DEMO-E003' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-E003');
IF EXISTS(SELECT 1 FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-E003' WHERE t.Codigo=N'EX-003' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'EX-003' FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-E003';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-E004',N'Examen',Id FROM dbo.Examen
WHERE Codigo=N'DEMO-E004' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-E004');
IF EXISTS(SELECT 1 FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-E004' WHERE t.Codigo=N'EX-004' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'EX-004' FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-E004';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-E005',N'Examen',Id FROM dbo.Examen
WHERE Codigo=N'DEMO-E005' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-E005');
IF EXISTS(SELECT 1 FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-E005' WHERE t.Codigo=N'EX-005' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'EX-005' FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-E005';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-E006',N'Examen',Id FROM dbo.Examen
WHERE Codigo=N'DEMO-E006' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-E006');
IF EXISTS(SELECT 1 FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-E006' WHERE t.Codigo=N'EX-006' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'EX-006' FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-E006';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-E007',N'Examen',Id FROM dbo.Examen
WHERE Codigo=N'DEMO-E007' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-E007');
IF EXISTS(SELECT 1 FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-E007' WHERE t.Codigo=N'EX-007' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'EX-007' FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-E007';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-E008',N'Examen',Id FROM dbo.Examen
WHERE Codigo=N'DEMO-E008' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-E008');
IF EXISTS(SELECT 1 FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-E008' WHERE t.Codigo=N'EX-008' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'EX-008' FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-E008';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-E009',N'Examen',Id FROM dbo.Examen
WHERE Codigo=N'DEMO-E009' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-E009');
IF EXISTS(SELECT 1 FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-E009' WHERE t.Codigo=N'EX-009' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'EX-009' FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-E009';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-E010',N'Examen',Id FROM dbo.Examen
WHERE Codigo=N'DEMO-E010' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-E010');
IF EXISTS(SELECT 1 FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-E010' WHERE t.Codigo=N'EX-010' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'EX-010' FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-E010';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-E011',N'Examen',Id FROM dbo.Examen
WHERE Codigo=N'DEMO-E011' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-E011');
IF EXISTS(SELECT 1 FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-E011' WHERE t.Codigo=N'EX-011' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'EX-011' FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-E011';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-E012',N'Examen',Id FROM dbo.Examen
WHERE Codigo=N'DEMO-E012' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-E012');
IF EXISTS(SELECT 1 FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-E012' WHERE t.Codigo=N'EX-012' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'EX-012' FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-E012';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-E013',N'Examen',Id FROM dbo.Examen
WHERE Codigo=N'DEMO-E013' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-E013');
IF EXISTS(SELECT 1 FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-E013' WHERE t.Codigo=N'EX-013' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'EX-013' FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-E013';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-E014',N'Examen',Id FROM dbo.Examen
WHERE Codigo=N'DEMO-E014' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-E014');
IF EXISTS(SELECT 1 FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-E014' WHERE t.Codigo=N'EX-014' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'EX-014' FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-E014';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-E015',N'Examen',Id FROM dbo.Examen
WHERE Codigo=N'DEMO-E015' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-E015');
IF EXISTS(SELECT 1 FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-E015' WHERE t.Codigo=N'EX-015' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'EX-015' FROM dbo.Examen t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-E015';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M001',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M001' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M001');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M001' WHERE t.Codigo=N'MED-001' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-001' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M001';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M002',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M002' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M002');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M002' WHERE t.Codigo=N'MED-002' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-002' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M002';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M003',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M003' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M003');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M003' WHERE t.Codigo=N'MED-003' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-003' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M003';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M004',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M004' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M004');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M004' WHERE t.Codigo=N'MED-004' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-004' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M004';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M005',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M005' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M005');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M005' WHERE t.Codigo=N'MED-005' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-005' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M005';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M006',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M006' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M006');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M006' WHERE t.Codigo=N'MED-006' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-006' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M006';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M007',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M007' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M007');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M007' WHERE t.Codigo=N'MED-007' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-007' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M007';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M008',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M008' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M008');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M008' WHERE t.Codigo=N'MED-008' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-008' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M008';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M009',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M009' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M009');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M009' WHERE t.Codigo=N'MED-009' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-009' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M009';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M010',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M010' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M010');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M010' WHERE t.Codigo=N'MED-010' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-010' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M010';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M011',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M011' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M011');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M011' WHERE t.Codigo=N'MED-011' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-011' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M011';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M012',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M012' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M012');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M012' WHERE t.Codigo=N'MED-012' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-012' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M012';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M013',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M013' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M013');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M013' WHERE t.Codigo=N'MED-013' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-013' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M013';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M014',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M014' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M014');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M014' WHERE t.Codigo=N'MED-014' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-014' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M014';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M015',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M015' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M015');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M015' WHERE t.Codigo=N'MED-015' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-015' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M015';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M016',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M016' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M016');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M016' WHERE t.Codigo=N'MED-016' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-016' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M016';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M017',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M017' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M017');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M017' WHERE t.Codigo=N'MED-017' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-017' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M017';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M018',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M018' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M018');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M018' WHERE t.Codigo=N'MED-018' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-018' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M018';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M019',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M019' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M019');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M019' WHERE t.Codigo=N'MED-019' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-019' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M019';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M020',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M020' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M020');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M020' WHERE t.Codigo=N'MED-020' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-020' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M020';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M021',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M021' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M021');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M021' WHERE t.Codigo=N'MED-021' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-021' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M021';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M022',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M022' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M022');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M022' WHERE t.Codigo=N'MED-022' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-022' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M022';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M023',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M023' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M023');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M023' WHERE t.Codigo=N'MED-023' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-023' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M023';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M024',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M024' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M024');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M024' WHERE t.Codigo=N'MED-024' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-024' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M024';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M025',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M025' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M025');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M025' WHERE t.Codigo=N'MED-025' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-025' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M025';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M026',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M026' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M026');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M026' WHERE t.Codigo=N'MED-026' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-026' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M026';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M027',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M027' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M027');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M027' WHERE t.Codigo=N'MED-027' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-027' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M027';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M028',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M028' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M028');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M028' WHERE t.Codigo=N'MED-028' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-028' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M028';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M029',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M029' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M029');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M029' WHERE t.Codigo=N'MED-029' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-029' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M029';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M030',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M030' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M030');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M030' WHERE t.Codigo=N'MED-030' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-030' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M030';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M031',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M031' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M031');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M031' WHERE t.Codigo=N'MED-031' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-031' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M031';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M032',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M032' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M032');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M032' WHERE t.Codigo=N'MED-032' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-032' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M032';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M033',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M033' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M033');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M033' WHERE t.Codigo=N'MED-033' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-033' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M033';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M034',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M034' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M034');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M034' WHERE t.Codigo=N'MED-034' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-034' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M034';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M035',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M035' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M035');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M035' WHERE t.Codigo=N'MED-035' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-035' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M035';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M036',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M036' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M036');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M036' WHERE t.Codigo=N'MED-036' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-036' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M036';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M037',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M037' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M037');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M037' WHERE t.Codigo=N'MED-037' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-037' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M037';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M038',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M038' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M038');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M038' WHERE t.Codigo=N'MED-038' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-038' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M038';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M039',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M039' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M039');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M039' WHERE t.Codigo=N'MED-039' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-039' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M039';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M040',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M040' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M040');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M040' WHERE t.Codigo=N'MED-040' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-040' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M040';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M041',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M041' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M041');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M041' WHERE t.Codigo=N'MED-041' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-041' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M041';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M042',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M042' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M042');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M042' WHERE t.Codigo=N'MED-042' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-042' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M042';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M043',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M043' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M043');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M043' WHERE t.Codigo=N'MED-043' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-043' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M043';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M044',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M044' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M044');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M044' WHERE t.Codigo=N'MED-044' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-044' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M044';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M045',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M045' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M045');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M045' WHERE t.Codigo=N'MED-045' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-045' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M045';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M046',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M046' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M046');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M046' WHERE t.Codigo=N'MED-046' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-046' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M046';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M047',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M047' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M047');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M047' WHERE t.Codigo=N'MED-047' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-047' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M047';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M048',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M048' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M048');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M048' WHERE t.Codigo=N'MED-048' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-048' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M048';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M049',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M049' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M049');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M049' WHERE t.Codigo=N'MED-049' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-049' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M049';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-M050',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-M050' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-M050');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-M050' WHERE t.Codigo=N'MED-050' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'MED-050' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-M050';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-PR01',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-PR01' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-PR01');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-PR01' WHERE t.Codigo=N'PR-001' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'PR-001' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-PR01';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-PR02',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-PR02' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-PR02');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-PR02' WHERE t.Codigo=N'PR-002' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'PR-002' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-PR02';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-PR03',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-PR03' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-PR03');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-PR03' WHERE t.Codigo=N'PR-003' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'PR-003' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-PR03';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-PR04',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-PR04' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-PR04');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-PR04' WHERE t.Codigo=N'PR-004' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'PR-004' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-PR04';


INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId)
SELECT N'LIMPIEZA/DEMO-PR05',N'MedicamentoProcedimiento',Id FROM dbo.MedicamentoProcedimiento
WHERE Codigo=N'DEMO-PR05' AND NOT EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-PR05');
IF EXISTS(SELECT 1 FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.Clave=N'LIMPIEZA/DEMO-PR05' WHERE t.Codigo=N'PR-005' AND t.Id<>m.RegistroId)
 THROW 51201,'Un código o documento de destino ya está ocupado. No se aplicaron cambios.',1;
UPDATE t SET Codigo=N'PR-005' FROM dbo.MedicamentoProcedimiento t JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=t.Id AND m.Clave=N'LIMPIEZA/DEMO-PR05';


IF (SELECT COUNT(*) FROM dbo.DemoHospitalRegistro WHERE Entidad=N'Paciente' AND Clave LIKE N'LIMPIEZA/DEMO-P[0-9][0-9][0-9]')<>20
 THROW 51202,'No se encontraron los veinte pacientes del paquete anterior.',1;
UPDATE p SET Nombres=LTRIM(RTRIM(REPLACE(p.Nombres,N'[DEMO]',N''))),
 Direccion=CASE WHEN p.Direccion LIKE N'%ficticia%' THEN N'Calle Los Cedros '+CONVERT(nvarchar(10),100+CONVERT(int,RIGHT(m.Clave,3))) ELSE p.Direccion END,
 Telefono=COALESCE(p.Telefono,N'90000'+RIGHT(m.Clave,3)+N'0')
FROM dbo.Paciente p JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=p.Id AND m.Entidad=N'Paciente' AND m.Clave LIKE N'LIMPIEZA/%';
UPDATE p SET Nombres=LTRIM(RTRIM(REPLACE(p.Nombres,N'[DEMO]',N'')))
FROM dbo.Personal p JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=p.Id AND m.Entidad=N'Personal' AND m.Clave LIKE N'LIMPIEZA/%';
IF EXISTS(SELECT 1 FROM dbo.Personal p JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=p.Id AND m.Entidad=N'Personal' AND m.Clave LIKE N'LIMPIEZA/%'
 JOIN dbo.Personal otro ON otro.Usuario=REPLACE(p.Usuario,N'demo.',N'') AND otro.Id<>p.Id)
 THROW 51203,'Un nombre de usuario sin prefijo ya está ocupado.',1;
UPDATE p SET Usuario=REPLACE(p.Usuario,N'demo.',N'')
FROM dbo.Personal p JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=p.Id AND m.Entidad=N'Personal' AND m.Clave LIKE N'LIMPIEZA/%';
UPDATE p SET Presentacion=CASE WHEN p.Tipo=N'Procedimiento' THEN N'Atención ambulatoria' ELSE REPLACE(p.Presentacion,N' | Presentación por completar',N'') END
FROM dbo.MedicamentoProcedimiento p JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=p.Id AND m.Entidad=N'MedicamentoProcedimiento' AND m.Clave LIKE N'LIMPIEZA/%';
UPDATE e SET Referencia=N'Según método del laboratorio'
FROM dbo.Examen e JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=e.Id AND m.Entidad=N'Examen' AND m.Clave LIKE N'LIMPIEZA/%'
WHERE e.Referencia LIKE N'%DEMO%';

UPDATE t SET Motivo=N'Consulta por malestar general de inicio reciente.' FROM dbo.Triaje t WHERE (Motivo LIKE N'%DEMO%' OR Motivo LIKE N'%fictici%') AND EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro m WHERE m.Entidad=N'Triaje' AND m.RegistroId=t.Id);

UPDATE t SET Evaluacion=N'Paciente alerta y orientado. Se registra evaluación general y antecedentes.' FROM dbo.Atencion t WHERE (Evaluacion LIKE N'%DEMO%' OR Evaluacion LIKE N'%fictici%') AND EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro m WHERE m.Entidad=N'Atencion' AND m.RegistroId=t.Id);

UPDATE t SET Diagnosticos=N'Malestar general en evaluación.' FROM dbo.Atencion t WHERE (Diagnosticos LIKE N'%DEMO%' OR Diagnosticos LIKE N'%fictici%') AND EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro m WHERE m.Entidad=N'Atencion' AND m.RegistroId=t.Id);

UPDATE t SET Evolucion=N'Permanece estable durante la observación.' FROM dbo.Atencion t WHERE (Evolucion LIKE N'%DEMO%' OR Evolucion LIKE N'%fictici%') AND EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro m WHERE m.Entidad=N'Atencion' AND m.RegistroId=t.Id);

UPDATE t SET Instruccion=N'Registrar y documentar los signos vitales durante la observación.' FROM dbo.Indicacion t WHERE (Instruccion LIKE N'%DEMO%' OR Instruccion LIKE N'%fictici%') AND EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro m WHERE m.Entidad=N'Indicacion' AND m.RegistroId=t.Id);

UPDATE t SET Detalle=N'Signos vitales registrados en la hoja de atención.' FROM dbo.Administracion t WHERE (Detalle LIKE N'%DEMO%' OR Detalle LIKE N'%fictici%') AND EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro m WHERE m.Entidad=N'Administracion' AND m.RegistroId=t.Id);

UPDATE t SET MotivoRechazo=N'Identificación incompleta del recipiente.' FROM dbo.Muestra t WHERE (MotivoRechazo LIKE N'%DEMO%' OR MotivoRechazo LIKE N'%fictici%') AND EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro m WHERE m.Entidad=N'Muestra' AND m.RegistroId=t.Id);

UPDATE t SET Observacion=N'Muestra recibida y procesada.' FROM dbo.Resultado t WHERE (Observacion LIKE N'%DEMO%' OR Observacion LIKE N'%fictici%') AND EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro m WHERE m.Entidad=N'Resultado' AND m.RegistroId=t.Id);


UPDATE r SET Valor=CASE e.Nombre WHEN N'Triglicéridos' THEN N'125' WHEN N'Examen parasitológico' THEN N'No se observan formas parasitarias en la muestra examinada.' WHEN N'Grupo sanguíneo y Rh' THEN N'O positivo' ELSE N'Procesamiento finalizado' END,FueraRango=0
FROM dbo.Resultado r JOIN dbo.Orden o ON o.Id=r.OrdenId JOIN dbo.Examen e ON e.Id=o.ExamenId
WHERE r.Valor LIKE N'%DEMO%' AND EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro m WHERE m.Entidad=N'Resultado' AND m.RegistroId=r.Id);
UPDATE dbo.Examen SET Unidad=N'mg/dL' WHERE Codigo=N'EX-004' AND EXISTS(SELECT 1 FROM dbo.DemoHospitalRegistro m WHERE m.Entidad=N'Examen' AND m.RegistroId=Examen.Id AND m.Clave=N'LIMPIEZA/DEMO-E004');

-- Añadir un episodio anterior solo a los pacientes de práctica sin atención.
-- Se conservan sus admisiones y triajes pendientes actuales.
DECLARE @i int=1,@p int,@med int,@enf int,@rec int,@ad int,@tri int,@at int,@ind int,@prod int,@fecha datetime2;
SELECT @enf=RegistroId FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-T002';
SELECT @rec=RegistroId FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-T001';
SELECT @prod=RegistroId FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-PR02';
IF @enf IS NULL OR @rec IS NULL OR @prod IS NULL
 THROW 51204,'Faltan personal o procedimientos del paquete inicial.',1;
WHILE @i<=20
BEGIN
 SELECT @p=RegistroId FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-P'+RIGHT(N'000'+CONVERT(nvarchar(3),@i),3);
 SELECT @med=RegistroId FROM dbo.DemoHospitalRegistro WHERE Clave=N'LIMPIEZA/DEMO-D'+RIGHT(N'000'+CONVERT(nvarchar(3),1+((@i-1)%8)),3);
 IF @med IS NULL THROW 51205,'Falta uno de los médicos de práctica.',1;
 IF NOT EXISTS(SELECT 1 FROM dbo.Atencion a JOIN dbo.Triaje t ON t.Id=a.TriajeId JOIN dbo.Admision ad ON ad.Id=t.AdmisionId WHERE ad.PacienteId=@p)
 BEGIN
  SET @fecha=DATEADD(day,-7-@i,SYSDATETIME());
  INSERT dbo.Admision(PacienteId,Fecha,Tipo,ResponsableId) VALUES(@p,@fecha,N'Emergencia',@rec);
  SET @ad=CONVERT(int,SCOPE_IDENTITY());
  INSERT dbo.Triaje(AdmisionId,Motivo,Presion,FC,FR,Temperatura,Saturacion,Prioridad,Fecha,ResponsableId,Estado)
  VALUES(@ad,N'Malestar general de inicio reciente.',N'120/80',78,18,36.6,98,4,DATEADD(minute,10,@fecha),@enf,N'Atendido');
  SET @tri=CONVERT(int,SCOPE_IDENTITY());
  INSERT dbo.Atencion(TriajeId,Evaluacion,Diagnosticos,Evolucion,Conducta,Destino,Fecha,MedicoId)
  VALUES(@tri,N'Paciente alerta y orientado. Se revisan antecedentes y se realiza evaluación general.',N'Malestar general en evaluación.',N'Permanece estable durante la observación.',N'Alta',N'Domicilio',DATEADD(minute,30,@fecha),@med);
  SET @at=CONVERT(int,SCOPE_IDENTITY());
  INSERT dbo.Indicacion(AtencionId,ProductoId,Instruccion,MedicoId) VALUES(@at,@prod,N'Registrar los signos vitales durante la observación.',@med);
  SET @ind=CONVERT(int,SCOPE_IDENTITY());
  INSERT dbo.Administracion(IndicacionId,Detalle,Fecha,EnfermeroId) VALUES(@ind,N'Signos vitales registrados. Paciente sin incidencias durante el control.',DATEADD(minute,40,@fecha),@enf);
  INSERT dbo.DemoHospitalRegistro(Clave,Entidad,RegistroId) VALUES(N'HISTORIA/'+CONVERT(nvarchar(20),@p),N'Atencion',@at);
 END;
 SET @i+=1;
END;
COMMIT;
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
SELECT p.Historia,p.Nombres,p.Documento,
 (SELECT COUNT(*) FROM dbo.Atencion a JOIN dbo.Triaje t ON t.Id=a.TriajeId JOIN dbo.Admision ad ON ad.Id=t.AdmisionId WHERE ad.PacienteId=p.Id) AS Atenciones
FROM dbo.Paciente p JOIN dbo.DemoHospitalRegistro m ON m.RegistroId=p.Id AND m.Entidad=N'Paciente' AND m.Clave LIKE N'LIMPIEZA/%';
END TRY
BEGIN CATCH
 IF @@TRANCOUNT>0 ROLLBACK;
 SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
 THROW;
END CATCH;
