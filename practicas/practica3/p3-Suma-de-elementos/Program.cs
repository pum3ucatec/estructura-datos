using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 5, 10, 15, 20 };
        int suma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }

        Console.WriteLine($"Arreglo: [{string.Join(", ", numeros)}]");
        Console.WriteLine($"Suma: {suma}");
    }
}
