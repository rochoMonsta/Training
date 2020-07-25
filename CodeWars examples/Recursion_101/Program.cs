using System;

namespace Recursion_101
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Solve(6, 19);
            Console.WriteLine(result.Item1 + " - " + result.Item2);
            Console.ReadLine();
        }
        public static (int, int) Solve(int a, int b)
        {
            if (a == 0 || b == 0) { return (a, b); }
            else if (a >= 2 * b) { return Solve(a - 2 * b, b); }
            else if (b >= 2 * a) { return Solve(a, b - 2 * a); }
            else { return (a, b); }
        }
    }
}
