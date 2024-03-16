class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma ou mais palavras para descobrir quantos caracteres elas possuem.");
        var input = Console.ReadLine()?.Trim();

        while (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Digite uma ou mais palavras para descobrir quantos caracteres elas possuem.");
            input = Console.ReadLine()?.Trim();
        }

        int counter = 0;

        foreach (var item in input)
        {
            if (!char.IsWhiteSpace(item))
            {
                counter++;
            }
        }

        Console.WriteLine("O número total de caracteres é: {0}", counter);
    }
}