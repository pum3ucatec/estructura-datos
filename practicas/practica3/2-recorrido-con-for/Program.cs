using System;

class Program
{
    static void Main()
    {
        // Crear un arreglo de 10 números enteros y asignar valores manualmente
        int[] numeros = { 5, 12, 7, 9, 20, 3, 15, 8, 11, 6 };

        // Usamos un ciclo for para recorrer todo el arreglo
        // Length nos da el tamaño total del arreglo
        Console.WriteLine("Los números en el arreglo son:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"numeros[{i}] = {numeros[i]}");
        }
    }
}