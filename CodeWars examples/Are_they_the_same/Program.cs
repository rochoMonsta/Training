using System;
using System.Linq;

namespace Are_they_the_same
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = { 121, 14641, 20736, 361, 25921, 361, 20736 };
            Console.WriteLine(comp(a, b));
            Console.ReadLine();
        }
        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null || a.Length != b.Length)
                return false;
            else
            {
                var bList = b.ToList();
                foreach (var number in a)
                {
                    if (!bList.Contains(number * number))
                        return false;
                    else
                        bList.Remove(number * number);
                }
                return true;
            }
        }
    }
}
