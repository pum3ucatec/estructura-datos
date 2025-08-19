using System;

class Program
{
    static void Main()
    {
        // Declarar y asignar valores al arreglo
        int[] numeros = { 5, 10, 15, 20, 25 };

        // Mostrar los elementos del arreglo entre corchetes
        Console.Write("El arreglo es: [");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i]);
            if (i < numeros.Length - 1)
            {
                Console.Write(", "); // Separar con comas
            }
        }
        Console.WriteLine("]"); // Cerrar corchete y salto de línea

        // Calcular la suma de los elementos
        int suma = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }

        // Mostrar el resultado
        Console.WriteLine($"La suma de todos los elementos es: {suma}");
    }
}