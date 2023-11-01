namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }
        static void PrintMenu()
        {
            Console.WriteLine("Wybierz operacje:");
            Console.WriteLine("1. Suma;");
            Console.WriteLine("2. Roznica;");
            Console.WriteLine("3. Iloczyn;");
            Console.WriteLine("4. Iloraz;");
            Console.WriteLine("5. Potega;");
            Console.WriteLine("6. Pierwiastek kwadratowy;");
            Console.WriteLine("7. Trygonometria;");
            Console.WriteLine("8. Wyjscie.");
            Console.Write("Twoj wybor: ");
        }
        static void Calculator()
        {
            while (true)
            {
                Console.ReadKey();
                Console.Clear();

                PrintMenu();
                int SelectedOperation = Convert.ToInt32(Console.ReadLine());

                switch (SelectedOperation)
                {
                    case 1:
                        Console.Clear();
                        SumOf(FirstValue: InputDouble(), SecondValue: InputDouble());
                        break;

                    case 2:
                        Console.Clear();
                        DifferenceOf(FirstValue: InputDouble(), SecondValue: InputDouble());
                        break;

                    case 3:
                        Console.Clear();
                        MultiplicationOf(FirstValue: InputDouble(), SecondValue: InputDouble());
                        break;

                    case 4:
                        Console.Clear();
                        DivisionOf(FirstValue: InputDouble(), SecondValue: InputDouble());
                        break;

                    case 5:
                        Console.Clear();
                        PowerOf(Value: InputDouble(), ToPowerOf: InputDouble());
                        break;

                    case 6:
                        Console.Clear();
                        SquareRoot(Value: InputDouble());
                        break;

                    case 7:
                        Console.Clear();
                        AngleOf(Value: InputDouble());
                        break;

                    case 8:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Nieprawidlowa opcja!");
                        break;
                }
            }
        }
        static double InputDouble()
        {
            Console.Write("Podaj wartosc: ");
            double Value = Convert.ToInt32(Console.ReadLine());
            return Value;
        }

        static void SumOf(double FirstValue, double SecondValue)
        {
            double Sum = FirstValue + SecondValue;
            Console.WriteLine($"Suma {FirstValue} + {SecondValue} = {Sum}.");
        }

        static void DifferenceOf(double FirstValue, double SecondValue)
        {
            double Difference = FirstValue - SecondValue;
            Console.WriteLine($"Roznica {FirstValue} - {SecondValue} = {Difference}.");
        }

        static void MultiplicationOf(double FirstValue, double SecondValue)
        {
            double Multiplication = FirstValue * SecondValue;
            Console.WriteLine($"Iloczyn {FirstValue} * {SecondValue} = {Multiplication}.");
        }

        static void DivisionOf(double FirstValue, double SecondValue)
        {
            double Division = FirstValue / SecondValue;
            Console.WriteLine($"Iloraz {FirstValue} / {SecondValue} = {Division}.");
        }

        static void PowerOf(double Value, double ToPowerOf)
        {
            double Power = Math.Pow(Value, ToPowerOf);
            Console.WriteLine($"Potega {Value} ** {ToPowerOf} = {Power}.");
        }

        static void SquareRoot(double Value)
        {
            double SquareR = Math.Sqrt(Value);
            Console.WriteLine($"Pierwiastek kwadratowy {Value} = {SquareR}.");
        }

        static void AngleOf(double Value)
        {
            double Rad = Value * Math.PI / 180;
            Console.WriteLine($"Sinus kata {Value} wynosi: {Math.Sin(Rad)}.");
        }
    }
}