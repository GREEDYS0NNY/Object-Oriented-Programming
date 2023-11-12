namespace Zadanie1
{
    internal class AdventureBook : Book
    {
        public bool? IsAvailable { get; set; }

        public AdventureBook(string title, Person author, DateOnly releaseDate, bool? isAvailable) : base(title, author, releaseDate) 
        {
            IsAvailable = isAvailable;
        }

        public override void View()
        {
            base.View();

            if (IsAvailable == true) { Console.WriteLine("Dostepnosc: dostepna."); }
            else if (IsAvailable == false) { Console.WriteLine("Dostepnosc: niedostepna."); }
            else { Console.WriteLine("Dostepnosc: nieznana"); }
        }
    }
}
