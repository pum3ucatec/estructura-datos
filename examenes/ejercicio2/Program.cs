using System;

class Program
{
    static void Main()
    {
       
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int[,] transposed = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposed[j, i] = matrix[i, j];  
            }
        }

        Console.WriteLine("Matriz transpuesta:");
        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Console.Write(transposed[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
