using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa los elementos del arreglo ordenado (separados por espacios): ");
        string? entrada = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("Entrada inválida. El programa terminará.");
            return;
        }

        string[] partes = entrada.Split(' ');
        int[] arreglo = new int[partes.Length];

        for (int i = 0; i < partes.Length; i++)
        {
            if (!int.TryParse(partes[i], out arreglo[i]))
            {
                Console.WriteLine($"Valor inválido en la posición {i + 1}. El programa terminará.");
                return;
            }
        }

        int nuevoTamaño = EliminarDuplicados(arreglo);

        Console.Write("✅ Arreglo sin duplicados: [");
        for (int i = 0; i < nuevoTamaño; i++)
        {
            Console.Write(arreglo[i]);
            if (i < nuevoTamaño - 1) Console.Write(", ");
        }
        Console.WriteLine("]");
    }

    // Elimina duplicados IN PLACE y devuelve el nuevo tamaño
    static int EliminarDuplicados(int[] arr)
    {
        if (arr.Length == 0) return 0;

        int j = 0; // índice de escritura

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[j])
            {
                j++;
                arr[j] = arr[i];
            }
        }

        return j + 1; // tamaño del arreglo sin duplicados
    }
}