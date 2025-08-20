using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("\nEjercicio 4: Menú con do-while");
        int opcion;
        do
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine()!);

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡Hola!");
                    break;
                case 2:
                    Console.Write("Ingresa primer número: ");
                    int a = int.Parse(Console.ReadLine()!);
                    Console.Write("Ingresa segundo número: ");
                    int b = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"Resultado: {a + b}");
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
