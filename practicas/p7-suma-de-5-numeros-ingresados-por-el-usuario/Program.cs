using System;

class Program
{
    static void Main()
    {
        int suma = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Ingrese el número {i}: ");
            suma += int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"La suma total es: {suma}");
    }
}
