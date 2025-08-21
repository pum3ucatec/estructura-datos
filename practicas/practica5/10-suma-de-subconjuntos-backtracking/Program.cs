using System;
using System.Collections.Generic;

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

        Console.Write("Ingresa el valor target: ");
        if (!int.TryParse(Console.ReadLine(), out int target))
        {
            Console.WriteLine("Valor target inválido. El programa terminará.");
            return;
        }

        List<List<int>> resultados = new List<List<int>>();
        List<int> temp = new List<int>();

        // Ordenamos para facilitar la búsqueda y evitar combinaciones duplicadas si quieres
        Array.Sort(arreglo);

        EncontrarSubconjuntos(arreglo, target, 0, temp, resultados);

        if (resultados.Count == 0)
        {
            Console.WriteLine($"No se encontraron subconjuntos con suma {target}.");
        }
        else
        {
            Console.WriteLine($"\nSubconjuntos con suma {target}:");
            foreach (var subconjunto in resultados)
            {
                Console.WriteLine("[ " + string.Join(", ", subconjunto) + " ]");
            }
        }
    }

    static void EncontrarSubconjuntos(int[] nums, int target, int inicio, List<int> temp, List<List<int>> resultados)
    {
        if (target == 0)
        {
            // Se encontró un subconjunto que suma target
            resultados.Add(new List<int>(temp));
            return;
        }

        for (int i = inicio; i < nums.Length; i++)
        {
            if (nums[i] > target) 
                break; // Como el arreglo está ordenado, no vale la pena continuar

            // Incluimos nums[i] y avanzamos con target reducido
            temp.Add(nums[i]);

            // Si quieres permitir repetir elementos, pasa 'i' en la recursión; si no, 'i + 1'
            EncontrarSubconjuntos(nums, target - nums[i], i, temp, resultados);

            temp.RemoveAt(temp.Count - 1); // Backtracking
        }
    }
}