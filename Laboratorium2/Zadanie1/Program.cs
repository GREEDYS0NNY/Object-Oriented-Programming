using Zadanie1;

namespace Zadanie1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Licz licz1 = new (10);
            Licz licz2 = new (-20);

            licz1.Dodaj(100);
            licz2.Dodaj(20);

            licz1.ShowValue();
            licz2.ShowValue();
        }
    }
}
