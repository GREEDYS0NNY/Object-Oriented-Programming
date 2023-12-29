using Newtonsoft.Json.Linq;

namespace Zadanie4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string jsonFile = File.ReadAllText("db.json");
            JObject populationDB = JObject.Parse(jsonFile);

            Console.WriteLine($"Róznica populacji miedzy 1970 a 2000 rokiem dla Indii wynosi {PopulationDifference(populationDB, "India", "1970", "2000")} osób.");
            Console.WriteLine($"Róznica populacji miedzy 1965 a 2010 rokiem dla USA wynosi {PopulationDifference(populationDB, "USA", "1965", "2010")} osób.");
            Console.WriteLine($"Róznica populacji miedzy 1980 a 2018 rokiem dla Chin wynosi {PopulationDifference(populationDB, "China", "1980", "2018")} osób.");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("1. Wyswietlic populacje dla wskazanego roku i kraju;");
                Console.WriteLine("2. Sprawdzic róznice populacji dla wskazanego zakresu lat i kraju;");
                Console.WriteLine("3. Sprawdzic procentowy wzrost populacji;");
                Console.WriteLine("4. Wyjsc.");
                Console.WriteLine();
                Console.WriteLine("Wybierz operacje:");

                string operationNumber = Console.ReadLine();

                switch (operationNumber)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Wybierz nazwe kraju z listy (USA, India, China):");
                        string country = Console.ReadLine();

                        Console.WriteLine() ;
                        Console.WriteLine("Podaj rok miedzy 1960 a 2023, dla którego chcesz zobaczyc populacje:");
                        string year = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine($"Populacja dla {country} w roku {year} wynosi {GetPopulation(populationDB, country, year)} osób.");
                        break;
                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("Wybierz nazwe kraju z listy (USA, India, China):");
                        country = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Podaj zakres lat (np. 1990-2020):");
                        string[] years = Console.ReadLine().Split("-");
                        string subtractYear = years[0];
                        year = years[1];

                        Console.WriteLine();
                        Console.WriteLine($"Róznica populacji dla {country} w latach {subtractYear}-{year} wynosi {PopulationDifference(populationDB, country, subtractYear, year)} osób.");
                        break;
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("Wybierz nazwe kraju z listy (USA, India, China):");
                        country = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Podaj rok dla obliczenia procentowego wzrostu populacji:");
                        year = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine($"Procentowy wzrost populacji dla {country} w roku {year} wynosi {PopulationGrowth(populationDB, country, year)}.");
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nieprawidlowy numer operacji.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static int GetPopulation(JObject populationDB, string country, string year) => (int) populationDB[country][year];

        static int PopulationDifference(JObject populationDB, string country, string subtractYear, string year)
        {
            return GetPopulation(populationDB, country, year) - GetPopulation(populationDB, country, subtractYear);
        }

        static double PopulationGrowth(JObject populationDB, string country, string year)
        {
            int previousYear = int.Parse(year) - 1;

            int previousYearPopulation = GetPopulation(populationDB, country, previousYear.ToString());
            int currentYearPopulation = GetPopulation(populationDB, country, year);

            return (double)(currentYearPopulation - previousYearPopulation) / previousYearPopulation * 100;
        }
    }
}