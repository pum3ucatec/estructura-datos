using System;

while (true)
{
    Console.Clear();
    Console.WriteLine("===== CALCULADORA =====");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicación");
    Console.WriteLine("4. División");
    Console.WriteLine("5. Raíz cuadrada");
    Console.WriteLine("6. Potencia");
    Console.WriteLine("7. Seno (grados)");
    Console.WriteLine("8. Coseno (grados)");
    Console.WriteLine("9. Logaritmo natural");
    Console.WriteLine("10. Salir");
    Console.Write("Selecciona una opción: ");

    if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 1 || opcion > 10)
    {
        Console.WriteLine("Opción inválida. Pulsa una tecla...");
        Console.ReadKey();
        continue;
    }

    if (opcion == 10) break;

    double num1 = 0, num2 = 0, resultado = double.NaN;

    bool requiereDos = opcion <= 4 || opcion == 6;
    try
    {
        if (requiereDos)
        {
            Console.Write("Ingresa el primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());
        }
        else
        {
            Console.Write("Ingresa el número: ");
            num1 = Convert.ToDouble(Console.ReadLine());
        }
    }
    catch
    {
        Console.WriteLine("Entrada no válida. Pulsa una tecla...");
        Console.ReadKey();
        continue;
    }

    switch (opcion)
    {
        case 1: resultado = num1 + num2; break;
        case 2: resultado = num1 - num2; break;
        case 3: resultado = num1 * num2; break;
        case 4:
            if (num2 == 0) Console.WriteLine("Error: división entre cero.");
            else resultado = num1 / num2;
            break;
        case 5:
            if (num1 < 0) Console.WriteLine("Error: raíz de número negativo.");
            else resultado = Math.Sqrt(num1);
            break;
        case 6: resultado = Math.Pow(num1, num2); break;
        case 7: resultado = Math.Sin(num1 * Math.PI / 180.0); break;
        case 8: resultado = Math.Cos(num1 * Math.PI / 180.0); break;
        case 9:
            if (num1 <= 0) Console.WriteLine("Error: logaritmo definido para números > 0.");
            else resultado = Math.Log(num1);
            break;
    }

    if (!double.IsNaN(resultado))
        Console.WriteLine($"Resultado: {resultado}");

    Console.WriteLine("Presiona una tecla para continuar...");
    Console.ReadKey();
}
