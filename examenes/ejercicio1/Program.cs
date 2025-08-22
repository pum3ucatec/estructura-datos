using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 }; 
        int k = 2;  
        int n = arr.Length;

        
        for (int i = 0; i < k; i++)
        {
            int last = arr[n - 1];  
            for (int j = n - 1; j > 0; j--)
            {
                arr[j] = arr[j - 1];  
            }
            arr[0] = last;  
        }

        
        Console.WriteLine("Arreglo rotado:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}
