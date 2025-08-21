using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa los elementos del arreglo separados por espacios: ");
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

        int maxSuma = Kadane(arreglo, out int inicio, out int fin);

        Console.WriteLine($"\n✅ Suma máxima: {maxSuma}");
        Console.Write("📦 Subarreglo con suma máxima: [");
        for (int i = inicio; i <= fin; i++)
        {
            Console.Write(arreglo[i]);
            if (i < fin) Console.Write(", ");
        }
        Console.WriteLine("]");
    }

    static int Kadane(int[] nums, out int inicio, out int fin)
    {
        int maxActual = nums[0];
        int maxTotal = nums[0];
        inicio = fin = 0;
        int tempInicio = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > maxActual + nums[i])
            {
                maxActual = nums[i];
                tempInicio = i;
            }
            else
            {
                maxActual += nums[i];
            }

            if (maxActual > maxTotal)
            {
                maxTotal = maxActual;
                inicio = tempInicio;
                fin = i;
            }
        }

        return maxTotal;
    }
}