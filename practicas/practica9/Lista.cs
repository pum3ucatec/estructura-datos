public class ListaCircular
{
    public Nodo Root;
    public ListaCircular()
    {
        this.Root = null;
    }
    //Insertar al final de la lista circular
    public void Insert(string name)
    {
        Nodo nodo = new Nodo(name);
        if (Root == null)
        {
            Root = nodo;
            Root.Next = Root;   //se apunta a si mismo
        }
        else
        {
            Nodo current = Root;
            while (current.Next != Root)    //Recorre hasta el ultimo nodo
            {
                current = current.Next;
            }
            current.Next = nodo;
            nodo.Next = Root;    //CERRAR EL CIRCULO
        }
    }
    //Mostrar Lista circular
    public void View()
    {
        if (Root == null)
        {
            Console.WriteLine("La lista esta vacía.");
            return;
        }
        Nodo current = Root;
        do
        {
            Console.Write($"{current.Name} | ");
            current = current.Next;
        }
        while (current != Root);    //detiene cuando vuelve al inicio
        Console.WriteLine();
    }

    //Eliminar un nodo
    public void Delete(string name)
    {
        if (Root == null)
        {
            Console.WriteLine("La lista esta vacía.");
            return;
        }
        Nodo current = Root;
        Nodo previous = null;
        do
        {
            if (current.Name == name)
            {
                if (previous != null)   //Nodo intermedio o final
                {
                    previous.Next = current.Next;
                    if (current == Root)    //Si eliminamos la Raíz
                        Root = current.Next;
                }
                else    //El primer nodo
                {
                    if (current.Next == Root)   //Solo hay un nodo
                    {
                        Root = null;
                    }
                    else
                    {
                        //Buscar el último para reconectar
                        Nodo last = Root;
                        while (last.Next != Root)
                        {
                            last = last.Next;
                        }
                        Root = current.Next;
                        last.Next = Root;
                    }
                }
                Console.WriteLine($"Elemento '{name}' eliminado.");
                return;
            }
            previous = current;
            current = current.Next;
        }
        while (current != Root);
        Console.WriteLine("Elmento no encontrado.");
    }

    //Buscar un nodo
    public Nodo Search(string name)
    {
        if (Root == null) return null;
        Nodo current = Root;
        do
        {
            if (current.Name == name)
                return current;
            current = current.Next;
        }
        while (current != Root);

        return null;
    }
    //Verificar si la lista esta vacía
    public bool IsEmpty()
    {
        return Root == null;
    }
}