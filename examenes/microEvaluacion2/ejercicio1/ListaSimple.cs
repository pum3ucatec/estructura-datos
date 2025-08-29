class ListaSimple
{
	public Nodo Cabeza;

	public ListaSimple()
	{
		Cabeza = null;
	}

	public void InsertarEnOrden(int valor)
	{
		Nodo nuevo = new Nodo(valor);
		if (Cabeza == null || valor < Cabeza.Valor)
		{
			nuevo.Siguiente = Cabeza;
			Cabeza = nuevo;
			return;
		}
		Nodo actual = Cabeza;
		while (actual.Siguiente != null && actual.Siguiente.Valor < valor)
		{
			actual = actual.Siguiente;
		}
		nuevo.Siguiente = actual.Siguiente;
		actual.Siguiente = nuevo;
	}

	public void Mostrar()
	{
		Nodo actual = Cabeza;
		while (actual != null)
		{
			Console.Write(actual.Valor + (actual.Siguiente != null ? ", " : "\n"));
			actual = actual.Siguiente;
		}
	}
}