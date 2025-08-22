using System;

class Program
{
    static void Main()
    {
        // Solicitar el número de filas y columnas de la matriz
        int filas = GetValidInteger("Introduce el número de filas de la matriz:");
        int columnas = GetValidInteger("Introduce el número de columnas de la matriz:");

        // Crear la matriz original
        int[,] matriz = new int[filas, columnas];

        // Ingresar los valores de la matriz
        Console.WriteLine("Introduce los valores de la matriz:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = GetValidInteger($"Elemento en posición [{i + 1}, {j + 1}]: ");
            }
        }

        // Mostrar la matriz original
        Console.WriteLine("\nMatriz Original:");
        PrintMatrix(matriz);

        // Obtener la transpuesta
        int[,] transpuesta = GetTranspose(matriz);

        // Mostrar la matriz transpuesta
        Console.WriteLine("\nMatriz Transpuesta:");
        PrintMatrix(transpuesta);
    }

    // Función para obtener la matriz transpuesta
    static int[,] GetTranspose(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        // Crear una nueva matriz con filas y columnas intercambiadas
        int[,] transpuesta = new int[columnas, filas];

        // Llenar la matriz transpuesta
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                transpuesta[j, i] = matriz[i, j];
            }
        }

        return transpuesta;
    }

    // Función para imprimir la matriz
    static void PrintMatrix(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Función para obtener un valor entero válido, con manejo de nulos
    static int GetValidInteger(string message)
    {
        int value;
        while (true)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            // Verificamos que la entrada no esté vacía
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("La entrada no puede estar vacía. Intenta de nuevo.");
                continue;
            }

            // Intentamos convertir el valor ingresado
            if (int.TryParse(input, out value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Por favor ingresa un número entero válido.");
            }
        }
    }
}
