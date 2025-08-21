using System;

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

        int[,] transpuesta = TransponerMatriz(matriz, filas, columnas);

        Console.WriteLine("\nMatriz transpuesta:");

        for (int i = 0; i < columnas; i++)
        {
            for (int j = 0; j < filas; j++)
            {
                Console.Write(transpuesta[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] TransponerMatriz(int[,] matriz, int filas, int columnas)
    {
        int[,] transpuesta = new int[columnas, filas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                transpuesta[j, i] = matriz[i, j];
            }
        }

        return transpuesta;
    }
}