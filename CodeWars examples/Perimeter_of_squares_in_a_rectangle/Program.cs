using System;
using System.Numerics;

namespace Perimeter_of_squares_in_a_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(perimeter(5));
            Console.ReadLine();
        }
        public static BigInteger perimeter(BigInteger squares_count)
        {
            BigInteger number1 = 1, number2 = 1, result = 2;
            for (int i = 2; i <= squares_count; ++i)
            {
                result += number1 + number2;
                var number_box = number2;
                number2 += number1;
                number1 = number_box;
            }
            return 4 * result;
        }
    }
}
