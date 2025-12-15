using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        int[] dp = new int[n];

        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
            dp[i] = 1;
        }

        int max = 1;
        for (int i = 1; i < n; i++)
            for (int j = 0; j < i; j++)
                if (a[j] < a[i] && dp[j] + 1 > dp[i])
                    dp[i] = dp[j] + 1;

        for (int i = 0; i < n; i++)
            if (dp[i] > max) max = dp[i];

        Console.WriteLine(max);
    }
}
