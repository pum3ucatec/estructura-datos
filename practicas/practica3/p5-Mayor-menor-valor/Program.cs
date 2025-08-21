using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 12, 5, 8, 20, 3, 17, 25, 10 };
        int mayor = numeros[0];
        int menor = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
                mayor = numeros[i];
            if (numeros[i] < menor)
                menor = numeros[i];
        }

        Console.WriteLine($"Números: [{string.Join(", ", numeros)}]");
        Console.WriteLine($"Mayor: {mayor}");
        Console.WriteLine($"Menor: {menor}");
    }
}
