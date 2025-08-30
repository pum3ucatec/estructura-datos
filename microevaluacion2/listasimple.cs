using System;

public class ListaSimple
{
    private Nodo? cabeza;

    public void InsertarEnOrden(int valor)
    {
        Nodo nuevo = new Nodo(valor);

        if (cabeza == null || valor < cabeza.Dato) 
        {
            nuevo.Siguiente = cabeza;
            cabeza = nuevo;
            return;
        }

        Nodo actual = cabeza;
        while (actual.Siguiente != null && actual.Siguiente.Dato < valor)
        {
            actual = actual.Siguiente;
        }

        nuevo.Siguiente = actual.Siguiente;
        actual.Siguiente = nuevo;
    }

    public void InsertarAlPrincipio(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        nuevo.Siguiente = cabeza;
        cabeza = nuevo;
    }

    public void Mostrar()
    {
        Nodo? aux = cabeza;
        while (aux != null)
        {
            Console.Write(aux.Dato + " -> ");
            aux = aux.Siguiente;
        }
        Console.WriteLine("nulo");
    }

    public void Limpiar() => cabeza = null;
}
