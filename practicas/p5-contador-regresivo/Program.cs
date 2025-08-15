using System;

class Program
{
    static void Main()
    {
        int i = 10;

        // Bucle while para contar regresivamente del 10 al 1
        while (i >= 1)
        {
            Console.WriteLine(i);
            i--; // Decrementa en 1
        }

        Console.WriteLine("¡Fin de la cuenta regresiva!");
        Console.ReadKey(); // Mantiene la consola abierta
    }
}
