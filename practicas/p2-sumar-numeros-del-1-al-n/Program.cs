using System;

class Programa
{
    static void Main()
    {
        Console.Write("Ingresa un número N (>= 1): ");
        string? entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int N) || N < 1)
        {
            Console.WriteLine("Entrada no valida. N debe ser un entero mayor o igual a 1.");
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
            return;
        }

        int i = 1;
        long suma = 0;

        while (i <= N)
        {
            suma += i;
            i++;
        }

        Console.WriteLine($"La suma de 1 hasta {N} es: {suma}");
        Console.WriteLine("Presiona cualquier tecla para salir.");
        Console.ReadKey();
    }
}
