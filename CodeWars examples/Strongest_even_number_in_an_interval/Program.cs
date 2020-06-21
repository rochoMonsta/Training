using System;
using System.Linq;

namespace Strongest_even_number_in_an_interval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(strongestEven(48, 56));
            Console.ReadLine();
        }
        public static int strongestEven(int n, int m)
        {
            int strong = 0, strongest_number = 0;
            int[] even_numbers = Enumerable.Range(n, m - n + 1).Select(numb => numb).Where(element => element % 2 == 0).ToArray();
            for (int i = 0; i < even_numbers.Length; ++i)
            {
                int local_strong = 0, number_copy = even_numbers[i];
                while (number_copy % 2 == 0)
                {
                    number_copy /= 2;
                    local_strong++;
                }
                if (local_strong > strong)
                {
                    strong = local_strong;
                    strongest_number = even_numbers[i];
                }
            }
            return strongest_number;
        }
        public static void PrintArray <T> (T[] array)
        {
            foreach (var element in array)
                Console.WriteLine(element + " ");
            Console.WriteLine();
        }
    }
}
