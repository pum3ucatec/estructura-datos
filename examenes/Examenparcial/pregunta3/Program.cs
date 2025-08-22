using System;

class Program
{
    static void Main()
    {
        // Solicitamos el número de filas y columnas de la matriz
        int filas = LeerEntero("Introduce el número de filas: ");
        int columnas = LeerEntero("Introduce el número de columnas: ");

        // Creamos la matriz original
        int[,] matriz = new int[filas, columnas];

        // Solicitamos los valores de la matriz al usuario
        Console.WriteLine("Introduce los valores de la matriz:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = LeerEntero($"Matriz[{i},{j}]: ");
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

    // Método para leer un número entero de forma segura
    static int LeerEntero(string mensaje)
    {
        int numero;
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out numero))
            {
                return numero;
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número entero válido.");
            }
        }
    }
}
