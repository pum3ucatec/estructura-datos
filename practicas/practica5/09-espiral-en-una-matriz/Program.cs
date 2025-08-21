using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el número de filas de la matriz:");
        if (!int.TryParse(Console.ReadLine(), out int filas) || filas <= 0)
        {
            Console.WriteLine("Número de filas inválido. El programa terminará.");
            return;
        }

        Console.WriteLine("Ingrese el número de columnas de la matriz:");
        if (!int.TryParse(Console.ReadLine(), out int columnas) || columnas <= 0)
        {
            Console.WriteLine("Número de columnas inválido. El programa terminará.");
            return;
        }

        int[,] matriz = new int[filas, columnas];

        Console.WriteLine($"Ingrese los elementos de la matriz ({filas}x{columnas}):");

        for (int i = 0; i < filas; i++)
        {
            Console.WriteLine($"Fila {i + 1} (ingrese {columnas} números separados por espacios):");
            string? entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Entrada inválida. El programa terminará.");
                return;
            }

            string[] partes = entrada.Split(' ');
            if (partes.Length != columnas)
            {
                Console.WriteLine("Cantidad incorrecta de elementos. El programa terminará.");
                return;
            }

            for (int j = 0; j < columnas; j++)
            {
                if (!int.TryParse(partes[j], out matriz[i, j]))
                {
                    Console.WriteLine($"Valor inválido en la fila {i + 1}, columna {j + 1}. El programa terminará.");
                    return;
                }
            }
        }

        List<int> resultado = RecorrerEspiral(matriz, filas, columnas);

        Console.WriteLine("\nElementos en orden espiral:");
        Console.WriteLine("[" + string.Join(", ", resultado) + "]");
    }

    static List<int> RecorrerEspiral(int[,] matriz, int filas, int columnas)
    {
        List<int> resultado = new List<int>();

        int inicioFila = 0, finFila = filas - 1;
        int inicioCol = 0, finCol = columnas - 1;

        while (inicioFila <= finFila && inicioCol <= finCol)
        {
            // Recorrer fila superior
            for (int col = inicioCol; col <= finCol; col++)
                resultado.Add(matriz[inicioFila, col]);
            inicioFila++;

            // Recorrer columna derecha
            for (int fila = inicioFila; fila <= finFila; fila++)
                resultado.Add(matriz[fila, finCol]);
            finCol--;

            if (inicioFila <= finFila)
            {
                // Recorrer fila inferior
                for (int col = finCol; col >= inicioCol; col--)
                    resultado.Add(matriz[finFila, col]);
                finFila--;
            }

            if (inicioCol <= finCol)
            {
                // Recorrer columna izquierda
                for (int fila = finFila; fila >= inicioFila; fila--)
                    resultado.Add(matriz[fila, inicioCol]);
                inicioCol++;
            }
        }

        return resultado;
    }
}