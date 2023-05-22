using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        int i, n;

        double[] v = { 1, 2, 3, 4, 5 }, u = { 1, 2, 3, 4, 5 };

        v[0] = 2.0;
        v[1] = 3.0;
        v[2] = 4.0;
        v[3] = 5.0;
        v[4] = 6.0;

        n = 5;

        for (i = 0; i < n; i++)
        {


            u[i] = v[i] * (i + 1);
        }
        Console.WriteLine(u[1]);
        Console.WriteLine(u[3]);
    }
}
