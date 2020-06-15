using System;

namespace Persistent_Bugger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Persistence(999));
            Console.ReadLine();
        }
        public static int Persistence(long n)
        {
            int counter = 0;
            while (n.ToString().Length != 1)
            {
                int result = 1;
                var n_as_string = n.ToString();
                for (int i = 0; i < n_as_string.Length; ++i)
                    result *= Int32.Parse(n_as_string[i].ToString());
                n = result;
                counter++;
            }
            return counter;
        }
    }
}
