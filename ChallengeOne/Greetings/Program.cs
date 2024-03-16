namespace Greetings;
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Digite seu nome: ");
        string? name = Console.ReadLine();

        while (name is null || name.Trim() == "")
        {
            Console.WriteLine("Digite seu nome: ");
            name = Console.ReadLine();
        };

        Console.WriteLine($"Olá, {name.Trim()}! Seja muito bem - vindo!");
    }
}
