using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- Menú ---");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar 2 números");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡Hola! 😄");
                    break;

                case 2:
                    Console.Write("Ingresa el primer número: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Ingresa el segundo número: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine($"La suma es: {a + b}");
                    break;

                case 3:
                    Console.WriteLine("Saliendo del menú...");
                    break;

                default:
                    Console.WriteLine("Opción inválida. Intenta de nuevo.");
                    break;
            }

        } while (opcion != 3);

        Console.WriteLine("Programa finalizado.");
        Console.ReadKey();
    }
}
