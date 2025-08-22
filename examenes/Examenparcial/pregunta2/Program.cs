using System;

class Program
{
    static void Main()
    {
        // Solicitamos el número de filas y columnas de la matriz
        Console.Write("Introduce el número de filas: ");
        int filas = int.Parse(Console.ReadLine());
        
        Console.Write("Introduce el número de columnas: ");
        int columnas = int.Parse(Console.ReadLine());

        // Creamos la matriz original
        int[,] matriz = new int[filas, columnas];

        // Solicitamos los valores de la matriz al usuario
        Console.WriteLine("Introduce los valores de la matriz:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Matriz[{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Creamos la matriz transpuesta
        int[,] transpuesta = new int[columnas, filas];

        // Realizamos la transposición
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                transpuesta[j, i] = matriz[i, j];
            }
        }

        // Imprimimos la matriz transpuesta
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
}
