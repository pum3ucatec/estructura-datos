//Cola con Arreglo
using System;
namespace ColaFIFO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --- Cola con Arreglos --- ");
            ColaArreglo<string> cola = new ColaArreglo<string>(5);
            foreach (string nombre in args)
            {
                cola.Encolar(nombre);
                Console.WriteLine($"Encolado: {nombre} (Conteo: {cola.Conteo})");
            }
            if (cola.EstaVacia)
            {
                Console.WriteLine("La cola está vacía.");
            }
            else
            {
                Console.WriteLine($"Frente de la cola: {cola.Frente()}");
            }
            while (!cola.EstaVacia)
            {
                Console.WriteLine($"Atendiendo: {cola.Desencolar()} (Quedan {cola.Conteo})");
            }
            Console.WriteLine("Cola vacía");
        }
    }
}