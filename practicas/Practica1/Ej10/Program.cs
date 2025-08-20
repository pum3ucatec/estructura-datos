using System;
class Program {
    static void Main()
    {
        Console.WriteLine("\nEjercicio 10: Adivina el número");
        Random rnd = new Random();
        int secreto = rnd.Next(1, 51); // número entre 1 y 50
        int intento;
        do
        {
            Console.Write("Adivina el número (1-50): ");
            intento = int.Parse(Console.ReadLine()!);

            if (intento > secreto)
                Console.WriteLine("El número es menor");
            else if (intento < secreto)
                Console.WriteLine("El número es mayor");
            else
                Console.WriteLine("¡Correcto!");
        } while (intento != secreto);
    }
}