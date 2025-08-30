using System;

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

    // Mostrar completo (recursivo)
    public void ViewRecursive()
    {
        ViewRecursive(this.Root);
        Console.WriteLine();
    }

    private void ViewRecursive(Nodo current)
    {
        if (current == null) return;
        Console.Write($"{current.Name} | ");
        ViewRecursive(current.Next);
    }

    // Buscar (recursivo) - bool simple
    public bool Search(string name) => SearchRecursive(this.Root, name);

    private bool SearchRecursive(Nodo current, string name)
    {
        if (current == null) return false;
        if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) return true;
        return SearchRecursive(current.Next, name);
    }

    // Eliminar
    public void Delete(string name) => this.Root = DeleteRecursive(this.Root, name);

    private Nodo DeleteRecursive(Nodo current, string name)
    {
        if (current == null) return null;
        if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            return current.Next;
        current.Next = DeleteRecursive(current.Next, name);
        return current;
    }

    // Mostrar desde un valor =====
    public void ViewFromValue(string name)
    {
        Nodo start = FindNodeRecursive(this.Root, name);
        if (start == null)
        {
            Console.WriteLine($"El valor '{name}' no está en la lista.");
            return;
        }
        ViewRecursive(start);   // reutilizamos el mostrador recursivo
        Console.WriteLine();
    }
    private Nodo FindNodeRecursive(Nodo current, string name)
    {
        if (current == null) return null;
        if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) return current;
        return FindNodeRecursive(current.Next, name);
    }
}
