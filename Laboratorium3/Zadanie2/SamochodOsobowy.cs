namespace Zadanie2
{
    internal class SamochodOsobowy : Samochod
    {
        private double waga = 0;
        private double pojemnoscSilnika = 0;

        public double Waga
        {
            set
            {
                if (value >= 2 && value <= 4.5 )
                {
                    waga = value;
                }
                else
                {
                    Console.WriteLine("Waga powinna byc z przedzialu 2 t – 4,5 t.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

            get { return waga; }
        }
        public double PojemnoscSilnika
        {
            set
            {
                if (value >= 0.8 && value <= 3)
                {
                    pojemnoscSilnika = value;
                }
                else
                {
                    Console.WriteLine("Pojemnosc silnika powinna byc z przedzialu 0,8 - 3,0.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

            get { return pojemnoscSilnika; }
        }
        public uint IloscOsob { get; set; }

        public SamochodOsobowy(string marka, string model, string nadwozie, string kolor, uint rokProdukcji,
                               double przebieg, double waga, double pojemnoscSilnika, uint iloscOsob) 
            : base(marka, model, nadwozie, kolor, rokProdukcji, przebieg)
        {
            Waga = waga;
            PojemnoscSilnika = pojemnoscSilnika;
            IloscOsob = iloscOsob;
        }

        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Waga: {Waga};\nPojemnosc silnika: {PojemnoscSilnika};\nIlosc osob: {IloscOsob}.");
        }
    }
}
