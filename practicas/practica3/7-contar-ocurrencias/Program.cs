using System;

class Program
{
    static void Main()
    {
        // Crear un arreglo de 10 números enteros
        int[] numeros = new int[10];

        // Llenar el arreglo con números ingresados por el usuario
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingresa el número #{i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Pedir el número a buscar
        Console.Write("Ingresa el número a buscar: ");
        int busqueda = Convert.ToInt32(Console.ReadLine());

        // Contador de apariciones
        int contador = 0;

        // Recorrer el arreglo y contar cuántas veces aparece el número
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == busqueda)
            {
                contador++;
            }
        }

        // Mostrar el resultado
        if (contador > 0)
        {
            Console.WriteLine($"El número {busqueda} aparece {contador} vez(es) en el arreglo.");
        }
        else
        {
            Console.WriteLine($"El número {busqueda} no se encuentra en el arreglo.");
        }
    }
}