using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Licz
    {
        double Value = 0;

        public Licz(double InputValue)
        {
            Value = InputValue;
        }
        public double Dodaj(double InputValue)
        {
            Value += InputValue;
            return Value;
        }

        public double Odejmij(double InputValue)
        {
            Value = InputValue - Value;
            return Value;
        }

        public void ShowValue()
        {
            Console.WriteLine($"Wynik: {Value}.");
        }

    }

}
