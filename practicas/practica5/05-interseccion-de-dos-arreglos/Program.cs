using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa los elementos del primer arreglo separados por espacios: ");
        string? entrada1 = Console.ReadLine();

        Console.Write("Ingresa los elementos del segundo arreglo separados por espacios: ");
        string? entrada2 = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(entrada1) || string.IsNullOrWhiteSpace(entrada2))
        {
            Console.WriteLine("Entrada inválida. El programa terminará.");
            return;
        }

        int[] arr1 = ParsearArreglo(entrada1);
        int[] arr2 = ParsearArreglo(entrada2);

        int[] interseccion = Interseccion(arr1, arr2);

        Console.Write("✅ Intersección: [");
        for (int i = 0; i < interseccion.Length; i++)
        {
            Console.Write(interseccion[i]);
            if (i < interseccion.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("]");
    }

    static int[] ParsearArreglo(string entrada)
    {
        string[] partes = entrada.Split(' ');
        int[] arreglo = new int[partes.Length];
        for (int i = 0; i < partes.Length; i++)
        {
            if (!int.TryParse(partes[i], out arreglo[i]))
            {
                Console.WriteLine($"Valor inválido en la posición {i + 1}. El programa terminará.");
                Environment.Exit(0);
            }
        }
        return arreglo;
    }

    // Método para obtener la intersección considerando repeticiones
    static int[] Interseccion(int[] arr1, int[] arr2)
    {
        // Ordenamos los arreglos para facilitar la comparación
        Array.Sort(arr1);
        Array.Sort(arr2);

        int i = 0, j = 0;
        int[] temp = new int[Math.Min(arr1.Length, arr2.Length)];
        int index = 0;

        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] == arr2[j])
            {
                temp[index++] = arr1[i];
                i++;
                j++;
            }
            else if (arr1[i] < arr2[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }

        // Copiamos el resultado a un arreglo de tamaño exacto
        int[] resultado = new int[index];
        Array.Copy(temp, resultado, index);

        return resultado;
    }
}