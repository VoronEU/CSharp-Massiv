using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int count = 0;

        for (int i = 0; i < n; i++)
            a[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            bool unique = true;
            for (int j = 0; j < n; j++)
                if (i != j && a[i] == a[j])
                    unique = false;

            if (unique) count++;
        }

        Console.WriteLine(count);
    }
}
