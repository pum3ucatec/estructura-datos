using System;

class Program
{
    static void Main()
    {
        int[] arreglo = { 1, 2, 3, 4, 5 };
        int[] arregloInvertido = new int[arreglo.Length];

        for (int i = 0; i < arreglo.Length; i++)
        {
            arregloInvertido[i] = arreglo[arreglo.Length - 1 - i];
        }

        Console.WriteLine($"Arreglo original: [{string.Join(", ", arreglo)}]");
        Console.WriteLine($"Arreglo invertido: [{string.Join(", ", arregloInvertido)}]");
    }
}
