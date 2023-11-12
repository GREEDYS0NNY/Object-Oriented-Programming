namespace Zadanie1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Zadanie 1 a
            Person person1 = new(firstName: "Tsugumi", lastName: "Ohba", age: null);
            Person person2 = new(firstName: "Tensai", lastName: "Okamura", age: 61);
            Person person3 = new(firstName: "Sadamoto", lastName: "Yoshiyuki", age: 61);
            Person person4 = new(firstName: "Yasuhiro", lastName: "Nightow", age: 56);  
            Person person5 = new(firstName: "Thomas", lastName: "Keneally", age: 88);

            person1.View();
            person2.View();
            person3.View();

            Book book1 = new(title: "Death Note", author: person1, releaseDate: new(2003, 12, 1));
            Book book2 = new(title: "Darker than Black", author: person2, releaseDate: new(2007, 2, 24));
            Book book3 = new(title: "Neon Genesis Evangelion", author: person3, releaseDate: new(1994, 12, 26));

            book1.View();
            book2.View();

            // Zadanie 1 b
            Reader reader1 = new(firstName: "Milosz", lastName: "Cebula", age: 22);
            Reader reader2 = new(firstName: "Karol", lastName: "Dawidowicz", age: 34);

            reader1.BooksRead.Add(book1);
            reader1.BooksRead.Add(book2);

            reader2.BooksRead.Add(book3);

            reader1.ViewBook();
            reader2.ViewBook();

            // Zadanie 1 c
            reader1.View();
            reader2.View();

            //Zadanie 1 d
            Person o = new Reader(firstName: "O", lastName: "O", age: 0);
            o.View();

            // Zadanie 1 f
            Reviewer reviewer1 = new(firstName: "Robert", lastName: "Wisniewski", age: 45);
            Reviewer reviewer2 = new(firstName: "Unknown", lastName: "Unknown", age: 37);

            reviewer1.BooksRead.Add(book1);
            reviewer1.BooksRead.Add(book2);
            reviewer1.BooksRead.Add(book3);

            reviewer2.BooksRead.Add(book3);
            reviewer2.BooksRead.Add(book1);

            reviewer1.Wypisz();
            reviewer2.Wypisz();

            // Zadanie 1 g
            List<Person> persons = new() { reader1, reader2, reviewer1, reviewer2 };

            foreach (Person person in persons)
            {
                person.View();
            }

            // Zadanie 1 i
            AdventureBook adventureBook1 = new(title: "Blood Blockade Battlefront", author: person4, releaseDate: new(2009, 1, 5), isAvailable: true);
            DocumentaryBook documentaryBook1 = new(title: "Schindler's Ark", author: person5, releaseDate: new(1982, 10, 18), cena: 46);

            // Zadanie 1 j
            adventureBook1.View();
            documentaryBook1.View();

            reader1.BooksRead.Add(adventureBook1);
            reader2.BooksRead.Add(adventureBook1);

            reader1.BooksRead.Add(documentaryBook1);
            reader2.BooksRead.Add(documentaryBook1);

            reader1.ViewBook();
            reader2.ViewBook();
        }
    }
}
