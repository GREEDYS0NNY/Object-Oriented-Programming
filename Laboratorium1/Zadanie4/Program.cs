namespace Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = GetArray();
            Console.WriteLine($"\nSuma elementów tablicy: {SumOfElements(array)}.");
            Console.WriteLine($"Iloczyn elementów tablicy: {ProductOfElements(array)}.");
            Console.WriteLine($"Wartosc srednia: {AverageValue(array)}.");
            Console.WriteLine($"Wartosc minimalna: {MinimalValue(array)}.");
            Console.WriteLine($"Wartosc maksymalna: {MaximalValue(array)}.");
        }
        static double[] GetArray()
        {
            double[] array = new double[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Wpisz liczbe pod indeksem {i}: ");
                array[i] = InputDouble();
            }
            return array;

        }
        static double InputDouble()
        {
            double Value = Convert.ToInt32(Console.ReadLine());
            return Value;
        }
        static double SumOfElements(double[] array)
        {
            double SumOfElements = 0;
            for (int i = 0; i < array.Length; i++)
            {
                SumOfElements += array[i];
            }
            return SumOfElements;
        }
        static double ProductOfElements(double[] array)
        {
            double ProductOfElements = 1;
            for (int i = 0; i < array.Length; i++)
            {
                ProductOfElements *= array[i];
            }
            return ProductOfElements;
        }
        static double AverageValue(double[] array)
        {
            double MiddleValue = SumOfElements(array) / array.Length;
            return MiddleValue;
        }
        static double MinimalValue(double[] array)
        {
            double MinimalElement = array[0];
            int MinimalIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < MinimalElement)
                {
                    MinimalElement = array[i];
                    MinimalIndex = i;
                }


            }
            return array[MinimalIndex];
        }
        static double MaximalValue(double[] array)
        {
            double MaximalElement = array[0];
            int MaximalIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > MaximalElement)
                {
                    MaximalElement = array[i];
                    MaximalIndex = i;
                }

            }
            return array[MaximalIndex];
        }
    }
}
