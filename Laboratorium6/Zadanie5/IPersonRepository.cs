using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    public record Person(string FirstName, string LastName, int Age, int Id);
    internal interface IPersonRepository
    {
        List<Person> GetPersons();
        Person GetPersonById(int id);
        void AddPerson(Person person);
        void DeletePerson(int id);
    }
}
