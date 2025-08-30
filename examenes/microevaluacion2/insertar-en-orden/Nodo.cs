public class Nodo
{
    public int Value { get; set; }
    public Nodo Next { get; set; }

    public Nodo(int value)
    {
        this.Value = value;
        this.Next = null;
    }
}