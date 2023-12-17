using System;

namespace Zadanie2
{
    internal class Nauczyciel : Uczen
    {
        public string TytulNaukowy { get; set; }
        public List<Uczen> PodwladniUczniowie { get; set; }
        public Nauczyciel() 
        {
            PodwladniUczniowie = new List<Uczen>();
        }
        public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
        {
            Console.WriteLine($"Uczniowie, ktorzy moga isc sami do domu na {dateToCheck.ToShortDateString()}:");
            foreach (var uczen in PodwladniUczniowie)
            {
                if (uczen.CanGoAloneToHome())
                    Console.WriteLine($"{uczen.GetFullName()}");
            }
        }
    }
}
