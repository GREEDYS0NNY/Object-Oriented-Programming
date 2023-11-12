namespace Zadanie1
{
    internal class Reader : Person
    {
        public List<Book> BooksRead { get; set; }

        public Reader(string firstName, string lastName, int? age) : base(firstName, lastName, age)
        {
            BooksRead = new List<Book>();
        }

        public void ViewBook()
        {
            Console.WriteLine();
            Console.WriteLine("<———————————————————Lista ksiazek—————————————————————>");
            Console.WriteLine($"Ksiazki przeczytane przez uzytkownika {FirstName} {LastName}: ");

            foreach (var book in BooksRead)
            {
                Console.WriteLine(book.Title + ";");
            }
        }

        public override void View()
        {
            Console.WriteLine();
            Console.WriteLine("<==================|Dane uzytkownika|=================>");

            base.View();
            ViewBook();
        }
    }
}
