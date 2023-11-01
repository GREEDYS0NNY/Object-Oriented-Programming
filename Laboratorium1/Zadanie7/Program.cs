namespace Zadanie7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] SortedArray = InsertionSort(InputValues());
            PrintArray(SortedArray);

        }
        static double[] InputValues()
        {
            Console.Write("Podaj ilosc liczb: ");
            uint NumberOfValues = Convert.ToUInt32(Console.ReadLine());

            double[] Array = new double[NumberOfValues];

            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write($"Wpisz liczbe pod indeksem {i}: ");
                Array[i] = Convert.ToDouble(Console.ReadLine());
            }
            return Array;
        }
        static double[] InsertionSort(double[] Array)
        {
            for (int i = 1; i < Array.Length; i++)
            {
                double CurrentValue = Array[i];
                int j = i - 1;

                while (j >= 0 && Array[j] > CurrentValue)
                {
                    Array[j + 1] = Array[j];
                    j--;
                }
                Array[j + 1] = CurrentValue;
            }
            return Array;
        }
        static void PrintArray(double[] Array)
        {
            Console.WriteLine();
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + " ");
            }
        }
    }
}
