namespace Zadanie1
{
    internal class Reviewer : Reader
    {
        public Reviewer(string firstName, string lastName, int? age) : base(firstName, lastName, age) { }

        public void Wypisz()
        {
            Console.WriteLine();
            Console.WriteLine($"<—————————————————Ocena recenzenta————————————————————>");
            
            foreach (var book in BooksRead) 
            {
                Console.WriteLine($"Ocena dla ksiazki '{book.Title}': {new Random().Next(5)}.");
            }
        }
    }
}
