using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Ingrese 8 números enteros:");
        int[] numeros = new int[8];
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingrese el numero: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }
        int mayor = numeros[0];
        int menor = numeros[0];
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
            }
            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }
        Console.WriteLine($"Número mayor: {mayor}");
        Console.WriteLine($"Número menor: {menor}");
    }
}