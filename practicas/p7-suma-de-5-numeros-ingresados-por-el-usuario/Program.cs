using System;

class Program
{
    static void Main()
    {
        int suma = 0;

        // Bucle for para pedir 5 números y sumarlos
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Ingresa el número {i}: ");
            int numero = int.Parse(Console.ReadLine());
            suma += numero; // suma = suma + numero
        }

        Console.WriteLine($"La suma de los 5 números es: {suma}");
        Console.ReadKey(); // Mantiene la consola abierta
    }
}

