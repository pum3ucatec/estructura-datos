public class DoubleList
{
	public DoubleNode Head;
	public DoubleNode Tail;

	public DoubleList()
	{
		Head = null;
		Tail = null;
	}

	// Insert at the end
	public void InsertAtEnd(int value)
	{
		DoubleNode newNode = new DoubleNode(value);
		if (Head == null)
		{
			Head = Tail = newNode;
		}
		else
		{
			Tail.Next = newNode;
			newNode.Prev = Tail;
			Tail = newNode;
		}
	}

	public void ShowForward()
	{
		DoubleNode current = Head;
		Console.Write("Lista: ");
		while (current != null)
		{
			Console.Write(current.Value + (current.Next != null ? ", " : "\n"));
			current = current.Next;
		}
	}

	public void ShowBackward()
	{
		DoubleNode current = Tail;
		Console.Write("Lista al reverso: ");
		while (current != null)
		{
			Console.Write(current.Value + (current.Prev != null ? ", " : "\n"));
			current = current.Prev;
		}
	}
}