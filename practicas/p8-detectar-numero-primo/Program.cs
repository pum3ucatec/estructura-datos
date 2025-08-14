using System;

class Programa
{
    static void Main()
    {
        Console.Write("Ingresa un numero entero positivo: ");
        string? entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int numero) || numero <= 1)
        {
            Console.WriteLine("Entrada no valida. Debes ingresar un numero entero mayor a 1.");
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
            return;
        }

        bool esPrimo = true;

        // Verificar divisores
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                esPrimo = false;
                break;
            }
        }

        if (esPrimo)
            Console.WriteLine($"{numero} es un numero primo.");
        else
            Console.WriteLine($"{numero} no es un numero primo.");

        Console.WriteLine("Presiona cualquier tecla para salir.");
        Console.ReadKey();
    }
}
