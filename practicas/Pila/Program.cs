  
using System;

namespace PracticaPila
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila();
            int opcion;

            do
            {
                Console.WriteLine("\n=== MENÚ PILA ===");
                Console.WriteLine("1. Mostrar pila");
                Console.WriteLine("2. Push (apilar)");
                Console.WriteLine("3. Pop (desapilar)");
                Console.WriteLine("4. Peek (ver cima)");
                Console.WriteLine("5. Contar elementos");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");

                // Validar entrada
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción no válida.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        pila.Mostrar();
                        break;
                    case 2:
                        Console.Write("Ingresa un número para apilar: ");
                        if (int.TryParse(Console.ReadLine(), out int valor))
                        {
                            pila.Push(valor);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;
                    case 3:
                        pila.Pop();
                        break;
                    case 4:
                        pila.Peek();
                        break;
                    case 5:
                        pila.Contar();
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
}