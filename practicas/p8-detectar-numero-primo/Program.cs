using System;

class Program
{
    public static void Main()
    {   
            Console.WriteLine("Introduce un número:");
            string entrada = Console.ReadLine() ?? "";
            int numero;
        if (!int.TryParse(entrada, out numero))
        {
            
            Console.WriteLine("Debes ingresar un número");
        }
        else
        {
            if (numero == 1 || numero == 0 || numero < 0)
            {
                Console.WriteLine($"{numero} no es primo.");
            }
            else
            {
                bool esPrimo = true;
                for (int j = 2; j <= Math.Sqrt(numero); j++)
                {
                    if (numero % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                { Console.WriteLine($"{numero} es primo."); }
                else
                {
                    Console.WriteLine($"{numero} no es primo.");
                }
            }
        }
    }
}
