using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
            a[i] = int.Parse(Console.ReadLine());

        int maxLen = 1;

        for (int center = 0; center < n; center++)
        {
            int l = center, r = center;
            while (l >= 0 && r < n && a[l] == a[r])
            {
                maxLen = Math.Max(maxLen, r - l + 1);
                l--; r++;
            }

            l = center; r = center + 1;
            while (l >= 0 && r < n && a[l] == a[r])
            {
                maxLen = Math.Max(maxLen, r - l + 1);
                l--; r++;
            }
        }

        Console.WriteLine(maxLen);
    }
}
