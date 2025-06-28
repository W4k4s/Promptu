# Promptu

Gestor de prompts para Windows.

## Compilación

Se requiere **.NET 8 SDK** para compilar los proyectos. Una vez instalado, ejecutar:

```bash
dotnet build Promptu.sln
```

Para ejecutar la aplicación WPF:

```bash
dotnet run --project src/Promptu.App/Promptu.App.csproj
```

Las pruebas unitarias se ejecutan con:

```bash
dotnet test tests/Promptu.Tests/Promptu.Tests.csproj
```
