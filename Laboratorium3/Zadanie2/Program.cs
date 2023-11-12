namespace Zadanie2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SamochodOsobowy samochodOsobowy1 = new(marka: "Lexus", model: "LX 570", nadwozie: "SUV", kolor: "Czarny",
                rokProdukcji: 2019, przebieg: 234.000, waga: 2.585, pojemnoscSilnika: 3, iloscOsob: 5);

            Samochod samochod1 = new(marka: "Apollo", model: "Intensa Emozione",
                nadwozie: "coupé", kolor: "Zloty", rokProdukcji: 2019, przebieg: 5.000);

            Samochod samochod2 = new(marka: "Ferrari", model: "F40",
                nadwozie: "coupé", kolor: "Rozowy", rokProdukcji: 1987, przebieg: 14.678);

            samochodOsobowy1.ShowInfo();
            Console.WriteLine();

            samochod1.ShowInfo();
            Console.WriteLine();

            samochod2.ShowInfo();
        }
    }
}
