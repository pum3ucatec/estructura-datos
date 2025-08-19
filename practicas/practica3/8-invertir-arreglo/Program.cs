using System;

class Program
{
    static void Main()
    {
        // Crear un arreglo de ejemplo
        int[] original = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Crear un arreglo para almacenar el inverso
        int[] inverso = new int[original.Length];

        // Llenar el arreglo inverso
        for (int i = 0; i < original.Length; i++)
        {
            inverso[i] = original[original.Length - 1 - i];
        }

        // Mostrar el arreglo original
        Console.Write("Arreglo original: [");
        for (int i = 0; i < original.Length; i++)
        {
            Console.Write(original[i]);
            if (i < original.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("]");

        // Mostrar el arreglo inverso
        Console.Write("Arreglo inverso: [");
        for (int i = 0; i < inverso.Length; i++)
        {
            Console.Write(inverso[i]);
            if (i < inverso.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}