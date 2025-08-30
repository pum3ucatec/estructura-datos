using System;

class Principal
{
    public static int FactorialRecursivo(int valor)
    {
        if (valor <= 1) return 1;
        return valor * FactorialRecursivo(valor - 1);
    }

    static void Main(string[] args)
    {
        Lista lista = new Lista();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ LISTA SIMPLE =====");
            Console.WriteLine("1. Mostrar");
            Console.WriteLine("2. Insertar");
            Console.WriteLine("3. Buscar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("5. Mostrar lista desde un valor");
            Console.WriteLine("6. Ejemplo de recursividad con el factorial");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    lista.ViewRecursive();
                    break;

                case 2:
                    Console.Write("Ingrese el valor a insertar (ej. 1, 3, 2): ");
                    string valor = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(valor))
                        lista.Insert(valor.Trim());
                    else
                        Console.WriteLine("Valor inválido.");
                    break;

                case 3:
                    Console.Write("Ingrese el valor a buscar: ");
                    string buscar = Console.ReadLine();
                    bool encontrado = lista.Search(buscar);
                    Console.WriteLine(encontrado
                        ? $"El elemento '{buscar}' está en la lista."
                        : $"El elemento '{buscar}' NO se encontró.");
                    break;

                case 4:
                    Console.Write("Ingrese el valor a eliminar: ");
                    string eliminar = Console.ReadLine();
                    lista.Delete(eliminar);
                    Console.WriteLine($"Si existía, el elemento '{eliminar}' fue eliminado.");
                    break;

                case 5:
                    Console.Write("Mostrar desde el valor: ");
                    string desde = Console.ReadLine();
                    lista.ViewFromValue(desde);
                    break;

                case 6:
                    Console.Write("Número para factorial: ");
                    if (!int.TryParse(Console.ReadLine(), out int number))
                    {
                        Console.WriteLine("Ingrese un número válido.");
                        continue;
                    }
                    int factRec = FactorialRecursivo(number);
                    Console.WriteLine($"El factorial con RECURSIVIDAD de {number} es {factRec}");
                    break;

                case 0:
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 0);
    }
}
