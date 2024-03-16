class Program
{
    static void Main()
    {
        Console.WriteLine("Esse programa mostra as principais operações matemáticas dado dois valores.");

        Console.WriteLine("Digite o primeiro valor: ");
        double value1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        double value2 = Convert.ToDouble(Console.ReadLine());

        double sum = value1 + value2;
        double sub = value1 - value2;
        double mul = value1 * value2;
        object div = value2 == 0 ? "Não é possível a divisão por zero" : value1 / value2;
        double avg = (value1 + value2) / 2;

        Console.WriteLine("Soma: {0}\nSubtração: {1}\nMultiplicação: {2}\nDivisão: {3}\nMédia: {4}", sum, sub, mul, div, avg);
    }
}
