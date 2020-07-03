using System;
using System.Linq;

namespace ttt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Numericals("Hello, World!"));
            Console.ReadLine();
        }
        public static string Numericals(string s)
        {
            return String.Concat(Enumerable.Range(0, s.Length).Select(x => s.Substring(0, x).Count(y => y == s[x]) + 1));
        }
    }
}
