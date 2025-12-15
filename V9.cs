using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = int.Parse(Console.ReadLine());

        int m = int.Parse(Console.ReadLine());
        int[] b = new int[m];
        for (int i = 0; i < m; i++) b[i] = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (a[i] == b[j])
                {
                    count++;
                    break;
                }

        Console.WriteLine(count);
    }
}
