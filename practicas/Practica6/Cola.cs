using System;

public class Cola<T>
{
    public Nodo<T>? Front { get; private set; }
    public Nodo<T>? Rear  { get; private set; }

    public Cola()
    {
        Front = null;
        Rear  = null;
    }

    public bool IsEmpty()
    {
        return Front == null;
    }

    public void Enqueue(T data)
    {
        var nodo = new Nodo<T>(data);

        if (Front == null)
        {
            Front = nodo;
            Rear  = nodo;
        }
        else
        {
            Rear!.Next = nodo;
            Rear = nodo;
        }
    }

    public T Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Cola vacía");

        T value = Front!.Data;
        Front = Front.Next;

        if (Front == null)
            Rear = null;

        return value;
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Cola vacía");

        return Front!.Data;
    }

    public void View()
    {
        if (IsEmpty())
        {
            Console.WriteLine("[Cola vacía]");
            return;
        }

        Nodo<T>? current = Front;
        Console.Write("Frente -> ");
        while (current != null)
        {
            Console.Write(current.Data);
            current = current.Next;
            if (current != null) Console.Write(" -> ");
        }
        Console.WriteLine(" -> Fondo");
    }
}

