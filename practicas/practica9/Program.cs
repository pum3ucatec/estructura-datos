//LISTA CIRCULAR https://conclase.net/c/edd/cap4
class Principal
{
    static void Main(string[] args)
    {
        ListaCircular lista = new ListaCircular();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ LISTA SIMPLE CIRCULAR =====");
            Console.WriteLine("1. Mostrar lista");
            Console.WriteLine("2. Insertar nodo");
            Console.WriteLine("3. Eliminar nodo");
            Console.WriteLine("4. Buscar nodo");
            Console.WriteLine("5. Verificar si está vacía");
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
                    string valorInsertar = Console.ReadLine();
                    if (!string.IsNullOrEmpty(valorInsertar))
                    {
                        lista.Insert(valorInsertar);
                        Console.WriteLine($"Elemento '{valorInsertar}' insertado.");
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
                    Console.Write("Ingrese el nombre a buscar: ");
                    string valorBuscar = Console.ReadLine();
                    if (!string.IsNullOrEmpty(valorBuscar))
                    {
                        var nodoEncontrado = lista.Search(valorBuscar);
                        if (nodoEncontrado != null)
                            Console.WriteLine($"Nodo '{valorBuscar}' encontrado.");
                        else
                            Console.WriteLine($"Nodo '{valorBuscar}' no encontrado.");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido");
                    }
                    break;
                case 5:
                    Console.WriteLine(lista.IsEmpty()
                        ? "La lista está vacía."
                        : "La lista tiene elementos.");
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