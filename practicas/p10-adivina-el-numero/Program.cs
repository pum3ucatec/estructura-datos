using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int secreto = rnd.Next(1, 51);
        int intento;
        Console.WriteLine("Adivina el número (entre 1 y 50)");

        do
        {
            Console.Write("Ingresa tu intento: ");
            intento = int.Parse(Console.ReadLine());

            if (intento > secreto)
                Console.WriteLine("Muy alto");
            else if (intento < secreto)
                Console.WriteLine("Muy bajo");
            else
                Console.WriteLine("¡Correcto!");
        }
        while (intento != secreto);
    }
}
