using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número N: ");
        int N = int.Parse(Console.ReadLine());
        int suma = 0, i = 1;

        while (i <= N)
        {
            suma += i;
            i++;
        }

        Console.WriteLine($"La suma de 1 hasta {N} es: {suma}");
    }
}
