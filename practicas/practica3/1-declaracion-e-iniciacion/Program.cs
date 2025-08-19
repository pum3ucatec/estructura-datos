using System;

class Program
{
    static void Main()
    {
        // Declarar el arreglo de 5 enteros y asignar valores
        int[] numeros = { 10, 20, 30, 40, 50 };

        // Imprimir los valores del arreglo
        Console.WriteLine("Los valores del arreglo son:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"numeros[{i}] = {numeros[i]}");
        }
    }
}