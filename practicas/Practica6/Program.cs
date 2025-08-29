class Principal
{
    static void Main(string[] args)
    {
        Cola cola = new Cola();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ COLA con NODOS =====");
            Console.WriteLine("1. Mostrar Cola");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("6. Contar elementos");
            Console.WriteLine("7. Eliminar por posición");
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
                    cola.View();
                    break;
                case 2:
                    Console.Write("Ingrese el nombre a insertar: ");
                    string valor = Console.ReadLine();
                    if (!string.IsNullOrEmpty(valor))
                    {
                        cola.Enqueue(valor);
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case 3:
                    string eliminado = cola.Dequeue();
                    if (eliminado != null)
                        Console.WriteLine($"Elemento eliminado: {eliminado}");
                    else
                        Console.WriteLine("La cola está vacía.");
                    break;
                case 4:
                    string frente = cola.Peek();
                    if (frente != null)
                        Console.WriteLine($"Elemento al frente: {frente}");
                    else
                        Console.WriteLine("La cola está vacía.");
                    break;
                case 5:
                    if (cola.IsEmpty())
                        Console.WriteLine("La cola está vacía.");
                    else
                        Console.WriteLine("La cola NO está vacía.");
                    break;
                case 6:
                    Console.WriteLine($"Cantidad de elementos en la cola: {cola.Count()}");
                    break;
                case 7:
                    Console.Write("Ingrese la posición a eliminar (empezando en 0): ");
                    if (int.TryParse(Console.ReadLine(), out int pos))
                    {
                        if (cola.RemoveAt(pos))
                            Console.WriteLine($"Elemento en la posición {pos} eliminado.");
                        else
                            Console.WriteLine("No se pudo eliminar. Posición inválida o cola vacía.");
                    }
                    else
                    {
                        Console.WriteLine("Posición inválida.");
                    }
                    break;
                case 0:
                    break;
                default:
                    break;
            }

        } while (opcion != 0);
    }
}