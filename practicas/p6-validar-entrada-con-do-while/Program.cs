using System;

class Program
{
    static void Main()
    {
        int numero;

        do
        {
            Console.Write("Introduce un número positivo: ");
            
            // Convertimos la entrada a int
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero <= 0)
            {
                Console.WriteLine("Error: el número debe ser positivo.");
            }

        } while (numero <= 0);

        Console.WriteLine($"Has introducido: {numero}");
    }
}