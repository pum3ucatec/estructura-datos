public class Nodo
{
    public string Name { get; set; }
    public Nodo? Next { get; set; }

    public Nodo(string name)
    {
        Name = name;
        Next = null;
    }
}
