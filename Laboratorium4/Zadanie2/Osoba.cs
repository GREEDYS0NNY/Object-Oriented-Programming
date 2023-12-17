namespace Zadanie2
{
    abstract class Osoba
    {
        string Imie;
        string Nazwisko;
        string Pesel;

        public void SetFirstName(string FirstName) { Imie = FirstName; }
        public void SetLastName(string LastName) { Nazwisko = LastName; }
        public void SetPesel(string pesel) { Pesel = pesel; }
        public int GetAge() 
        {
            int YearOfBirth = int.Parse(Pesel.Substring(0, 2));
            int ActualYear = DateTime.Now.Year;
            int Age = (ActualYear >= YearOfBirth) ? ActualYear - YearOfBirth : ActualYear + 100 - YearOfBirth;
            return Age;
        }
        public string GetGender() 
        {
            string gender = int.Parse(Pesel.Substring(9, 1)) % 2 == 0 ? "Kobieta" : "Mezczyzna";
            return gender;
        }
        public virtual string GetEducationInfo()
        {
            return "Brak informacji o edukacji.";
        }
        public string GetFullName()
        {
            return $"{Imie} {Nazwisko}.";
        }
        public virtual bool CanGoAloneToHome()
        {
            return false;
        }
    }
}
