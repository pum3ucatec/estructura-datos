using System;

class Program
{
    public static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 51);
        int intentos = 0;

        Console.WriteLine("¡Bienvenido al juego de adivinar el número!");
        Console.WriteLine("Adivina un número entre 1 y 50");

        do
        {
            string entrada = Console.ReadLine() ?? "";
            int numero;
            if (!int.TryParse(entrada, out numero))
            {
                Console.WriteLine("Por favor, ingresa solo números.");
                continue;
            }

            intentos++;

            if (numero == numeroSecreto)
            {
                Console.WriteLine($"Adivinaste el número secreto era {numeroSecreto} y lo lograste en {intentos} intentos");
                break;
            }
            else if (numero < numeroSecreto)
            {
                Console.WriteLine("El número es mayor. Intenta de nuevo");
            }
            else
            {
                Console.WriteLine("El número es menor. Intenta de nuevo");
            }
        } while (true);
    }
}