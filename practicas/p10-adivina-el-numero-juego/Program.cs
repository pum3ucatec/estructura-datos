using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int numeroSecreto = rnd.Next(1, 51); // Número aleatorio del 1 al 50
        int intento;

        Console.WriteLine("¡Bienvenido al juego 'Adivina el número'!");
        Console.WriteLine("Tienes que adivinar un número entre 1 y 50.");

        // Bucle do-while hasta que el usuario acierte
        do
        {
            Console.Write("Ingresa tu intento: ");
            intento = int.Parse(Console.ReadLine());

            if (intento < numeroSecreto)
                Console.WriteLine("Es mayor.");
            else if (intento > numeroSecreto)
                Console.WriteLine("Es menor.");
            else
                Console.WriteLine("¡Correcto! 🎉");

        } while (intento != numeroSecreto);

        Console.WriteLine("Fin del juego. Gracias por jugar.");
        Console.ReadKey(); // Mantiene la consola abierta
    }
}
