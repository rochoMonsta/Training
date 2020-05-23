using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_and_together
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 32, 45, 43, 23, 54, 23, 54, 34 };
            PrintArray(SplitAndAdd(array, 2));
            Console.ReadLine();
        }
        public static int[] SplitAndAdd(int[] numbers, int n)
        {
            var numbers_list = numbers.ToList();
            for (int i = 0; i < n; ++i)
            {
                int count = numbers_list.Count / 2;
                for (int j = 0; j < count; ++j)
                {
                    if (count * 2 == numbers_list.Count)
                        numbers_list[count + j] += numbers_list[j];
                    else
                        numbers_list[count + j + 1] += numbers_list[j];
                }
                for (int j = 0; j < count; ++j)
                    numbers_list.RemoveAt(0);
            }
            return numbers_list.ToArray();
        }
        public static void PrintArray(int[] array)
        {
            foreach (var element in array)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}
