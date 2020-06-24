using System;
using System.Linq;

namespace Find_The_Parity_Outlier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Find(new int[] { 160, 3, 1719, 19, 11, 13, -21 }));
            Console.ReadLine();
        }
        public static int Find(int[] integers)
        {
            int result = integers.Count(x => x % 2 == 0) > 1 ?
                         integers.FirstOrDefault(z => z % 2 != 0) : 
                         integers.FirstOrDefault(k => k % 2 == 0);
            return result;
        }
    }
}
