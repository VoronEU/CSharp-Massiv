using System;

class Program
{
    static bool Contains(int[] a, int x)
    {
        foreach (int v in a)
            if (v == x) return true;
        return false;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = int.Parse(Console.ReadLine());

        int m = int.Parse(Console.ReadLine());
        int[] b = new int[m];
        for (int i = 0; i < m; i++) b[i] = int.Parse(Console.ReadLine());

        bool equal = true;

        foreach (int x in a)
            if (!Contains(b, x)) equal = false;

        foreach (int x in b)
            if (!Contains(a, x)) equal = false;

        Console.WriteLine(equal ? "да" : "нет");
    }
}
