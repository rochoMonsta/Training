using System;

namespace Two_Joggers
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = NbrOfLaps(4, 8);
            Console.WriteLine(result.Item1 + " " + result.Item2);
            Console.ReadLine();
        }
        public static Tuple<int, int> NbrOfLaps(int x, int y)
        {
            int max = x > y ? x : y;
            while (max % x != 0 || max % y != 0)
                max++;
            return new Tuple<int, int>(max / x, max / y);
        }
    }
}
