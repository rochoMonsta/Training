using System;
using System.Linq;

namespace Row_of_the_odd_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArr(OddRow(4));
            Console.ReadLine();
        }
        public static long[] OddRow(int n)
        {
            long x0 = (long)n * (n - 1) + 1;
            return Enumerable.Range(0, n).Select(i => x0 + 2 * i).ToArray();
        }
        public static void PrintArr<T>(T[] array)
        {
            foreach (var element in array)
                Console.Write(element + " ");
            Console.WriteLine();
        }
        //public static long[] OddRow(int n)
        //{
        //    var odd_numbers_arr = new long[n];
        //    long count_before = (long)n * (n - 1) + 1;
        //    for (int i = 0; i < n; ++i)
        //    {
        //        odd_numbers_arr[i] = count_before;
        //        count_before += 2;
        //    }
        //    return odd_numbers_arr;
        //}
    }
}
