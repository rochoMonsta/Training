using System;
using System.Linq;

namespace Take_a_Ten_Minute_Walk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }));
            Console.ReadLine();
        }
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10)
                return false;
            else
            {
                if (walk.Count(x => x == "w") == walk.Count(y => y == "e") &&
                    walk.Count(x => x == "n") == walk.Count(x => x == "s"))
                    return true;
                else
                    return false;
            }
        }
    }
}
