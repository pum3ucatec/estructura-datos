using System;

class Principal
{
    static void Main(string[] args)
    {
        // OJO: como la cola ahora es genérica, debes indicar el tipo
        Cola<string> cola = new Cola<string>();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ COLA DINÁMICA =====");
            Console.WriteLine("1. Mostrar Cola");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opcion: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    cola.View();
                    break;

                case 2:
                    Console.Write("Ingrese el valor a insertar: ");
                    string? valor = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(valor))
                        cola.Enqueue(valor);
                    else
                        Console.WriteLine("Valor inválido.");
                    break;

                case 3:
                    if (!cola.IsEmpty())
                        Console.WriteLine($"Eliminado: {cola.Dequeue()}");
                    else
                        Console.WriteLine("La cola está vacía.");
                    break;

                case 4:
                    if (!cola.IsEmpty())
                        Console.WriteLine($"Frente: {cola.Peek()}");
                    else
                        Console.WriteLine("La cola está vacía.");
                    break;

                case 5:
                    Console.WriteLine(cola.IsEmpty() ? "Vacía" : "Con elementos");
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 0);
    }
}
