namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuControl();
        }
        static void PrintMenu()
        {
            Console.WriteLine("Wybierz operacje:");
            Console.WriteLine("1. Wyświetlanie tablicy od pierwszego do ostatniego indeksu;");
            Console.WriteLine("2. Wyświetlanie tablicy od ostatniego do pierwszego indeksu;");
            Console.WriteLine("3. Wyświetlanie elementów o nieparzystych indeksach;");
            Console.WriteLine("4. Wyświetlanie elementów o parzystych indeksach;"); ;
            Console.WriteLine("5. Wyjscie.");
            Console.Write("Twoj wybor: ");
        }
        static void MenuControl()
        {
            do
            {
                Console.ReadKey();
                Console.Clear();

                PrintMenu();
                int SelectedOperation = Convert.ToInt32(Console.ReadLine());

                if (SelectedOperation == 1)
                    PrintArray(GetArray());

                else if (SelectedOperation == 2)
                    PrintReverseArray(GetArray());

                else if (SelectedOperation == 3)
                    PrintOddArray(GetArray());

                else if (SelectedOperation == 4)
                    PrintEvenArray(GetArray());

                else if (SelectedOperation == 5)
                    Environment.Exit(0);

                else
                    Console.WriteLine("Nieprawidlowa opcja!");
            }
            while (true);
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
        static void PrintArray(double[] array)
        {
            Console.WriteLine();
            foreach (double item in array)
            {
                Console.Write(item + " ");
            }
        }
        static void PrintReverseArray(double[] array)
        {
            Console.WriteLine();
            for (int i = array.Length - 1; i > 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
        static void PrintOddArray(double[] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                if ((i % 2) != 0)
                    Console.Write(array[i] + " ");
            }
        }
        static void PrintEvenArray(double[] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                if ((i % 2) == 0)
                    Console.Write(array[i] + " ");
            }
        }
    }
}
