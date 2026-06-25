# test3

Proyecto desarrollado en **Unity** con scripts en **C#**.

## Descripción

Creación de videojuego de tierra de nadie, el videojuego es un tower defence que se centra en eliminar a los objetivos que estan en el mapa

## Requisitos

Para abrir y ejecutar el proyecto necesitas:

- **Unity Editor 6000.5.0f1**
- Git
- Un editor de código compatible con C# (por ejemplo, Visual Studio o Rider)

## Instalación

1. Clona el repositorio:
   ```bash
   git clone https://github.com/Stromjold/test3.git
   cd test3
   ```

2. (Opcional) Verifica que estás en `main`:
   ```bash
   git checkout main
   ```

3. Antes de subir cambios, sincroniza con remoto:
   ```bash
   git pull --rebase origin main
   ```

4. Agrega y confirma tus cambios:
   ```bash
   git add .
   git commit -m "feat: actualización de documentación"
   ```

5. Sube los cambios:
   ```bash
   git push origin main
   ```

### Si aparece el error `! [rejected] main -> main (fetch first)`

Ese error significa que `origin/main` tiene commits que no están en tu copia local.  
Solución recomendada:

```bash
git pull --rebase origin main
git push origin main
```

### Si hay conflictos durante el rebase

1. Revisa archivos en conflicto:
   ```bash
   git status
   ```
2. Resuelve conflictos y guarda.
3. Continúa el rebase:
   ```bash
   git add .
   git rebase --continue
   ```
4. Vuelve a intentar el push:
   ```bash
   git push origin main
   ```

### Consejo de seguridad (backup rápido)

Antes de hacer rebase, puedes crear una rama de respaldo:

```bash
git branch backup-local-main
```

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
