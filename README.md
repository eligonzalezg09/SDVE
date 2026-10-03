# Miniproyecto1
# SDVE - Sistema Digital de Votación Estudiantil

Aplicación de escritorio en **C# (Windows Forms)** que gestiona el proceso de votación escolar para tres convocatorias, que pueden elegirse de forma simultánea o independiente: **Sociedad de Alumnos**, **Consejo Universitario** y **Consejo de Representantes**.

## Características

- **Papeleta dinámica:** el votante elige una combinación libre de 1, 2 o las 3 convocatorias.
- **Candidatos registrados** (listas oficiales) y **candidatos no registrados** (write-in) mediante un campo de texto libre.
- **Validación de voto:** el alumno solo vota en las elecciones seleccionadas y no puede votar dos veces en la misma convocatoria.
- **Motor de conteo:** resultados agrupados por Grupo, Carrera y Centro Universitario, con absolutos, porcentaje de participación y abstencionismo.
- **Reportes:** visualización gráfica de resultados y exportación a CSV.

## Requisitos

- Windows 10 u 11
- SDK de .NET 10
- Visual Studio 2026 con la carga de trabajo **"Desarrollo de escritorio con .NET"** (el proyecto usa el formato de solución `.slnx`)

## Instalación y ejecución

### Opción 1: Instalador

1. Descarga el paquete de instalación de [liga o sección de Releases].
2. Ejecuta `[nombre del instalador]` y sigue los pasos.
3. Abre **SDVE** desde el menú de inicio.

### Opción 2: Compilar desde el código fuente

```bash
git clone https://github.com/eligonzalezg09/SDVE.git
cd SDVE
```

1. Abre `Miniproyecto1.slnx` en Visual Studio.
2. Espera a que se restauren las dependencias.
3. Selecciona la configuración **Debug** o **Release** y presiona **F5** para ejecutar.

## Uso básico

1. En la ventana de inicio, captura los datos del alumno (ID, nombre, grupo, carrera y centro universitario) y selecciona las convocatorias en las que votará.
2. En la papeleta, elige un candidato de la lista o escribe uno no registrado.
3. Revisa tu selección y confirma el voto.
4. En los módulos de resultados, consulta los conteos, el desglose por grupo, carrera y centro, y las gráficas. Exporta los datos a CSV.

> **Nota:** los votos se almacenan en memoria mientras la aplicación está abierta. Al cerrarla se pierden, así que exporta los resultados antes de salir.

## Estructura del proyecto

| Archivo | Descripción |
|---|---|
| `Program.cs` | Punto de entrada de la aplicación |
| `Form1.cs` | Ventana de inicio (`FormInicio`): captura de datos del alumno y selección de convocatorias |
| `FormVotacion.cs` | Papeleta electrónica y emisión del voto |
| `FormResultados.cs` | Resultados generales, participación y abstencionismo |
| `FormDesglose.cs` | Desglose por Grupo, Carrera y Centro Universitario |
| `FormGrafica.cs` | Visualización gráfica de resultados |
| `GestorVotacion.cs` | Registro de votos y validación de voto duplicado |
| `Voto.cs` | Modelo de datos de un voto |
| `Miniproyecto1.csproj` / `Miniproyecto1.slnx` | Archivos de proyecto y solución |

## Tecnologías

- C# / Windows Forms
- .NET 10
- Los votos se almacenan en memoria durante la ejecución; los resultados se exportan a CSV

## Contexto académico

Miniproyecto 01 de Programación Java (5-A), Universidad Autónoma de Aguascalientes.
