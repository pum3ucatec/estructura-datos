using System;

class Program
{
    static void Main()
    {
        int contador = 0; // Contador de números pares mostrados
        int numero = 2;   // Primer número par

        // Bucle while para mostrar los primeros 10 números pares
        while (contador < 10)
        {
            Console.WriteLine(numero);
            numero += 2; // Pasamos al siguiente número par
            contador++;  // Incrementamos el contador
        }

        Console.WriteLine("¡Fin de los primeros 10 números pares!");
        Console.ReadKey(); // Mantiene la consola abierta
    }
}
