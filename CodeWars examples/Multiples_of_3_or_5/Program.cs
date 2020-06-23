using System;
using System.Linq;

namespace Multiples_of_3_or_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(10));
            Console.ReadLine();
        }
        public static int Solution(int value)
        {
            return Enumerable.Range(0, value).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
        }
    }
}
