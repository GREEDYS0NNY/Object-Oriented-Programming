namespace Zadanie1
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }

        public Person(string firstName, string lastName, int? age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public virtual void View()
        {
            Console.WriteLine();
            Console.WriteLine("<————————————————————————Osoba————————————————————————>");

            Console.WriteLine($"Imie: {FirstName};\nNazwisko: {LastName};\nWiek: {Age}.");
        }
    }
}
