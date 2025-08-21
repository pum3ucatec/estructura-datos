using System;

class Program
{
    static void Main()
    {
        int[] arreglo = { 8, 3, 5, 1, 9 };
        for (int i = 0; i < arreglo.Length - 1; i++)
        {
            for (int j = 0; j < arreglo.Length - 1 - i; j++)
            {
                if (arreglo[j] > arreglo[j + 1])
                {
                    int temp = arreglo[j];
                    arreglo[j] = arreglo[j + 1];
                    arreglo[j + 1] = temp;
                }
            }
        }

        Console.WriteLine($"Arreglo desordenado: [{string.Join(", ", arreglo)}]");
    }
}
