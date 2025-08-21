using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa los números del arreglo (separados por espacios): ");
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

        int n = arreglo.Length + 1; // porque falta un número

        int faltante = EncontrarNumeroFaltante(arreglo, n);

        Console.WriteLine($"\n✅ Número faltante: {faltante}");
    }

    // Método que calcula la suma del 1..n y resta los elementos del arreglo
    static int EncontrarNumeroFaltante(int[] arr, int n)
    {
        int sumaEsperada = n * (n + 1) / 2;
        int sumaArreglo = 0;

        foreach (int num in arr)
            sumaArreglo += num;

        return sumaEsperada - sumaArreglo;
    }
}