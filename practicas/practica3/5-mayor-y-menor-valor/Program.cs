using System;

class Program
{
    static void Main()
    {
        // Crear un arreglo de 8 números
        int[] numeros = new int[8];

        // Leer los números del usuario
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingresa el número #{i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Inicializar mayor y menor con el primer elemento
        int mayor = numeros[0];
        int menor = numeros[0];

        // Recorrer el arreglo para encontrar el mayor y el menor
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

        // Mostrar los resultados
        Console.Write("Los números ingresados son: [");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i]);
            if (i < numeros.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("]");

        Console.WriteLine($"El número mayor es: {mayor}");
        Console.WriteLine($"El número menor es: {menor}");
    }
}