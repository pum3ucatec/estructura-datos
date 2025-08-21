using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa los elementos del arreglo rotado separados por espacios: ");
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

        Console.Write("Ingresa el número a buscar: ");
        if (!int.TryParse(Console.ReadLine(), out int target))
        {
            Console.WriteLine("Número inválido. El programa terminará.");
            return;
        }

        int indice = BuscarEnArregloRotado(arreglo, target);

        if (indice == -1)
            Console.WriteLine($"\nEl número {target} no se encontró en el arreglo.");
        else
            Console.WriteLine($"\nNúmero {target} encontrado en el índice: {indice}");
    }

    static int BuscarEnArregloRotado(int[] nums, int target)
    {
        int izquierda = 0;
        int derecha = nums.Length - 1;

        while (izquierda <= derecha)
        {
            int medio = izquierda + (derecha - izquierda) / 2;

            if (nums[medio] == target)
                return medio;

            // Verificamos si la mitad izquierda está ordenada
            if (nums[izquierda] <= nums[medio])
            {
                if (target >= nums[izquierda] && target < nums[medio])
                    derecha = medio - 1;
                else
                    izquierda = medio + 1;
            }
            else // La mitad derecha está ordenada
            {
                if (target > nums[medio] && target <= nums[derecha])
                    izquierda = medio + 1;
                else
                    derecha = medio - 1;
            }
        }

        return -1; // No encontrado
    }
}