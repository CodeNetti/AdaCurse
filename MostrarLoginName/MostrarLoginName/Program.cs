
using System.Diagnostics.SymbolStore;

internal class Program
{
    private static void Main(string[] args)
    {
        string nome, dia, mes;

        Console.WriteLine("Bem vindo ao App ADA");
        Console.WriteLine("Digite seu  nome");
        nome = Console.ReadLine();
        Console.WriteLine("Digite o dia em que nasceu");
        dia = Console.ReadLine();
        Console.WriteLine("Digite seu mes de aniversario");
        mes = Console.ReadLine();

        Console.WriteLine($"Login:{dia + nome + mes}");
        

    }
}