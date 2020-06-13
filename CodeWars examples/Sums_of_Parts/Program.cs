using System;
using System.Collections.Generic;

namespace Sums_of_Parts
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArray(PartsSums(new int[] { 744125, 935, 407, 454, 430, 90, 144, 6710213, 889, 810, 2579358 }));
            Console.ReadLine();
        }
        public static int[] PartsSums(int[] numbers_arr)
        {
            var sum_list = new List<int>();
            for (int i = 0; i <= numbers_arr.Length; ++i)
            {
                int sum_of_numbers = 0;

                for (int j = numbers_arr.Length - 1; j > numbers_arr.Length - i - 1; --j)
                    sum_of_numbers += numbers_arr[j];

                sum_list.Insert(0, sum_of_numbers);
            }
            return sum_list.ToArray();
        }
        public static void PrintArray <T> (T[] array)
        {
            foreach (var element in array)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}
