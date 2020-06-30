using System;
using System.Linq;

namespace Count_the_divisible_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DivisibleCount(6, 11, 2));
            Console.ReadLine();
        }
        public static long DivisibleCount(long x, long y, long k)
        {
            return Convert.ToInt64(Enumerable.Range(Convert.ToInt32(x), Convert.ToInt32(y - x)).Where(number => number % k == 0).Count());
        }
    }
}
