namespace Zadanie3
{
    public static class ListIOsobaExtensions
    {
        public static void WypiszOsoby(this List<IOsoba> osoby)
        {
            foreach (var osoba in osoby)
            {
                Console.WriteLine($"{osoba.Imie} {osoba.Nazwisko}.");
            }
        }

        public static void PosortujOsobyPoNazwisku(this List<IOsoba> osoby)
        {
            osoby.Sort((osoba1, osoba2) => string.Compare(osoba1.Nazwisko, osoba2.Nazwisko));
        }
    }
}
