using System;

class Program
{
    public static void Main()
    {
        int suma = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Introduce un número:");
            string entrada = Console.ReadLine() ?? "";
            int numero;
            if (!int.TryParse(entrada, out numero))
            {
                Console.WriteLine("No es un número. Introduce solo números.");
                i--;
                continue;
            }
            suma += numero;
        }
        Console.WriteLine("La suma de los 5 números ingresados es: " + suma);
    }
}