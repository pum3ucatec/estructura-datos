# 📘 Práctica: Arreglos en C#  

**Nota:** Crear una rama llamada ´GastonQuelali/Practica3´

## 1. Declaración e inicialización  
Declara un arreglo de 5 enteros y asígnales valores manualmente. Luego imprime todos los valores en pantalla.  

```csharp
int[] numeros = { 10, 20, 30, 40, 50 };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}
```

**Ejemplo de salida:**  
```
10
20
30
40
50
```

---

## 2. Recorrido con `for`  
Crea un arreglo de 10 números enteros y muéstralos en consola utilizando un ciclo `for`.

**Explicación:** El alumno debe entender cómo usar `Length` para recorrer el arreglo completo.

---

## 3. Suma de elementos  
Dado un arreglo de enteros, calcula la suma de todos sus elementos.  

**Ejemplo esperado:**  
```
Arreglo: [5, 10, 15, 20]
Suma: 50
```

---

## 4. Promedio de elementos  
Ingresa 5 calificaciones en un arreglo y calcula el promedio.  

**Ejemplo esperado:**  
```
Notas: [80, 70, 90, 60, 100]
Promedio: 80
```

---

## 5. Mayor y menor valor  
Crea un programa que lea 8 números en un arreglo y muestre el mayor y el menor.  

**Ejemplo esperado:**  
```
Números: [12, 5, 8, 20, 3, 17, 25, 10]
Mayor: 25
Menor: 3
```

---

## 6. Búsqueda lineal  
Dado un arreglo de 10 números, pide al usuario un número y determina si está dentro del arreglo (imprime la posición si existe).  

**Ejemplo esperado:**  
```
Ingrese un número: 17
El número 17 se encuentra en la posición 4
```

---

## 7. Contar ocurrencias  
Dado un arreglo de enteros, pide un número y cuenta cuántas veces aparece en el arreglo.  

**Ejemplo esperado:**  
```
Arreglo: [2, 5, 2, 8, 2, 9]
Número buscado: 2
El número aparece 3 veces
```

---

## 8. Invertir arreglo  
Dado un arreglo, crea un segundo arreglo que contenga los mismos elementos pero en orden inverso.  

**Ejemplo esperado:**  
```
Arreglo original: [1, 2, 3, 4, 5]
Arreglo invertido: [5, 4, 3, 2, 1]
```

---

## 9. Ordenamiento (básico)  
Implementa un algoritmo sencillo (por ejemplo, **Burbuja**) para ordenar un arreglo de enteros de menor a mayor.  

**Ejemplo esperado:**  
```
Arreglo desordenado: [8, 3, 5, 1, 9]
Arreglo ordenado: [1, 3, 5, 8, 9]
```

---

## 10. Arreglo bidimensional (matriz)  
Declara una matriz de 3x3, inicialízala con valores y muestra la suma de cada fila y cada columna.  

**Ejemplo esperado:**  
```
Matriz:
1 2 3
4 5 6
7 8 9

Suma de filas:
Fila 1: 6
Fila 2: 15
Fila 3: 24

Suma de columnas:
Columna 1: 12
Columna 2: 15
Columna 3: 18
```
