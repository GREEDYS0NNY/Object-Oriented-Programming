namespace Zadanie6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Queue<int> numbers = new();
            MyList<int> evenNumbers = new();

            numbers.Enqueue(4);
            numbers.Enqueue(1);
            numbers.Enqueue(6);
            numbers.Enqueue(2);

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                    Console.WriteLine(number);
                }  
            }
        }
    }
}