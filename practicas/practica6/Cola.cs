using System;

namespace ColaDinamica
{
    public class Cola<T>
    {
        private Nodo<T>? frente;
        private Nodo<T>? fondo;
        public int Conteo { get; private set; }

        public bool EstaVacia => Conteo == 0;

        public void Encolar(T valor)
        {
            Nodo<T> nuevo = new Nodo<T>(valor);

            if (fondo == null) // si está vacía
            {
                frente = nuevo;
                fondo = nuevo;
            }
            else
            {
                fondo.Siguiente = nuevo;
                fondo = nuevo;
            }
            Conteo++;
        }

        public T Desencolar()
        {
            if (frente == null)
                throw new InvalidOperationException("La cola está vacía");

            T valor = frente.Valor;
            frente = frente.Siguiente;

            if (frente == null) // si quitamos el último
                fondo = null;

            Conteo--;
            return valor;
        }

        public T Peek()
        {
            if (frente == null)
                throw new InvalidOperationException("La cola está vacía");
            return frente.Valor;
        }

        public void Mostrar()
        {
            if (EstaVacia)
            {
                Console.WriteLine("La cola está vacía.");
                return;
            }

            Console.Write("Cola: ");
            Nodo<T>? actual = frente;
            while (actual != null)
            {
                Console.Write(actual.Valor + " ");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }
    }
}