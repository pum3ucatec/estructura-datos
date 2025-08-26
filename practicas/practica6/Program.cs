using System;

namespace ColaDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cola<string> cola = new Cola<string>();
            int opcion;

            do
            {
                Console.WriteLine("\n===== MENÚ COLA con NODOS =====");
                Console.WriteLine("1. Mostrar Cola");
                Console.WriteLine("2. Insertar (Enqueue)");
                Console.WriteLine("3. Eliminar (Dequeue)");
                Console.WriteLine("4. Ver frente (Peek)");
                Console.WriteLine("5. Verificar si está vacía");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida, intente de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        cola.Mostrar();
                        break;
                    case 2:
                        Console.Write("Ingrese un valor: ");
                        string valor = Console.ReadLine()!;
                        cola.Encolar(valor);
                        Console.WriteLine($"Se insertó: {valor}");
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine($"Se eliminó: {cola.Desencolar()}");
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 4:
                        try
                        {
                            Console.WriteLine($"Frente: {cola.Peek()}");
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 5:
                        Console.WriteLine(cola.EstaVacia ? "La cola está vacía." : "La cola NO está vacía.");
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            } while (opcion != 0);
        }
    }
}