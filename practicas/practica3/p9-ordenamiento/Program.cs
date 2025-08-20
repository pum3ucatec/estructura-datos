using System;

class Program
{
    static void Main()
    {
        int[] arreglo = { 8, 3, 5, 1, 9 };

        Console.WriteLine("arreglo: [" + string.Join(", ", arreglo) + "]");

        for (int i = 0; i < arreglo.Length - 1; i++)
        {
            for (int j = 0; j < arreglo.Length - i - 1; j++)
            {
                if (arreglo[j] > arreglo[j + 1])
                {
                    int temp = arreglo[j];
                    arreglo[j] = arreglo[j + 1];
                    arreglo[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("arreglo ordenado: [" + string.Join(", ", arreglo) + "]");
    }
}