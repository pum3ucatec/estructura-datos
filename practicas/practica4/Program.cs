using System;

class Program
{
    static void Main()
    {
        int tamañoMaximo = 5;
        string[] cola = new string[tamañoMaximo];
        int inicio = 0;
        int fin = 0;

        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\n--- Menú de operaciones de Cola ---");
            Console.WriteLine("1. Encolar");
            Console.WriteLine("2. Desencolar");
            Console.WriteLine("3. Ver frente");
            Console.WriteLine("4. Mostrar cola");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    if (fin < tamañoMaximo)
                    {
                        Console.Write("Ingrese el elemento a encolar: ");
                        string elemento = Console.ReadLine();
                        cola[fin] = elemento;
                        fin = fin + 1;
                        Console.WriteLine($"Encolado: {elemento}");
                    }
                    else
                    {
                        Console.WriteLine("Cola llena, no se puede encolar.");
                    }
                    break;
                case "2":
                    if (inicio < fin)
                    {
                        string desencolado = cola[inicio];
                        inicio = inicio + 1;
                        Console.WriteLine($"Desencolado: {desencolado}");
                    }
                    else
                    {
                        Console.WriteLine("Cola vacía, no se puede desencolar.");
                    }
                    break;
                case "3":
                    if (inicio < fin)
                        Console.WriteLine($"Frente de la cola: {cola[inicio]}");
                    else
                        Console.WriteLine("Cola vacía.");
                    break;
                case "4":
                    if (inicio == fin)
                    {
                        Console.WriteLine("Cola vacía.");
                    }
                    else
                    {
                        Console.WriteLine("Elementos en la cola:");
                        for (int i = inicio; i < fin; i++)
                        {
                            Console.WriteLine("- " + cola[i]);
                        }
                    }
                    break;
                case "0":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        Console.WriteLine("\nTodos los clientes han sido atendidos.");
    }
}