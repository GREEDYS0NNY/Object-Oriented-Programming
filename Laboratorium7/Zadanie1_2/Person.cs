using CsvHelper;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.IO;
using System.Transactions;

namespace Zadanie1
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public long Pesel { get; set; }
        public string Email { get; set; }

        public void AddPerson(string filePath, string connectionString)
        {
            Console.Write("Wpisz imie: ");
            string firstName = Console.ReadLine();

            Console.Write("Wpisz nazwisko: ");
            string lastName = Console.ReadLine();
                    
            Console.Write("Wpisz kraj: ");
            string country = Console.ReadLine();

            Console.Write("Wpisz miasto: ");
            string city = Console.ReadLine();

            Console.Write("Wpisz ulice: ");
            string street = Console.ReadLine();

            Console.Write("Wpisz pesel: ");
            _ = long.TryParse(Console.ReadLine(), out long pesel);

            Console.Write("Wpisz email: ");
            string email = Console.ReadLine();

            if (firstName != null & lastName != null & country != null & city != null & street != null & pesel.ToString().Length == 11 & email != null & email.Contains('@'))
            {
                List<Person> personList = [
                        new Person
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Address = new Address { Country = country, City = city, Street = street },
                            Pesel = pesel,
                            Email = email
                        }
                    ];

                using StreamWriter writer = new(filePath);
                using CsvWriter csv = new(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(personList);

                // Zadanie 2
                using SqlConnection connection = new(connectionString);
                connection.Open();

                string insertQuery = "INSERT INTO PersonInfo (FirstName, LastName, Country, City, Street, Pesel, Email) VALUES (@FirstName, @LastName, @Country, @City, @Street, @Pesel, @Email)";

                using SqlCommand command = new(insertQuery, connection);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Country", country);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@Street", street);
                command.Parameters.AddWithValue("@Pesel", pesel);
                command.Parameters.AddWithValue("@Email", email);

                command.ExecuteNonQuery();

                Console.WriteLine("\nDane zapisane do pliku CSV oraz do bazy danych.");
            }
            else { Console.WriteLine(); Console.WriteLine("Pola nie moga miec wartosci null. Pesel musi zawierac 11 cyfr. Adres e-mail musi zawierac '@'."); }
        }

        public void ShowInfo(string filePath)
        {
            using StreamReader reader = new(filePath);
            using CsvReader csv = new(reader, CultureInfo.InvariantCulture);

            List<Person> records = csv.GetRecords<Person>().ToList();

            Console.WriteLine("Dane odczytane z pliku CSV:");
            foreach (Person person in records)
            {
                Console.WriteLine($"Imie: {person.FirstName}; Nazwisko: {person.LastName}; " +
                                  $"Adres: {person.Address.Country}, {person.Address.City}, {person.Address.Street}; " +
                                  $"Pesel: {person.Pesel}; Email: {person.Email}.");
            }
        }

        public void UpdatePerson(string filePath, long pesel)
        {
            List<Person> personList = [];
            Person person = SearchPersonByPesel(filePath, pesel);
            
            if (person != null)
            {
                
                Console.WriteLine($"\nAktualne dane dla osoby:");
                Console.WriteLine($"Imie: {person.FirstName}; Nazwisko: {person.LastName}; " +
                                  $"Adres: {person.Address.Country}, {person.Address.City}, {person.Address.Street}; " +
                                  $"Pesel: {person.Pesel}; Email: {person.Email}.");

                Console.WriteLine("\nWprowadz nowe dane:");

                Console.Write("Wpisz imie: ");
                string newFirstName = Console.ReadLine();

                Console.Write("Wpisz nazwisko: ");
                string newLastName = Console.ReadLine();

                Console.Write("Wpisz kraj: ");
                string newCountry = Console.ReadLine();

                Console.Write("Wpisz miasto: ");
                string newCity = Console.ReadLine();

                Console.Write("Wpisz ulice: ");
                string newStreet = Console.ReadLine();

                Console.Write("Wpisz pesel: ");
                _ = long.TryParse(Console.ReadLine(), out long newPesel);

                Console.Write("Wpisz email: ");
                string newEmail = Console.ReadLine();

                if (newFirstName != null & newLastName != null & newCountry != null & newCity != null & newStreet != null & newPesel.ToString().Length == 11 & newEmail != null & newEmail.Contains('@'))
                {
                    person.FirstName = newFirstName;
                    person.LastName = newLastName;
                    person.Address.Country = newCountry;
                    person.Address.City = newCity;
                    person.Address.Street = newStreet;
                    person.Pesel = newPesel;
                    person.Email = newEmail;

                    personList.Add(person);

                    using StreamWriter writer = new(filePath);
                    using CsvWriter csv = new(writer, CultureInfo.InvariantCulture);
                    csv.WriteRecords(personList);

                    Console.WriteLine("\nDane zostaly zaktualizowane.");
                }
                else { Console.WriteLine("Pola nie moga miec wartosci null. Pesel musi zawierac 11 cyfr. Adres e-mail musi zawierac '@'."); }
            }
            else
            {
                Console.WriteLine($"\nNie znaleziono osoby.");
            }
        }

        public void DeletePerson(string filePath, long pesel)
        {
            Person person = SearchPersonByPesel(filePath, pesel);
            List<Person> personList = [person];

            if (person != null)
            {
                Console.WriteLine($"\nUsuwanie osoby...");

                personList.Remove(person);

                using StreamWriter writer = new(filePath);
                using CsvWriter csv = new(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(personList);

                Console.WriteLine("\nDane osoby zostaly usuniete.");
            }
            else
            {
                Console.WriteLine($"\nNie znaleziono osoby.");
            }
        }

        public Person SearchPersonByPesel(string filePath, long pesel)
        {
            using StreamReader reader = new(filePath);
            using CsvReader csv = new(reader, CultureInfo.InvariantCulture);

            List<Person> records = csv.GetRecords<Person>().Where(p => p.Pesel == pesel).ToList();
            Person person = records.FirstOrDefault();

            return person;
        }
    }
}
