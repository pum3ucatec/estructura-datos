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
}