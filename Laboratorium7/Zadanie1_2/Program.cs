namespace Zadanie1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string filePath = "People.csv";
            string connectionString = @"Data Source=GREED;Initial Catalog=Lab7;Integrated Security=True;";

            Person person = new();

            while (true)
            {
                Console.WriteLine("1. Pokaz informacje z pliku");
                Console.WriteLine("2. Dodaj osobe");
                Console.WriteLine("3. Zaktualizuj osobe");
                Console.WriteLine("4. Usun osobe");
                Console.WriteLine("5. Wyjdz");
                Console.WriteLine();
                Console.Write("Wybierz opcje: ");

                string chosenOption = Console.ReadLine();

                switch (chosenOption)
                {
                    case "1":
                        Console.Clear();
                        person.ShowInfo(filePath);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        person.AddPerson(filePath, connectionString);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.Write("Wpisz pesel osoby: ");
                        _ = long.TryParse(Console.ReadLine(), out long pesel1);
                        person.UpdatePerson(filePath, pesel1);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        Console.Write("Wpisz pesel osoby: ");
                        _ = long.TryParse(Console.ReadLine(), out long pesel2);
                        person.DeletePerson(filePath, pesel2);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        Console.WriteLine("\nUdane wyjscie.");
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}