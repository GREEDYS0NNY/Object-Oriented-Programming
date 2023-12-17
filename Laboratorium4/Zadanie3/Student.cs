namespace Zadanie3
{
    public class Student : IStudent
    {
        public string Uczelnia { get; set; }
        public string Kierunek { get; set; }
        public int Rok { get; set; }
        public int Semestr { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public string ZwrocPelnaNazwe()
        {
            return $"{Imie} {Nazwisko}";
        }
        public string WypiszPelnaNazweIUczelnie()
        {
            return $"{Imie} {Nazwisko} – {Semestr}{Kierunek} {Rok} {Uczelnia}";
        }
    }
}
