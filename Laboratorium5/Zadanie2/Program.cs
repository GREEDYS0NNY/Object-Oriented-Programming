namespace Zadanie2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try { GetRandomException(); }
            catch (CustomException1) { Console.WriteLine("To jest CustomException1"); }
            catch (CustomException2) { Console.WriteLine("To jest CustomException2"); }
            catch (CustomException3) { Console.WriteLine("To jest CustomException3"); }
        }
        public static void GetRandomException()
        {
            Random random = new();
            int randomNumber = random.Next(1, 4);

            throw randomNumber switch
            {
                1 => new CustomException1("CustomException1"),
                2 => new CustomException2("CustomException2"),
                3 => new CustomException3("CustomException3"),
                _ => new Exception("Unknown exception")
            };
        }
    }
    class CustomException1 : Exception
    {
        public CustomException1(string message) : base(message) { }
    }

    class CustomException2 : Exception
    {
        public CustomException2(string message) : base(message) { }
    }

    class CustomException3 : Exception
    {
        public CustomException3(string message) : base(message) { }
    }
}