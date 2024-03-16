class Program
{
    static void Main()
    {
        Console.WriteLine("Digite seu primeiro nome:");
        string? firstName = Console.ReadLine()?.Trim();

        while (string.IsNullOrWhiteSpace(firstName))
        {
            Console.WriteLine("Digite seu primeiro nome:");
            firstName = Console.ReadLine()?.Trim();
        }

        Console.WriteLine("Digite seu sobrenome:");
        string? lastName = Console.ReadLine()?.Trim();

        while (string.IsNullOrWhiteSpace(lastName))
        {
            Console.WriteLine("Digite seu sobrenome:");
            lastName = Console.ReadLine()?.Trim();
        }

        Console.WriteLine($"Nome completo: {firstName} {lastName}");
    }
}