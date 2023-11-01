namespace Zadanie6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InfiniteQuery();
        }
        static void InfiniteQuery()
        {
            while (true)
            {
                //Console.Clear();

                if (InputLong() < 0)
                {
                    break;
                }

            }
        }
        static long InputLong()
        {
            Console.Write("Wpisz liczbe calkowita: ");

            long InputLong = Convert.ToInt64(Console.ReadLine());
            return InputLong;
        }

    }
}
