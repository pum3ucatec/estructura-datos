using System;

class Program
{
    public static void Main()
    {
        Console.Write("Ingrese un número para ver su tabla de multiplicar: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Tabla de multiplicar del {numero}:");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}