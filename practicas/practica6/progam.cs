using System;

class Principal
{
    static void Main(string[] args)
    {
        var cola = new Cola();
        int opcion;

        while (true)
        {
            MostrarEstado(cola);
            MostrarMenu();

            Console.Write("Elige una opción: ");
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Mensaje("Debes ingresar un número.");
                continue;
            }

            switch (opcion)
            {
                case 1: OpcionInsertar(cola); break;          
                case 2: OpcionVerFrente(cola); break;        
                case 3: OpcionEliminarFrente(cola); break;     
                case 4: OpcionMostrarCola(cola); break;       
                case 5: OpcionEliminarPorPosicion(cola); break;
                case 6: OpcionContar(cola); break;             
                case 7: OpcionVacia(cola); break;              
                case 0:
                    Console.WriteLine("Fin del programa.");
                    return;
                default:
                    Mensaje("Opción no válida.");
                    break;
            }
        }
    }

    static void MostrarEstado(Cola cola)
    {
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("           ESTADO DE LA COLA            ");
        Console.WriteLine("========================================");

        string frente = cola.Peek() ?? "(sin elementos)";
        Console.WriteLine($" Frente: {frente}");
        Console.WriteLine($" Cantidad: {cola.Count()}");
        Console.WriteLine($" Vacía: {(cola.IsEmpty() ? "Sí" : "No")}");
        Console.WriteLine("----------------------------------------");
    }

    static void MostrarMenu()
    {
        Console.WriteLine("1) Insertar ");
        Console.WriteLine("2) Ver frente ");
        Console.WriteLine("3) Eliminar frente ");
        Console.WriteLine("4) Mostrar cola ");
        Console.WriteLine("5) Eliminar por posición (0 = frente)");
        Console.WriteLine("6) Contar elementos");
        Console.WriteLine("0) Salir");
        Console.WriteLine("----------------------------------------");
    }

    static void Mensaje(string texto)
    {
        Console.WriteLine(texto);
        Console.Write("Presione ENTER para continuar...");
        Console.ReadLine();
        Console.WriteLine();
    }

    static void OpcionInsertar(Cola cola)
    {
        Console.Write("Nombre a insertar: ");
        string? valor = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(valor))
        {
            Mensaje("No se insertó. Valor inválido.");
            return;
        }

        cola.Enqueue(valor.Trim());
        Mensaje("Elemento insertado.");
    }

    static void OpcionVerFrente(Cola cola)
    {
        string? frente = cola.Peek();
        Mensaje(frente == null ? "La cola está vacía." : $"Frente: {frente}");
    }

    static void OpcionEliminarFrente(Cola cola)
    {
        string? eliminado = cola.Dequeue();
        Mensaje(eliminado == null ? "No hay elementos para eliminar." : $"Eliminado: {eliminado}");
    }

    static void OpcionMostrarCola(Cola cola)
    {
        Console.WriteLine();
        Console.WriteLine("Contenido (de Frente a Fondo):");
        cola.View(); 
        Console.WriteLine();
        Mensaje("");
    }

    static void OpcionEliminarPorPosicion(Cola cola)
    {
        if (cola.IsEmpty())
        {
            Mensaje("La cola está vacía.");
            return;
        }

        Console.Write("Posición a eliminar (0 = frente): ");
        string? raw = Console.ReadLine();

        if (!int.TryParse(raw, out int index))
        {
            Mensaje("Índice inválido.");
            return;
        }

        string? removido = cola.RemoveAt(index);
        Mensaje(removido == null ? "Posición fuera de rango." : $"Eliminado en posición {index}: {removido}");
    }

    static void OpcionContar(Cola cola)
    {
        Mensaje($"Cantidad de elementos: {cola.Count()}");
    }

    static void OpcionVacia(Cola cola)
    {
        Mensaje(cola.IsEmpty() ? "Sí, la cola está vacía." : "No, la cola contiene elementos.");
    }
}
