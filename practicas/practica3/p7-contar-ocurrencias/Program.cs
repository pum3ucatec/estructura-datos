using System;

class Program
{
    static void Main()
    {
        int[] arreglo = { 3, 5, 7, 3, 2, 3, 8, 5, 3 };

        Console.Write("Ingrese el número a buscar: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int contador = 0;
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == numero)
            {
                contador++;
            }
        }
        if (contador == 0)
        {
            Console.WriteLine($"El número {numero} no se encuentra en el arreglo.");
            return;
        }
        Console.WriteLine($"El número {numero} aparece {contador} veces en el arreglo.");
    }
}