using System;
class Program {
    static void Main()
    {
        Console.WriteLine("\nEjercicio 9: Primeros 10 números pares");
        int pares = 0;
        int numPar = 2;
        while (pares < 10)
        {
            Console.WriteLine(numPar);
            numPar += 2;
            pares++;
        }
    }
}