using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        Console.Write("Ingrese un número: ");
        int numeroBuscado = Convert.ToInt32(Console.ReadLine());

        bool encontrado = false;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == numeroBuscado)
            {
                Console.WriteLine($"El número {numeroBuscado} se encuentra en la posición {i}");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("El número no se encuentra en el arreglo.");
        }
    }
}
