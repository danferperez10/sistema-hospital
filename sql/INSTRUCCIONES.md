# Verificaciones SQL de HospitalAcademico

El archivo `verificaciones.sql` comprueba que la base de datos se creó bien. Solo lee datos, no modifica nada.

## Requisitos
- SQL Server con SQL Server Management Studio (SSMS) o Azure Data Studio.
- Haber ejecutado antes, en este orden:
  1. `BaseDatos/01_Crear.sql`
  2. `BaseDatos/02_DatosDemo.sql`

## Cómo ejecutarlo
1. Abre SSMS y conéctate a tu servidor.
2. Abre `sql/verificaciones.sql`.
3. Pulsa **Ejecutar** (F5).
4. Revisa cada resultado en la pestaña de resultados.

Desde la terminal también funciona:

```
sqlcmd -S localhost -E -i sql/verificaciones.sql
```

## Qué comprueba
| Nº | Comprobación | Resultado correcto |
|----|--------------|--------------------|
| 1 | Existen las 16 tablas | Todas en `OK` |
| 2 | Todas las tablas tienen clave primaria | 0 filas |
| 3 | Total de claves foráneas | 24, `OK` |
| 4 | Claves foráneas deshabilitadas o no confiables | 0 filas |
| 5 | Registros huérfanos (hijo sin padre) | Todas en `OK` |
| 6 | Valores duplicados en campos únicos | Todas en `OK` |
| 7 | Reglas de negocio (citas, horarios, estados) | Todas en `OK` |
| 8 | Cantidad de filas por tabla | Informativo |

## Cómo interpretar
- `OK`: la comprobación pasó.
- `REVISAR` o `FALTA`: hay un problema; el nombre de la fila indica dónde.
- Si hay errores, avisa al equipo antes de seguir.
