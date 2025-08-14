using System;

class Programa
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("===== MENÚ =====");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar dos números");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");

            string? entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine("Opción inválida. Presiona una tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("holi.");
                    break;

                case 2:
                    Console.Write("Ingresa el primer numero: ");
                    int num1 = int.Parse(Console.ReadLine() ?? "0");

                    Console.Write("Ingresa el segundo numero: ");
                    int num2 = int.Parse(Console.ReadLine() ?? "0");

                    Console.WriteLine($"La suma es: {num1 + num2}");
                    break;

                case 3:
                    Console.WriteLine("Saliendo del programa");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine("\nPresiona una tecla para continuar.");
            Console.ReadKey();

        } while (opcion != 3);
    }
}
