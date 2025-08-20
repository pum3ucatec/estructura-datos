using System;
class Program
{
    public static void Main(string[] args)
    {
        int[] numeros = new int[] { 24, 2, 17, 5, 10, 3, 8, 1, 12, 9 };
        Console.WriteLine("Ingrese el número a buscar:");
        int numeroBuscado = Convert.ToInt32(Console.ReadLine());
        bool encontrado = false;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == numeroBuscado)
            {
                encontrado = true;
                Console.WriteLine($"El número {numeroBuscado} se encuentra en la posición {i}.");
                break;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine($"El número no se encuentra en el arreglo.");
        }
 
    }
}