namespace Zadanie4_5
{
    public class Person : ICloneable
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public object Clone()
        {
            return new Person { Age = Age, Name = Name };
        }

        public Person DeepCopy()
        {
            Person copy = (Person)MemberwiseClone();
            copy.Name = Name;
            copy.Age = Age;
            return copy;
        }
    }
}
