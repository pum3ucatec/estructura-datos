class ej2
{
    public static void Program()
    {
        int i = 1;
        int a = 0;
        Console.WriteLine("Ingresa un número:");
        int x = int.Parse(Console.ReadLine()!);

        while (i <= x)
        {
            Console.Write(i + "+");
            a = a + i;
            i++;
            
            
        }
        Console.WriteLine("="+a);

    }
}
