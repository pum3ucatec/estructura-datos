using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número para ver su tabla de multiplicar: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
}
