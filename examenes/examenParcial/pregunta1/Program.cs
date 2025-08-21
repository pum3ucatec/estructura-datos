using System;

class Program
{
    public static void Main()
    {
        int[] arreglo = { 1, 2, 3, 4, 5 };
        int k = 2;

        int[] rotado = RotarDerecha(arreglo, k);

        Console.WriteLine("Arreglo rotado:");
        Console.Write("[");
        for (int i = 0; i < rotado.Length; i++)
        {
            Console.Write(rotado[i]);
            if (i < rotado.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("]");
    }

    public static int[] RotarDerecha(int[] arreglo, int k)
    {
        int n = arreglo.Length;
        int[] resultado = new int[n];
        k = k % n;

        for (int i = 0; i < n; i++)
        {
            int nuevaPosicion = (i + k) % n;
            resultado[nuevaPosicion] = arreglo[i];
        }

        return resultado;
    }
}