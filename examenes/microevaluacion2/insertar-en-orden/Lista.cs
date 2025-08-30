public class Lista
{
    public Nodo Root;
    public Lista()
    {
        this.Root = null;
    }
    public void Insert(int value)
    {
        Nodo nodo = new Nodo(value);
        if (this.Root == null)
        {
            this.Root = nodo;
        }
        else
        {
            Nodo current = this.Root;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = nodo;
        }
    }
    public void View()
    {
        Nodo current = this.Root;
        while (current != null)
        {
            Console.Write($"{current.Value} | ");
            current = current.Next;
        }
    }
    public void Delete(int value)
    {
        if (Root == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }
        if (Root.Value == value)
        {
            Root = Root.Next;
            Console.WriteLine($"Elemento '{value}' eliminado.");
            return;
        }
        Nodo current = Root;
        while (current.Next != null && current.Next.Value != value)
        {
            current = current.Next;
        }
        if (current.Next == null)
        {
            Console.WriteLine("Elemento no encontrado.");
        }
        else
        {
            current.Next = current.Next.Next;
            Console.WriteLine($"Elemento '{value}' eliminado.");
        }
    }
    //Insertar al principio
    public void InsertAtBeguinning(int value)
    {
        Nodo nodo = new Nodo(value);
        nodo.Next = Root;
        Root = nodo;
        Console.WriteLine($"Elemento '{value}' se insertó al principio");
    }
    //Insertar en orden
    public void InsertInOrder(int value)
    {
        Nodo nodo = new Nodo(value);
        if (Root == null || value < Root.Value)
        {
            nodo.Next = Root;
            Root = nodo;
            Console.WriteLine($"Elemento {value} insertado en orden.");
            return;
        }
        Nodo current = Root;
        while (current.Next != null && current.Next.Value < value)
        {
            current = current.Next;
        }
        nodo.Next = current.Next;
        current.Next = nodo;
        Console.WriteLine($"Elemento {value} insertado en orden");
    }
}