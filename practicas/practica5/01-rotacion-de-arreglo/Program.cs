using System;

public static class RotacionArreglo
{
    public static void RotateRight(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0) return;
        int n = nums.Length;

        // normaliza k (soporta k > n y k negativos)
        k = ((k % n) + n) % n;
        if (k == 0) return;

        Reverse(nums, 0, n - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, n - 1);
    }

    private static void Reverse(int[] a, int l, int r)
    {
        while (l < r)
        {
            int tmp = a[l];
            a[l] = a[r];
            a[r] = tmp;
            l++; r--;
        }
    }

    // Demo rápida
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        RotateRight(arr, 2);
        Console.WriteLine(string.Join(", ", arr)); // 4, 5, 1, 2, 3

        int[] arr2 = { 1, 2, 3, 4, 5, 6 };
        RotateRight(arr2, 8);
        Console.WriteLine(string.Join(", ", arr2)); // 5, 6, 1, 2, 3, 4

        int[] arr3 = { 10, 20, 30 };
        RotateRight(arr3, -1);
        Console.WriteLine(string.Join(", ", arr3)); // 20, 30, 10 (rotación izquierda 1)
    }
}