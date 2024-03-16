class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número de placa para verificar se ela é válida. A placa deve ter 7 caracteres alfanuméricos.");
        var input = Console.ReadLine()?.Trim();

        while (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Digite um número de placa para verificar se ela é válida. A placa deve ter 7 caracteres alfanuméricos.");
            input = Console.ReadLine()?.Trim();
        }

        var isValid = VerifyPlate(input) ? "verdadeira" : "falsa";

        Console.WriteLine($"A placa é {isValid}");

        static bool VerifyPlate(string plate)
        {
            if (plate.Length != 7)
                return false;

            for(int i = 0; i < 3; i++)
            {
                if (!char.IsLetter(plate[i]))
                {
                    return false;
                }
            }

            for (int i = 3; i < 7; i++)
            {
                if (!char.IsDigit(plate[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

