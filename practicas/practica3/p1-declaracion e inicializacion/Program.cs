using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] arreglo = new int[5];

        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.WriteLine("Ingrese un número entero:");
            arreglo[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Los datos del arreglo son:");
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.WriteLine(arreglo[i]);
        }
    }
}