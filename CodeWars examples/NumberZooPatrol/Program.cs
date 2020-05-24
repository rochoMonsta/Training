using System;
using System.Linq;

namespace NumberZooPatrol
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 13, 11, 10, 3, 2, 1, 4, 5, 6, 9, 7, 8 };
            Console.WriteLine(FindNumber(array));
            Console.ReadLine();
        }
        public static int FindNumber(int[] array)
        {
            if (array.Length != 0)
            {
                int zoo_length = array.Max() + 1;
                for (int i = 1; i <= zoo_length; ++i)
                    if (!array.Contains(i))
                        return i;
                return 1;
            }
            else
                return 1;
        }
    }
}
