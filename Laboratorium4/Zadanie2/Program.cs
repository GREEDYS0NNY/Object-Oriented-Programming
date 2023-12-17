namespace Zadanie2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Uczen uczen1 = new();
            Uczen uczen2 = new();

            uczen1.SetFirstName("Michal");
            uczen1.SetLastName("Nowak");
            uczen1.SetPesel("63091316225");
            uczen1.SetSchool("Szkola 1");

            uczen2.SetFirstName("Anna");
            uczen2.SetLastName("Nowak");
            uczen2.SetPesel("55121171843");
            uczen2.SetSchool("Szkola 2");
            uczen2.SetCanGoHomeAlone(true);

            Console.WriteLine(uczen1.GetAge());
            Console.WriteLine(uczen1.GetGender());
            Console.WriteLine(uczen1.GetEducationInfo());
            Console.WriteLine(uczen1.GetFullName());

            Console.WriteLine("<====================>");

            Console.WriteLine(uczen2.GetAge());
            Console.WriteLine(uczen2.GetGender());
            Console.WriteLine(uczen2.GetEducationInfo());
            Console.WriteLine(uczen2.GetFullName());

            Console.WriteLine("<====================>");

            Nauczyciel nauczyciel = new(); 

            nauczyciel.PodwladniUczniowie.Add(uczen1);
            nauczyciel.PodwladniUczniowie.Add(uczen2);

            nauczyciel.WhichStudentCanGoHomeAlone(DateTime.Now);
        }
    }
}
