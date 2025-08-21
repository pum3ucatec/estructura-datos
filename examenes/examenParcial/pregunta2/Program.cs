using System;

class Program
{
    public static void Main()
    {
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        int[,] transpuesta = TransponerMatriz(matriz);

        Console.WriteLine("Matriz transpuesta:");
        for (int i = 0; i < transpuesta.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < transpuesta.GetLength(1); j++)
            {
                Console.Write(transpuesta[i, j] + " ");
            }
            Console.WriteLine("]");
        }
    }

    public static int[,] TransponerMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int[,] resultado = new int[columnas, filas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[j, i] = matriz[i, j];
            }
        }

        return resultado;
    }
}