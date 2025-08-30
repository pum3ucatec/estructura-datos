using System;

class Principal
{
    static void Main(string[] args)
    {
        Lista lista = new Lista();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ LISTA SIMPLE =====");
            Console.WriteLine("1. Mostrar");
            Console.WriteLine("2. Insertar (al final)");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Buscar");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("6. Insertar al principio");
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
                    Console.Write("Ingrese el valor a insertar al final: ");
                    {
                        string v = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(v)) lista.Insert(v);
                        else Console.WriteLine("Valor inválido.");
                    }
                    break;

                case 3:
                    Console.Write("Ingrese el valor a eliminar: ");
                    lista.Delete(Console.ReadLine());
                    break;

                case 4:
                    Console.Write("Ingrese el valor a buscar: ");
                    Console.WriteLine(lista.Search(Console.ReadLine())
                        ? "Elemento encontrado ✅"
                        : "No se encontró el elemento ❌");
                    break;

                case 5:
                    Console.WriteLine(lista.IsEmpty()
                        ? "La lista está vacía."
                        : "La lista contiene elementos.");
                    break;

                case 6:
                    Console.Write("Ingrese el valor a insertar al principio: ");
                    {
                        string v = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(v)) lista.InsertAtBeginning(v);
                        else Console.WriteLine("Valor inválido.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 0);
    }
}
