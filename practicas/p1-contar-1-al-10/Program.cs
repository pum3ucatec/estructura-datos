using System;

class Program
{
    public static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar dos números");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");
            
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡Hola! ¿Cómo estás?");
                    break;
                case 2:
                    Console.Write("Ingresa el primer número: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingresa el segundo número: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"La suma es: {num1 + num2}");
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida, intenta de nuevo.");
                    break;
            }

            Console.WriteLine(); // Línea en blanco para mejor lectura

        } while (opcion != 3);
    }
}
