
internal class Program
{
    private static void Main(string[] args)
    {

        double x, i, t, e;
        double a;


        Console.WriteLine("Quantos numeros quer informar ?");
        x = Convert.ToInt32(Console.ReadLine());

        i = 0;
        t = 0;

        while (i < x)
        {
            Console.WriteLine("Digite a quantidade de numeros");
            e = Convert.ToInt32(Console.ReadLine());

            t = t + e;
            i = i + 1;
        }
        a = t / x;
        Console.WriteLine(i);
        Console.WriteLine(a);
    }
};