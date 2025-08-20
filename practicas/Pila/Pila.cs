using System;
using System.Collections.Generic;

namespace PracticaPila
{
    // Clase Pila con operaciones básicas
    class Pila
    {
        private Stack<int> elementos;

        public Pila()
        {
            elementos = new Stack<int>();
        }

        // Insertar un elemento
        public void Push(int valor)
        {
            elementos.Push(valor);
            Console.WriteLine($"Se agregó {valor} a la pila.");
        }

        // Eliminar un elemento
        public void Pop()
        {
            if (elementos.Count > 0)
            {
                int eliminado = elementos.Pop();
                Console.WriteLine($"Se eliminó {eliminado} de la pila.");
            }
            else
            {
                Console.WriteLine("La pila está vacía, no se puede eliminar.");
            }
        }

        // Ver el elemento superior
        public void Peek()
        {
            if (elementos.Count > 0)
            {
                Console.WriteLine($"El elemento en la cima es: {elementos.Peek()}");
            }
            else
            {
                Console.WriteLine("La pila está vacía.");
            }
        }

        // Mostrar todos los elementos
        public void Mostrar()
        {
            if (elementos.Count > 0)
            {
                Console.WriteLine("Elementos en la pila:");
                foreach (int num in elementos)
                {
                    Console.WriteLine(num);
                }
            }
            else
            {
                Console.WriteLine("La pila está vacía.");
            }
        }

        // Ver cantidad de elementos
        public void Contar()
        {
            Console.WriteLine($"La pila contiene {elementos.Count} elementos.");
        }
    }
}