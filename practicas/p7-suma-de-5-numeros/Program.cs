using System;

class Programa
{
    static void Main()
    {
        int suma = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Ingresa el numero {i}: ");
            string? entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out int numero))
            {
                Console.WriteLine("Entrada invalida. Se tomara como 0.");
                numero = 0;
            }

            suma += numero;
        }

        Console.WriteLine($"\nLa suma de los 5 números es: {suma}");
        Console.WriteLine("Presiona cualquier tecla para salir.");
        Console.ReadKey();
    }
}
