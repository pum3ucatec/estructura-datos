using System;

class Program
{
    static void Main()
    {
        int contador = 0; // Cuántos pares llevamos
        int numero = 2;   // Primer par

        while (contador < 10)
        {
            Console.WriteLine(numero);
            numero += 2;   // Siguiente par
            contador++;    // Contamos un par más
        }
    }
}