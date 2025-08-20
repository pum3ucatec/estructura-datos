using System;

class Program
{
    static void Main()
    {
        // 🔁 3. Tablas de multiplicar
        Console.WriteLine("Ejercicio 3: Tabla de multiplicar");
        Console.Write("Ingresa un número: ");
        int num = int.Parse(Console.ReadLine()!);
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
}