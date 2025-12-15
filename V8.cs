using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] a = new double[n];

        for (int i = 0; i < n; i++)
            a[i] = double.Parse(Console.ReadLine());

        Array.Sort(a);

        for (int i = 0; i < 4; i++)
            Console.WriteLine(a[i]);
    }
}
