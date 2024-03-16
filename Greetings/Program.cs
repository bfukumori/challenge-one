class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o seu nome:");
        string? name = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Nome inválido. Por favor, digite um nome válido.");
        }
        else
        {
            string msg = $"Olá, {name}! Seja muito bem-vindo!";
            Console.WriteLine(msg);
        }
    }
}
