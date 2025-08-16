using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("===== CALCULADORA CIENTÍFICA =====");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raíz cuadrada");
            Console.WriteLine("7. Seno");
            Console.WriteLine("8. Coseno");
            Console.WriteLine("9. Tangente");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            double num1 = 0, num2 = 0, resultado = 0;

            if (opcion >= 1 && opcion <= 5)
            {
                Console.Write("Ingrese el primer número: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                num2 = double.Parse(Console.ReadLine());
            }
            else if (opcion == 6 || (opcion >= 7 && opcion <= 9))
            {
                Console.Write("Ingrese el número: ");
                num1 = double.Parse(Console.ReadLine());
            }

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 4:
                    if (num2 == 0)
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    else
                        Console.WriteLine($"Resultado: {num1 / num2}");
                    break;
                case 5:
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case 6:
                    if (num1 < 0)
                        Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un número negativo.");
                    else
                        Console.WriteLine($"Resultado: {Math.Sqrt(num1)}");
                    break;
                case 7:
                    Console.WriteLine($"Resultado: {Math.Sin(num1)}");
                    break;
                case 8:
                    Console.WriteLine($"Resultado: {Math.Cos(num1)}");
                    break;
                case 9:
                    Console.WriteLine($"Resultado: {Math.Tan(num1)}");
                    break;
                case 0:
                    continuar = false;
                    Console.WriteLine("Saliendo de la calculadora...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
