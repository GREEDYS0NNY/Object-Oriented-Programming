using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Sumator
    {
        double[] Liczby;

        public Sumator(double[] liczby)
        {
            Liczby = liczby;
        }

        public double Suma()
        {
            double Suma = 0;

            for (int i = 0; i < Liczby.Length; i++)
            {
                Suma += Liczby[i];
            }
            return Suma;
        }

        public double SumaPodziel2()
        {
            double Suma = 0;

            for (int i = 0; i < Liczby.Length; i++)
            {
                if (Liczby[i] % 2 == 0)
                {
                    Suma += Liczby[i];
                } 
            }
            return Suma;
        }
        public int IleElementow()
        {
            return Liczby.Length;
        }
        public void PrintArray()
        {
            Console.Write($"[{string.Join(", ", Liczby)}]");
        }
        public void Slice(int lowIndex, int highIndex) 
        {
            if (lowIndex < 0)
                lowIndex = 0;

            if (highIndex >= Liczby.Length)
                highIndex = Liczby.Length - 1;

            for (int i = lowIndex; i <= highIndex; i++) { Console.Write(Liczby[i] + " "); }
        }
    }
}
