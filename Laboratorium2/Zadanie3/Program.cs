using Zadanie3;

namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new();

            date.AddWeek();
            date.AddWeek();
            date.AddWeek();
            date.AddWeek();
            Console.WriteLine($"Data po przesunieciu o 4 tygodnie do przodu: {date.CurrentDate().ToShortDateString()}.");

            date.SubstractWeek();
            Console.WriteLine($"Data po cofnieciu o 1 tydzien: {date.CurrentDate().ToShortDateString()}.");
        }
    }
}
