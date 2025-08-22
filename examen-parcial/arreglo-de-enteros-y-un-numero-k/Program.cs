using System;

class Program
{
    static int[] RotarDerecha(int[] arr, int k)
    {
        int n = arr.Length;
        if (n == 0) return arr;

        k = k % n;
        int[] resultado = new int[n];

        Array.Copy(arr, n - k, resultado, 0, k);

        Array.Copy(arr, 0, resultado, k, n - k);

        return resultado;
    }

    static void Main()
    {
        int[] arreglo = { 1, 2, 3, 4, 5 };
        int k = 2;

        Console.WriteLine("Arreglo original: [" + string.Join(", ", arreglo) + "]");
        Console.WriteLine("k = " + k);

        int[] rotado = RotarDerecha(arreglo, k);
        Console.WriteLine("Arreglo rotado: [" + string.Join(", ", rotado) + "]");
    }
}