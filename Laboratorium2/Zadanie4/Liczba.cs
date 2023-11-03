using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    internal class Liczba
    {
        int[] Numbers = new int[2];
        string _Value;

        public Liczba(string Value)
        {
            SetValue(Value);
        }
        public void SetValue(string Value)
        {
            _Value = Value;
            int length = Value.Length;

            if (length <= 1 | length > 2)
            {
                Console.WriteLine("Liczba dziesietna nie moze zawierac mniej lub wiecej niz dwie cyfry!");
                Environment.Exit(0);
            }
            else
            {
                if (char.IsDigit(Value[0]) & char.IsDigit(Value[1]))
                {
                    int number = Convert.ToInt32(Value);
                    if (number >= 10)
                        Numbers = Value.Select(ch => ch - '0').ToArray();
                    else
                    {
                        Console.WriteLine("Liczba nie moze byc mniej niz 10!");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Niepoprawne znaki!");
                    Environment.Exit(0);
                }
            }
        }
        public void MultiplyBy(int Number)
        {
            if (int.IsPositive(Number)) 
            {
                int result = Convert.ToInt32(_Value) * Number;
                string strResult = Convert.ToString(result);

                if (strResult.Length > Numbers.Length)
                {
                    int[] NewNumbers = strResult.Select(ch => ch - '0').ToArray();
                    Numbers = new int[strResult.Length];
                    Array.Copy(NewNumbers, Numbers, strResult.Length);
                }
                else if (strResult.Length == 1)
                {
                    Array.Resize(ref Numbers, strResult.Length);
                    Numbers[0] = result;
                }
                else
                {
                    Numbers = strResult.Select(ch => ch - '0').ToArray();
                }
            }
            else
            {
                Console.WriteLine("Liczba nie moze byc ujemna.");
                Environment.Exit(0);
            }
        }
        public long Factorial(long Number)
        {
            if (long.IsPositive(Number))
            {
                if (Number == 0)
                    return 1;
                else
                    return Number * Factorial(Number - 1);
            }
            else
            {
                Console.WriteLine("Liczba nie moze byc ujemna.");
                Environment.Exit(0);
                return 0;
            }
            
        }
        public void PrintValue()
        {
            Console.WriteLine($"[{string.Join(", ", Numbers)}]");
        }
    }
}
