namespace Zadanie3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Zadanie3 3a.
            Osoba osoba1 = new() { Imie = "Jan", Nazwisko = "Nowak"};
            Osoba osoba2 = new() { Imie = "Michal", Nazwisko = "Kowalski"};
            Osoba osoba3 = new() { Imie = "Piotr", Nazwisko = "Nowak" };

            List<Osoba> osoby1 = new() { osoba1, osoba2, osoba3};

            foreach (Osoba osoba in osoby1)
            {
                Console.WriteLine(osoba.ZwrocPelnaNazwe());
            }

            Console.WriteLine();

            // Zadanie 3b.
            List<IOsoba> osoby2 = new() { osoba3, osoba2, osoba1 };
            osoby2.WypiszOsoby();

            Console.WriteLine();

            // Zadanie 3c.
            osoby2.PosortujOsobyPoNazwisku();

            foreach (var osoba in osoby2)
            {
                Console.WriteLine($"{osoba.Imie} {osoba.Nazwisko}.");
            }

            Console.WriteLine();

            // Zadanie 3d.
            Student student = new() 
            { 
                Imie = "Jan",
                Nazwisko = "Nowak",
                Uczelnia = "WSIiZ", 
                Kierunek = "IID-P",
                Rok = 2020,
                Semestr = 2
            };

            Console.WriteLine(student.WypiszPelnaNazweIUczelnie());

            Console.WriteLine();

            // Zadanie 3e.
            StudentWSIiZ studentWSIiZ1 = new() 
            { 
                Imie = "Martin",
                Nazwisko = "Kowalenko",
                Uczelnia = "WSIiZ",
                Kierunek = "IID-P",
                Rok = 2019,
                Semestr = 3
            };
            StudentWSIiZ studentWSIiZ2 = new()
            {
                Imie = "Adam",
                Nazwisko = "Hogh",
                Uczelnia = "WSIiZ",
                Kierunek = "IID",
                Rok = 2021,
                Semestr = 1
            };

            List<StudentWSIiZ> studentsWSIiZ = new() { studentWSIiZ1, studentWSIiZ2 };
            studentsWSIiZ.WypiszPelnaNazweIUczelnie();
        }
    }
}