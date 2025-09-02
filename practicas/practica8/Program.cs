//LISTA DOBLEMENTE ENLAZADA https://conclase.net/c/edd/cap5
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
            Console.WriteLine("\n===== MENÚ LISTA DOBLE =====");
            Console.WriteLine("1. Mostrar lista");
            Console.WriteLine("2. Insertar nodo");
            Console.WriteLine("3. Eliminar nodo");
            Console.WriteLine("4. Buscar nodo");
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
                    Console.WriteLine("Lista hacia adelante");
                    lista.ViewForward();
                    Console.WriteLine("Lista hacia atrás");
                    lista.ViewBackward();
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
                    Console.WriteLine("Ingrese el nombre a buscar");
                    string valorBuscar = Console.ReadLine();
                    Nodo encontrado = lista.Search(valorBuscar);
                    if (encontrado != null)
                        Console.WriteLine($"Nodo '{encontrado.Name}' encontrado.");
                    else
                        Console.WriteLine("Nodo no encontrado");
                    break;
                case 5:
                    if (lista.IsEmpty())
                        Console.WriteLine("La lista esta vacía");
                    else
                        Console.WriteLine("La lista tiene elementos");
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
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

        } while (opcion != 0);
    }
}