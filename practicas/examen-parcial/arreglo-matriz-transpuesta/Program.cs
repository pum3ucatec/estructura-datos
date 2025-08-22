using System;

class Program
{
    static int[,] Transponer(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
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

    static void Main()
    {
        int[,] matriz = { {1, 2, 3}, {4, 5, 6} };
        int[,] transpuesta = Transponer(matriz);

        Console.WriteLine("Matriz original:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nMatriz transpuesta:");
        for (int i = 0; i < transpuesta.GetLength(0); i++)
        {
            for (int j = 0; j < transpuesta.GetLength(1); j++)
            {
                Console.Write(transpuesta[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}