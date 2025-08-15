using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int n = int.Parse(Console.ReadLine());

        bool esPrimo = n > 1; // Los números menores o iguales a 1 no son primos

        // Bucle for para comprobar si n tiene divisores
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                esPrimo = false;
                break; // Si encontramos un divisor, no es primo
            }
        }

        if (esPrimo)
            Console.WriteLine($"{n} es un número primo.");
        else
            Console.WriteLine($"{n} no es un número primo.");

        Console.ReadKey(); // Mantiene la consola abierta
    }
}

