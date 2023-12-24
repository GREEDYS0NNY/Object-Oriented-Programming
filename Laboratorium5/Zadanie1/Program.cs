namespace Zadanie1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try { GetTextLength(null); }

            catch (NullReferenceException exception)
            {
                Console.WriteLine($"Stack trace: {exception.StackTrace}");
                Console.WriteLine();
                throw new Exception("Blad podczas obliczania dlugosci tekstu.", exception);
            }
        }

        public static void GetTextLength(string text)
        {
            Console.WriteLine(text.Length);
        }
    }
}
