using System;

public class ListaSimple
{
    private Nodo head;

    public ListaSimple()
    {
        head = null;
    }

    public void InsertarAlPrincipio(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        nuevo.Siguiente = head;
        head = nuevo;
        Console.WriteLine($"Se inserto {valor} al principio de la lista.");
    }

    public void InsertarAlFinal(int valor)
    {
        Nodo nuevo = new Nodo(valor);

        if (head == null)
        {
            head = nuevo;
        }
        else
        {
            Nodo actual = head;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
        Console.WriteLine($"Se inserto {valor} al final de la lista.");
    }

    public void EliminarAlPrincipio()
    {
        if (head == null)
        {
            Console.WriteLine("La lista esta vacia.");
            return;
        }
        Console.WriteLine($"Se elimino el elemento {head.Dato} del principio.");
        head = head.Siguiente;
    }

    public void Mostrar()
    {
        if (head == null)
        {
            Console.WriteLine("La lista está vacia.");
            return;
        }

        Nodo actual = head;
        Console.Write("Lista: ");
        while (actual != null)
        {
            Console.Write(actual.Dato + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }
    public void InsertarEnOrden(int valor)
{
    Nodo nuevo = new Nodo(valor);

    if (head == null || valor < head.Dato)
    {
        nuevo.Siguiente = head;
        head = nuevo;
        return;
    }

    Nodo actual = head;
    while (actual.Siguiente != null && actual.Siguiente.Dato < valor)
    {
        actual = actual.Siguiente;
    }

    nuevo.Siguiente = actual.Siguiente;
    actual.Siguiente = nuevo;
}


    public bool EstaVacia()
    {
        return head == null;
    }
}
