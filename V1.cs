using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
            a[i] = int.Parse(Console.ReadLine());

        bool inc = true;
        for (int i = 1; i < n; i++)
            if (a[i] <= a[i - 1])
                inc = false;

        Console.WriteLine(inc ? "да" : "нет");
    }
}
