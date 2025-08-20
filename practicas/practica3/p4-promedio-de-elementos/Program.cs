using System;

class Program

{
    public static void Main(string[] args)
    {
        int[] notas = new int[5];
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Ingrese la nota {i + 1}: ");
            notas[i] = Convert.ToInt32(Console.ReadLine());
        }
        int promedio = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            promedio += notas[i];
        }
        promedio /= notas.Length;
        Console.WriteLine("Notas: " + "[" + string.Join(", ", notas) + "]");
        Console.WriteLine($"Promedio: {promedio}");
    }
}