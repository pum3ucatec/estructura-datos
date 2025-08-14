using System;

class Programa
{
    static void Main()
    {
        int numero;

        
        do
        {
            Console.Write("Ingresa un número positivo: ");
            string? entrada = Console.ReadLine();

            
            if (!int.TryParse(entrada, out numero))
            {
                Console.WriteLine("Entrada no valida. Debes ingresar un numero entero.");
                numero = -1; 
            }
            else if (numero <= 0)
            {
                Console.WriteLine("El numero debe ser positivo.");
            }

        } while (numero <= 0);

        Console.WriteLine($"Numero ingresado correctamente: {numero}");
        Console.WriteLine("Presiona cualquier tecla para salir.");
        Console.ReadKey();
    }
}
