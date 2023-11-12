namespace Zadanie1
{
    internal class DocumentaryBook : Book
    {
        public double? Cena { get; set; }
        public DocumentaryBook(string title, Person author, DateOnly releaseDate, double? cena) : base(title, author, releaseDate)
        {
            Cena = cena;
        }

        public override void View()
        {
            base.View();

            if (Cena != null) { Console.WriteLine($"Cena w PLN: {Cena}."); }
            else { Console.WriteLine("Cena w PLN: nieznana"); }
        }
    }
}
