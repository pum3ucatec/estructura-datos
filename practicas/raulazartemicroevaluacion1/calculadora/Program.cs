using System;

class Calculadora
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("      CALCULADORA C#");
            Console.WriteLine("=============================");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Seno");
            Console.WriteLine("6. Coseno");
            Console.WriteLine("7. Tangente");
            Console.WriteLine("8. Potencia");
            Console.WriteLine("9. Raíz cuadrada");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Entrada inválida. Intenta de nuevo.\n");
                continue;
            }

            if (opcion == 0) break;

            double num1 = 0, num2 = 0, resultado = 0;

            // Para operaciones con dos números
            if (opcion >= 1 && opcion <= 4 || opcion == 8)
            {
                Console.Write("Ingresa el primer número: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingresa el segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            // Para operaciones con un solo número
            else if (opcion >= 5 && opcion <= 7 || opcion == 9)
            {
                Console.Write("Ingresa el número: ");
                num1 = Convert.ToDouble(Console.ReadLine());
            }

            switch (opcion)
            {
                case 1: resultado = num1 + num2; break;
                case 2: resultado = num1 - num2; break;
                case 3: resultado = num1 * num2; break;
                case 4:
                    if (num2 != 0) resultado = num1 / num2;
                    else Console.WriteLine("Error: División entre cero.");
                    break;
                case 5: resultado = Math.Sin(num1); break;
                case 6: resultado = Math.Cos(num1); break;
                case 7: resultado = Math.Tan(num1); break;
                case 8: resultado = Math.Pow(num1, num2); break;
                case 9:
                    if (num1 >= 0) resultado = Math.Sqrt(num1);
                    else Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un número negativo.");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

            if (!(opcion == 4 && num2 == 0) && !(opcion == 9 && num1 < 0))
            {
                Console.WriteLine($"Resultado: {resultado}\n");
            }
        }

        Console.WriteLine("¡Gracias por usar la calculadora!");
    }
}