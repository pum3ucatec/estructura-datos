public class Lista
{
    public Nodo Root;
    public Lista()
    {
        this.Root = null;
    }
    public void Insert(string name)
    {
        Nodo nodo = new Nodo(name);
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
            Console.Write($"{current.Name} | ");
            current = current.Next;
        }
    }
    public void Delete(string name)
    {
        if (Root == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }
        if (Root.Name == name)
        {
            Root = Root.Next;
            Console.WriteLine($"Elemento '{name}' eliminado.");
            return;
        }
        Nodo current = Root;
        while (current.Next != null && current.Next.Name != name)
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
            Console.WriteLine($"Elemento '{name}' eliminado.");
        }
    }
    //Insertar al principio
    public void InsertAtBeguinnig(string name)
    {
        Nodo nodo = new Nodo(name);
        nodo.Next = Root;
        Root = nodo;
        Console.WriteLine($"Elemento '{name}' se insertó al principio");
    }
}