using System;
class Program
{
    public static void Main()
    {
        Console.Write("Ingrese un número N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int suma = 0;
        for (int i = 1; i <= N; i++)
        {
            suma += i;
        }
        Console.WriteLine("La suma de los números del 1 al " + N + " es: " + suma);
    }
}