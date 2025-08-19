using System;

class Program
{
    static void Main()
    {
        // Declarar la matriz 3x3
        int[,] matriz = new int[3, 3];
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        // Pedir valores al usuario
        Console.WriteLine("Ingresa los valores para la matriz 3x3:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nMatriz ingresada:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // Calcular suma de cada fila
        for (int i = 0; i < filas; i++)
        {
            int sumaFila = 0;
            for (int j = 0; j < columnas; j++)
            {
                sumaFila += matriz[i, j];
            }
            Console.WriteLine($"Suma de la fila {i}: {sumaFila}");
        }

        Console.WriteLine();

        // Calcular suma de cada columna
        for (int j = 0; j < columnas; j++)
        {
            int sumaColumna = 0;
            for (int i = 0; i < filas; i++)
            {
                sumaColumna += matriz[i, j];
            }
            Console.WriteLine($"Suma de la columna {j}: {sumaColumna}");
        }
    }
}