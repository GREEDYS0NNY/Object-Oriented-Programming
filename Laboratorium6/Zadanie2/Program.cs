namespace Zadanie2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwe pliku bez rozszerzenia:"); // Nazwa pliku z danymi: student1
            string file = Console.ReadLine() + ".txt";

            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                Console.WriteLine($"[{string.Join(", ", lines)}]");
            }
            else Console.WriteLine("Nazwa pliku jest nieprawidlowa lub plik nie istnieje.");
        }
    }
}