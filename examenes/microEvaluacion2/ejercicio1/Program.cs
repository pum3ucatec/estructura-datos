using System;

class Program
{
    static void Main(string[] args)
    {
        ListaSimple lista = new ListaSimple();
        int[] numeros = { 6, 4, 8, 2, 7 };
        foreach (int n in numeros)
        {
            lista.InsertarEnOrden(n);
        }
        Console.WriteLine("Lista ordenada:");
        lista.Mostrar();
    }
}
