using System;

class Program
{
    public static void Main()
    {
        Console.Write("Ingrese un número N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(N + " x " + i + " = " + (N * i));
        }
    }
}