namespace Zadanie1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwe pliku bez rozszerzenia: ");
            string fileName = Console.ReadLine() + ".txt";

            Console.WriteLine("Podaj swoj numer albumu:");
            string numerAlbumu = Console.ReadLine();

            if (fileName != null)
            {
                using StreamWriter file = new(fileName);
                file.WriteLine(numerAlbumu);
            }
        }
    }
}