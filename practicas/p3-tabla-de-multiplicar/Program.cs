using System;

class Programa
{
    static void Main()
    {
        Console.Write("Ingresa un numero para mostrar su tabla de multiplicar: ");
        string? entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int numero))
        {
            Console.WriteLine("Entrada no valida. Debes ingresar un número entero.");
            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey();
            return;
        }

        Console.WriteLine($"\nTabla de multiplicar del {numero}:\n");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir.");
        Console.ReadKey();
    }
}
