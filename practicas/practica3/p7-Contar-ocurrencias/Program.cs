using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 2, 5, 2, 8, 2, 9 };
        Console.Write("Número buscado: ");
        int numeroBuscado = Convert.ToInt32(Console.ReadLine());

        int contador = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == numeroBuscado)
            {
                contador++;
            }
        }

        Console.WriteLine($"El número {numeroBuscado} aparece {contador} veces.");
    }
}
