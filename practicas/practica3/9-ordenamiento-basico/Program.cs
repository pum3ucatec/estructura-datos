using System;

class Program
{
    static void Main()
    {
        // Crear un arreglo de ejemplo
        int[] numeros = { 9, 3, 7, 1, 5, 8, 2, 6, 4, 0 };

        Console.Write("Arreglo original: [");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i]);
            if (i < numeros.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("]");

        // Algoritmo de burbuja
        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = 0; j < numeros.Length - 1 - i; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    // Intercambiar elementos
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }

        // Mostrar arreglo ordenado
        Console.Write("Arreglo ordenado: [");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i]);
            if (i < numeros.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}