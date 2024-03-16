using System.Globalization;

class Program { 
static void Main()
    {
        Console.WriteLine("-----VISUALIZADOR DE DATAS-----\n");
        Console.WriteLine("\tOPÇÕES\n");


        bool active = true;
       
        while (active)
        {
            Console.WriteLine("\t1 - Formato completo");
            Console.WriteLine("\t2 - Apenas a data no formato DD/MM/YYYY");
            Console.WriteLine("\t3 - Apenas a hora no formato de 24h");
            Console.WriteLine("\t4 - A data com o mês por extenso");
            Console.WriteLine("\t0 - Sair do progama\n");

            Console.Write("\tEscolha o formato de data que gostaria de visualizar: ");
            var option = Console.ReadLine();

            DateTime date = DateTime.Now;
            CultureInfo culture = new("pt-BR");

          
            string formattedDate1 = date.ToString("dddd, dd/MM/yyyy HH:mm:ss", culture);
            string formattedDate2 = date.ToString("d", culture);
            string formattedDate3 = date.ToString("t", culture);
            string formattedDate4 = date.ToString("f", culture);


            switch (option)
            {
                case "1":
                    Console.WriteLine("\n\t Data atual: {0}\n\n", formattedDate1);
                    break;
                case "2":
                    Console.WriteLine("\n\t Data atual: {0}\n\n", formattedDate2);
                    break;
                case "3":
                    Console.WriteLine("\n\t Data atual: {0}\n\n", formattedDate3);
                    break;
                case "4": 
                    Console.WriteLine("\n\t Data atual: {0}\n\n", formattedDate4);
                    break;
                case "0":
                    active = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}