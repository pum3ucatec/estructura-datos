using System;

class Programa
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 51); 
        int intento;
        int contadorIntentos = 0;

        Console.WriteLine("Bienvenido al juego de Adivina el Numero");
        Console.WriteLine("He pensado un número entre 1 y 50. ¿a que no adivinas cual es?\n");

        do
        {
            Console.Write("Ingresa tu intento: ");
            string? entrada = Console.ReadLine();
            contadorIntentos++;

            if (!int.TryParse(entrada, out intento))
            {
                Console.WriteLine("Entrada invalida. Debes ingresar un número entero.");
                continue;
            }

            if (intento < numeroSecreto)
            {
                Console.WriteLine("El numero secreto es mayor.");
            }
            else if (intento > numeroSecreto)
            {
                Console.WriteLine("El numero secreto es menor.");
            }
            else
            {
                Console.WriteLine($"\nAdivinaste el numero {numeroSecreto} en {contadorIntentos} intentos.");
            }

        } while (intento != numeroSecreto);

        Console.WriteLine("Presiona cualquier tecla para salir.");
        Console.ReadKey();
    }
}
