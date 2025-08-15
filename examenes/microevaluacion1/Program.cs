using System;

class Program
{
    public static void Main()
    {
        bool encendido = true;
        do
        {
            Console.WriteLine("Calculadora Cientifica");
            Console.WriteLine("Seleccione una función");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raíz Cuadrada");
            Console.WriteLine("7. Seno");
            Console.WriteLine("8. Coseno");
            Console.WriteLine("9. Tangente");
            Console.WriteLine("0. Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese dos números para sumar:");
                    Console.WriteLine("Primer número:");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Segundo número:");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    resultado = num1 + num2;
                    Console.WriteLine("El resultado es: " + resultado);
                    break;
                case 2:
                    Console.WriteLine("Ingrese dos números para restar:");
                    Console.WriteLine("Primer número:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Segundo número:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    resultado = num1 - num2;
                    Console.WriteLine("El resultado es: " + resultado);
                    break;
                case 3:
                    Console.WriteLine("Ingrese dos números para multiplicar:");
                    Console.WriteLine("Primer número:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Segundo número:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    resultado = num1 * num2;
                    Console.WriteLine("El resultado es: " + resultado);
                    break;
                case 4:
                    Console.WriteLine("Ingrese dos números para dividir:");
                    Console.WriteLine("Primer número:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Segundo número:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    resultado = num1 / num2;
                    Console.WriteLine("El resultado es: " + resultado);
                    break;
                case 5:
                    Console.WriteLine("Ingrese la base y el exponente:");
                    Console.WriteLine("Base:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Exponente:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine("El resultado es: " + resultado);
                    break;
                case 6:
                    Console.WriteLine("Ingrese un número");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    resultado = Math.Sqrt(num1);
                    Console.WriteLine("El resultado es: " + resultado);
                    break;
                case 7:
                    Console.WriteLine("Ingrese un ángulo en grados:");
                    double angulo = Convert.ToDouble(Console.ReadLine());
                    double radianes = angulo * (Math.PI / 180);
                    resultado = Math.Sin(radianes);
                    Console.WriteLine("El resultado es: " + resultado);
                    break;
                case 8:
                    Console.WriteLine("Ingrese un ángulo en grados:");
                    angulo = Convert.ToDouble(Console.ReadLine());
                    radianes = angulo * (Math.PI / 180);
                    resultado = Math.Cos(radianes);
                    Console.WriteLine("El resultado es: " + resultado);
                    break;
                case 9:
                    Console.WriteLine("Ingrese un ángulo en grados:");
                    angulo = Convert.ToDouble(Console.ReadLine());
                    radianes = angulo * (Math.PI / 180);
                    resultado = Math.Tan(radianes);
                    Console.WriteLine("El resultado es: " + resultado);
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    encendido = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

        } while (encendido);
    }
}