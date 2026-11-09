# Propuesta de trabajo para tres compañeros

Son tareas propuestas, no cambios ya implementados ni commits atribuidos. Cada compañero debe realizar y comprobar sus cambios antes de confirmarlos con su propia identidad Git. Se preparan tres cambios por persona (nueve en total).

## Compañero 1: citas
1. Mostrar días, horas y duración del horario del médico al seleccionarlo.
2. Ofrecer intervalos disponibles y excluir citas ocupadas.
3. Mostrar el motivo cuando no hay disponibilidad y comprobar cruces de citas.

## Compañero 2: consultas
1. Ajustar columnas y habilitar lectura completa de los detalles de la historia clínica.
2. Incorporar mensajes claros cuando una consulta no tiene registros.
3. Mostrar filtros activos y permitir limpiarlos para consultar todos los resultados permitidos.

## Compañero 3: instalación y datos
1. Unificar la instalación de datos para usar los códigos finales desde el inicio.
2. Hacer repetible la carga sin duplicar usuarios, pacientes o episodios.
3. Añadir comprobaciones de integridad y documentar instalación desde una base nueva.

## Cómo entregar cada cambio

Crear una rama propia desde main; implementar y comprobar cada tarea; registrar un commit por tarea con la identidad Git de quien la realiza. Abrir una solicitud de incorporación cuando los tres cambios estén listos. No confirmar tareas aún no implementadas.

Ramas sugeridas: codex/companero-1-citas, codex/companero-2-consultas y codex/companero-3-instalacion.

Criterios: citas debe respetar duración y cruces; consultas debe conservar permisos y no ocultar datos por filtros residuales; instalación debe probarse en una base de práctica nueva y en una segunda ejecución sin duplicados.
