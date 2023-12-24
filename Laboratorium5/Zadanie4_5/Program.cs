namespace Zadanie4_5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Person person1 = new() { Age = 20, Name = "John" };

                Person personCopy1 = (Person)person1.Clone();
                Person personCopy2 = person1.DeepCopy();

                Console.WriteLine($"{personCopy1.Name}, {personCopy1.Age}");
                Console.WriteLine($"{personCopy2.Name}, {personCopy2.Age}");
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}