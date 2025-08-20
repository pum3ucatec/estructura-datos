using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] arreglo = new int[10];
        arreglo[0] = 5;
        arreglo[1] = 10;
        arreglo[2] = 15;
        arreglo[3] = 20;
        arreglo[4] = 25;
        arreglo[5] = 30;
        arreglo[6] = 35;
        arreglo[7] = 40;
        arreglo[8] = 45;
        arreglo[9] = 50;

        Console.WriteLine("Los datos del arreglo son:");
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.WriteLine(arreglo[i]);
        }
    }
}