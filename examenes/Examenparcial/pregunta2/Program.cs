using System;

class Program
{
    static void Main()
    {
        // Entrada: arreglo de enteros y el valor k
        Console.WriteLine("Introduce el arreglo de enteros (separados por espacios):");
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("El arreglo no puede estar vacío.");
            return;
        }

        int[] arr;
        try
        {
            arr = Array.ConvertAll(input.Split(' '), int.Parse);
        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor ingresa solo números enteros.");
            return;
        }

        Console.WriteLine("Introduce el número k (posiciones a rotar):");
        string kInput = Console.ReadLine();
        if (string.IsNullOrEmpty(kInput))
        {
            Console.WriteLine("El valor k no puede estar vacío.");
            return;
        }

        int k;
        if (!int.TryParse(kInput, out k))
        {
            Console.WriteLine("Por favor ingresa un número válido para k.");
            return;
        }

        // Llamada a la función de rotación
        RotateArray(arr, k);

        // Mostrar el arreglo después de la rotación
        Console.WriteLine("Arreglo después de rotar:");
        Console.WriteLine(string.Join(", ", arr));
    }

    static void RotateArray(int[] arr, int k)
    {
        int n = arr.Length;
        k = k % n;  // Asegura que k no sea mayor que el tamaño del arreglo

        // Rotar el arreglo
        ReverseArray(arr, 0, n - 1);        // Primero invertimos todo el arreglo
        ReverseArray(arr, 0, k - 1);        // Invertimos la primera parte
        ReverseArray(arr, k, n - 1);        // Invertimos la segunda parte
    }

    // Función para invertir un segmento del arreglo
    static void ReverseArray(int[] arr, int start, int end)
    {
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }
}