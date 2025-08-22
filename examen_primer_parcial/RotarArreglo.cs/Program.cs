using System;

class RotarArreglo
{
    static void Main()
    {
        // Pedir al usuario el arreglo
        Console.WriteLine("Ingrese los elementos del arreglo (ej: [1, 2, 3, 4, 5] o 1 2 3 4 5):");
        string[] entrada = Console.ReadLine()
                                .Replace("[", "")
                                .Replace("]", "")
                                .Replace(",", "")
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] arreglo = Array.ConvertAll(entrada, int.Parse);

        // Pedir k
        Console.WriteLine("Ingrese el número de posiciones a rotar (k):");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("Arreglo original:");
        ImprimirArreglo(arreglo);

        RotarDerecha(arreglo, k);

        Console.WriteLine("Arreglo rotado a la derecha " + k + " posiciones:");
        ImprimirArreglo(arreglo);
    }

    static void RotarDerecha(int[] arr, int k)
    {
        int n = arr.Length;
        k = k % n; // Para casos donde k > n
        if (k == 0) return;

        int[] temp = new int[k];
        Array.Copy(arr, n - k, temp, 0, k);

        for (int i = n - 1; i >= k; i--)
        {
            arr[i] = arr[i - k];
        }

        for (int i = 0; i < k; i++)
        {
            arr[i] = temp[i];
        }
    }

    static void ImprimirArreglo(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

