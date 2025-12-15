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
            bool diff = true;
            for (int j = 0; j < i; j++)
                if (a[i] == a[j])
                    diff = false;

            if (diff) count++;
        }

        Console.WriteLine(count);
    }
}
