public class Lista
{
    public Nodo Root;
    public Lista()
    {
        this.Root = null;
    }
    //Insertar al final de la lista doble
    public void Insert(string name)
    {
        Nodo nodo = new Nodo(name);
        if (Root == null)
        {
            Root = nodo;
        }
        else
        {
            Nodo current = Root;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = nodo;
            nodo.Prev = current;    //enlazar el nodo nuevo al anterior
        }
    }
    //Mostrar Lista desde el inicio
    public void ViewForward()
    {
        Nodo current = Root;
        while (current != null)
        {
            Console.Write($"{current.Name} | ");
            current = current.Next;
        }
        Console.WriteLine();
    }
    //Mostrar Lista desde el final
    public void ViewBackward()
    {
        if (Root == null) return;
        Nodo current = Root;
        while (current.Next != null)
        {
            current = current.Next;
        }
        while (current != null)
        {
            Console.Write($"{current.Name} | ");
            current = current.Prev;
        }
        Console.WriteLine();
    }
    //Eliminar nodo
    public void Delete(string name)
    {
        if (Root == null)
        {
            Console.WriteLine("La lista está vacía");
            return;
        }
        Nodo current = Root;
        while (current != null && current.Name != name)
        {
            current = current.Next;
        }
        if (current == null)
        {
            Console.WriteLine("Elemento no encontrado");
            return;
        }
        if (current.Prev == null)
        {
            Root = current.Next;
            if (Root != null)
                Root.Prev = null;
        }
        else
        {
            current.Prev.Next = current.Next;
            if (current.Next != null)
                current.Next.Prev = current.Prev;
        }
        current.Next = null;
        current.Prev = null;
        Console.WriteLine($"Elemento '{name}' eliminado.");
    }

    //Buscar un nodo
    public Nodo Search(string name)
    {
        Nodo current = Root;
        while (current != null)
        {
            if (current.Name == name)
                return current;
            current = current.Next;
        }
        return null;
    }
    //Verificar si la lista esta vacía
    public bool IsEmpty()
    {
        return Root == null;
    }
}