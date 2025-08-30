using System;

public class Lista
{
    public Nodo Root;

    public Lista()
    {
        this.Root = null;
    }

    // Inserta al final
    public void Insert(string name)
    {
        Nodo nodo = new Nodo(name);

        if (this.Root == null)
        {
            this.Root = nodo;
            return;
        }

        Nodo current = this.Root;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = nodo;
    }

    // Inserta al principio
    public void InsertAtBeginning(string name)
    {
        Nodo nuevo = new Nodo(name);
        nuevo.Next = this.Root;
        this.Root = nuevo;
    }

    public void View()
    {
        if (this.Root == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo current = this.Root;
        while (current != null)
        {
            Console.Write($"{current.Name} | ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    public void Delete(string name)
    {
        if (this.Root == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        if (this.Root.Name == name)
        {
            this.Root = this.Root.Next;
            Console.WriteLine($"Se eliminó: {name}");
            return;
        }

        Nodo current = this.Root;
        while (current.Next != null && current.Next.Name != name)
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
            Console.WriteLine($"Se eliminó: {name}");
        }
        else
        {
            Console.WriteLine("Elemento no encontrado.");
        }
    }

    public bool Search(string name)
    {
        Nodo current = this.Root;
        while (current != null)
        {
            if (current.Name == name) return true;
            current = current.Next;
        }
        return false;
    }

    public bool IsEmpty()
    {
        return this.Root == null;
    }
}
