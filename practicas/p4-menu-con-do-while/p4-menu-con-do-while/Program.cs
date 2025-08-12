using System;

class Program
{
    public static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("######################");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("######################");
                    Console.WriteLine("Bienvenido al Programa");
                    break;

                case 2:
                    Console.Write("Ingrese el primer número: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La suma es: " + (num1 + num2));
                    break;

                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida, por favor intente de nuevo.");
                    break;
            }
        } while (opcion != 3);
    }
}