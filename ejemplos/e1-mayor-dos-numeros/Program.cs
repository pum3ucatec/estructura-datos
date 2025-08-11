using System;

class Program
{
    public static void Main()
    {
        Console.Write("Primer numero: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Segundo numero: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine($"El mayor es: {numero1}");
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine($"El mayor es: {numero2}");
        }
        else
        {
            Console.WriteLine("Los numero son iguales");
        }
    }
}