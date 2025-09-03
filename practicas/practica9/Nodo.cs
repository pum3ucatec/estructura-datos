public class Nodo
{
    public string Name { get; set; }
    public Nodo Next { get; set; }
//    public Nodo Prev { get; set; }        Para lista simple circular, no necesitas Prev, solo Next

    public Nodo(string name)
    {
        this.Name = name;
        this.Next = null;
//        this.Prev = null;
    }
}