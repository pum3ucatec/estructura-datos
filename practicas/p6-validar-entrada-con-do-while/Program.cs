using System;

class Program
{
    public static void Main()
    {
        int numero;
        do
        {
            Console.Write("Introduce un número positivo: ");
            string entrada = Console.ReadLine() ?? "";
            if (int.TryParse(entrada, out numero))
            {
                Console.WriteLine(entrada + " es un número positivo");
                break;
            }
            Console.WriteLine("No es un número. Por favor, inténtalo de nuevo.");
        } while (true);
    }
}