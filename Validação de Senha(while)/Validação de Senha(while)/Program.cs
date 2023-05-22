
internal class Program
{
    private static void Main(string[] args)
    {

        string senha;
        int i = 0;

        Console.WriteLine("Para continuar, digite sua senha:");
        senha = Console.ReadLine();

        while (senha != "a6b5c4")
        {
            Console.WriteLine("Senha inválida");
            i = i + 1;
            Console.WriteLine("Para continuar, digite sua senha");
            senha = Console.ReadLine();

        }

        Console.WriteLine("Seja bem-vindo(a) á área do cliente");

    }
};