internal class Program
{
    private static void Main(string[] args)
    {

        double x1, x2;
        double res;

        Console.WriteLine("Digite o valor de X1");
        x1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor de X2");
        x2 = Convert.ToDouble(Console.ReadLine());

        if (x1 > x2)
        {
            res = (x1 - x2) / x1;
        }
        else
        {
            res = (x2 - x1) / x2;
        }

        Console.WriteLine($"O Resultado da Divisão é{res}");
    }
};