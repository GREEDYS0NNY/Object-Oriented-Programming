namespace Zadanie3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SomeClass someClassObj = new SomeClass();
            try
            {
                someClassObj.CanThrowException();
                someClassObj.CanThrowException();
                someClassObj.CanThrowException();
                someClassObj.CanThrowException();
                someClassObj.CanThrowException();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Wyjatek wystapil w: {e.StackTrace}");
            }
        }
    }
    public class SomeClass
    {
        public void CanThrowException()
        {
            if (new Random().Next(5) == 0)
                throw new Exception();
        }
    }
}