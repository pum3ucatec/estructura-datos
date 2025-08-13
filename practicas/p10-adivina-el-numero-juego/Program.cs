using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 51); // Genera entre 1 y 50
        int intento;

        Console.WriteLine("¡Adivina el número entre 1 y 50!");

        do
        {
            Console.Write("Tu intento: ");
            intento = Convert.ToInt32(Console.ReadLine());

            if (intento < numeroSecreto)
            {
                Console.WriteLine("El número secreto es MAYOR.");
            }
            else if (intento > numeroSecreto)
            {
                Console.WriteLine("El número secreto es MENOR.");
            }
            else
            {
                Console.WriteLine("¡Correcto! Has adivinado el número.");
            }

        } while (intento != numeroSecreto);
    }
}