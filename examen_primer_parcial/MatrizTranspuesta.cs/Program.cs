using System;

namespace MatrizTranspuesta
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definimos la matriz original
            int[,] matriz = {
                {1, 2, 3},
                {4, 5, 6}
            };

            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            // Creamos la matriz transpuesta
            int[,] transpuesta = new int[columnas, filas];

            // Calculamos la transpuesta
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    transpuesta[j, i] = matriz[i, j];
                }
            }

            // Mostramos la matriz original
            Console.WriteLine("Matriz original:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Mostramos la matriz transpuesta
            Console.WriteLine("\nMatriz transpuesta:");
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    Console.Write(transpuesta[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine(); // Mantener la consola abierta
        }
    }
}
