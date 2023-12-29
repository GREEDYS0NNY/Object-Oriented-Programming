namespace Zadanie3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string file = "pesels.txt";
            List<string> allPesels = [];

            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                allPesels = new(lines);
            }

            WomenAmount(allPesels);
        }
        public static void WomenAmount(List<string> pesels)
        {
            List<string> WomanPesels = pesels.FindAll(pesel => int.Parse(pesel.Substring(9, 1)) % 2 == 0);

            Console.WriteLine($"Liczba zenskich peseli: {WomanPesels.Count}.");
        }
    }
}