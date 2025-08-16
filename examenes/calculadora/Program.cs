using System;

class Program
{
    static void Main()
    {
        double num1, num2, resultado = 0;
        int opcion;

        do
        {
            Console.WriteLine("===== CALCULADORA CIENTIFICA =====");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raíz cuadrada");
            Console.WriteLine("7. Logaritmo natural");
            Console.WriteLine("8. Seno");
            Console.WriteLine("9. Coseno");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 0) break;

            if (opcion >= 1 && opcion <= 5) 
            {
                Console.Write("Ingresa el primer numero: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa el segundo numero: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            else 
            {
                Console.Write("Ingresa un numero: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                num2 = 0;
            }

            switch (opcion)
            {
                case 1: resultado = num1 + num2; break;
                case 2: resultado = num1 - num2; break;
                case 3: resultado = num1 * num2; break;
                case 4:
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                        Console.WriteLine(" No se puede dividir entre cero.");
                    break;
                case 5: resultado = Math.Pow(num1, num2); break;
                case 6: resultado = Math.Sqrt(num1); break;
                case 7: resultado = Math.Log(num1); break;
                case 8: resultado = Math.Sin(num1); break;
                case 9: resultado = Math.Cos(num1); break;
                default: Console.WriteLine("Opción invalida"); break;
            }

            if (opcion != 4 || num2 != 0) 
                Console.WriteLine($" Resultado: {resultado}\n");

        } while (opcion != 0);

        Console.WriteLine(" Saliendo de la calculadora.");
    }
}
