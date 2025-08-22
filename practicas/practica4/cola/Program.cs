using System;
using System.Collections.Generic;

namespace PracticaCola
{
    // Clase Cola con operaciones
    class Cola
    {
        private Queue<int> elementos;

        public Cola()
        {
            elementos = new Queue<int>();
        }

        // Insertar (Enqueue)
        public void Enqueue(int valor)
        {
            elementos.Enqueue(valor);
            Console.WriteLine($"Se agregó {valor} a la cola.");
        }

        // Eliminar (Dequeue)
        public void Dequeue()
        {
            if (elementos.Count > 0)
            {
                int eliminado = elementos.Dequeue();
                Console.WriteLine($"Se eliminó {eliminado} de la cola.");
            }
            else
            {
                Console.WriteLine("La cola está vacía, no se puede eliminar.");
            }
        }

        // Ver el primer elemento
        public void Peek()
        {
            if (elementos.Count > 0)
            {
                Console.WriteLine($"El primer elemento en la cola es: {elementos.Peek()}");
            }
            else
            {
                Console.WriteLine("La cola está vacía.");
            }
        }

        // Mostrar todos los elementos
        public void Mostrar()
        {
            if (elementos.Count > 0)
            {
                Console.WriteLine("Elementos en la cola:");
                foreach (int num in elementos)
                {
                    Console.WriteLine(num);
                }
            }
            else
            {
                Console.WriteLine("La cola está vacía.");
            }
        }

        // Cantidad de elementos
        public void Contar()
        {
            Console.WriteLine($"La cola contiene {elementos.Count} elementos.");
        }
    }

    // Clase principal con menú
    class Program
    {
        static void Main(string[] args)
        {
            Cola cola = new Cola();
            int opcion;

            do
            {
                Console.WriteLine("\n=== MENÚ COLA ===");
                Console.WriteLine("1. Mostrar cola");
                Console.WriteLine("2. Enqueue (encolar)");
                Console.WriteLine("3. Dequeue (desencolar)");
                Console.WriteLine("4. Peek (ver primero)");
                Console.WriteLine("5. Contar elementos");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción no válida.");
                    continue;
                }

                switch (opcion)
                {
                    case 1: cola.Mostrar(); break;
                    case 2:
                        Console.Write("Ingresa un número: ");
                        if (int.TryParse(Console.ReadLine(), out int valor))
                            cola.Enqueue(valor);
                        else
                            Console.WriteLine("Entrada inválida.");
                        break;
                    case 3: cola.Dequeue(); break;
                    case 4: cola.Peek(); break;
                    case 5: cola.Contar(); break;
                    case 0: Console.WriteLine("Saliendo..."); break;
                    default: Console.WriteLine("Opción inválida."); break;
                }

            } while (opcion != 0);
        }
    }
}