//LISTA SIMPLE
class Principal
{
    public static int FactorialRecursivo(int valor) // si o si debe estar en Método separado aqui arriba
    {
        if (valor == 1)    //Termina su RECURSIVIDAD
        {
            return 1;
        }
        else
        {
            return valor * FactorialRecursivo(valor - 1);
        }
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
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Buscar");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("6. Ejemplo de Recursividad con el factorial");
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
                    lista.View();
                    break;
                case 2:
                    Console.Write("Ingrese el nombre a insertar: ");
                    string valor = Console.ReadLine();
                    if (!string.IsNullOrEmpty(valor))
                    {
                        lista.Insert(valor);
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case 3:
                    Console.Write("Ingrese el nombre a eliminar: ");
                    string valorEliminar = Console.ReadLine();
                    if (!string.IsNullOrEmpty(valorEliminar))
                    {
                        lista.Delete(valorEliminar);
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case 4:

                    break;
                case 5:
                    break;
                case 6:
                    Console.Write("Ingrese un número para calcular su factorial: ");
                    int number;
                    if (!int.TryParse(Console.ReadLine(), out number))
                    {
                        Console.WriteLine("Ingrese un número válido.");
                        continue;
                    }
                    long f = 1;
                    int cont = 1;
                    while (cont <= number)
                    {
                        f *= cont;
                        cont++;
                    }
                    Console.WriteLine($"El factorial de {number} es {f}");

                    int factlRec = FactorialRecursivo(number);
                    Console.WriteLine($"El factorial con RECURSIVIDAD {number} es {f}");

                    break;
                case 0:
                    break;
                default:
                    break;
            }

        } while (opcion != 0);
    }
}