using System;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar dos números");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡Hola!");
                    break;
                case 2:
                    Console.Write("Ingrese el primer número: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine($"La suma es: {a + b}");
                    break;
                case 3:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

        } while (opcion != 3);
    }
}
