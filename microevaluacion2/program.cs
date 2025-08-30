using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Ejercicio 1: Insertar en orden (menor a mayor)");
        int[] datos1 = { 6, 4, 8, 2, 7 };
        var listaOrden = new ListaSimple();

        foreach (var x in datos1)
            listaOrden.InsertarEnOrden(x);

        Console.WriteLine("Entrada:  6, 4, 8, 2, 7");
        Console.Write("Salida:   ");
        listaOrden.Mostrar();  
        Console.WriteLine();

        Console.WriteLine("Ejercicio 2: Insertar al principio");
        var listaInicio = new ListaSimple();

        listaInicio.InsertarAlPrincipio(7);
        listaInicio.InsertarAlPrincipio(2);
        listaInicio.InsertarAlPrincipio(8);
        listaInicio.InsertarAlPrincipio(4);

        Console.Write("Lista base: ");
        listaInicio.Mostrar();

        Console.WriteLine("Insertamos 6 al principio");
        listaInicio.InsertarAlPrincipio(6);

        Console.Write("Salida:     ");
        listaInicio.Mostrar(); 
    }
}
