# Lista Simple – Insertar en Orden & Insertar al Principio

Esta Microevaluacion contiene la implementación de **listas simplemente enlazadas** en C# con dos operaciones solicitadas:

## Ejercicios

### 1. Insertar en orden
- Se insertan los elementos `6, 4, 8, 2, 7`.
- La lista se mantiene en **orden ascendente**.
- **Salida esperada:**

2 -> 4 -> 6 -> 7 -> 8 -> null

### 2. Insertar al principio
- Lista base: `4 -> 8 -> 2 -> 7 -> null`.
- Insertando `6` al inicio con `InsertarAlPrincipio(6)`.
- **Salida esperada:**

6 -> 4 -> 8 -> 2 -> 7 -> null


## Archivos

- `Nodo.cs` -> definición del nodo.
- `ListaSimple.cs` -> implementación de la lista con las funciones:
- `InsertarEnOrden(int valor)`
- `InsertarAlPrincipio(int valor)`
- `Mostrar()`
- `Program.cs` -> pruebas de los ejercicios.
- `ListaSimple.csproj` -> configuración del proyecto .NET.
- `README.md` -> documentación.

## Cómo ejecutar

1. Abrir terminal en la carpeta del proyecto.
2. Ejecutar:

 dotnet run
