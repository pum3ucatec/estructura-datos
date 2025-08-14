using System;

class Programa
{
    static void Main()
    {
        int contador = 0; 
        int numero = 2;   

        while (contador < 10)
        {
            Console.WriteLine(numero);
            numero += 2;
            contador++;
        }

        Console.WriteLine("Presiona cualquier tecla para salir.");
        Console.ReadKey();
    }
}
