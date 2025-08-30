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
            Console.WriteLine("6. Insertar en orden");
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
                    string eliminar = Console.ReadLine();
                    lista.Delete(eliminar);
                    break;

                case 4:
                    Console.Write("Ingrese el nombre a buscar: ");
                    string buscar = Console.ReadLine();
                    bool encontrado = lista.Search(buscar);
                    Console.WriteLine(encontrado ? "Elemento encontrado ✅" : "No se encontró el elemento ❌");
                    break;

                case 5:
                    Console.WriteLine(lista.IsEmpty() ? "La lista está vacía." : "La lista contiene elementos.");
                    break;

                case 6:
                    Console.Write("Ingrese el número a insertar en orden: ");
                    if (int.TryParse(Console.ReadLine(), out int numOrdenado))
                    {
                        lista.InsertOrdered(numOrdenado);
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
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
