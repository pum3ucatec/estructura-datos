using System;

public class Cola
{
    public Nodo? Front { get; private set; }
    public Nodo? Rear  { get; private set; }

    private int count = 0;  

    public Cola()
    {
        Front = null;
        Rear  = null;
    }


    public int Count()
    {
        return count;
    }


    public void Enqueue(string name)
    {
        var nodo = new Nodo(name);

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

        count++;
    }


    public string? Dequeue()
    {
        if (Front == null)
            return null;

        string valor = Front.Name;
        Front = Front.Next;

        if (Front == null)           
            Rear = null;

        count--;
        return valor;
    }


    public string? Peek()
    {
        if (Front == null)
            return null;

        return Front.Name;
    }


    public bool IsEmpty()
    {
        return Front == null;
    }


    public string? RemoveAt(int index)
    {
        if (index < 0 || index >= count || Front == null)
            return null;

  
        if (index == 0)
            return Dequeue();


        Nodo anterior = Front;
        for (int i = 0; i < index - 1; i++)
            anterior = anterior.Next!;

        Nodo objetivo = anterior.Next!;          
        anterior.Next = objetivo.Next;        

        if (objetivo == Rear)                   
            Rear = anterior;

        count--;
        return objetivo.Name;
    }

    public void View()
    {
        if (Front == null)
        {
            Console.WriteLine("[cola vacía]");
            return;
        }

        Console.Write("Frente -> ");
        Nodo? current = Front;
        int i = 0;
        while (current != null)
        {
            Console.Write($"({i})[{current.Name}] ");
            current = current.Next;
            i++;
        }
        Console.WriteLine("<- Fondo");
    }
}
