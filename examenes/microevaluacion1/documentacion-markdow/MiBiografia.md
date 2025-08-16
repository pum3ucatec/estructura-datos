# 🖩 Proyecto: Calculadora Científica en C#
**Estudiante:** Wilson Aguilar Lima

##  Herramientas necesarias
Antes de iniciar, asegúrate de tener instalado:
- **Visual Studio Code** 
- **Git** para la gestión de versiones.
- **.NET SDK** para compilar y ejecutar el código.

---

##  Preparación del entorno

### 1. Creación y registro de una clave SSH
```bash
ls -al ~/.ssh
ssh-keygen -t ed25519 -C "wil6703@gmail
eval "$(ssh-agent -s)"
ssh-add ~/.ssh/id_ed25519
cat ~/.ssh/id_ed25519.pub
```
 **Importante:** Copia el contenido y agrégalo en tu cuenta de GitHub, en la sección *Settings > SSH and GPG keys*.

### 2. Clonar y ejecutar el proyecto
```bash
git clone https://github.com/pum3ucatec/estructura-datos.git
cd ESTRUCTURA-DATOS
git checkout WilsonAguilar/microevaluacion1
dotnet run
```

### 3. Enviar cambios a una nueva rama en GitHub
```bash
git checkout -b WilsonAguilar/microevaluacion1
git add .
git commit -m "Actualización inicial"
git push -u origin mi-nueva-rama
```


### Instrucciones de uso

1. Abre la terminal en la carpeta del proyecto.
2. Ejecuta:
   ```bash
   dotnet run
   ```
3. Selecciona la operación matemática que desees.
4. Ingresa los valores solicitados.
5. Para salir, elige la opción `0`.


![Vista previa de la Calculadora](./imagenes/image%20.png)

 **Recomendación:** Mantén tu entorno actualizado para evitar errores de compatibilidad con .NET o Git.
