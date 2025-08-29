class ListaSimple
{
	public Nodo Cabeza;

	public ListaSimple()
	{
		Cabeza = null;
	}

	public void InsertarAlPrincipio(int valor)
	{
		Nodo nuevo = new Nodo(valor);
		nuevo.Siguiente = Cabeza;
		Cabeza = nuevo;
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