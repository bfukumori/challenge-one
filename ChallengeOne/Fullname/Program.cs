namespace Fullname;
internal class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite seu primeiro nome:");
        string? firstName = Console.ReadLine();
        
        while (firstName == null || firstName == "")
        {
            Console.WriteLine("Digite seu primeiro nome:");
            firstName = Console.ReadLine();
        }

        Console.WriteLine("Digite seu sobrenome nome:");
        string? lastName = Console.ReadLine();

        while (lastName == null || lastName == "")
        {
            Console.WriteLine("Digite seu sobrenome:");
            lastName = Console.ReadLine();
        }

        Console.WriteLine($"{ firstName} { lastName}");
    }
}
