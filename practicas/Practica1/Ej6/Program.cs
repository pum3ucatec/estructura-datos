using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("\nEjercicio 6");
        int positivo;
        do
        {
            Console.Write("Ingresa un número positivo: ");
            positivo = int.Parse(Console.ReadLine()!);
        } while (positivo <= 0);
        Console.WriteLine($"Ingresaste el número positivo: {positivo}");
    }
}