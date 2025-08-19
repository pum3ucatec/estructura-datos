using System;

class Program
{
    static void Main()
    {
        // Declarar un arreglo de 10 números
        int[] numeros = new int[10];

        // Llenar el arreglo con números ingresados por el usuario
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingresa el número #{i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Pedir al usuario el número a buscar
        Console.Write("Ingresa el número a buscar: ");
        int busqueda = Convert.ToInt32(Console.ReadLine());

        // Variable para verificar si se encontró
        bool encontrado = false;

        // Recorrer el arreglo para buscar el número
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == busqueda)
            {
                Console.WriteLine($"El número {busqueda} se encuentra en la posición {i} del arreglo.");
                encontrado = true;
                break; // Salimos del ciclo si encontramos el número
            }
        }

        // Si no se encontró el número
        if (!encontrado)
        {
            Console.WriteLine($"El número {busqueda} no se encuentra en el arreglo.");
        }
    }
}