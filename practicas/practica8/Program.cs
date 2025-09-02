using System;
class Program
{
	static void Main(string[] args)
	{
		DoubleList list = new DoubleList();
		int[] data = { 10, 20, 30, 40, 50 };
		foreach (int n in data)
		{
			list.InsertAtEnd(n);
		}
		list.ShowForward();
		list.ShowBackward();
	}
}