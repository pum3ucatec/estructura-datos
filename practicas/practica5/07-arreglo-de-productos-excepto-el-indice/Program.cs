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

        int[] resultado = ProductoExceptoIndice(arreglo);

        Console.Write("✅ Arreglo resultado: [");
        for (int i = 0; i < resultado.Length; i++)
        {
            Console.Write(resultado[i]);
            if (i < resultado.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("]");
    }

    static int[] ProductoExceptoIndice(int[] nums)
    {
        int n = nums.Length;
        int[] resultado = new int[n];

        // Producto de los elementos a la izquierda de i
        int productoIzq = 1;
        for (int i = 0; i < n; i++)
        {
            resultado[i] = productoIzq;
            productoIzq *= nums[i];
        }

        // Producto de los elementos a la derecha de i
        int productoDer = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            resultado[i] *= productoDer;
            productoDer *= nums[i];
        }

        return resultado;
    }
}