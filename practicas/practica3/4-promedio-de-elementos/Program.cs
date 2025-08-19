using System;

class Program
{
    static void Main()
    {
        // Crear un arreglo de 5 calificaciones
        double[] calificaciones = new double[5];
        double suma = 0;

        // Pedir al usuario que ingrese las calificaciones
        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.Write($"Ingresa la calificación #{i + 1}: ");
            calificaciones[i] = Convert.ToDouble(Console.ReadLine());
            suma += calificaciones[i]; // Acumular la suma
        }

        // Calcular el promedio
        double promedio = suma / calificaciones.Length;

        // Mostrar las calificaciones y el promedio
        Console.Write("Las calificaciones son: [");
        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.Write(calificaciones[i]);
            if (i < calificaciones.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");

        Console.WriteLine($"El promedio es: {promedio:F2}");
    }
}