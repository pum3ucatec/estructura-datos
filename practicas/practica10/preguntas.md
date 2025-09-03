# 📘 Ejercicios de Recursividad en C#

En este documento se presentan problemas clásicos que normalmente se resuelven con **recursividad**.  
Sin embargo, aquí se muestran únicamente las **soluciones iterativas**.  

## Implementar la **versión recursiva** de cada uno.

---

## 1. Factorial de un número

**Pregunta:**  
Implementar una función que calcule el factorial de un número `n`.

### 🔄 Solución Iterativa
```csharp
public static int FactorialIterativo(int n)
{
    int resultado = 1;
    for (int i = 1; i <= n; i++)
    {
        resultado *= i;
    }
    return resultado;
}
```

---

## 2. Suma de los primeros N números naturales

**Pregunta:**  
Calcular la suma de los primeros `n` números naturales.

### 🔄 Solución Iterativa
```csharp
public static int SumaIterativa(int n)
{
    int suma = 0;
    for (int i = 1; i <= n; i++)
    {
        suma += i;
    }
    return suma;
}
```

---

## 3. Secuencia de Fibonacci

**Pregunta:**  
Calcular el término `n` de la secuencia de Fibonacci.

### 🔄 Solución Iterativa
```csharp
public static int FibonacciIterativo(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;

    int a = 0, b = 1, temp;

    for (int i = 2; i <= n; i++)
    {
        temp = a + b;
        a = b;
        b = temp;
    }
    return b;
}
```

---

## 4. Potencia de un número

**Pregunta:**  
Calcular `base^exponente` (base elevado al exponente).

### 🔄 Solución Iterativa
```csharp
public static int PotenciaIterativa(int baseNum, int exp)
{
    int resultado = 1;
    for (int i = 1; i <= exp; i++)
    {
        resultado *= baseNum;
    }
    return resultado;
}
```

---

## 5. Invertir una cadena

**Pregunta:**  
Invertir una cadena de texto.

### 🔄 Solución Iterativa
```csharp
public static string InvertirCadenaIterativa(string cadena)
{
    char[] array = cadena.ToCharArray();
    Array.Reverse(array);
    return new string(array);
}
```

---

## 6. Contar dígitos de un número

**Pregunta:**  
Contar la cantidad de dígitos que tiene un número entero positivo.

### 🔄 Solución Iterativa
```csharp
public static int ContarDigitosIterativo(int n)
{
    int contador = 0;
    while (n > 0)
    {
        contador++;
        n /= 10;
    }
    return contador;
}
```

---

## 7. Máximo Común Divisor (MCD)

**Pregunta:**  
Calcular el máximo común divisor (MCD) de dos números.

### 🔄 Solución Iterativa
```csharp
public static int MCDIterativo(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}
```

---

## 8. Suma de un arreglo

**Pregunta:**  
Calcular la suma de todos los elementos de un arreglo.

### 🔄 Solución Iterativa
```csharp
public static int SumaArregloIterativa(int[] arr)
{
    int suma = 0;
    foreach (int num in arr)
    {
        suma += num;
    }
    return suma;
}
```

---

## 9. Buscar un elemento en un arreglo

**Pregunta:**  
Determinar si un número existe en un arreglo.

### 🔄 Solución Iterativa
```csharp
public static bool BuscarElementoIterativo(int[] arr, int valor)
{
    foreach (int num in arr)
    {
        if (num == valor)
            return true;
    }
    return false;
}
```

---

## 10. Convertir un número decimal a binario

**Pregunta:**  
Convertir un número decimal en su representación binaria.

### 🔄 Solución Iterativa
```csharp
public static string DecimalABinarioIterativo(int n)
{
    string binario = "";
    while (n > 0)
    {
        binario = (n % 2) + binario;
        n /= 2;
    }
    return binario;
}
```