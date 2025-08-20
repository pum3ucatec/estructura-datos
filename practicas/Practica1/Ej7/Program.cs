using System;
class Program {
    static void Main()
    {
        Console.WriteLine("\nEjercicio 7: Suma de 5 números");
        int suma = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Número {i}: ");
            suma += int.Parse(Console.ReadLine()!);
        }
        Console.WriteLine($"La suma es: {suma}");
    }
}

