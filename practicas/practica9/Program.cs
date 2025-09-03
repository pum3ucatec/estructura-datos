using System;

class Program
{
    static void Main(string[] args)
    {
        CircularList list = new CircularList();

        list.Insert(10);
        list.Insert(20);
        list.Insert(30);
        list.Insert(40);

        Console.WriteLine("Lista circular insertada:");
        list.Show();

        list.Delete(20);
        Console.WriteLine("Lista circular después de eliminar 20:");
        list.Show();

        list.Delete(10);
        Console.WriteLine("Lista circular después de eliminar 10:");
        list.Show();

        list.Delete(30);
        list.Delete(40);
        Console.WriteLine("Lista circular después de eliminar todos los elementos:");
        list.Show();
    }
}
