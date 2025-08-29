using System;

class Program
{
    static void Main(string[] args)
    {
        ListaSimple lista = new ListaSimple();
        int[] numeros = { 4, 8, 2, 7 };
        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            lista.InsertarAlPrincipio(numeros[i]);
        }
        lista.InsertarAlPrincipio(6);
        Console.WriteLine("Lista después de insertar al principio:");
        lista.Mostrar();
    }
}
