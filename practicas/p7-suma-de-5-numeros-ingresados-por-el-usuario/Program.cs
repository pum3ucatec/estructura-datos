using System;

class Program
{
    static void Main()
    {
        int suma = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Introduce el número {i}: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            suma += numero;
        }

        Console.WriteLine($"La suma de los 5 números es: {suma}");
    }
}