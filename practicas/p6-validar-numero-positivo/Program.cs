using System;

class Program
{
    static void Main()
    {
        int num;
        do
        {
            Console.Write("Ingrese un número positivo: ");
            num = int.Parse(Console.ReadLine());
        } while (num <= 0);

        Console.WriteLine($"Número válido: {num}");
    }
}
