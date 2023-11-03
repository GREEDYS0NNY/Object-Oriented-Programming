using Zadanie4;
namespace Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Liczba liczba = new("10");
            liczba.MultiplyBy(22);
            liczba.PrintValue();

            Console.WriteLine();
            Console.WriteLine($"5! = {liczba.Factorial(5)}.");
        }
    }
}
