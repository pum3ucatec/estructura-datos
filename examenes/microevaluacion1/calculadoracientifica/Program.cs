using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Usar punto como separador decimal de forma consistente
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== CALCULADORA CIENTÍFICA ===");
            Console.WriteLine("Solo se permiten números. Use punto como separador decimal.");
            Console.WriteLine();
            Console.WriteLine("1) Suma (a + b)");
            Console.WriteLine("2) Resta (a - b)");
            Console.WriteLine("3) Multiplicación (a * b)");
            Console.WriteLine("4) División (a / b)");
            Console.WriteLine("5) Raíz cuadrada (√x)");
            Console.WriteLine("6) Potencia (x^y)");
            Console.WriteLine("7) Logaritmo natural (ln x)");
            Console.WriteLine("8) Seno (sin x) [radianes]");
            Console.WriteLine("9) Coseno (cos x) [radianes]");
            Console.WriteLine("0) Salir");
            Console.WriteLine();

            int opcion = LeerOpcion("Elige una opción: ", 0, 9);

            if (opcion == 0)
            {
                Console.WriteLine("Saliendo... ¡Hasta luego!");
                return;
            }

            try
            {
                switch (opcion)
                {
                    case 1: // Suma
                    {
                        double a = LeerNumero("a = ");
                        double b = LeerNumero("b = ");
                        Console.WriteLine($"Resultado: {a} + {b} = {a + b}");
                        break;
                    }
                    case 2: // Resta
                    {
                        double a = LeerNumero("a = ");
                        double b = LeerNumero("b = ");
                        Console.WriteLine($"Resultado: {a} - {b} = {a - b}");
                        break;
                    }
                    case 3: // Multiplicación
                    {
                        double a = LeerNumero("a = ");
                        double b = LeerNumero("b = ");
                        Console.WriteLine($"Resultado: {a} * {b} = {a * b}");
                        break;
                    }
                    case 4: // División
                    {
                        double a = LeerNumero("a = ");
                        double b = LeerNumeroNoCero("b (≠ 0) = ");
                        Console.WriteLine($"Resultado: {a} / {b} = {a / b}");
                        break;
                    }
                    case 5: // Raíz cuadrada
                    {
                        double x = LeerNumeroNoNegativo("x (≥ 0) = ");
                        Console.WriteLine($"Resultado: √{x} = {Math.Sqrt(x)}");
                        break;
                    }
                    case 6: // Potencia
                    {
                        double x = LeerNumero("Base (x) = ");
                        double y = LeerNumero("Exponente (y) = ");
                        Console.WriteLine($"Resultado: {x}^{y} = {Math.Pow(x, y)}");
                        break;
                    }
                    case 7: // Logaritmo natural
                    {
                        double x = LeerNumeroPositivo("x (> 0) = ");
                        Console.WriteLine($"Resultado: ln({x}) = {Math.Log(x)}");
                        break;
                    }
                    case 8: // Seno
                    {
                        double x = LeerNumero("x (radianes) = ");
                        Console.WriteLine($"Resultado: sin({x}) = {Math.Sin(x)}");
                        break;
                    }
                    case 9: // Coseno
                    {
                        double x = LeerNumero("x (radianes) = ");
                        Console.WriteLine($"Resultado: cos({x}) = {Math.Cos(x)}");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine();
            Console.Write("Presiona cualquier tecla para continuar...");
            Console.ReadKey(true);
        }
    }

    // Lee una opción de menú entre min y max (inclusive), solo números enteros
    static int LeerOpcion(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (int.TryParse(input, NumberStyles.Integer, CultureInfo.InvariantCulture, out int op)
                && op >= min && op <= max)
                return op;

            Console.WriteLine($"Entrada inválida. Debe ser un número entero entre {min} y {max}.");
        }
    }

    // Lee un double (solo números) con reintento
    static double LeerNumero(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
                return value;

            Console.WriteLine("Entrada inválida. Solo se permiten números (usa punto como decimal).");
        }
    }

    // Lee un double distinto de cero
    static double LeerNumeroNoCero(string prompt)
    {
        while (true)
        {
            double v = LeerNumero(prompt);
            if (v != 0.0) return v;
            Console.WriteLine("El valor no puede ser cero. Intenta nuevamente.");
        }
    }

    // Lee un double >= 0
    static double LeerNumeroNoNegativo(string prompt)
    {
        while (true)
        {
            double v = LeerNumero(prompt);
            if (v >= 0.0) return v;
            Console.WriteLine("El valor debe ser mayor o igual a 0. Intenta nuevamente.");
        }
    }

    // Lee un double > 0
    static double LeerNumeroPositivo(string prompt)
    {
        while (true)
        {
            double v = LeerNumero(prompt);
            if (v > 0.0) return v;
            Console.WriteLine("El valor debe ser mayor que 0. Intenta nuevamente.");
        }
    }
}
