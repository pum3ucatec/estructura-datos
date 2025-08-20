using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] arreglo = new int[5];
        arreglo = new int[] { 2, 4, 6, 8, 10 };
        int suma = 0;
        for (int i = 0; i < arreglo.Length; i++)
        {
            suma += arreglo[i];
        }
        Console.WriteLine("La suma es: " + suma);
    }
}