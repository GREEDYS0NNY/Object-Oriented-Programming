using Newtonsoft.Json;

namespace Zadanie5
{
    internal class FilePersonRepository : IPersonRepository
    {
        readonly string pathToFile;
        public FilePersonRepository(string pathToFile)
        {
            this.pathToFile = pathToFile;

            if (!File.Exists(pathToFile))
                File.Create(pathToFile).Close();
        }

        public List<Person> GetPersons()
        {
            List<Person> persons = [];
            string[] lines = File.ReadAllLines(pathToFile);

            foreach (string line in lines)
            {
                Person person = JsonConvert.DeserializeObject<Person>(line);
                persons.Add(person);
            }
            return persons;
        }

        public Person GetPersonById(int id) => GetPersons().FirstOrDefault(person => person.Id == id);

        public void AddPerson(Person person)
        {
            string newPerson = JsonConvert.SerializeObject(person);
            File.AppendAllLines(pathToFile, [newPerson]);
        }

        public void DeletePerson(int id)
        {
            List<Person> persons = GetPersons();

            persons.RemoveAll(person => person.Id == id);

            File.WriteAllLines(pathToFile, persons.Select(JsonConvert.SerializeObject));
        }
    }
}