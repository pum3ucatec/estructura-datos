using System;

class Program
{
    static void Main()
    {
        int numero;

        // Bucle do-while para validar número positivo
        do
        {
            Console.Write("Introduce un número positivo: ");
            numero = int.Parse(Console.ReadLine());

            if (numero <= 0)
                Console.WriteLine("Número inválido. Debe ser positivo.");
        } while (numero <= 0);

        Console.WriteLine($"¡Número válido! Ingresaste: {numero}");
        Console.ReadKey(); // Mantiene la consola abierta
    }
}
