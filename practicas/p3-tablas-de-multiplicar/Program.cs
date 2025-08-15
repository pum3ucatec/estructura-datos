using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número para la tabla de multiplicar: ");
        int num = int.Parse(Console.ReadLine());

        // Bucle for para la tabla del 1 al 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }

        Console.WriteLine("¡Fin de la tabla!");
        Console.ReadKey(); // Mantiene la consola abierta
    }
}

