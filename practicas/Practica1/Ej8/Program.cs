using System;
class Program {
    static void Main()
    {
       Console.WriteLine("\nEjercicio 8: Detectar número primo");
        Console.Write("Ingresa un número: ");
        int primo = int.Parse(Console.ReadLine()!);
        bool esPrimo = true;
        if (primo <= 1) esPrimo = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(primo); i++)
            {
                if (primo % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
        }
        Console.WriteLine(esPrimo ? "Es primo" : "No es primo");
    }
}