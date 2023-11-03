using Zadanie2;

namespace Zadanie2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double[] array = { 2, 1, 4, 62, 21, -2, 11 };
            Sumator sumator = new(array);
            
            Console.WriteLine($"Suma elementow tablicy: {sumator.Suma()}.");
            Console.WriteLine($"Suma elementow tablicy podzielnych przez 2: {sumator.SumaPodziel2()}.");

            Console.WriteLine();
            sumator.PrintArray();
            Console.WriteLine();

            Console.WriteLine();
            sumator.Slice(1, 3);
        }
    }
}
