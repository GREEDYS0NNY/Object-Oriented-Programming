namespace Zadanie3
{
    public class Osoba : IOsoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string ZwrocPelnaNazwe()
        {
            return $"{Imie} {Nazwisko}.";
        }
    }
}
