using System;
class Program
{
    static void Main()
    {
        int[] arr = { 3, 6, 9, 12, 15, 18, 21 };
        int n = arr.Length;
        Console.WriteLine("Ingrese el valor de k para mover el arreglo: ");
        int k = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Elegiste:{k} ");

        k = k % n;
        int[] resultado = new int[n];
        for (int i = 0; i < k; i++)
        {
            resultado[i] = arr[n - k + i];
        }
        for (int i = k; i < n; i++)
        {
            resultado[i] = arr[i - k];
        }
        Console.WriteLine("Arreglo original: " + string.Join(", ", arr));
        Console.WriteLine("Arreglo rotado: " + string.Join(", ", resultado));
    }
}