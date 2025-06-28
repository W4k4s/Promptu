# Plan de trabajo para Promptu

Este documento desglosa las tareas recomendadas para llevar a cabo el proyecto **Promptu**, un gestor de prompts para Windows basado en las especificaciones definidas previamente (PromptKeeper).

## Fase 0: Prueba de concepto (2 semanas)
- [ ] Configurar entorno de desarrollo: `.NET 8`, `Visual Studio` o `VS Code` y `AutoHotkey` (si se usa la opción AHK).
- [ ] Crear repositorio Git con estructura básica y licencia MIT.
- [ ] Implementar overlay sencillo con AutoHotkey reutilizando `mwClipboard` como referencia.
- [ ] Configurar base de datos `SQLite` fija con 10 prompts de prueba.
- [ ] Validar el flujo de copiado/pegado en una aplicación (por ejemplo ChatGPT Web).

## Fase 1: MVP (6 semanas)
- [ ] Implementar el CRUD de prompts con `Entity Framework Core` y modelo de datos propuesto.
- [ ] Crear interfaz principal (WPF/WinUI) con panel de carpetas y editor básico.
- [ ] Añadir hotkey global personalizable para invocar el menú flotante.
- [ ] Soportar etiquetas múltiples y buscador "type-ahead".
- [ ] Permitir exportar a CSV compatible con PromptBox.

## Fase 2: Beta 1 (4 semanas)
- [ ] Agregar cifrado opcional (AES-256) para la base de datos.
- [ ] Registrar historial de uso y marcar favoritos.
- [ ] Implementar tema oscuro/claro.
- [ ] Preparar instalador (MSIX o Squirrel).

## Fase 3: Beta 2 (4 semanas)
- [ ] Implementar sincronización con carpeta local o nube (OneDrive/WebDAV/Git).
- [ ] Añadir CLI/PowerShell para obtener prompts desde scripts.
- [ ] Recoger feedback de usuarios y corregir errores.

## Fase 4: Versión 1.0 (3 semanas)
- [ ] Desarrollar extensión ligera para navegadores que permita pegar prompts en `chat.openai.com`.
- [ ] Escribir documentación oficial y página web de producto.
- [ ] Revisar accesibilidad y rendimiento (menú en <150 ms tras hotkey).

## Fase 5: Evolución (continuo)
- [ ] Publicar marketplace comunitario de prompts.
- [ ] Implementar analítica opcional para usuarios premium.
- [ ] Explorar portabilidad multiplataforma (WPF → MAUI).

## Organización del equipo
- **Backend y base de datos**: Ismael
- **Interfaz de usuario (XAML)**: Antonia
- **Documentación y QA**: Colaborador externo

## Siguientes pasos inmediatos
1. Revisar este plan con el equipo y ajustar tiempos/recursos.
2. Crear issues en GitHub para cada tarea principal.
3. Iniciar la configuración del entorno de desarrollo.

