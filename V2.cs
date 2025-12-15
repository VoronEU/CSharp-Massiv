using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
            a[i] = int.Parse(Console.ReadLine());

        int maxLen = 1, curLen = 1;

        for (int i = 1; i < n; i++)
        {
            if (a[i] > a[i - 1])
                curLen++;
            else
                curLen = 1;

            if (curLen > maxLen)
                maxLen = curLen;
        }

        Console.WriteLine(maxLen);
    }
}
