namespace Zadanie1
{
    internal class Book
    {
        public string Title { get; set; }
        public Person Author { get; set; }
        public DateOnly ReleaseDate { get; set; }

        public Book(string title, Person author, DateOnly releaseDate)
        {
            Title = title;
            Author = author;
            ReleaseDate = releaseDate;
        }

        public virtual void View()
        {
            Console.WriteLine();
            Console.WriteLine("<—————————————————————-—Ksiazka—-—————————————————————>");

            Console.WriteLine($"Tytul: {Title};\nAutor: {Author.FirstName} {Author.LastName};\nData wydania: {ReleaseDate}.");
        }
    }
}
