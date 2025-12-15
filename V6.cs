using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
            a[i] = int.Parse(Console.ReadLine());

        int best = a[0], bestCount = 1;

        for (int i = 0; i < n; i++)
        {
            int cnt = 0;
            for (int j = 0; j < n; j++)
                if (a[i] == a[j]) cnt++;

            if (cnt > bestCount)
            {
                bestCount = cnt;
                best = a[i];
            }
        }

        Console.WriteLine(best);
    }
}
