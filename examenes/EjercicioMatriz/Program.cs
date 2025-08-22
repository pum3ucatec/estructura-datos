using System;

class Program
{
    static void Main()
    {
        // Matriz de ejemplo
        int[,] matriz = {
            {5, 4, 3},
            {9, 8, 7}
        };

        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        // Crear la matriz transpuesta
        int[,] transpuesta = new int[columnas, filas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                transpuesta[j, i] = matriz[i, j];
            }
        }

        // Mostrar la matriz original
        Console.WriteLine("Matriz original:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // Mostrar la matriz transpuesta
        Console.WriteLine("Matriz transpuesta:");
        for (int i = 0; i < columnas; i++)
        {
            for (int j = 0; j < filas; j++)
            {
                Console.Write(transpuesta[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

