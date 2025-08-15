using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;
        double num1, num2, resultado;

        do
        {
            Console.Clear();
            Console.WriteLine("=== Calculadora Científica ===");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Raíz cuadrada");
            Console.WriteLine("6. Potencia");
            Console.WriteLine("7. Valor absoluto");
            Console.WriteLine("8. Seno");
            Console.WriteLine("9. Coseno");
            Console.WriteLine("0. Salir");
            Console.Write("Ingrese una opción: ");

            opcion = int.Parse(Console.ReadLine());

            if (opcion >= 1 && opcion <= 4)
            {
                Console.Write("Ingrese el primer número: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                num2 = double.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    resultado = num1 + num2;
                    Console.WriteLine("Resultado: " + resultado);
                }
                else if (opcion == 2)
                {
                    resultado = num1 - num2;
                    Console.WriteLine("Resultado: " + resultado);
                }
                else if (opcion == 3)
                {
                    resultado = num1 * num2;
                    Console.WriteLine("Resultado: " + resultado);
                }
                else if (opcion == 4)
                {
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("Resultado: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Error: División por cero");
                    }
                }
            }
            else if (opcion == 5)
            {
                Console.Write("Ingrese el número: ");
                num1 = double.Parse(Console.ReadLine());
                resultado = Math.Sqrt(num1);
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (opcion == 6)
            {
                Console.Write("Ingrese la base: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el exponente: ");
                num2 = double.Parse(Console.ReadLine());
                resultado = Math.Pow(num1, num2);
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (opcion == 7)
            {
                Console.Write("Ingrese el número: ");
                num1 = double.Parse(Console.ReadLine());
                resultado = Math.Abs(num1);
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (opcion == 8)
            {
                Console.Write("Ingrese el número: ");
                num1 = double.Parse(Console.ReadLine());
                resultado = Math.Sin(num1);
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (opcion == 9)
            {
                Console.Write("Ingrese el número: ");
                num1 = double.Parse(Console.ReadLine());
                resultado = Math.Cos(num1);
                Console.WriteLine("Resultado: " + resultado);
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 0);

        Console.WriteLine("Gracias por usar la calculadora.");
    }
}
