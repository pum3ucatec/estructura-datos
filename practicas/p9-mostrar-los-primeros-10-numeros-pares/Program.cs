using System;

class Program
{
    public static void Main()
    {
        int numero = 2;
        while (true)
        {
            int limite = 20;

            if (numero > limite)
            {
                break;
            }
            Console.WriteLine(numero);
            numero += 2;
        }
    }
}