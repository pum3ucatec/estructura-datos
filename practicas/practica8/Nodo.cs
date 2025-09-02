public class Nodo
{
    public string Name { get; set; }
    public Nodo Next { get; set; }
    public Nodo Prev { get; set; }

    public Nodo(string name)
    {
        this.Name = name;
        this.Next = null;
        this.Prev = null;
    }
}