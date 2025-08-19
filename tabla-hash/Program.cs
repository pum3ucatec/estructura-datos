using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> edades = new Dictionary<string, int>();
        edades["Juan"] = 25;
        edades["Ana"] = 30;

        Console.WriteLine(edades["Ana"]); // 30
    }
}