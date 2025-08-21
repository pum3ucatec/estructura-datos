using System;

class Program
{
    static void Main()
    {
        int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        Console.WriteLine("Matriz:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        int[] sumaFilas = new int[matriz.GetLength(0)];
        int[] sumaColumnas = new int[matriz.GetLength(1)];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                sumaFilas[i] += matriz[i, j];
                sumaColumnas[j] += matriz[i, j];
            }
        }

        Console.WriteLine("\nSuma de filas:");
        for (int i = 0; i < sumaFilas.Length; i++)
        {
            Console.WriteLine($"Fila {i + 1}: {sumaFilas[i]}");
        }

        Console.WriteLine("\nSuma de columnas:");
        for (int j = 0; j < sumaColumnas.Length; j++)
        {
            Console.WriteLine($"Columna {j + 1}: {sumaColumnas[j]}");
        }
    }
}
