# test3

Proyecto desarrollado en **Unity** con scripts en **C#**.

## Descripción

Este repositorio contiene un proyecto de Unity configurado con varios paquetes y herramientas para desarrollo 2D, sistema de entrada, render pipeline universal (URP), timeline y otras utilidades de desarrollo.

## Requisitos

Para abrir y ejecutar el proyecto necesitas:

- **Unity Editor 6000.5.0f1**
- Git
- Un editor de código compatible con C# (por ejemplo, Visual Studio o Rider)

## Instalación

### 1. Clonar el repositorio

```bash
git clone https://github.com/Stromjold/test3.git
```

### 2. Abrir el proyecto en Unity Hub

1. Abre **Unity Hub**
2. Selecciona **Add project from disk**
3. Elige la carpeta del repositorio clonado
4. Asegúrate de usar la versión **6000.5.0f1**

### 3. Esperar la importación

Unity importará automáticamente los archivos, paquetes y configuraciones del proyecto.

### 4. Actualizar y subir cambios a GitHub

```bash
git add .
git commit -m "feat: integracion de soldados, rutas y diseno de HUD tactico"
git push origin main
```

**¿Qué significa cada comando?**

1. **`git add .`**  
   Le dice a Git que revise toda la carpeta actual y prepare todos los archivos que tengan cambios, modificaciones o que sean nuevos.

2. **`git commit -m "..."`**  
   Cierra la caja y le pega una etiqueta con un mensaje. Todo lo que va entre comillas queda guardado en el historial de Git para identificar los cambios.

3. **`git push origin main`**  
   Toma ese commit y lo envía a GitHub al repositorio remoto llamado `origin`, específicamente a la rama `main`.

   > **Nota:** Si tu proyecto usa la rama `master`, usa:
   > `git push origin master`

## Uso

Una vez abierto el proyecto:

1. Abre la escena principal desde la carpeta `Assets/Scenes`
2. Ejecuta el proyecto con el botón **Play**
3. Usa los controles definidos en el archivo de entrada:
   - `Assets/InputSystem_Actions.inputactions`

Si el proyecto incluye escenas adicionales o prefabs, puedes encontrarlos en:

- `Assets/Scenes`
- `Assets/Prefabs`
- `Assets/Scripts`
- `Assets/Sprites`

## Estructura del proyecto

### `Assets/`
Carpeta principal del contenido del proyecto.

- `Assets/Scenes/`  
  Contiene las escenas del juego o aplicación.

- `Assets/Scripts/`  
  Contiene los scripts en C#.

- `Assets/Prefabs/`  
  Contiene prefabs reutilizables.

- `Assets/Sprites/`  
  Contiene recursos gráficos e imágenes.

- `Assets/Settings/`  
  Configuraciones y recursos relacionados con el proyecto.

- `Assets/InputSystem_Actions.inputactions`  
  Definición de controles de entrada.

### `Packages/`
Contiene la configuración de paquetes de Unity.

- `manifest.json`  
  Lista de dependencias del proyecto.

- `packages-lock.json`  
  Bloqueo de versiones exactas de paquetes instalados.

### `ProjectSettings/`
Configuraciones globales del proyecto de Unity.

- Versión del editor
- Ajustes de físicas
- Ajustes de entrada
- Ajustes de calidad
- Configuración de compilación
- Configuración de gráficos

### `Documentacion/`
Contiene documentación del proyecto.

### `test3.slnx`
Archivo de solución para abrir el proyecto con herramientas externas de desarrollo.

## Paquetes principales detectados

El proyecto usa, entre otros:

- `com.unity.2d.animation`
- `com.unity.2d.aseprite`
- `com.unity.2d.psdimporter`
- `com.unity.inputsystem`
- `com.unity.render-pipelines.universal`
- `com.unity.timeline`
- `com.unity.visualscripting`

## Notas

- El proyecto está orientado a **Unity 2D**.
- Se usa **URP** como pipeline de renderizado.
- La versión del editor registrada en el proyecto es **6000.5.0f1**.

## Licencia

No se encontró información de licencia en el repositorio.
