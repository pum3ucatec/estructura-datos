using System;

class Programa
{
    static void Main()
    {
        int numero = 10;

        while (numero >= 1)
        {
            Console.WriteLine(numero);
            numero--;
        }

        Console.WriteLine("Cuenta regresiva finalizada");
        Console.WriteLine("Presiona cualquier tecla para salir.");
        Console.ReadKey();
    }
}
