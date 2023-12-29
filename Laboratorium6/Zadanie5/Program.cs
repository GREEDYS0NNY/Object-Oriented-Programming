namespace Zadanie5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FilePersonRepository personRepository = new("persons.json");

            //personRepository.AddPerson(new Person("Kacper", "Nowak", 24, 1));
            //personRepository.AddPerson(new Person("John", "Owl", 20, 2));

            foreach (var person in personRepository.GetPersons())
            {
                Console.WriteLine($"First name: {person.FirstName};\nLast name: {person.LastName};\nAge: {person.Age};\nId: {person.Id}.");
                Console.WriteLine();
            }

            Person firstPerson = personRepository.GetPersonById(1);
            Console.WriteLine($"First person is: {firstPerson.FirstName} {firstPerson.LastName}.");

            //personRepository.DeletePerson(2);
        }
    }
}