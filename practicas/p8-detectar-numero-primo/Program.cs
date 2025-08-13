using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número entero mayor que 1: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool esPrimo = true;

        // Un número primo solo es divisible por 1 y por sí mismo
        for (int i = 2; i <= numero / 2; i++)
        {
            if (numero % i == 0)
            {
                esPrimo = false;
                break; // Ya encontramos un divisor, no hace falta seguir
            }
        }

        if (esPrimo && numero > 1)
        {
            Console.WriteLine($"{numero} es primo.");
        }
        else
        {
            Console.WriteLine($"{numero} no es primo.");
        }
    }
}