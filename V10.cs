using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
            a[i] = int.Parse(Console.ReadLine());

        bool set = true;
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
                if (a[i] == a[j])
                    set = false;

        Console.WriteLine(set ? "да" : "нет");
    }
}
