# 📘 Ejercicios Avanzados con Arreglos en C#

## 1. Rotación de Arreglo
Escribe un programa que reciba un arreglo de enteros y un número `k`, y rote los elementos del arreglo hacia la derecha `k` posiciones.  
Ejemplo: `[1, 2, 3, 4, 5]` con `k=2` → `[4, 5, 1, 2, 3]`.

---

## 2. Subarreglo con Suma Máxima (Kadane’s Algorithm)
Dado un arreglo de enteros (puede contener positivos y negativos), encuentra el subarreglo contiguo con la suma más grande.  
Ejemplo: `[−2, 1, −3, 4, −1, 2, 1, −5, 4]` → el subarreglo `[4, −1, 2, 1]` tiene suma máxima `6`.

---

## 3. Eliminar Duplicados en un Arreglo Ordenado
Escribe un programa que elimine los elementos duplicados de un arreglo **ordenado**, sin usar colecciones como `List` o `HashSet`.  
Ejemplo: `[1, 1, 2, 2, 3, 4, 4]` → `[1, 2, 3, 4]`.

---

## 4. Encontrar el Número que Falta
En un arreglo de números del `1` al `n`, falta un número. Encuentra cuál es.  
Ejemplo: `[1, 2, 4, 5, 6]` → Falta `3`.

---

## 5. Intersección de Dos Arreglos
Dado dos arreglos de enteros, encuentra los elementos comunes sin usar LINQ.  
Ejemplo: `[1,2,2,1]` y `[2,2]` → `[2,2]`.

---

## 6. Matriz Transpuesta
Dada una **matriz** (arreglo bidimensional), encuentra su transpuesta.  
Ejemplo:  
```
[ [1, 2, 3],
  [4, 5, 6] ]
```
→  
```
[ [1, 4],
  [2, 5],
  [3, 6] ]
```

---

## 7. Arreglo de Productos Excepto el Índice
Dado un arreglo de enteros, construye un nuevo arreglo donde cada posición contenga el producto de todos los elementos excepto el de esa posición (sin usar división).  
Ejemplo: `[1, 2, 3, 4]` → `[24, 12, 8, 6]`.

---

## 8. Buscar Elemento en Arreglo Rotado
Dado un arreglo **rotado y ordenado** (ej. `[4,5,6,7,0,1,2]`), implementa búsqueda binaria modificada para encontrar un número dado.

---

## 9. Espiral en una Matriz
Escribe un programa que recorra e imprima los elementos de una matriz en forma de espiral.  
Ejemplo:  
```
[ [1, 2, 3],
  [4, 5, 6],
  [7, 8, 9] ]
```
→ `[1, 2, 3, 6, 9, 8, 7, 4, 5]`.

---

## 10. Suma de Subconjuntos (Backtracking)
Dado un arreglo de enteros y un número `target`, encuentra todos los subconjuntos cuya suma sea igual al `target`.  
Ejemplo: `[2, 3, 6, 7], target=7` → subconjuntos `[7]`, `[2, 2, 3]`.

---