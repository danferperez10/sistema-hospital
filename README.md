# Sistema de hospital

Aplicación académica de escritorio en C# Windows Forms, .NET Framework 4.8 y SQL Server. Incluye formularios editables en el diseñador, inicio de sesión, roles, catálogos, citas, emergencia, atención, laboratorio e historias clínicas.

## Abrir y compilar

Instalar Visual Studio con Desarrollo de escritorio de .NET y .NET Framework 4.8 Developer Pack. Abrir Hospital.sln y establecer Hospital.Presentacion como proyecto de inicio. Compilar la solución y ejecutar. Alternativamente, ejecutar Compilar.ps1 con PowerShell.

## Base de datos nueva

1. En SQL Server Management Studio, ejecutar BaseDatos/01_Crear.sql una sola vez.
2. Revisar Presentacion/App.config: servidor localhost, base HospitalAcademico y autenticación Windows.
3. Ejecutar la aplicación y crear el administrador inicial.
4. Para cargar los datos de práctica, ejecutar BaseDatos/03_DemostracionCompleta.sql completo. Este archivo ya incluye los catálogos de 02; no ejecutar ambos.
5. Ejecutar BaseDatos/04_Actualizar_Presentacion_Corregido.sql para los nombres y códigos finales.
6. Volver a abrir los formularios.

No ejecutar 01 sobre una base existente. Después de 04, no repetir 02 ni 03 porque usan las claves anteriores. El archivo 04 puede repetirse sin duplicar historias. El script SQL se versiona; los archivos .mdf/.ldf/.bak no se incluyen.

Los datos incluidos son sintéticos para presentación académica. Tras 04, las cuentas son medico01 a medico08, recepcion, enfermeria, tecnico y laboratorio. Contraseña inicial de esas cuentas: DemoHospital2026! El administrador conserva sus credenciales. No usar estos datos o cuentas como configuración de producción.

## Organización

- Entidades: sesión y entidades compartidas.
- Datos: conexión y operaciones SQL.
- Logica: permisos, validaciones y procesos.
- Presentacion: formularios, diseñador y recursos.
- BaseDatos: esquema y cargas de práctica.

## Colaboración

Consultar docs/TRABAJO_COMPANEROS.md. Los tres commits iniciales corresponden a esta importación del proyecto; no representan un historial de desarrollo reconstruido.
