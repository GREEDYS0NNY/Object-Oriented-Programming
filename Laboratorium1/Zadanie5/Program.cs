namespace Zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ExceptNumbers = { 2, 6, 9, 15, 19 };
            PrintNumbers(ExceptNumbers);
        }
        static void PrintNumbers(int[] ExceptNumbers)
        {
            for (int i = 20; i >= 0; i--)
            {
                if (Array.Exists(ExceptNumbers, number => number == i))
                {
                    continue;
                }
                Console.WriteLine(i);

            }
        }
    }
}