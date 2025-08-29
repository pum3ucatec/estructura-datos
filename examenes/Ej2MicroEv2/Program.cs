class Program
{
    static void Main(string[] args)
    {
        ListaSimple lista = new ListaSimple();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ LISTA SIMPLE =====");
            Console.WriteLine("1. Mostrar lista");
            Console.WriteLine("2. Insertar al principio");
            Console.WriteLine("3. Insertar al final");
            Console.WriteLine("4. Eliminar al principio");
            Console.WriteLine("5. Verificar si está vacia");
            Console.WriteLine("6. Insertar en orden"); 
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un numero valido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    lista.Mostrar();
                    break;
                case 2:
                    Console.Write("Ingrese el numero a insertar al principio: ");
                    if (int.TryParse(Console.ReadLine(), out int valorP))
                    {
                        lista.InsertarAlPrincipio(valorP);
                    }
                    else
                    {
                        Console.WriteLine("Valor invalido.");
                    }
                    break;
                case 3:
                    Console.Write("Ingrese el numero a insertar al final: ");
                    if (int.TryParse(Console.ReadLine(), out int valorF))
                    {
                        lista.InsertarAlFinal(valorF);
                    }
                    else
                    {
                        Console.WriteLine("Valor invalido.");
                    }
                    break;
                case 4:
                    lista.EliminarAlPrincipio();
                    break;
                case 5:
                    Console.WriteLine(lista.EstaVacia() ? "La lista está vacia." : "La lista tiene elementos.");
                    break;
                case 6:  
                    Console.Write("Ingrese el número a insertar en orden: ");
                    if (int.TryParse(Console.ReadLine(), out int valorO))
                    {
                        lista.InsertarEnOrden(valorO);
                        Console.WriteLine($"Se insertó {valorO} en orden.");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción invalida.");
                    break;
            }

        } while (opcion != 0);
    }
}


