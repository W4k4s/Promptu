# Promptu

Gestor de prompts para Windows.

Este repositorio contiene la primera planificación y documentación para desarrollar **Promptu**, basado en el documento "Gestor de Prompts para Windows" (PromptKeeper). Consulta [PLAN_DE_TRABAJO.md](./PLAN_DE_TRABAJO.md) para ver las tareas propuestas por fase. Las pautas para contribuyentes y para el asistente se encuentran en [agent.md](./agent.md).

## Compilación

Para compilar el proyecto se requiere **.NET 8 SDK** en Windows. Una vez instalado, ejecuta desde la raíz:

```bash
dotnet build Promptu.sln
```

Esto generará la aplicación WPF en modo Debug. Puedes abrir el fichero `Promptu.sln` en Visual Studio para un entorno de desarrollo completo.
